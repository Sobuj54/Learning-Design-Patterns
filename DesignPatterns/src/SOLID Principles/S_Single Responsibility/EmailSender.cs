using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.SOLID_Principles.S_Single_Responsibility
{
    public class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"{email} : {message}");
        }
    }
}
