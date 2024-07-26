using Microsoft.AspNetCore.Mvc;
using WebAppMVC1.Models;
using WebAppMVC1.Repository;

namespace WebAppMVC1.Controllers
{
    public class ArticleController : Controller
    {
        //HTTPGET
        public IActionResult List()
        {
            var _article = ArticleRepository.GetArticles();
            return View(_article);
        }
        public IActionResult Add(Article article)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Action = nameof(Add);
                return View(article);
            }
            ArticleRepository.AddArticles(article.Id, article.NameOfProduct, article.ColorOfProduct, article.PriceOfProduct);
            return RedirectToAction(actionName: "List", controllerName: "Article");
        }
    }
    public IActionResult Edit(int id, Article article)
    {
        var _article = ArticleRepository.GetArticleById(id);
        if (id == _article.Id) ArticleRepository.UpdateArticle(_article);
        {
            _article.Id = id;
            _article.NameOfProduct = _article.NameOfProduct;
            _article.PriceOfProduct = _article.PriceOfProduct;
            _article.ColorOfProduct = _article.ColorOfProduct;
        }
        return RedirectToActi)
    }
}
