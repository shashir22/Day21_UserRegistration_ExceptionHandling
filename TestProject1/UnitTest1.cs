using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Patterns patternsMatch = new Patterns();

        [TestMethod]
        public void GivenFirstName_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateFirstName(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);

            }
        }
        [TestMethod]
        public void GivenLastName_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateLastName(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid LastName", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmailId_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateEmailId(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Email ID", e.Message);
            }
        }
        [TestMethod]
        public void GivenMobileNumber_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateMobileNumber(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Mobile Number", e.Message);
            }
        }
        [TestMethod]
        public void GivenPassword_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidatePassword(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }

    }
}