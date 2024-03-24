using Labman.UserInterface.WindowViews;

namespace Labman.UserInterface
{
      /// <summary>
      /// Interaction logic for MainWindow.xaml
      /// </summary>
      public partial class MainWindow : WindowBase
      {
            #region Public Constructors

            /// <summary>
            /// Initializes a new instance of the <see cref="MainWindow" /> class.
            /// </summary>
            public MainWindow()
            {
                  InitializeComponent();
            }

            #endregion

            private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
            {
                  // Check with the user if they realise they are closing the application while the process is running.
                  if (ProcessList.IsProcessRunning)
                  {
                        var result = MessageBox.Show("Closing the application will end the current process. This could cause damage to the system. Are you sure you wish to close?",
                              "Process is running",
                              System.Windows.MessageBoxButton.OKCancel,
                              System.Windows.MessageBoxImage.Warning,
                              System.Windows.MessageBoxResult.Cancel);

                        if (result == System.Windows.MessageBoxResult.Cancel)
                        {
                              e.Cancel = true;
                              return;
                        }
                  }

                  BaseClass.Dispose();
            }
      }
}