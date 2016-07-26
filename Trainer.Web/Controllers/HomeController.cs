using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Trainer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TrainerControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}