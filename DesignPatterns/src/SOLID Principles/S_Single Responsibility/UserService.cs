using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.SOLID_Principles.S_Single_Responsibility
{
    public class UserService
    {
        public void Register(User user)
        {
            // Registration Logic

            // Send email
            var emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Registration Successfull.");
        }
    }
}
