using System;
using System.Runtime.Serialization;

namespace TestProject1
{
    [Serializable]
    internal class UserRegistrationCustomException : Exception
    {
        public UserRegistrationCustomException()
        {
        }

        public UserRegistrationCustomException(string? message) : base(message)
        {
        }

        public UserRegistrationCustomException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserRegistrationCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}