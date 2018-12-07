using Flunt.Validations;
using MediatR;

namespace MediatrExample.Domain.Models
{
    public class Product : EntityBase, IRequest<Response>, INotification, IValidatable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;

            AddNotifications(new Contract()
                   .IsNotNullOrEmpty(name, "Name", "Nome não pode ficar em branco")
                   .IsGreaterOrEqualsThan(price, 0, "Price", "Valor deve ser maior que zero.")
               );
        }

        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
