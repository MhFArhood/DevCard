using Microsoft.AspNetCore.Mvc;
namespace DevCard.Views.Home.Components
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Models.Project>
            {
                new Models.Project(1,"تاکسی اینترنتی","درخواست آنلاین تاکسی برای سفر های درون شهری","Farhood","project-1.jpg"),
                new Models.Project(2,"زود فود","درخواست انلاین غذا برای سراسر کشور","ZooodFood","project-2.jpg"),
                new Models.Project(3,"مدارس","سیستم مدیریت یکپارچه مدارس","SaMiM", "project-3.jpg"),
                new Models.Project(4,"اهل فنا","درخواست آنلاین تعمیر کار برای منازل ","Fania", "project-4.jpg")
            };

            return View("_ProjectViewComponent", projects);

        }
    }
}
