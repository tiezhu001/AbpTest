using System;
using System.Collections.Generic;
using System.Text;
using Study.Core.Localization;
using Volo.Abp.Application.Services;

namespace Study.Core;

/* Inherit your application services from this class.
 */
public abstract class CoreAppService : ApplicationService
{
    protected CoreAppService()
    {
        LocalizationResource = typeof(CoreResource);
    }
}
