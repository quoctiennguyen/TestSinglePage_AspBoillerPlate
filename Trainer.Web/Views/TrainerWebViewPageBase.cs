using Abp.Web.Mvc.Views;

namespace Trainer.Web.Views
{
    public abstract class TrainerWebViewPageBase : TrainerWebViewPageBase<dynamic>
    {

    }

    public abstract class TrainerWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TrainerWebViewPageBase()
        {
            LocalizationSourceName = TrainerConsts.LocalizationSourceName;
        }
    }
}