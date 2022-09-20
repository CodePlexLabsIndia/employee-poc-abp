using System;
using System.Collections.Generic;
using System.Text;
using Codeplex.EMS.Localization;
using Volo.Abp.Application.Services;

namespace Codeplex.EMS;

/* Inherit your application services from this class.
 */
public abstract class EMSAppService : ApplicationService
{
    protected EMSAppService()
    {
        LocalizationResource = typeof(EMSResource);
    }
}
