using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Crud.Configuration.Dto;

namespace Crud.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CrudAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
