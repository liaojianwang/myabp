using System.Threading.Tasks;
using Abp.Application.Services;
using TheEndProject.Authorization.Accounts.Dto;

namespace TheEndProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
