using Codeplex.EMS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Codeplex.EMS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EMSController : AbpControllerBase
{
    protected EMSController()
    {
        LocalizationResource = typeof(EMSResource);
    }
}
