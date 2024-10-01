namespace CoreApi.Platform.Domain.Models
{
    public abstract class Response
    {
        public DateTime ResponseTime { get; set; }

        public Guid RequestId { get; set; }
    }
}
