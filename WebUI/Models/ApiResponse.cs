namespace WebUI.Models
{
    public class ApiResponse<T>
    {
        public ApiStatusCode StatusCode { get; set; }
        public T Data { get; set; }
        public ApiResponse(ApiStatusCode statusCode, T data)
        {
            this.StatusCode = statusCode;
            this.Data = data;
        }
    }
}