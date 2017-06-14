using MediatrExample.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MediatrExample.Domain.Models;

namespace MediatrExample.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetByName(string name)
        {
            if (name != "mouse")
                return null;

            return new Product("Teclado sem fio",50);
        }

        public Product Save(Product model)
        {
            return new Product(model.Name, model.Price);
        }
    }
}
