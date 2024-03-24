//=============================================================================
// <copyright file="RobotHardwareAutoGen.cs" company="Labman Automation Ltd">
// Copyright (c) Labman Automation Ltd. All rights reserved.
// </copyright>
//
// THIS FILE HAS BEEN AUTO-GENERATED. DO NOT EDIT. CHANGES WILL BE LOST.
// The classes are declared as partial so additions can be made in other files.
//=============================================================================

using System.Collections.Generic;
using Labman.Hardware.Balances;
using Labman.Hardware.BarcodeReaders;
using Labman.Hardware.Cameras;
using Labman.Hardware.CentrifugeCameras;
using Labman.Hardware.ElectricGrippers;
using Labman.Hardware.Instruments;
using Labman.Hardware.IODevices;
using Labman.Hardware.MotorControllers;
using Labman.Hardware.MotorControllers.TrinamicMotorControllers;
using Labman.Hardware.RecirculatingCoolers;
using Labman.Hardware.Rheometers;
using Labman.Hardware.RobotArms;
using Labman.Hardware.Syringes;
using Labman.IO;
using Labman.MotionControl;

namespace Labman.Hardware
{
      /// <summary>Exposes the ConnectedHardware types used by this system as properties.<summary>
      public static partial class RobotHardware
      {
            #region Classes

            /// <summary>AnalogInputs connected to the robot.</summary>
            public static partial class AnalogInputs
            {
                  #region Properties

                  /// <summary>AnalogInput</summary>
                  public static AnalogInput AnalogInput => ConnectedHardware.AnalogInputs["AnalogInput"];

                  /// <summary>AnalogInput2</summary>
                  public static AnalogInput AnalogInput2 => ConnectedHardware.AnalogInputs["AnalogInput2"];

                  /// <summary>AnalogInput3</summary>
                  public static AnalogInput AnalogInput3 => ConnectedHardware.AnalogInputs["AnalogInput3"];

                  /// <summary>AnAnalogInputWithAVeryLongNameAndMileageToMakeSureTheUICanCope</summary>
                  public static AnalogInput AnAnalogInputWithAVeryLongNameAndMileageToMakeSureTheUICanCope => ConnectedHardware.AnalogInputs["AnAnalogInputWithAVeryLongNameAndMileageToMakeSureTheUICanCope"];

                  #endregion
            }

            /// <summary>AnalogOutputs connected to the robot.</summary>
            public static partial class AnalogOutputs
            {
                  #region Properties

                  /// <summary>AnalogInputWithVeryVeryLongNameToCheckUICanCope</summary>
                  public static AnalogOutput AnalogInputWithVeryVeryLongNameToCheckUICanCope => ConnectedHardware.AnalogOutputs["AnalogInputWithVeryVeryLongNameToCheckUICanCope"];

                  /// <summary>AnalogOutput</summary>
                  public static AnalogOutput AnalogOutput => ConnectedHardware.AnalogOutputs["AnalogOutput"];

                  /// <summary>AnalogOutput2</summary>
                  public static AnalogOutput AnalogOutput2 => ConnectedHardware.AnalogOutputs["AnalogOutput2"];

                  /// <summary>AnalogOutputWithMileage</summary>
                  public static AnalogOutput AnalogOutputWithMileage => ConnectedHardware.AnalogOutputs["AnalogOutputWithMileage"];

                  #endregion
            }

            /// <summary>Axes connected to the robot.</summary>
            public static partial class Axes
            {
                  #region Properties

                  /// <summary>ServoTronixAxis</summary>
                  public static ServotronixAxis ServoTronixAxis => (ServotronixAxis)ConnectedHardware.Axes["ServoTronixAxis"];

                  /// <summary>TecanOmniAxis</summary>
                  public static Axis TecanOmniAxis => ConnectedHardware.Axes["TecanOmniAxis"];

                  /// <summary>Trinamic3351Axis</summary>
                  public static TrinamicAxis Trinamic3351Axis => (TrinamicAxis)ConnectedHardware.Axes["Trinamic3351Axis"];

                  /// <summary>X Axis</summary>
                  public static Axis XAxis => ConnectedHardware.Axes["X Axis"];

                  /// <summary>Y Axis</summary>
                  public static SchneiderCANAxis YAxis => (SchneiderCANAxis)ConnectedHardware.Axes["Y Axis"];

                  /// <summary>Z Axis</summary>
                  public static SchneiderCANAxis ZAxis => (SchneiderCANAxis)ConnectedHardware.Axes["Z Axis"];

                  #endregion
            }

            /// <summary>CartesianConfigurations connected to the robot.</summary>
            public static partial class CartesianConfigurations
            {
                  #region Properties

                  /// <summary>Gantry</summary>
                  public static CartesianConfiguration Gantry => ConnectedHardware.CartesianConfigurations["Gantry"];

                  /// <summary>Partial Gantry</summary>
                  public static CartesianConfiguration PartialGantry => ConnectedHardware.CartesianConfigurations["Partial Gantry"];

                  #endregion
            }

            /// <summary>Hardware connected to the robot.</summary>
            public static partial class Hardware
            {
                  #region Properties

                  /// <summary>ADAMIODevice</summary>
                  public static ADAMIODevice ADAMIODevice => (ADAMIODevice)ConnectedHardware.IODevices["ADAMIODevice"];

                  /// <summary>AntonPaar</summary>
                  public static AntonPaar AntonPaar => (AntonPaar)ConnectedHardware.Rheometers["AntonPaar"];

                  /// <summary>Barcode</summary>
                  public static IFMBarcodeReader Barcode => (IFMBarcodeReader)ConnectedHardware.BarcodeReaders["Barcode"];

                  /// <summary>Baumer1</summary>
                  public static BaumerCamera Baumer1 => (BaumerCamera)ConnectedHardware.Cameras["Baumer1"];

                  /// <summary>Baumer2</summary>
                  public static BaumerCamera2 Baumer2 => (BaumerCamera2)ConnectedHardware.Cameras["Baumer2"];

                  /// <summary>CentrifugeCamera</summary>
                  public static CentrifugeCamera1Point CentrifugeCamera => (CentrifugeCamera1Point)ConnectedHardware.CentrifugeCameras["CentrifugeCamera"];

                  /// <summary>FanucRobotArm</summary>
                  public static FanucRobotArm FanucRobotArm => (FanucRobotArm)ConnectedHardware.RobotArms["FanucRobotArm"];

                  /// <summary>FestoAnalogInputDevice</summary>
                  public static FestoCANAnalogInputDevice FestoAnalogInputDevice => (FestoCANAnalogInputDevice)ConnectedHardware.IODevices["FestoAnalogInputDevice"];

                  /// <summary>FestoAnalogOutputDevice</summary>
                  public static FestoCANAnalogOutputDevice FestoAnalogOutputDevice => (FestoCANAnalogOutputDevice)ConnectedHardware.IODevices["FestoAnalogOutputDevice"];

                  /// <summary>FestoCoDeSys</summary>
                  public static FestoCPXCoDeSysEmbeddedControllerIODevice FestoCoDeSys => (FestoCPXCoDeSysEmbeddedControllerIODevice)ConnectedHardware.IODevices["FestoCoDeSys"];

                  /// <summary>FestoCPX</summary>
                  public static FestoCANCPXIODevice FestoCPX => (FestoCANCPXIODevice)ConnectedHardware.IODevices["FestoCPX"];

                  /// <summary>FestoDoubleValveBank</summary>
                  public static FestoCANDoubleValveBankIODevice FestoDoubleValveBank => (FestoCANDoubleValveBankIODevice)ConnectedHardware.IODevices["FestoDoubleValveBank"];

                  /// <summary>FestoStringDoubleValveBank</summary>
                  public static FestoCANCPXCPStringDoubleValveBankIODevice FestoStringDoubleValveBank => (FestoCANCPXCPStringDoubleValveBankIODevice)ConnectedHardware.IODevices["FestoStringDoubleValveBank"];

                  /// <summary>FestoStringIODevice</summary>
                  public static FestoCANCPXCPStringIODevice FestoStringIODevice => (FestoCANCPXCPStringIODevice)ConnectedHardware.IODevices["FestoStringIODevice"];

                  /// <summary>FestoValveBankIODevice</summary>
                  public static FestoCANValveBankIODevice FestoValveBankIODevice => (FestoCANValveBankIODevice)ConnectedHardware.IODevices["FestoValveBankIODevice"];

                  /// <summary>Gripper</summary>
                  public static SchunkElectricGripper Gripper => (SchunkElectricGripper)ConnectedHardware.ElectricGrippers["Gripper"];

                  /// <summary>JulaboRecirculatingCooler</summary>
                  public static JulaboRecirculatingCooler JulaboRecirculatingCooler => (JulaboRecirculatingCooler)ConnectedHardware.RecirculatingCoolers["JulaboRecirculatingCooler"];

                  /// <summary>Kawasaki</summary>
                  public static KawasakiRobotArm Kawasaki => (KawasakiRobotArm)ConnectedHardware.RobotArms["Kawasaki"];

                  /// <summary>LabmanEthernetIO</summary>
                  public static LabmanEthernetIO LabmanEthernetIO => (LabmanEthernetIO)ConnectedHardware.IODevices["LabmanEthernetIO"];

                  /// <summary>LabmanPneumaticsOutputAdapter</summary>
                  public static LabmanPneumaticsOutputAdapter LabmanPneumaticsOutputAdapter => (LabmanPneumaticsOutputAdapter)ConnectedHardware.IODevices["LabmanPneumaticsOutputAdapter"];

                  /// <summary>LMA2012</summary>
                  public static LMA2012_04IODevice LMA2012 => (LMA2012_04IODevice)ConnectedHardware.IODevices["LMA2012"];

                  /// <summary>LumbergFieldBusIODevice</summary>
                  public static LumbergFieldBusIODevice LumbergFieldBusIODevice => (LumbergFieldBusIODevice)ConnectedHardware.IODevices["LumbergFieldBusIODevice"];

                  /// <summary>Mettler Balance</summary>
                  public static MettlerBalance MettlerBalance => (MettlerBalance)ConnectedHardware.Balances["Mettler Balance"];

                  /// <summary>MettlerMoistureAnalyser</summary>
                  public static MettlerMoistureAnalyser MettlerMoistureAnalyser => (MettlerMoistureAnalyser)ConnectedHardware.Balances["MettlerMoistureAnalyser"];

                  /// <summary>Mitsubishi</summary>
                  public static MitsubishiRobotArm Mitsubishi => (MitsubishiRobotArm)ConnectedHardware.RobotArms["Mitsubishi"];

                  /// <summary>MoxaE1Digital</summary>
                  public static MoxaE1KDigitalIODevice MoxaE1Digital => (MoxaE1KDigitalIODevice)ConnectedHardware.IODevices["MoxaE1Digital"];

                  /// <summary>MoxaIOLogikE1242</summary>
                  public static MoxaIOLogikE1242IODevice MoxaIOLogikE1242 => (MoxaIOLogikE1242IODevice)ConnectedHardware.IODevices["MoxaIOLogikE1242"];

                  /// <summary>Phigits</summary>
                  public static PhidgetsIODevice Phigits => (PhidgetsIODevice)ConnectedHardware.IODevices["Phigits"];

                  /// <summary>PILZ</summary>
                  public static PILZPNOZMulti2IODevice PILZ => (PILZPNOZMulti2IODevice)ConnectedHardware.IODevices["PILZ"];

                  /// <summary>PositionIODevice</summary>
                  public static PositionIODevice PositionIODevice => (PositionIODevice)ConnectedHardware.IODevices["PositionIODevice"];

                  /// <summary>RGB</summary>
                  public static QuasarRGBLEDController RGB => (QuasarRGBLEDController)ConnectedHardware.Instruments["RGB"];

                  /// <summary>Sartorius Balance</summary>
                  public static SartoriusBalance SartoriusBalance => (SartoriusBalance)ConnectedHardware.Balances["Sartorius Balance"];

                  /// <summary>SchneiderCANMotorController</summary>
                  public static SchneiderCANMotorController SchneiderCANMotorController => (SchneiderCANMotorController)ConnectedHardware.MotorControllers["SchneiderCANMotorController"];

                  /// <summary>ServoTronixMotorController</summary>
                  public static ServotronixCANMotorController ServoTronixMotorController => (ServotronixCANMotorController)ConnectedHardware.MotorControllers["ServoTronixMotorController"];

                  /// <summary>Tecan</summary>
                  public static TecanSyringe Tecan => (TecanSyringe)ConnectedHardware.Syringes["Tecan"];

                  /// <summary>TecanOmniAPIMotorController</summary>
                  public static TecanOmniAPIMotorController TecanOmniAPIMotorController => (TecanOmniAPIMotorController)ConnectedHardware.MotorControllers["TecanOmniAPIMotorController"];

                  /// <summary>TecanOmniMotorController</summary>
                  public static TecanOmniMotorController TecanOmniMotorController => (TecanOmniMotorController)ConnectedHardware.MotorControllers["TecanOmniMotorController"];

                  /// <summary>Trinamic3351MotorController</summary>
                  public static TrinamicMotorController3351 Trinamic3351MotorController => (TrinamicMotorController3351)ConnectedHardware.MotorControllers["Trinamic3351MotorController"];

                  /// <summary>Vermes</summary>
                  public static VermesMicroDispenser Vermes => (VermesMicroDispenser)ConnectedHardware.Syringes["Vermes"];

                  /// <summary>WatersBackPressureRegulator</summary>
                  public static WatersBackPressureRegulator WatersBackPressureRegulator => (WatersBackPressureRegulator)ConnectedHardware.Instruments["WatersBackPressureRegulator"];

                  #endregion
            }

            /// <summary>Inputs connected to the robot.</summary>
            public static partial class Inputs
            {
                  #region Properties

                  /// <summary>Input With Spaces</summary>
                  public static Input InputWithSpaces => ConnectedHardware.Inputs["Input With Spaces"];

                  /// <summary>Input</summary>
                  public static Input Input => ConnectedHardware.Inputs["Input"];

                  /// <summary>Input2</summary>
                  public static Input Input2 => ConnectedHardware.Inputs["Input2"];

                  /// <summary>InputThatIsInverted</summary>
                  public static Input InputThatIsInverted => ConnectedHardware.Inputs["InputThatIsInverted"];

                  #endregion
            }

            /// <summary>Outputs connected to the robot.</summary>
            public static partial class Outputs
            {
                  #region Properties

                  /// <summary>Cylinder</summary>
                  public static Output Cylinder => ConnectedHardware.Outputs["Cylinder"];

                  /// <summary>Output</summary>
                  public static Output Output => ConnectedHardware.Outputs["Output"];

                  /// <summary>Output2</summary>
                  public static Output Output2 => ConnectedHardware.Outputs["Output2"];

                  /// <summary>Output3</summary>
                  public static Output Output3 => ConnectedHardware.Outputs["Output3"];

                  /// <summary>OutputWithMileage</summary>
                  public static Output OutputWithMileage => ConnectedHardware.Outputs["OutputWithMileage"];

                  /// <summary>OutputWithSensors</summary>
                  public static Output OutputWithSensors => ConnectedHardware.Outputs["OutputWithSensors"];

                  #endregion
            }

            #endregion
      }
}
