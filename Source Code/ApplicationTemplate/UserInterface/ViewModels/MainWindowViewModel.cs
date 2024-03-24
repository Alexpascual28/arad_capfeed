using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Labman.MotionControl;
using Labman.UserInterface.WindowViews;

namespace Labman.UserInterface.ViewModels
{
      /// <summary>
      /// This is the custom view model for the main window.
      /// It inherits from a base view model which provides common functionality.
      /// </summary>
      public class MainWindowViewModel : BaseFormViewModel
      {
            #region Variables & Objects

            private CartesianConfigurationUserControlViewModel _cartesianConfigurationUserControlViewModel;

            private ViewModelBase _robotArmConfigurationViewModel;

            private SoakTestViewModel _soakTestUserControlViewModel;

            private ProcessStatesUserControlViewModel _processStatesViewModel;

            private int _unreadWarningLogs;

            private int _unreadErrorLogs;

            private bool _logsVisible;

            #endregion

            #region Template Properties

            /// <summary>
            /// Gets or sets the hardware configuration user control view model.
            /// </summary>
            public HardwareConfigUserControlViewModel HardwareConfigurationUserControlViewModel
            {
                  get;
                  set;
            }

            /// <summary>
            /// Gets or sets the position database view model.
            /// </summary>
            public PositionDatabaseViewModel PositionsDatabaseViewModel
            {
                  get;
                  set;
            }

            /// <summary>
            /// Gets or sets the assembly name of the robot/project assembly. For use in Engineering actions.
            /// </summary>
            public string ProjectAssemblyName { get; set; } = typeof(MainWindowViewModel).Assembly.FullName;

            /// <summary>
            /// Gets or sets the selected cartesian configuration.
            /// </summary>
            public CartesianConfiguration SelectedCartesianConfiguration
            {
                  get;
                  set;
            }

            /// <summary>
            /// Gets or sets the selected robot arm.
            /// </summary>
            public Hardware.RobotArms.RobotArm SelectedRobotArm
            {
                  get;
                  set;
            }

            /// <summary>
            /// Gets or sets the cartesian configuration user control view model.
            /// </summary>
            public CartesianConfigurationUserControlViewModel CartesianConfigurationUserControlViewModel
            {
                  get => _cartesianConfigurationUserControlViewModel;
                  set => Set(ref _cartesianConfigurationUserControlViewModel, value);
            }

            /// <summary>
            /// Gets or sets the robot arm configuration view model.
            /// </summary>
            public ViewModelBase RobotArmConfigurationViewModel
            {
                  get => _robotArmConfigurationViewModel;
                  set => Set(ref _robotArmConfigurationViewModel, value);
            }

            /// <summary>
            /// Gets or sets the soak test user control view model.
            /// </summary>
            public SoakTestViewModel SoakTestUserControlViewModel
            {
                  get => _soakTestUserControlViewModel;
                  set => Set(ref _soakTestUserControlViewModel, value);
            }

            /// <summary>
            /// Gets the cartesian configurations.
            /// </summary>
            public IDictionary<string, CartesianConfiguration> CartesianConfigurations =>
                  ConnectedHardware.CartesianConfigurations;

            /// <summary>
            /// Gets the cartesian configurations.
            /// </summary>
            public IDictionary<string, Hardware.RobotArms.RobotArm> RobotArms =>
                  ConnectedHardware.RobotArms;

            /// <summary>
            /// Gets or sets the process states user control view model.
            /// </summary>
            public ProcessStatesUserControlViewModel ProcessStatesViewModel
            {
                  get => _processStatesViewModel;
                  set => Set(ref _processStatesViewModel, value);
            }

            /// <summary>The number of warning log messages that have not been seen.</summary>
            public int UnreadWarningLogs
            {
                  get => _unreadWarningLogs;
                  set => Set(ref _unreadWarningLogs, value);
            }

            /// <summary>The number of error log messages that have not been seen.</summary>
            public int UnreadErrorLogs
            {
                  get => _unreadErrorLogs;
                  set => Set(ref _unreadErrorLogs, value);
            }

            /// <summary>Whether the log user control is selected. Used to control log notification badges</summary>
            public bool LogsVisible
            {
                  get => _logsVisible;
                  set
                  {
                        if (value && !_logsVisible)
                              UnreadWarningLogs = UnreadErrorLogs = 0;

                        Set(ref _logsVisible, value);
                  }
            }

            #endregion

            /*#region Project-specific Properties

            /// <summary>
            /// Instance of main process viewmodel
            /// </summary>
            public Process1UserControlViewModel MainProcessVM { get; set; }

            #endregion*/

            #region Commands

            private ICommand _aboutCommand;

            /// <summary>
            /// Gets the About selection changed command.
            /// </summary>
            public ICommand AboutCommand
            {
                  get
                  {
                        return _aboutCommand ?? (_aboutCommand = new RelayCommand(() =>
                        {
                              var aboutPrompt = new WindowViews.RegistrationWindow();
                              aboutPrompt.ShowDialog();
                        },
                              "About button clicked."));
                  }
            }

            private ICommand _cartesianConfigurationSelectionChangedCommand;

            /// <summary>
            /// Gets the cartesian configuration selection changed command.
            /// </summary>
            public ICommand CartesianConfigurationSelectionChangedCommand
            {
                  get
                  {
                        return _cartesianConfigurationSelectionChangedCommand ?? (_cartesianConfigurationSelectionChangedCommand =
                              new RelayCommand(() =>
                              {
                                    if (SelectedCartesianConfiguration != null)
                                    {
                                          CartesianConfigurationUserControlViewModel =
                                                new CartesianConfigurationUserControlViewModel(
                                                      SelectedCartesianConfiguration, BaseClass.PositionsDatabases.FirstOrDefault().Value);
                                    }
                              },
                                    "Cartesian Configuration selected."));
                  }
            }

            private ICommand _robotArmSelectionChangedCommand;

            /// <summary>
            /// Gets the cartesian configuration selection changed command.
            /// </summary>
            public ICommand RobotArmSelectionChangedCommand => _robotArmSelectionChangedCommand ?? (_robotArmSelectionChangedCommand =
                              new RelayCommand(() =>
                              {
                                    if (SelectedRobotArm != null)
                                    {
                                          RobotArmConfigurationViewModel = (ViewModelBase)Activator.CreateInstance(SelectedRobotArm.RobotArmUIType, SelectedRobotArm);
                                    }
                              },
                                    "Robot Arm slected."));

            #endregion

            #region Override Methods

            /// <summary>
            /// Overrides the base method which is called when constructing the view model and allows
            /// rack control view models to be setup ready to be bound by control in the view.
            /// </summary>
            public override void SetupRackControls()
            {
            }

            /// <summary>
            /// Override the start process command so we can implement pre-run checks
            /// </summary>
            public override void StartProcess()
            {
                  // TODO: Create and load a xaml file of extra content if needed for more elaborate pre-run checks.
                  var preRunResources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/UserInterface/PreRunChecksHelpers.xaml") };

                  // Perform checks here
                  var prerun = new PreRunChecks(
                        () =>
                        {
                              // Start the process
                              base.StartProcess();
                        }
                        //// TODO: Add pre-run checks with just a title. The second parameter is used to display extra content when the "?" icon is clicked. If the parameter is ommited, no "?" will display.
                        //// The second parameter can be a URI to an image to display just that, or an object, which will be displayed so should be a visual element (in this example, loaded from the above resource dictionary).
                        //new PreRunChecksViewModel.PreRunCheck("Pre run check 1", "pack://application:,,,/Labman.Merlin;component/Images/color.png"),
                        )
                  {
                        // TODO: Restyle the Pre run checks here, if desired. BackgroundBrush and ShadowVisibility are currently unimplemented.
                        //ShadowVisibility = Visibility.Collapsed,
                        //BackgroundBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255)),
                        //HighlightBrush = new SolidColorBrush(Color.FromRgb(0, 128, 255))
                  };
                  prerun.ShowDialog();
            }

            #endregion

            #region Constructor

            /// <summary>
            /// View model constructor.
            /// First calls the constructor of the base view model.
            /// </summary>
            public MainWindowViewModel() : base(500)
            {
                  // MainProcessVM = new Process1UserControlViewModel();

                  // Set a custom update action each time the window is updated
                  //base.UpdateWindowTick = () =>
                  //{
                  //      // TODO: Do something here if required
                  //};

                  // Create the hardware config viewmodel
                  HardwareConfigurationUserControlViewModel = new HardwareConfigUserControlViewModel();

                  // Create the positions database viewmodel if appropriate
                  if (BaseClass.PositionsDatabases.Count > 0 && BaseClass.PositionsDatabases.Any())
                  {
                        PositionsDatabaseViewModel = new PositionDatabaseViewModel(BaseClass.PositionsDatabases.First().Value);
                  }

                  // Create the process states view model.
                  //ProcessStatesViewModel = new ProcessStatesUserControlViewModel();
                  // TODO: Or use the generically typed constructor when using the ProcessStatesIndicatorUserControl if all process use the same Enum.
                  //ProcessStatesViewModel = new ProcessStatesUserControlViewModel<Processes.MockMainGantryProcess.ProcessState>();
                  // TODO: Or use this constructor to provide a different enum for each process.
                  ProcessStatesViewModel = new ProcessStatesUserControlViewModel(
                        new ProcessViewModel<Processes.CapFeedingProcess.ProcessState>("Main Process"));

                  // Set the soak test viewmodel to that created by the base class.
                  SoakTestUserControlViewModel = BaseClass.SoakTestViewModel;

                  // Select a default cartesian configuration
                  SelectedCartesianConfiguration = CartesianConfigurations.Values.FirstOrDefault();
                  CartesianConfigurationSelectionChangedCommand.Execute(null);

                  // Select a default robot arm.
                  SelectedRobotArm = RobotArms.Values.FirstOrDefault();
                  RobotArmSelectionChangedCommand.Execute(null);

                  // Subscribe to events in the log files.
                  foreach (var logFile in BaseClass.LogFiles)
                        logFile.Value.RecentMessages.CollectionChanged += LogFilesRecentMessagesChanged;
            }

            #endregion

            #region Method

            /// <summary>Event handler for messages being added to the event logs, to notify the user while the logs aren't visible.</summary>
            /// <param name="sender">The sender</param>
            /// <param name="e">The envent args</param>
            private void LogFilesRecentMessagesChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
            {
                  // If the log window is currently visible, or items aren't being added we don't increment the counters.
                  if (LogsVisible || e.Action != System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                        return;

                  switch (((Logging.LogMessage)e.NewItems[0]).Type)
                  {
                        case Logging.LogMessage.LogType.Warning:
                              UnreadWarningLogs++;
                              break;
                        case Logging.LogMessage.LogType.CriticalError:
                              UnreadErrorLogs++;
                              break;
                  }
            }

            #endregion
      }
}
