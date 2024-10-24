namespace BlazorDiscovery.Shared
{
    public class BaseApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T? Model { get; set; }
    }
}
