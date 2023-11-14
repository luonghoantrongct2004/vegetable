using Microsoft.AspNetCore.Mvc;

namespace Selling_Vegetable_26102023.Areas.Admin.Controllers
{
	public class HomeController : Controller
	{
		[Area("Admin")]

		public IActionResult Index()
		{
			return View();
		}
	}
}
