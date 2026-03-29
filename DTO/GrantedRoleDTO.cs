using System;

namespace QLBV.DTO
{
    public class GrantedRoleDTO
    {
        public string Grantee { get; set; }
        public string GrantedRole { get; set; }
        public string AdminOption { get; set; }
        public string DefaultRole { get; set; }
    }
}
