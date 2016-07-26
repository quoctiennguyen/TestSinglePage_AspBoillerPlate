using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Trainer.MultiTenancy.Dto;

namespace Trainer.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
