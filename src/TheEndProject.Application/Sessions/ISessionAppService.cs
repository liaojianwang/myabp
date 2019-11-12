using System.Threading.Tasks;
using Abp.Application.Services;
using TheEndProject.Sessions.Dto;

namespace TheEndProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
