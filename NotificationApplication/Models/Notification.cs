﻿namespace NotificationsApp.Models
{
    public class Notification
    {
        public string Message { get; set; }
        public string Recipient { get; set; }
        public string Type { get; set; } // Email, SMS, etc.
    }
}
