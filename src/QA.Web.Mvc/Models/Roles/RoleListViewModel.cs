using System.Collections.Generic;
using QA.Roles.Dto;

namespace QA.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
