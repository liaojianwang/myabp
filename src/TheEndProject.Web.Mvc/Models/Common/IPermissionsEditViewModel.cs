using System.Collections.Generic;
using TheEndProject.Roles.Dto;

namespace TheEndProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}