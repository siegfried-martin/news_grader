namespace NewsGraderServer.Models
{
    public class ArticleEntity : IEntity
    {
        public Guid Id { get; set; }
        public string? DataSource { get; set; }
        public Uri? ArticleSource { get; set; }
        public string? Contents { get; set; }
    }
}
