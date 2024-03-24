using System;
using GalaSoft.MvvmLight.Messaging;
using Labman.Hardware;

namespace Labman.Processes
{
      /// <summary>
      /// This class is used as a demo to mock a simple state machine for a dispensing station.
      /// This class should be used as a template for all process classes inheritting from the base Process class.
      /// </summary>
      public class CapFeedingProcess : ProcessBase
      {
            #region Private Fields

            private int _consecutiveJamCount;

            #endregion

            #region Constructors

            /// <summary>
            /// Cap feeder constructor
            /// </summary>
            public CapFeedingProcess() : base()
            {
            }

            /// <summary>Initializes a new instance of the <see cref="CapFeedingProcess"/> class.</summary>
            /// <param name="processName">Name of the process.</param>
            /// <param name="logStateChanges">if set to <c>true</c> [log state changes].</param>
            public CapFeedingProcess(string processName, bool logStateChanges) : base(processName, logStateChanges)
            {
            }

            #endregion

            #region Public Enums

            /// <summary>Enumeration of cap marshalling process states</summary>
            public enum ProcessState
            {
                  /// <summary>The process stopped with an error</summary>
                  Faulted = -2,

                  /// <summary>The process ended because the cap hopper is empty</summary>
                  Complete = -1,

                  /// <summary>The process is performing setup actions</summary>
                  Initialising = 1,

                  /// <summary>The process is marshalling caps</summary>
                  Running = 2,
            }

            #endregion

            #region State Machine Overrides

            /// <summary>Pre-process method</summary>
            /// <returns>A process result state that indicates whether the main process loop may continue</returns>
            protected override PreProcessResult PreProcess()
            {
                  _consecutiveJamCount = 0;

                  try
                  {
                        Hardware.Conveyor.SwitchBelt(Hardware.IODevices.IODevice.OutputState.On);
                        Hardware.CapClassifier.ResetMarshallingGates();
                        Hardware.Conveyor.SwitchBelt(Hardware.IODevices.IODevice.OutputState.Off);
                  }
                  catch
                  {
                        Hardware.Conveyor.SwitchBelt(Hardware.IODevices.IODevice.OutputState.Off);
                        Hardware.CapClassifier.OpenMarshallingGates();
                  }

                  //Set output queue parameters based
                  SetState(ProcessState.Initialising);
                  return PreProcessResult.OkToStart;
            }

            /// <summary>Process loop method runs repeatedly until the process ends</summary>
            protected override void ProcessLoop()
            {
                  switch ((ProcessState)CurrentState)
                  {
                        case ProcessState.Initialising:

                              //Setting Hardware to starting positions
                              Conveyor.SwitchBelt(Hardware.IODevices.IODevice.OutputState.On);
                              CapLifter.LowerHopperShelf();
                              SetState(ProcessState.Running);
                              break;

                        case ProcessState.Running:
                              //Try to lift the shelf in the hopper
                              CapLifter.HopperFeedResult result = CapLifter.LiftHopperShelf();
                              switch (result)
                              {
                                    case CapLifter.HopperFeedResult.Okay:
                                          _consecutiveJamCount = 0;
                                          break;

                                    case CapLifter.HopperFeedResult.Jammed:
                                          //1 jam is fine, but many means that the hopper is stuck
                                          _consecutiveJamCount++;
                                          int maxJams = 3; // TODO: Change this from hard code
                                          if (_consecutiveJamCount > maxJams)
                                          {
                                                throw new Exception($"Cap feeding failed. The shelf is obstructed and has failed to lift after {maxJams} attempts.");
                                          }
                                          break;

                                    default: throw new Exception($"Invalid hopper lifting status '{result}'.");
                              }

                              //Lower the shelf
                              CapLifter.LowerHopperShelf();
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
      }
}
