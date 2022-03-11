﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationException
{
    public class Patterns
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2,}";
        public bool ValidateFirstName(string firstName)
        {
            if (firstName == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid FirstName");
            }
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
    }
}