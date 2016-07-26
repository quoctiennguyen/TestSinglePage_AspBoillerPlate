using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Trainer.EntityFramework;

namespace Trainer.Migrator
{
    [DependsOn(typeof(TrainerDataModule))]
    public class TrainerMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TrainerDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}