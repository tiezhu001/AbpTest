using Study.Core.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Study.Core.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CorePageModel : AbpPageModel
{
    protected CorePageModel()
    {
        LocalizationResourceType = typeof(CoreResource);
    }
}
