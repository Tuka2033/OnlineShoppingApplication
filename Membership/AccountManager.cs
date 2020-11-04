
using CRM;
using System;

namespace Membership
{
    public static class AccountManager
    {

        public static bool Login(string userName, string password)
        {
            bool status = false;
            if(userName=="ravi" && password == "seed")
            {
                status = true;
            }
            return status;
        }


        public static bool Register(string loginId, string password,string name,string email, 
                                     string contactnumber,string location)
        {
            bool status = false;

            Customer theCustomer = new Customer();

            theCustomer.FullName = name;
            theCustomer.UserID = loginId;
            theCustomer.Password = password;
            theCustomer.Email = email;
            theCustomer.ContactNubmer = contactnumber;
            theCustomer.Location = location;

            //theCustomer = null;

            if (theCustomer != null)
                status = true;
            return status;
        }


        public static bool ChangePassword(string loginId, string existingPassword,string newPassword)
        {
            bool status = false;
            // set new password for userId
            // How do I Set
            // you need make changes into file, database....?
            return status;
        }


        public static bool ForgotPassword(string loginId)
        {
            bool status = false;
            //
            return status;
        }
    }
}
