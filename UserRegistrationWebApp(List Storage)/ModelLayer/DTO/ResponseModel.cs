namespace ModelLayer.DTO
{
    public class ResponseModel<T>
    {
        public string success { get; set; } = "true";
        public string message { get; set; } = "";
        public T? data { get; set; }
    }
}
