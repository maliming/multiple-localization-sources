using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using QA.Controllers;

namespace QA.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : QAControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
