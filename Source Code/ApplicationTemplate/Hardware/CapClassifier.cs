using System;
using System.Threading;
using Labman.Hardware.IODevices;
using Labman.IO;
using Labman.Logging;

namespace Labman.Hardware
{
      /// <summary>
      /// Class to process Cap Classifier module actions (sorting, marshalling, etc)
      /// </summary>
      public static class CapClassifier
      {
            #region Public Properties

            /// <summary>
            ///  Used for tracking how many caps have been sorted. 
            /// </summary>
            public static int SortedCaps { get; set; }

            /// <summary>
            ///  Used for tracking how many caps have been rejected. 
            /// </summary>
            public static int RejectedCaps { get; set; }

            #endregion

            #region Private Properties

            // Cap sorting sensors

            /// <summary>
            /// Detects the presence of the cap
            /// </summary>
            private static Input SideSensor => ConnectedHardware.Inputs["CapSideSensor"];

            /// <summary>
            /// Detects if the cap is inverted
            /// </summary>
            private static Input TopSensor => ConnectedHardware.Inputs["CapTopSensor"];

            // Cylinder sensors

            /// <summary>
            /// Cylinder which pushes the caps off if they are wrong
            /// </summary>
            private static Output SortingCylinder => ConnectedHardware.Outputs["SortingCylinder"];

            /// <summary>
            /// Cylinder that prevents caps from entering the sorting area
            /// </summary>
            private static Output MarshalEntranceCylinder => ConnectedHardware.Outputs["MarshalEntranceCylinder"];

            /// <summary>
            /// Cylinder which prevents the cap from exiting while being sorted
            /// </summary>
            private static Output MarshalExitCylinder => ConnectedHardware.Outputs["MarshalExitCylinder"];

            #endregion

            /// <summary>
            /// Processes one cap through the marshalling gates
            /// </summary>
            public static void MarshalCap()
            {
                  if (BaseClass.SimulationMode)
                  {
                        return;
                  }

                  //Thread.Sleep(500);      //todo 1000ms
                  bool correctWayUp = TopSensor.ReadInput(IODevice.InputState.Off) == IODevice.InputState.On;

                  //Ensure gate 2 is closed
                  MarshalExitCylinder.On();
                  SortingCylinder.Off();

                  //Let cap past gate 1
                  MarshalEntranceCylinder.Off();

                  //Thread.Sleep(400);

                  int marshallingGateRetries = 0;
                  bool gateClosed = false;

                  while (!gateClosed)
                  {
                        // Might need to add some more error handling with this / find out what is going on with the gate retrys
                        MarshalEntranceCylinder.On(Output.SwitchParameters.SkipSensorCheckAndDelay);

                        // Loop while the input is not at the correct state
                        DateTime timeoutTime = DateTime.Now.AddMilliseconds(MarshalEntranceCylinder.Settings.OnSensorTimeout);

                        // Giving the gate time to close
                        while (DateTime.Now < timeoutTime)
                        {
                              Thread.Sleep(5);
                        }

                        // Checking if it closed succcesfully
                        if (ConnectedHardware.Inputs[MarshalEntranceCylinder.Settings.OnSensorName].ReadInput(IODevice.InputState.On) == IODevice.InputState.On)
                        {
                              // Gate closed Succesfully
                              gateClosed = true;
                        }
                        else
                        {
                              // Gate didn't close
                              gateClosed = false;
                              if (marshallingGateRetries >= 5)
                              {
                                    HardwareLog.AddLogMessage($"After 5 attempts marshalling gate didn't close", LogMessage.LogType.Information);
                                    throw new EntranceGateNotClosingException("Marshalling entrance gate not closing after 5 attempts");
                              }
                              else
                              {
                                    HardwareLog.AddLogMessage($"After {MarshalEntranceCylinder.Settings.OnSensorTimeout}ms, marshalling gate didn't close, retrying", LogMessage.LogType.Information);
                              }
                             MarshalEntranceCylinder.Off();

                        }

                        marshallingGateRetries++;
                  }

                  //Determine whether the cap is the correct way up
                  if (correctWayUp)
                  {
                        //Cap is the correct way up - allow through
                        MarshalExitCylinder.Off();

                        //Thread.Sleep(400);
                  }
                  else
                  {
                        //Cap is upside-down, push it off the belt
                        SortingCylinder.On();
                        //Thread.Sleep(200);
                        SortingCylinder.Off();
                        SystemLog.AddLogMessage($"Total Caps Rejected: {RejectedCaps}", LogMessage.LogType.Data);
                        RejectedCaps++;
                  }

                  // Implemented like this for the QA testing
                  SystemLog.AddLogMessage($"Total Caps Sorted: {SortedCaps}", LogMessage.LogType.Data);
                  SortedCaps++;

            }

            /// <summary>
            /// Closes the marshalling gates in the cap feeder
            /// </summary>
            public static void ResetMarshallingGates()
            {
                  if (BaseClass.SimulationMode)
                  {
                        return;
                  }

                  // Reset the cylinders
                  MarshalExitCylinder.Off();
                  SortingCylinder.Off();
                  MarshalEntranceCylinder.On();

                  Thread.Sleep(1000);

                  // Reset the cylinders
                  MarshalExitCylinder.On();
                  SortingCylinder.Off();
                  MarshalEntranceCylinder.Off();

                  Thread.Sleep(1000);

                  CloseMarshallingGates();
            }

            /// <summary>
            /// Closes the marshalling gates in the cap feeder
            /// </summary>
            public static void CloseMarshallingGates()
            {
                  if (BaseClass.SimulationMode)
                  {
                        return;
                  }

                  // Close the cylinders
                  MarshalExitCylinder.On();
                  SortingCylinder.Off();
                  MarshalEntranceCylinder.On();

            }

            /// <summary>
            /// Opens all marshalling gates
            /// </summary>
            public static void OpenMarshallingGates()
            {
                  if (BaseClass.SimulationMode)
                  {
                        return;
                  }

                  // Reset the cylinders
                  MarshalExitCylinder.Off();
                  SortingCylinder.Off();
                  MarshalEntranceCylinder.Off();
            }

            /// <summary>
            /// Returns true if there is a cap waiting to be fed TODO: Check if inverted
            /// </summary>
            /// <returns>Returns true if a cap is ready</returns>
            public static bool IsCapFed()
            {
                  if (BaseClass.SimulationMode)
                  {
                        return true;
                  }

                  return SideSensor.ReadInput(IODevices.IODevice.InputState.On).Equals(IODevices.IODevice.InputState.On);
            }
      }
}
