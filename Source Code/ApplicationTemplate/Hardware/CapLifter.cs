using System;
using System.Threading;
using Labman.Hardware.IODevices;
using Labman.IO;
using Labman.Logging;

namespace Labman.Hardware
{
      /// <summary>
      /// Class to process cap lift module actions
      /// </summary>
      public static class CapLifter
      {
            /// <summary>
            /// Stores the state of if the hopper is jammed
            /// </summary>
            public enum HopperFeedResult
            {
                  /// <summary>The caps were lifted successfully</summary>
                  Okay,

                  /// <summary>The shelf could not lift because caps obstructed it</summary>
                  Jammed
            }

            /// <summary>
            /// CapLifting Cylinder
            /// </summary>
            private static Output LiftingCylinder => ConnectedHardware.Outputs["LiftingCylinder"];

            /// <summary>
            /// Lowers the cap lifting cylinder
            /// </summary>
            public static void LowerHopperShelf()
            {
                  if (BaseClass.SimulationMode)
                  {
                        return;
                  }
                  LiftingCylinder.Off();
            }

            /// <summary>
            /// Attempts to lift the cap shelf. Returns the result 
            /// </summary>
            /// <returns>Result from lift attempt</returns>
            public static HopperFeedResult LiftHopperShelf()
            {
                  HardwareLog.AddLogMessage("Lifting cap hopper shelf", LogMessage.LogType.Information);  //todo remove? too much logging?
                  if (BaseClass.SimulationMode)
                  {
                        return HopperFeedResult.Okay;
                  }

                  //Fire output
                  LiftingCylinder.On(Output.SwitchParameters.SkipSensorCheckAndDelay);

                  // Loop while the input is not at the correct state
                  DateTime timeoutTime = DateTime.Now.AddMilliseconds(LiftingCylinder.Settings.OnSensorTimeout);
                  while (ConnectedHardware.Inputs[LiftingCylinder.Settings.OnSensorName].ReadInput(IODevice.InputState.On) == IODevice.InputState.Off)
                  {
                        Thread.Sleep(5);

                        // If a timeout has occurred
                        if (DateTime.Now > timeoutTime)
                        {
                              HardwareLog.AddLogMessage($"After {LiftingCylinder.Settings.OnSensorTimeout}ms, hopper shelf did not lift fully",
                                                         LogMessage.LogType.Information);
                              return HopperFeedResult.Jammed;
                        }
                  }

                  Thread.Sleep(500);
                  return HopperFeedResult.Okay;
            }
      }
}
