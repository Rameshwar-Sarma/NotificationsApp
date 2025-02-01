
using Microsoft.AspNetCore.Mvc;
using NotificationsApp.Models;
using NotificationsApp.Services;
using NotificationsApp.Services.FacadePattern;
using NotificationsApp.Services.InterpreterPattern;
using NotificationsApp.Services.Singleton;

namespace NotificationsApp.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly NotificationFacade _notificationFacade;
        private readonly IConfiguration _configuration;
        public NotificationsController(IConfiguration config)
        {
            _notificationFacade = new NotificationFacade();
            _configuration = config;
            //_keyVaultService = keyVaultService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendNotification(Notification notification)
        {
            
            //string SecretName = _configuration["SecretName"];
            // Log the notification send request using Singleton logger
           // string Secret = await _keyVaultService.GetSecret(SecretName);
            NotificationLogger.Instance.Log("Request to send notification ");

            // Send notification using Facade and Factory patterns
            _notificationFacade.SendNotification(notification);

            // Interpret message format based on type
            IExpression expression = notification.Type.ToLower() == "sms" ? new SimpleExpression() : new DetailedExpression();
            ViewBag.FormattedMessage = expression.Interpret(notification);
            ViewBag.Logger = NotificationLogger.Instance.LogInformation;

            return View("Index");
        }
    }

}
