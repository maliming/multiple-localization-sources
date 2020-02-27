using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QA.Configuration.Dto;

namespace QA.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QAAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
