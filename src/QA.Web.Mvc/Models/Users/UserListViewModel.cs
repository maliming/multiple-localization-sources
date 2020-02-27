using System.Collections.Generic;
using QA.Roles.Dto;

namespace QA.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
