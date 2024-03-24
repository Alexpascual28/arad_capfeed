using System;
using System.Threading;
using Labman.Hardware.IODevices;
using Labman.IO;
using Labman.Logging;

namespace Labman.Hardware
{
      /// <summary>
      /// Class to process conveyor actions
      /// </summary>
      public static class Conveyor
      {
            /// <summary>
            /// Motor which moves the caps
            /// </summary>
            private static Output ConveyorMotor => ConnectedHardware.Outputs["ConveyorMotor"];

            /// <summary>
            /// Changes the state of the conveyor motor
            /// </summary>
            /// <param name="state">On or Off</param>
            public static void SwitchBelt(IODevice.OutputState state)
            {
                  if (BaseClass.SimulationMode)
                  {
                        return;
                  }
                  HardwareLog.AddLogMessage($"Switching belt motor {state}", LogMessage.LogType.Information);
                  ConveyorMotor.Switch(state);
            }
      }
}
