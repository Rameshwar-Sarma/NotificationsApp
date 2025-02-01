using NotificationsApp.Models;

namespace NotificationsApp.Services.InterpreterPattern
{
    public class DetailedExpression : IExpression
    {
        public string Interpret(Notification notification)
        {
            return $"[{notification.Type.ToUpper()}] Message to {notification.Recipient}: {notification.Message}";
        }
    }
}
