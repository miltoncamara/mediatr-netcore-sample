using MediatR;

namespace MediatrExample.Domain.Models
{
    public class Product : IRequest<string>, INotification
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
