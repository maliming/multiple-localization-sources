using System.Threading.Tasks;
using QA.Configuration.Dto;

namespace QA.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
