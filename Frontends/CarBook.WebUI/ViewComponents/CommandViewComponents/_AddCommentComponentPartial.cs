using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CommandViewComponents
{
    public class _AddCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
