using System;

namespace Labman.Actions
{
      /// <summary> 
      /// Test cycles class allows process movements and actions to be tested from engineering
      /// </summary>
      public static class TestCycles
      {
            #region Pick and Place Methods

            /// <summary>
            /// Pick vials from rack
            /// </summary>
            /// <remarks>
            /// Example engineering method with no attributes
            /// </remarks>            
            [EngineeringMethodAttribute("Picks a vial from input rack position 1 and moves the same vial through all input rack positions. Load ONLY the first vial in the rack.")]
            public static void InputVialShuffleVial()
            {
                  try
                  {
                        // TODO
                        throw new NotImplementedException();
                  }
                  catch (Exception ex)
                  {
                        System.Windows.MessageBox.Show(ex.Message);
                  }
            }

            #endregion

            #region Test Methods

            /// <summary>
            /// Dispenses the liquid.
            /// </summary>
            /// <param name="target">The target weight.</param>
            /// <param name="repeats">The number of repeats.</param>
            /// <remarks>
            /// Example engineering method with input parameter attributes
            /// </remarks>         
            [EngineeringMethodAttribute("Tests setting the adam module voltage")]
            [EngineeringParameter(Name = "target", 
                                  Description = "Target weight in mg",
                                  MinValue = 1.0,
                                  MaxValue = 100.0,
                                  DefaultValue = 10.0)]
            [EngineeringParameter(Name = "repeats", 
                                  Description = "Number of repeats",
                                  MinValue = 1,
                                  MaxValue = 10,
                                  DefaultValue = 3)]
            public static void DispenseLiquid(double target, int repeats)
            {
                  try
                  {
                        // TODO
                        throw new NotImplementedException();
                  }
                  catch (Exception ex)
                  {
                        System.Windows.MessageBox.Show(ex.Message);
                  }
            }
            
            #endregion
      }
}
