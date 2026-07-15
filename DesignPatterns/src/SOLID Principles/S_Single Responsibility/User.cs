using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.SOLID_Principles.S_Single_Responsibility
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public void Register()
        {
            // Registration Logic

            var emailSender = new EmailSender();
            emailSender.SendEmail(Email, "Registration Successfull.");
        }
    }
}
