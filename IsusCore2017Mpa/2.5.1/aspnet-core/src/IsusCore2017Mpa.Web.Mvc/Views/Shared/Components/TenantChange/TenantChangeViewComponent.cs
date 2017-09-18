using System.Threading.Tasks;
using Abp.AutoMapper;
using IsusCore2017Mpa.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace IsusCore2017Mpa.Web.Views.Shared.Components.TenantChange
{
    public class TenantChangeViewComponent : IsusCore2017MpaViewComponent
    {
        private readonly ISessionAppService _sessionAppService;

        public TenantChangeViewComponent(ISessionAppService sessionAppService)
        {
            _sessionAppService = sessionAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionAppService.GetCurrentLoginInformations();
            var model = loginInfo.MapTo<TenantChangeViewModel>();
            return View(model);
        }
    }
}
