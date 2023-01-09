using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.ViewComponents
{
	public class _NewPartial : ViewComponent
	{
		private readonly INewsService _newsService;

		public _NewPartial(INewsService newsService)
		{
			_newsService = newsService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_newsService.GetListAll();
			return View(values);
		}
	}
}
