using System.Threading.Tasks;
using Abp.Application.Services;
using QA.Sessions.Dto;

namespace QA.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
