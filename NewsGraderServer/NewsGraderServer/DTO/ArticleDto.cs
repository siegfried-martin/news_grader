namespace NewsGraderServer.DTO
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string? DataSource { get; set; }
        public Uri? ArticleSource { get; set; }
        public string? Contents { get; set; }
    }
}
