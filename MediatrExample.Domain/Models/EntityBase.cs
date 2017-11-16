using Flunt.Notifications;
using System;

namespace MediatrExample.Domain.Models
{
    public class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
