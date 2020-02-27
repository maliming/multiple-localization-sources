using System.Collections.Generic;
using QA.Roles.Dto;

namespace QA.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}