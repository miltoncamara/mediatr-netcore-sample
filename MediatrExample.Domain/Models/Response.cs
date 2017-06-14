namespace MediatrExample.Domain.Models
{
    public class Response
    {
        public Response(object data, bool hasError = false)
        {
            this.Data = data;
            this.HasError = hasError;
        }

        public bool HasError { get; set; }
        public object Data { get; set; }
    }
}
