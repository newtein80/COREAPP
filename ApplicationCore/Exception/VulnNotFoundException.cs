using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Exception
{
    public class VulnNotFoundException : System.Exception
    {
        public VulnNotFoundException(int basketId) : base($"No Vuln found with id {basketId}")
        {
        }

        protected VulnNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public VulnNotFoundException(string message) : base(message)
        {
        }

        public VulnNotFoundException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
