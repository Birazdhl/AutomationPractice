using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask
{
    class SendKeysValues
    {
        #region elements Value Declarations
        public static string EmailAddressToRegister { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Days { get; set; }
        public static string Months { get; set; }
        public static string Year { get; set; }
        public static string Address { get; set; }
        public static string City { get; set; }
        public static string PostalCode { get; set; }
        public static string MobilePhone { get; set; }
        public static string Alias { get; set; }
        public static string State { get; set; }
        public static string Password { get; set; }

        #endregion

        #region elemments Value Assignments
        public static void SetValuesForSendKeys()
        {

            //User Registration Email
            EmailAddressToRegister = "Newbiraz9@gmail.com";

            //Personal Information Field
            FirstName = "Biraz";
            LastName = "Dahal";
            Password = "futsal10Player";
            Days = "15";
            Months = "10";
            Year = "1997";
            Address = "Kanchanbari";
            City = "Biratnagar";
            State = "1";
            PostalCode = "12345";
            MobilePhone = "9823220017";
            Alias = "gmail@zlatan.com";
        }
        #endregion

    }
}
