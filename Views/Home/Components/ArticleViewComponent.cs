using Microsoft.AspNetCore.Mvc;
namespace DevCard.Views.Home.Components
{
    public class ArticleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Models.Article>
            {
                new Models.Article(1,"آموزش برنامه نویسی انگولار","بهترین و کاملترین دوره برنامه نویسی فریمورک انگولار","blog-post-thumb-card-1.jpg"),
                new Models.Article(2,"آموزش سی شارپ","بهترین و کاملترین دوره برنامه نویسی سی شارپ","blog-post-thumb-card-2.jpg"),
                new Models.Article(3,"آموزش دات نت","بهترین و کاملترین دوره برنامه نویسی فریمورک دات نت","blog-post-thumb-card-3.jpg"),
                new Models.Article(4,"آموزش الگوریتم و مبانی برنامه نویسی","بهترین و کاملترین دوره مبانی برنامه نویسی  ","blog-post-thumb-card-4.jpg")
            };
            return View("_Article", articles);
        }
    }
}
