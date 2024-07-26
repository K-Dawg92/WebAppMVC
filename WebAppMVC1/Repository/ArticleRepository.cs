using WebAppMVC1.Models;

namespace WebAppMVC1.Repository
{
    public class ArticleRepository
    {
        public static List<Article> _articles = new List<Article>()
        {
            new Article()
            {
                Id = 1,
                NameOfProduct = "Laptop",
                ColorOfProduct = "Red",
                PriceOfProduct = 300.00
            },
            new Article()
            {
                Id= 2,
                NameOfProduct = "Football",
                ColorOfProduct = "White",
                PriceOfProduct = 18.99
            },
            new Article()
            {
                Id = 3,
                NameOfProduct = "Car",
                ColorOfProduct = "Burgundy",
                PriceOfProduct = 17000.00
            }

        };

        private static int GetUniqueId() => _articles.Count > 0 ? _articles.Max(x => x.Id) + 1 : 1;

        // READ ALL DATA = Read from the CRUD Method
        public static List<Article>GetArticles() => _articles;

        // CREATE in the CRUD Method
        public static void AddArticles(int id, string nameOfProduct,  string colorOfProduct, double priceOfProduct) 
        {
            var idNewArticle = _articles.Find(x => x.Id == id);
            var newArticle = new Article()
            {
                Id = new Article().Id + 1,
                NameOfProduct = nameOfProduct,
                ColorOfProduct = colorOfProduct,
                PriceOfProduct = priceOfProduct
            };
            // save the new object in the list
            _articles.Add(newArticle);
        }
        public static Article? GetArticleById(int idArticle) => _articles.Find(x => x.Id == idArticle);

        // UPDATE = EDIT in the CRUD method
        public static void UpdateArticle(Article articleToUpdate)
        {
            var article = _articles.Find(x => x.Id == articleToUpdate.Id);
            if (article is null) return;
            article.NameOfProduct = articleToUpdate.NameOfProduct;
            article.ColorOfProduct = articleToUpdate.ColorOfProduct;
            article.PriceOfProduct = articleToUpdate.PriceOfProduct;
        }
        public static bool DeleteArticle(int articleId) //DELETE from the CRUD Method
        {
            var article = _articles.Find(x =>x.Id == articleId);
            if (article is null) return false;
            _articles.Remove(article);
            return true;
        }
    }
}
