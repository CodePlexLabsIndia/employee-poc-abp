﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Codeplex.EMS.Web;

[Dependency(ReplaceServices = true)]
public class EMSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EMS";
}
