using MediatR;
using MediatrExample.Domain.Models;
using System.Diagnostics;

namespace MediatrExample.Domain.Notifications
{
    public class ProductRegisteredNotification : INotificationHandler<Product>
    {
        public void Handle(Product notification)
        {
            //SEND EMAIL NOTIFY PRODUCT REGISTERED
            Debug.WriteLine(notification.Name);
        }
    }
}
