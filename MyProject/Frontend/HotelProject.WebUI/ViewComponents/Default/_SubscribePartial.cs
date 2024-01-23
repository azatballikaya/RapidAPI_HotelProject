using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _SubscribePartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
             return View();
        }
    }
}
