using Volo.Abp.Modularity;

namespace Codeplex.EMS;

[DependsOn(
    typeof(EMSApplicationModule),
    typeof(EMSDomainTestModule)
    )]
public class EMSApplicationTestModule : AbpModule
{

}
