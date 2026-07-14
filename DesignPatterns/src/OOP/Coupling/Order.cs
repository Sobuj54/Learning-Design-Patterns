using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.OOP.Coupling
{
    public class Order
    {
        private readonly INotificationService _notification;
        public Order(INotificationService notification)
        {
            _notification = notification;
        }

        public void OrderSuccessNotification(string message)
        {
            _notification.SendNotification(message);
        }
    }
}
