using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Windows;
using Labman.Logging.ActivityLogging;
using Labman.Processes;
using Traciot.Messages;

namespace Labman
{
      /// <summary>
      /// Interaction logic for App.xaml
      /// </summary>
      public partial class App : Application
      {

            #region Variables & Objects

            private Exception _startupException = null;
            private static Mutex _mutex = null;

            #endregion

            #region Startup Method 

            /// <summary>
            /// This is the main application statup handler
            /// </summary>
            /// <param name="e">The startup event arguments</param>
            protected override void OnStartup(StartupEventArgs e)
            {
                  DispatcherUnhandledException += App_DispatcherUnhandledException;

                  if (bool.Parse(ConfigurationManager.AppSettings["SingletonApplication"] ?? bool.FalseString))
                  {
                        // Check if application already running
                        _mutex = new Mutex(true, ResourceAssembly.FullName, out bool createdNew);

                        if (!createdNew)
                        {
                              //instance already running, exit this one
                              Current.Shutdown();
                        }
                  }

                  // Setup the base class
                  if (!Setup())
                  {
                        // Failed to setup, close the application
                        string message = "The application failed to load with an error.";
                        if (_startupException != null) { message += "\r\n" + _startupException.Message; }
                        if (_startupException.InnerException != null) { message += "\r\n" + _startupException.InnerException.Message; }

                        // Show the message.
                        UserInterface.WindowViews.MessageBox.Show(message);

                        Environment.Exit(0);
                  }
            }

            private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
            {
                  bool exceptionLogged = false;

                  try
                  {
                        SystemLog.AddLogMessage("An unhandled exception occurred: " + e.Exception.ToString(), Logging.LogMessage.LogType.CriticalError);
                        exceptionLogged = true;

                        TraciotTelemetry.AddEventLog(TraciotTelemetry.StandardEventCode.UnknownError, "An unhandled exception occurred: " + e.Exception.ToString(), EventMessage.EventTypes.Error);
                  }
                  catch { }

                  var message = "An error occurred:";
                  message += Environment.NewLine + Environment.NewLine;

                  if (exceptionLogged)
                  {
                        // If the exception details have been logged just display the exceptions message.
                        message += e.Exception.Message;
                        message += Environment.NewLine + Environment.NewLine;
                        message += "Further details can be found in the system log.";
                  }
                  else
                  {
                        // The exception was not logged, display all exception details.
                        message += e.Exception.ToString();
                  }

                  MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                  e.Handled = true;
            }

            #endregion

            #region Application Resources Setup

            /// <summary>
            /// Setup method loads configurations and sets up the project ready for use
            /// </summary>
            /// <returns>True if the setup completed properly </returns>
            private bool Setup()
            {
                  try
                  {
                        // ****************************************************************************************************************
                        // SET SIMULATION MODE FLAG STATE
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 

                        try
                        {
                              // TODO: turn simulation mode off when communicating with hardware
                              BaseClass.SimulationMode = bool.Parse(ConfigurationManager.AppSettings["SimulationMode"] ?? bool.FalseString);
                        }
                        catch (Exception)
                        {
                              BaseClass.SimulationMode = false;
                        }

                        // ****************************************************************************************************************
                        // SET HIDE HARDWARE HELP FLAG
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // TODO: collapse the hardware help when delivering to site
                        BaseClass.HardwareHelpVisibility = Visibility.Visible;

                        // ****************************************************************************************************************
                        // APPLICATION AUTHENTICATOR DEFINITION
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 

                        // Optionally setup an application authenticator
                        //
                        // Here we setup a simple authenticator that will stop the application working in the year 2112!
                        var authenticator = new Security.ApplicationAuthenticators.SimpleDateTimeApplicationAuthenticator(new DateTime(2112, 1, 1, 0, 0, 0));

                        //// OR

                        // Here we setup an authenticator that restricts the software to a specific computer (hardware) and also has an optional trial mode
                        //TODO: Utilities.ComputerHardwareUtilities.RegisterComputer();           // TODO - Run once to register the current computer (Remove after first use or the authenicator is completely useless)
                        //TODO: Security.TrialUtilities.SetTrailStatus(Security.TrialStatus.New); // TODO - Run once to activate the trial (Remove after first use or the trial authenicator is completely useless)                       
                        //var authenticator = new Security.ApplicationAuthenticators.ComputerHardwareTrialAuthenticator(true, 1);

                        BaseClass.ApplicationAuthenticator = authenticator;

                        // ****************************************************************************************************************
                        // TRACIOT SETUP
                        // This needs to be defined before calling BaseClass setup.
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // NOTE: 
                        // You must install the Host Service application to send messages to the server. 
                        // Download the latest version from the website: https://www.traciot.com/shared/HostWorker/Service.zip
                        // Set the project code in the projectcode.txt file and run the install.bat file (run as administrator)
                        // 
                        // (Optionally) define a host IP address for the PC running the Traciot service application
                        // This is ONLY needed if this module needs to use another PC as a proxy to access the internet! Default = ""
                        TraciotTelemetry.HostIpAddress = "";

                        // Project code override value. Leaving this blank uses the value set by the host service. Default = "".
                        // TODO: Always fill this in unless there's a good reason not to
                        TraciotTelemetry.ProjectCodeOverride = "";

                        // Define the name of the "MAIN" process that Traciot will use to give an overall representation of whether the system is running or not.
                        // TODO: Check this is updated to match your process
                        TraciotTelemetry.MainProcessName = "Main Process";

                        // Flag which allows you to disable Traciot logging (development only - please always leave on where possible!)
                        // Traciot is becoming intrinsic to our operation and monitoring. Even if a customer does not want it enabled, we would like it turned on while in the factory!
                        // Also required for POC rigs to track usage and quality; this is part of our project QA programme.
                        TraciotTelemetry.DisableLogging = true;

                        // ******* Example usage *******
                        // TODO: REMOVE EXAMPLES ONCE YOU HAVE INCORPORATED THESE INTO YOUR PROJECT
                        // EVENTS = Log a "special" event - useful to keep track of failures / things that have been recovered from
                        //TraciotTelemetry.AddEventLog(TraciotTelemetry.StandardEventCode.FailedToCap, "Capping Failure - Low Torque", EventMessage.EventTypes.Warning, 23.5);
                        //TraciotTelemetry.AddEventLog(TraciotTelemetry.StandardEventCode.InformationOnly,"User has changed the washer seals", EventMessage.EventTypes.Information);

                        // SAMPLE COUNTERS = Add a counter of samples processed - note: you must setup on the website which counters are included in the overall sample counter
                        // Try and treat these as overall metrics for usage rather than counting each and every stage of a process (general usage in implied from a single sample)
                        // You may want to count samples through a special module on some systems, in this case ensure you setup which counter names are applicable to the samples processed on the website
                        //TraciotTelemetry.AddToSampleCounter("Pots Processed", 1);
                        //TraciotTelemetry.AddToSampleCounter("Panels Processed", 1);

                        // The following methods are available but only for internal use in the baseapp, try and avoid using in process code
                        // HARDWARE TRACKING = These are automatically logged from the baseapp itself, do NOT use in project code
                        //TraciotTelemetry.AddHardwareTrackingLog(...);
                        // PROCESS EXCEPTIONS = These are added to automatically within processbase and you do NOT need to manually log
                        //TraciotTelemetry.AddProcessException("Test Process", ex);
                        // OVERALL SYSTEM STATE = This is set from within the baseapp and you do NOT need to manually set
                        //TraciotTelemetry.UpdateOverallState(...);
                        // PROCESS STATES = These are added to automatically within processbase and you do NOT need to manually log
                        //TraciotTelemetry.UpdateProcessState("Test Process", StateMessage.RunState.ProcessRunning);
                        // ****************************************** 

                        // ****************************************************************************************************************
                        // SETUP THE BASE CLASS
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // Setup the base class ready for use
                        // This sets up default log files, trace listener and the e/stop thread
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // TODO optionally override the estop thread method:
                        // Using the optional 'estopLoopOverride' parameter allows you to replace the method which runs on the estop thread
                        // Example: by supplying a copy of BaseClass.DefaultEstopLoop and removing 'SystemInitialised.Reset()' hardware will
                        // not be un-initialised when an e-stop occurs.
                        // TODO: IF YOU ARE TO USE THIS METHOD, PLEASE ALWAYS START WILL A FULL COPY OF THE DEFAULT ESTOP CHECKER AND JUST ALTER
                        // TODO: THE REQUIRED FUNCTIONALITY, OTHERWISE IT WILL BREAK/DISABLE OTHER FUNCTIONALITY THAT IS INCLUDED IN THAT THREAD.
                        // BaseClass.SetupBaseClass(CustomEstopLoop);
                        //
                        // The log file duration property can be used to set any duration for how long messages should be appended to a log file before
                        // a new file is created. The minimum value for this property is 1 min, there is no maximum. Any timespan can be specified that is 
                        // over one minute, the recommended value is 1 day as set below.
                        // The introduction of this property does mean the structure of the filename has changed slightly to Log_XXXX_TimeSuffix.html. The
                        // time suffix portion is added automatically and the XXXX is replaced with System, Process, Activity or Debug.
                        //
                        // IMPORTANT - There is no longer a need to pass in a timestamp as part of your log filename, this will be appended automatically
                        BaseClass.LogFileDuration = new TimeSpan(1, 0, 0, 0);

                        // TODO: Optionally add a project name and it will be prepended to the log file. Default is ""
                        BaseClass.LogFileProjectName = "";
                        BaseClass.SetupBaseClass();

                        // ****************************************************************************************************************
                        // SETUP DATABASES
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // Define where to get database connection details from

                        BaseClass.DatabasesStorageEngine = new Settings.StorageEngines.MemorySettingsStorageEngine();

                        // Manually define a database connection to add to the memory settings storage engine
                        Database.Providers.ProviderSettings databaseSettings = new Database.Providers.ProviderSettings(Database.Providers.ProviderSettings.ProviderType.MySQL, // TODO: set the type of database being used database type
                                                                               BaseClass.SystemDatabaseName,

                                                                               // TODO: Set database host
                                                                               ConfigurationManager.AppSettings["databaseHost"] ?? "localhost",

                                                                               // TODO: Set database username
                                                                               ConfigurationManager.AppSettings["databaseUserName"] ?? "root",

                                                                               // TODO: Set database password (NEVER SET THE PASSWORD TO BE THE SAME AS THE USERNAME - IDEALLY THIS SHOULD BE SET TO A REAL PASSWORD THAT IS STORED IN THE HARDWARE TRACKER ON THE INTRANET)
                                                                               ConfigurationManager.AppSettings["databasePassword"] ?? "labmanuser",

                                                                               // TODO: Set database schema name
                                                                               ConfigurationManager.AppSettings["databaseSchema"] ?? "merlin")
                        {
                              // Set whether to enable connection pooling (True = ON, False = OFF, null = do not specify in connection string)
                              EnableConnectionPooling = true,

                              // Set whether to disable SSL mode (True = Disabled, False = Enabled, null = do not specify in connection string)
                              DisableSSLMode = null,

                              // Set the maximum connection pool size (XX = integer number of connections in the pool, null = do not specify in connection string)
                              MaxConnectionPoolSize = null
                        };

                        BaseClass.DatabasesStorageEngine.Save(databaseSettings.ConnectionName, databaseSettings);

                        // Define where to get positions database connection details from
                        BaseClass.PositionsDatabasesStorageEngine = new Settings.StorageEngines.MemorySettingsStorageEngine();

                        // Manually add our positions database
                        PositionsDatabase.PositionsDatabaseSettings positionsDatabaseSettings = new PositionsDatabase.PositionsDatabaseSettings("positions")
                        {
                              ConnectionType = PositionsDatabase.PositionsDatabaseSettings.Providers.Database
                        };

                        PositionsDatabase.Providers.DBPositionProviderSettings dbProviderSettings = new PositionsDatabase.Providers.DBPositionProviderSettings
                        {
                              HostName = databaseSettings.HostName,
                              Username = databaseSettings.Username,
                              Password = databaseSettings.Password,
                              Schema = databaseSettings.Schema,
                              TableName = "tbl_positions" // TODO: set positions database table name
                        };

                        positionsDatabaseSettings.Settings = dbProviderSettings;
                        BaseClass.PositionsDatabasesStorageEngine.Save(positionsDatabaseSettings.ConnectionName, positionsDatabaseSettings);

                        // Setup database connections 
                        // This loads all database and positions databases from the storage engines and adds them to their collections

                        //TODO: Load database connections if your robot has a database.
                        //BaseClass.LoadDatabaseConnections();

                        // ****************************************************************************************************************
                        // SETUP PARAMETERS
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // Set parameters database settings

                        // TODO: set parameters database table name
                        //ParametersDatabase.ParametersDatabaseConnectionSettings parametersDatabaseSettings = new ParametersDatabase.ParametersDatabaseConnectionSettings
                        //{
                        //      DatabaseConnectionName = BaseClass.SystemDatabaseName,
                        //      ParametersTableName = "tbl_parameters",
                        //      ParametersSectionFieldName = "section",
                        //      ParameterKeyFieldName = "name",
                        //      ParameterValueFieldName = "value"
                        //};

                        // Add parameters database settings to base class
                        //BaseClass.ParametersDatabaseConnectionSettings = parametersDatabaseSettings;

                        // ****************************************************************************************************************
                        // SETUP USER ACCESS
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // Setup user access control
                        BaseClass.UsersStorageEngine = new Settings.StorageEngines.MemorySettingsStorageEngine();

                        // Define a list of users and the permissions they have
                        // TODO DEFINE PASSWORDS AS REQUIRED FOR THE PROJECT AND/OR REMOVE USERS NOT BEING USED
                        var defaultSuperuserPassword = "labmanuser"; 
                        var defaultOperatorPassword = "labmanuser"; 
                        var defaultAdminPassword = "labmanuser";
                        var defaultEngineerPassword = "labmanuser";
                        AccessControl.User userMerlin = new AccessControl.User("merlin", defaultSuperuserPassword, (int)(
                                          AccessControl.User.AccessGroupFlags.LabmanEngineer |
                                          AccessControl.User.AccessGroupFlags.SystemAdministrator |
                                          AccessControl.User.AccessGroupFlags.SystemEngineer |
                                          AccessControl.User.AccessGroupFlags.Operator |
                                          AccessControl.User.AccessGroupFlags.View));
                        AccessControl.User userOperator = new AccessControl.User("operator", defaultOperatorPassword, (int)(
                                          AccessControl.User.AccessGroupFlags.Operator |
                                          AccessControl.User.AccessGroupFlags.View));
                        AccessControl.User userAdmin = new AccessControl.User("admin", defaultAdminPassword, (int)(
                                          AccessControl.User.AccessGroupFlags.SystemAdministrator |
                                          AccessControl.User.AccessGroupFlags.Operator |
                                          AccessControl.User.AccessGroupFlags.View));
                        AccessControl.User userEngineer = new AccessControl.User("engineer", defaultEngineerPassword, (int)(
                                          AccessControl.User.AccessGroupFlags.SystemEngineer |
                                          AccessControl.User.AccessGroupFlags.Operator |
                                          AccessControl.User.AccessGroupFlags.View));

                        // Save the users
                        BaseClass.UsersStorageEngine.Save(userOperator.UserName, userOperator);
                        BaseClass.UsersStorageEngine.Save(userAdmin.UserName, userAdmin);
                        BaseClass.UsersStorageEngine.Save(userEngineer.UserName, userEngineer);
                        BaseClass.UsersStorageEngine.Save(userMerlin.UserName, userMerlin);
                        BaseClass.LoadAvailableUsers();

                        // Setup application feature access level requirements
                        BaseClass.FeatureAccessLevelRequirements.BasicProcessOperation = AccessControl.User.AccessGroupFlags.Operator;
                        BaseClass.FeatureAccessLevelRequirements.PositionsDatabaseRibbonAccess = AccessControl.User.AccessGroupFlags.Operator;
                        BaseClass.FeatureAccessLevelRequirements.ModifyProcessParameters = AccessControl.User.AccessGroupFlags.SystemAdministrator;
                        BaseClass.FeatureAccessLevelRequirements.HardwareRibbonAccess = AccessControl.User.AccessGroupFlags.SystemAdministrator;
                        BaseClass.FeatureAccessLevelRequirements.ShowHardwareConfigurationWindow = AccessControl.User.AccessGroupFlags.SystemEngineer;

                        // ****************************************************************************************************************
                        // SETUP USER ACTIVITY LOGGING
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 

                        // Optionally set up a user activity log. This default implementation logs to a HTML log file.
                        BaseClass.ActivityLogger = new ActivityLogFile($"{BaseClass.LogPath}Log_UserActivityLog.html");

                        // ****************************************************************************************************************
                        // LOAD HARDWARE DEVICE CONFIGURATIONS
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // Setup storage engines for system settings                       
                        ConnectedHardware.AnalogInputsStorageEngine = new Settings.StorageEngines.XmlSettingsStorageEngine(@"Config\AnalogInputs\", true);
                        ConnectedHardware.InputsStorageEngine = new Settings.StorageEngines.XmlSettingsStorageEngine(@"Config\Inputs\", true);
                        ConnectedHardware.AnalogOutputsStorageEngine = new Settings.StorageEngines.XmlSettingsStorageEngine(@"Config\AnalogOutputs\", true);
                        ConnectedHardware.OutputsStorageEngine = new Settings.StorageEngines.XmlSettingsStorageEngine(@"Config\Outputs\", true);
                        ConnectedHardware.AxesStorageEngine = new Settings.StorageEngines.XmlSettingsStorageEngine(@"Config\Axes\", true);
                        ConnectedHardware.CartesianConfigurationsStorageEngine = new Settings.StorageEngines.XmlSettingsStorageEngine(@"Config\CartesianConfigurations\", true);
                        ConnectedHardware.DevicesStorageEngine = new Settings.StorageEngines.XmlSettingsStorageEngine(@"Config\Hardware\", true);
                        ConnectedHardware.ArmsStorageEngine = new Settings.StorageEngines.XmlSettingsStorageEngine(@"Config\Arms\", true);

                        //// Optionally you can store hardware config in the database using a DatabaseSettingsStorageEngine
                        //// This will automatically create the relevant table.
                        //// See code below for a way to migrate your hardware config to the database instead of using XML files
                        //ConnectedHardware.AxesStorageEngine = new Settings.StorageEngines.DatabaseSettingsStorageEngine(BaseClass.DatabaseConnections[BaseClass.SystemDatabaseName], "hardwareconfig_axes");
                        
                        // Load all configurations from the storage engines
                        ConnectedHardware.LoadConnectedDeviceSettings();

                        // Optionally you can disable adding/removing/editing of items in hardware configuration
                        ConnectedHardware.DisableHardwareConfigUpdates = false;

                        //// If you want to migrate XML hardware config to database hardware config, you can use the MigrateSettingsToStorageEngine method
                        //var newAxesStorageEngine = new Settings.StorageEngines.DatabaseSettingsStorageEngine(BaseClass.DatabaseConnections[BaseClass.SystemDatabaseName], "hardwareconfig_axes");
                        //Settings.Configuration.MigrateSettingsToStorageEngine(ConnectedHardware.AxesStorageEngine, newAxesStorageEngine, false, true);

                        //var newHardwareStorageEngine = new Settings.StorageEngines.DatabaseSettingsStorageEngine(BaseClass.DatabaseConnections[BaseClass.SystemDatabaseName], "hardwareconfig_devices");
                        //Settings.Configuration.MigrateSettingsToStorageEngine(ConnectedHardware.DevicesStorageEngine, newHardwareStorageEngine, false, true);

                        // ****************************************************************************************************************
                        // SETUP EMERGENCY STOP CHECKER
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 

                        // TODO: PLEASE TAKE NOTE HOW THESE MAY BE AFFECTED BY THE OPTIONAL ESTOP LOOP OPTION IN THE SetupBaseClass METHOD
                        // TODO: IF YOU HAVE NOT CREATED A FULL COPY OF THE DEFAULT ESTOP LOOP METHOD THEN THESE METHODS WILL BE LEFT REDUNDANT

                        //// Check a single axis for an estop
                        //BaseClass.EmergencyStopChecker = new EmergencyStop.MotorControllerEmergencyStopChecker("X Axis");

                        //// OR

                        //// Check a list of axes for an estop, cycle through for each check so that the communication load is distributed across them all
                        //BaseClass.EmergencyStopChecker = new EmergencyStop.MotorControllerEmergencyStopChecker(new List<string>() { "X Axis", "Y Axis", "Z Axis"});

                        //// OR

                        //// Check an input for an estop
                        //BaseClass.EmergencyStopChecker = new EmergencyStop.IODeviceEmergencyStopChecker("EStop Input");

                        // ****************************************************************************************************************
                        // SETUP SYSTEM HOME SEQUENCE
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        ConnectedHardware.HomeAction = () =>
                        {
                              // TODO: Perform any special home actions e.g. Retract gripper cyclinder before homing

                              // We just want to home each of the cartesian configurations in order
                              foreach (MotionControl.CartesianConfiguration config in ConnectedHardware.CartesianConfigurations.Values)
                              {
                                    config.Home(Labman.Hardware.MotorControllers.MotorController.WaitForCompletion.Wait);
                              }
                        };

                        // ****************************************************************************************************************
                        // Setup priority hardware devices to be initialised first (before pre-initialise actions)
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        ConnectedHardware.PriorityHardwareInitialisationDeviceNames = new List<string>()
                        {
                              // TODO: Define a list of hardware device names that should be initialised first, BEFORE the pre-initialise actions
                              // "Safety PLC", "Special IO Device"
                        };

                        // ****************************************************************************************************************
                        // Perform pre intialisation actions
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        ConnectedHardware.PreInitialisationActions = () =>
                        {
                              // TODO: Define any pre intialisation actions. Delete if not required

                        };

                        // ****************************************************************************************************************
                        // Perform post intialisation actions
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        ConnectedHardware.PostInitialisationActions = () =>
                        {
                              // TODO: Define any post intialisation actions. Delete if not required

                        };

                        // ****************************************************************************************************************
                        // SETUP POST EMERGENCYSTOP ACTION ACTIONS
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .           
                        BaseClass.EmergencyStopTriggeredAction = () =>
                        {
                              // TODO: Define any actions that are to be perform when an emergency stop is triggered. Delete if not required

                              Hardware.CapClassifier.CloseMarshallingGates();
                              Hardware.CapLifter.LowerHopperShelf();
                              Hardware.Conveyor.SwitchBelt(Hardware.IODevices.IODevice.OutputState.Off);

                              // TODO: PLEASE TAKE NOTE HOW THIS MAY BE AFFECTED BY THE OPTIONAL ESTOP LOOP OPTION IN THE SetupBaseClass METHOD
                              // TODO: IF YOU HAVE NOT CREATED A FULL COPY OF THE DEFAULT ESTOP LOOP METHOD THEN THIS METHOD WILL BE LEFT REDUNDANT

                        };

                        // ****************************************************************************************************************
                        // SETUP PROCESS INSTANCES THAT WILL BE RUNNING
                        // NOTE - The processes aren't started yet.
                        //      - When the processes are started they are started in the same order that they are added to the ProcessList
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // TODO: UPDATE LIST TO INCLUDE PROJECT SPECIFIC PROCESSES
                        ProcessList.AddProcessClassInstance<CapFeedingProcess>("Main Process", false);
                        ProcessList.AddProcessClassInstance<CapMarshallingProcess>("Cap Marshalling Process", false);

                        // Example of assignomg module numbers to processes that have multiple instances

                        // ****************************************************************************************************************
                        // SETUP THE ACTIONS TO PERFORM FOR A SOAK TEST
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 

                        // Setup the items that we want the soak test to run.
                        // NOTE: These are prepared in order to ensure that the order they are added represents the safe home order for axes!!
                        BaseClass.SoakTestViewModel = new UserInterface.ViewModels.SoakTestViewModel();

                        // TODO: Add all axes to the soak test
                        BaseClass.SoakTestViewModel.AddTest(new SoakTesters.AxisSoakTester("X Axis", 500));

                        // ****************************************************************************************************************
                        // Log the application Version in the log
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        // Get assembly version
                        var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                        var fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
                        SystemLog.AddLogMessage($"Application (v{fvi.FileVersion}) setup complete", Logging.LogMessage.LogType.Information);

                        // ****************************************************************************************************************
                        // Login with default credentials
                        // Note: The application authentication is performed to prevent a user from being logged in if authentication expires
                        // This is also checked in the login method. This provides access to get to the RegistrationWindow
                        // . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 
                        if (BaseClass.IsApplicationAuthenticated())
                        {
                              BaseClass.UserAccess.Login("merlin", defaultSuperuserPassword);  // TODO: Set the default user. Remove if the user must perform a login
                        }
                        else
                        {
                              SystemLog.AddLogMessage($"The application is not authenticated for use on this computer.", Logging.LogMessage.LogType.Warning);
                        }

                        return true;
                  }
                  catch (Exception ex)
                  {
                        _startupException = ex;
                  }

                  return false;
            }
            
            #endregion

      }
}
