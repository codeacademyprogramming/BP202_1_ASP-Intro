using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers
{
    public class HomeController:Controller
    {
        //public ContentResult Index()
        //{
        //    var content =  Content("Salam");
        //    return content;
        //}

        public ViewResult Index()
        {
            //var view = new ViewResult();
            //view.ViewName = "Index";
            //return view;

            return View();
        }

        public ViewResult About()
        {
            var view = new ViewResult();
            view.ViewName = "About";
            return view;
        }
    }
}
