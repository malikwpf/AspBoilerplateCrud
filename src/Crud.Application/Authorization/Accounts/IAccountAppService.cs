using System.Threading.Tasks;
using Abp.Application.Services;
using Crud.Authorization.Accounts.Dto;

namespace Crud.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
