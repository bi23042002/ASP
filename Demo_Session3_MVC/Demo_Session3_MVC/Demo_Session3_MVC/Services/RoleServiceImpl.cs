using Demo_Session3_MVC.Models;

namespace Demo_Session3_MVC.Services
{
    public class RoleServiceImpl : RoleService
    {
        private List<Role> roles;

        public RoleServiceImpl()
        {
            roles = new List<Role>
            {
                new Role{ Id = "r1", Name = "Role 1" },
                new Role{ Id = "r2", Name = "Role 2" },
                new Role{ Id = "r3", Name = "Role 3" },
                new Role{ Id = "r4", Name = "Role 4" },
                new Role{ Id = "r5", Name = "Role 5" }
            };
        }

        public List<Role> findAll()
        {
            return roles;
        }
    }
}
