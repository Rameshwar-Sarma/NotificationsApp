using NotificationsApp.Models;

namespace NotificationsApp.Services.FactoryPattern
{
    public interface INotificationService
    {
        void Send(Notification notification);
    }
}
