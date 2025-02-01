using NotificationsApp.Models;
using NotificationsApp.Services.FactoryPattern;

namespace NotificationsApp.Services.FacadePattern
{
    public class NotificationFacade
    {
        public void SendNotification(Notification notification)
        {
            var service = NotificationFactory.CreateNotificationService(notification.Type);
            service.Send(notification);
        }
    }
}
