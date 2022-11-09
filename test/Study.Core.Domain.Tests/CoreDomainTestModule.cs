using Study.Core.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Study.Core;

[DependsOn(
    typeof(CoreEntityFrameworkCoreTestModule)
    )]
public class CoreDomainTestModule : AbpModule
{

}
