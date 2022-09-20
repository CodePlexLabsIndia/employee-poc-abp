using Codeplex.EMS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Codeplex.EMS;

[DependsOn(
    typeof(EMSEntityFrameworkCoreTestModule)
    )]
public class EMSDomainTestModule : AbpModule
{

}
