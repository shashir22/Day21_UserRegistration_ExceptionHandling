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
        public static string REGEX_LASTNAME = "[A-Z]{1}[a-z]{2,}";
        public static string REGEX_EMAILID = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public bool ValidateFirstName(string firstName)
        {
            if (firstName == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid FirstName");
            }
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string lastName)
        {
            if (lastName == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid LastName");
            }
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }
        public bool ValidateEmailId(string emailId)
        {
            if (emailId == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid Email ID");
            }
            return Regex.IsMatch(emailId, REGEX_EMAILID);
        }

    }
}