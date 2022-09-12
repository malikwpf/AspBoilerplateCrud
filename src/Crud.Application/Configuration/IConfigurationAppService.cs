using System.Threading.Tasks;
using Crud.Configuration.Dto;

namespace Crud.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
