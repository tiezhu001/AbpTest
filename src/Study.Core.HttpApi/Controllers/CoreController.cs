using Study.Core.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Study.Core.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CoreController : AbpControllerBase
{
    protected CoreController()
    {
        LocalizationResource = typeof(CoreResource);
    }
}
