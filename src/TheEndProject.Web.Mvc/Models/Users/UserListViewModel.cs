using System.Collections.Generic;
using TheEndProject.Roles.Dto;
using TheEndProject.Users.Dto;

namespace TheEndProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
