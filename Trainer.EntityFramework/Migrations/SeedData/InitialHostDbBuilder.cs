using Trainer.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Trainer.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TrainerDbContext _context;

        public InitialHostDbBuilder(TrainerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
