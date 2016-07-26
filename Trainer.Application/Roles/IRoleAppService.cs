using System.Threading.Tasks;
using Abp.Application.Services;
using Trainer.Roles.Dto;

namespace Trainer.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
