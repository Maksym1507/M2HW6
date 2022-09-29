using M2HW6.Interfaces;

namespace M2HW6.Services
{
    public class NotificationService : INotificationService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
