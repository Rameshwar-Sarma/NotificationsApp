using NotificationsApp.Models;

namespace NotificationsApp.Services.InterpreterPattern
{
    public class SimpleExpression : IExpression
    {
        public string Interpret(Notification notification)
        {
            return $"Message to {notification.Recipient}: {notification.Message}";
        }
    }
}
