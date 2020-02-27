using System.Threading.Tasks;
using Abp.Application.Services;
using QA.Authorization.Accounts.Dto;

namespace QA.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
