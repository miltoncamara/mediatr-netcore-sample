using MediatR;
using MediatrExample.Domain.Models;

namespace MediatrExample.Domain.Handlers
{
    public class ProductHandler : IRequestHandler<Product, string>
    {
        private readonly IMediator _mediatr;

        public ProductHandler(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public string Handle(Product message)
        {
            //Faço as validações dos campos da mensagem que no caso é o Produto
            if (string.IsNullOrEmpty(message.Name) && message.Price == 0)
                return "Preencher todos os campos.";

            //Depois de feito as validações do Produto, agora podemos salva-lo em nosso repositório.
            //productRepository.Save(message);

            //Enviar notificação de produto inserido
            _mediatr.Publish(message);

            return "Produto inserido com sucesso.";
        }
    }
}
