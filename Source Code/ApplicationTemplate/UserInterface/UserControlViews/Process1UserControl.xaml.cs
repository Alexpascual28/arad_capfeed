using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Labman.UserInterface.ViewModels;

namespace Labman.UserInterface.UserControlViews
{
      /// <summary>
      /// Interaction logic for Process1USerControl.xaml
      /// </summary>
      public partial class Process1UserControl : UserControl
      {
            /// <summary>
            /// Creates a new instance of <see cref="Process1UserControl"/>
            /// </summary>
            public Process1UserControl()
            {
                  Process1UserControlViewModel vm = new Process1UserControlViewModel();
                  this.DataContext = vm;
                  InitializeComponent();
            }
      }
}
