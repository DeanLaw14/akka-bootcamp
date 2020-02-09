using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace WinTail
{
    public class Messages
    {
        #region Neutral/system messages
        /// <summary>
        /// Marker class to continue processing
        /// </summary>
        public class ContinueProcessing
        {

        }
        #endregion

        #region Success messages
        /// <summary>
        /// Base class for signalling that a user input was valid
        /// </summary>
        public class InputSuccess
        {
            public InputSuccess(string reason)
            {
                Reason = reason;
            }

            public string Reason { get; private set; }

        }
        #endregion

        #region Error messages
        /// <summary>
        /// Base class for signalling that a user input was invalid
        /// </summary>
        public class InputError
        {
            public InputError(string reason)
            {
                Reason = reason;
            }
            public string Reason { get; private set; }

        }
        #endregion
    }
}
