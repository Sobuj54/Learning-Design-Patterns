using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.OOP.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email notification: {message}");
        }
    }
}
