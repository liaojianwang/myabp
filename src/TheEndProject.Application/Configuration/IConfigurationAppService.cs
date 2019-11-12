using System.Threading.Tasks;
using TheEndProject.Configuration.Dto;

namespace TheEndProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
