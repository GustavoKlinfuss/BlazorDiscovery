namespace BlazorDiscovery.Shared
{
    public class BaseApiResponse<T>
    {
        public bool Sucesso { get; set; }
        public IEnumerable<Error>? Erros { get; set; }
        public T? Dados { get; set; }
    }
    
    public class Error
    {
        public Error(string codigo, string mensagem)
        {
            Codigo = codigo;
            Mensagem = mensagem;
        }

        public string Codigo { get; set; }
        public string Mensagem { get; set; }
    }
}
