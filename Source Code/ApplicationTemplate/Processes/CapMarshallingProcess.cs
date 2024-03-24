using System;
using GalaSoft.MvvmLight.Messaging;
using Labman.Hardware;

namespace Labman.Processes
{
      /// <summary>
      /// This class is used as a demo to mock a simple state machine for a dispensing station.
      /// This class should be used as a template for all process classes inheritting from the base Process class.
      /// </summary>
      public class CapMarshallingProcess : ProcessBase
      {
            #region Variables & Objects 
            
            private DateTime _lastCapFedTime;
            private TimeSpan _averageTotalCappingTime;
            private TimeSpan _outOfCapsTimeout;
            private TimeSpan _timeBetweenLastCaps;
            private bool _isFirstRun = true;

            #endregion

            #region Enumeration

            /// <summary>
            /// Enumeration of process states for this state machine.
            /// States less than zero are used to end the process loop.
            /// </summary>
            private enum ProcessState
            { 
                  Faulted = -2,
                  Complete = -1,
                  Startup = 0,
                  Initialising = 1,
                  Running = 2
            }

            #endregion

            #region Constructor 
            
            /// <summary>
            /// Default constructor. The process name should be specified after initialisation
            /// </summary>
            public CapMarshallingProcess() : base() { }

            /// <summary>
            /// The class constructor calls the base constructor, passing the process name as a parameter
            /// </summary>
            /// <param name="processName">The name of this process thread</param>
            /// <param name="logStateChanges">True to log each state change to the process log</param>
            public CapMarshallingProcess(string processName, bool logStateChanges) : base(processName, logStateChanges) { }

            #endregion

            // These methods override those in the base class.
            #region State Machine Overrides

            /// <summary>
            /// This method is called before the main process loop begins
            /// </summary>
            /// <returns>A result state that determines the action to take before starting the process</returns>
            protected override ProcessBase.PreProcessResult PreProcess()
            {
                  // Perform any pre-process actions in here
                                    
                  if (_isFirstRun)
                  {
                        _averageTotalCappingTime = TimeSpan.Zero;
                        _isFirstRun = false;
                  }

                  _lastCapFedTime = DateTime.UtcNow;

                  //Set output queue parameters based
                  _outOfCapsTimeout = TimeSpan.FromMilliseconds(60000); // TODO: Change from hard code
                  
                  // Return that we are ready to start the process
                  return PreProcessResult.OkToStart;
            }

            /// <summary>
            /// Main process loop method that gets called from the base Process class continuously until the process
            /// state is set to the 'Complete' state.
            /// </summary>
            protected override void ProcessLoop()
            {
                  // Lookup the current process state for the state machine.
                  // For each state, execute the appropriate action and move to the next state.
                  // NOTE: Process states completed and faulted are handled by the base class!
                  switch ((ProcessState)CurrentState)
                  {
                        case ProcessState.Startup:
                              SetState(ProcessState.Initialising);
                              break;

                        case ProcessState.Initialising:
                              CapClassifier.CloseMarshallingGates();
                              SetState(ProcessState.Running);
                              break;

                        case ProcessState.Running:

                              if (CapClassifier.IsCapFed()) //Check that a cap is detected at the 1st gate
                              {
                                    CapClassifier.MarshalCap();
                                    _timeBetweenLastCaps = DateTime.UtcNow - _lastCapFedTime;
                                    _averageTotalCappingTime += _timeBetweenLastCaps;
                                    _lastCapFedTime = DateTime.UtcNow;
                                    SendCapFeederDataToUI();
                              }
                              else if ((DateTime.UtcNow - _lastCapFedTime) > _outOfCapsTimeout)
                              {
                                    //If a tube hasn't been fed in a while, the hopper is empty so end the process
                                    HardwareLog.AddLogMessage("System has run out of caps", Logging.LogMessage.LogType.Warning);
                                    _lastCapFedTime = DateTime.UtcNow;
                                    SetState(ProcessState.Complete);
                              }

                              break;

                        default: throw new Exception($"Process {ProcessName} set to invalid state {(ProcessState)CurrentState}");
                  }
            }

            /// <summary>
            /// This method is called when the process loop exits for any condition
            /// </summary>
            protected override void PostProcess()
            {
                  try
                  {
                        // Resetting the gates
                        CapClassifier.CloseMarshallingGates();
                        Conveyor.SwitchBelt(Hardware.IODevices.IODevice.OutputState.Off);
                        ProcessList.AbortAll();
                  }
                  catch
                  {
                        ProcessList.AbortAll();
                        throw new TimeoutException("Cap Marshalling Process Timed Out", ProcessException);
                  }
                  
            }

            #endregion

            #region Utility Methods

            private double CalculateThroughput()
            {
                  return CapClassifier.SortedCaps / (Convert.ToDouble(_averageTotalCappingTime.TotalSeconds) / 3600);
            }

            #endregion

            #region Messaging

            private void SendCapFeederDataToUI()
            {
                  int totalCaps = CapClassifier.SortedCaps;
                  int rejectedCaps = CapClassifier.RejectedCaps;
                  double throughput = CalculateThroughput();

                  Messenger.Default.Send(new Messaging.Messages.CapFeederDataChangedMessage(totalCaps, rejectedCaps, _timeBetweenLastCaps, throughput));
            }

            #endregion
      }
}
