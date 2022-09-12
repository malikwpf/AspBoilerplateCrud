using System.Threading.Tasks;
using Abp.Application.Services;
using Crud.Sessions.Dto;

namespace Crud.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
