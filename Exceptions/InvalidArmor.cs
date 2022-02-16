using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Exceptions
{
   public class InvalidArmor : Exception
    {
        public InvalidArmor()
        {
        }

        public InvalidArmor(string message) : base(message)
        {
        }

        public InvalidArmor(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidArmor(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
