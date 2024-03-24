//=============================================================================
// <copyright file="ParametersAutoGen.cs" company="Labman Automation Ltd">
// Copyright (c) Labman Automation Ltd. All rights reserved.
// </copyright>
//
// THIS FILE HAS BEEN AUTO-GENERATED. DO NOT EDIT. CHANGES WILL BE LOST.
// The classes are declared as partial so additions can be made in other files.
//=============================================================================
using System;

namespace Labman.Database
{
      /// <summary>The parameters used by this system.</summary>
      public static partial class Parameters
      {
            #region Classes

            /// <summary>The Process parameters.</summary>
            public static partial class Process
            {
                  #region Properties

                  /// <summary>Example process parameter</summary>
                  public static string DispenseTimeBRexampleBR
                  {
                        get => ParametersDatabase.ParametersDatabase.GetParameter<string>("Dispense Time BRexampleBR", "Process");
                        set => ParametersDatabase.ParametersDatabase.SetParameter("Dispense Time BRexampleBR", "Process", value);
                  }

                  /// <summary>Example process parameter</summary>
                  public static string LoadingPositionBRexampleBR
                  {
                        get => ParametersDatabase.ParametersDatabase.GetParameter<string>("Loading Position BRexampleBR", "Process");
                        set => ParametersDatabase.ParametersDatabase.SetParameter("Loading Position BRexampleBR", "Process", value);
                  }

                  #endregion
            }

            /// <summary>The System parameters.</summary>
            public static partial class System
            {
                  #region Properties

                  /// <summary>Example system parameter</summary>
                  public static string GlobalTargetWeightBRexampleBR
                  {
                        get => ParametersDatabase.ParametersDatabase.GetParameter<string>("Global Target Weight BRexampleBR", "System");
                        set => ParametersDatabase.ParametersDatabase.SetParameter("Global Target Weight BRexampleBR", "System", value);
                  }

                  #endregion
            }

            #endregion
      }
}
