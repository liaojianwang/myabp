using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TheEndProject.MultiTenancy.Dto;

namespace TheEndProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

