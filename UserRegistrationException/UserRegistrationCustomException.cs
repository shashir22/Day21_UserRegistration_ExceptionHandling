using System.Runtime.Serialization;

namespace UserRegistrationException
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionsType
        {
            Invalid_MESSAGE,
        }
        public ExceptionsType type;
        public UserRegistrationCustomException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;

        }
    }
}