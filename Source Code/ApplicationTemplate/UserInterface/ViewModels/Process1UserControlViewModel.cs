using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using Labman.Messaging.Messages;

namespace Labman.UserInterface.ViewModels
{

      /// <summary>
      /// Process User control
      /// </summary>
      public partial class Process1UserControlViewModel : ViewModelBase
      {
            #region Constructor

            /// <summary>
            /// Creates a new instance of <see cref="Process1UserControlViewModel"/>
            /// </summary>
            public Process1UserControlViewModel()
            {
                  RegisterToMessages();
            }

            #endregion

            #region Fields

            private int _totalCapsProcessed;
            private int _totalCapsRejected;
            private double _percentageCapsRejected;
            private TimeSpan _intervalFromLastCap;
            private double _throughput;

            #endregion

            #region Properties

            /// <summary>
            /// Gets or sets the current amount of processed caps
            /// </summary>
            public int TotalCapsProcessed
            {
                  get => _totalCapsProcessed;
                  set
                  {
                        _totalCapsProcessed = value;
                        OnPropertyChanged(nameof(TotalCapsProcessed));
                        OnPropertyChanged(nameof(PercentageCapsRejected));
                  }
            }

            /// <summary>
            /// Gets or sets the current amount of rejected caps
            /// </summary>
            public int TotalCapsRejected
            {
                  get => _totalCapsRejected;
                  set
                  {
                        _totalCapsRejected = value;
                        OnPropertyChanged(nameof(TotalCapsRejected));
                        OnPropertyChanged(nameof(PercentageCapsRejected));
                  }
            }

            /// <summary>
            /// Gets the current amount of rejected caps
            /// </summary>
            public double PercentageCapsRejected
            {
                  get
                  {
                        _percentageCapsRejected = _totalCapsProcessed == 0 ? 0 : Math.Round((Convert.ToDouble(_totalCapsRejected) / Convert.ToDouble(_totalCapsProcessed)) * 100, 2);
                        return _percentageCapsRejected;
                  }

                  set
                  {
                        _percentageCapsRejected = value;
                        OnPropertyChanged(nameof(PercentageCapsRejected));
                  }
            }

            /// <summary>
            /// Gets or sets the current amount of rejected caps
            /// </summary>
            public double IntervalFromLastCap
            {
                  get => Math.Round(Convert.ToDouble(_intervalFromLastCap.TotalSeconds), 4);
                  set
                  {
                        _intervalFromLastCap = TimeSpan.FromSeconds(value);
                        OnPropertyChanged(nameof(IntervalFromLastCap));
                  }
            }

            /// <summary>
            /// Gets or sets the current amount of rejected caps
            /// </summary>
            public double Throughput
            {
                  get => Math.Round(_throughput, 2);
                  set
                  {
                        _throughput = value;
                        OnPropertyChanged(nameof(Throughput));
                  }
            }

            #endregion

            #region Messaging

            private void RegisterToMessages()
            {
                  Messenger.Default.Register<CapFeederDataChangedMessage>(this, CapFeederMessageReceived);
            }

            private void CapFeederMessageReceived(CapFeederDataChangedMessage msg)
            {
                  this.TotalCapsProcessed = msg.TotalCapsProcessed;
                  this.TotalCapsRejected = msg.TotalCapsRejected;
                  this.IntervalFromLastCap = Convert.ToDouble(msg.IntervalFromLastCap.TotalSeconds);
                  this.Throughput = msg.Throughput;
            }

            #endregion
      }
}
