using Mvp.Feature.Forms.Shared.Models;
using Mvp.Feature.Navigation.Services;
using System.Web.Mvc;

namespace Mvp.Feature.Navigation.Controllers
{
    public class NavigationController: Controller
    {
		SitemapBuilder _service;

		public NavigationController()
		{
			_service = new SitemapBuilder();
		}

		[HttpGet]
		public JsonResult GetSitemapData()
		{
			var sitemapModel = new SitemapData
			{
				Sitemap = _service.GetSitemapData()
			};

			return Json(sitemapModel, JsonRequestBehavior.AllowGet);
		}
	}
}
