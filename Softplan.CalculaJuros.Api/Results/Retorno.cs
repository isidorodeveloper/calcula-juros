namespace Softplan.CalculaJuros.Api.Results
{
    public class Retorno
    {
        public Retorno() { }
        public Retorno(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
