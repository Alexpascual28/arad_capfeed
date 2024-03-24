using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Labman.Hardware
{
      /// <summary>
      /// Exception thrown when entrance marshalling gate is not closing
      /// </summary>
      [Serializable]
      internal class EntranceGateNotClosingException : Exception
      {
            /// <summary>
            /// Constructor
            /// </summary>
            public EntranceGateNotClosingException()
            {
            }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="message"> Exception message </param>
            public EntranceGateNotClosingException(string message) : base(message)
            {
            }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="message"> Exception message </param>
            /// <param name="innerException"> Additional exceptions </param>
            public EntranceGateNotClosingException(string message, Exception innerException) : base(message, innerException)
            {
            }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="info"> Exception information </param>
            /// <param name="context"> Streaming Context </param>
            public EntranceGateNotClosingException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
      }
}
