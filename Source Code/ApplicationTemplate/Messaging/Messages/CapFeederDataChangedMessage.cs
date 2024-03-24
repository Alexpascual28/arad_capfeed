using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labman.Messaging.Messages
{
      /// <summary>
      /// Class SampleUnloadedMessage.
      /// </summary>
      public class CapFeederDataChangedMessage
      {
            /// <summary>
            /// Gets or sets the TotalCapsProcessed data
            /// </summary>
            /// <value>The TotalCapsProcessed data.</value>
            public int TotalCapsProcessed { get; set; }

            /// <summary>
            /// Gets or sets the TotalCapsRejected data
            /// </summary>
            /// <value>The TotalCapsRejected data.</value>
            public int TotalCapsRejected { get; set; }

            /// <summary>
            /// Gets or sets the IntervalFromLastCap data
            /// </summary>
            /// <value>The IntervalFromLastCap data.</value>
            public TimeSpan IntervalFromLastCap { get; set; }

            /// <summary>
            /// Gets or sets the Throughput data
            /// </summary>
            /// <value>The Throughput data.</value>
            public double Throughput { get; set; }

            /// <summary>
            /// Initializes a new instance of the <see cref="CapFeederDataChangedMessage"/> class.
            /// </summary>
            /// <param name="totalCaps">The total caps.</param>
            /// /// <param name="rejectedCaps">The rejected caps.</param>
            /// /// <param name="capInterval">The interval from last cap.</param>
            /// /// <param name="throughput">The throughput.</param>
            public CapFeederDataChangedMessage(int totalCaps, int rejectedCaps, TimeSpan capInterval, double throughput)
            {
                  this.TotalCapsProcessed = totalCaps;
                  this.TotalCapsRejected = rejectedCaps;
                  this.IntervalFromLastCap = capInterval;
                  this.Throughput = throughput;
            }
      }
}