using Abp.Application.Services;
using Crud.MultiTenancy.Dto;

namespace Crud.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

