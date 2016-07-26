using System.Linq;
using Trainer.EntityFramework;
using Trainer.MultiTenancy;

namespace Trainer.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TrainerDbContext _context;

        public DefaultTenantCreator(TrainerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
