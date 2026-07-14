using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.OOP.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"sms notification: {message}");
        }
    }
}
