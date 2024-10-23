using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CommandViewComponents
{
    public class _CommentListByBlogComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
