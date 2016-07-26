using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Trainer
{
    [DependsOn(typeof(TrainerCoreModule), typeof(AbpAutoMapperModule))]
    public class TrainerApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
