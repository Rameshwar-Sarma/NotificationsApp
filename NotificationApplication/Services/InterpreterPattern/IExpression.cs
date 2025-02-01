using NotificationsApp.Models;

namespace NotificationsApp.Services.InterpreterPattern
{
    public interface IExpression
    {
        string Interpret(Notification notification);
    }
}
