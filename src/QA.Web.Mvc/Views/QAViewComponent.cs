using Abp.AspNetCore.Mvc.ViewComponents;

namespace QA.Web.Views
{
    public abstract class QAViewComponent : AbpViewComponent
    {
        protected QAViewComponent()
        {
            LocalizationSourceName = QAConsts.LocalizationSourceName;
        }
    }
}
