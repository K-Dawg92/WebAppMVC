namespace WebAppMVC1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string NameOfProduct { get; set; } = string.Empty;
        public string ColorOfProduct { get; set; } = string.Empty;
        public double PriceOfProduct { get; set; }
    }
}
