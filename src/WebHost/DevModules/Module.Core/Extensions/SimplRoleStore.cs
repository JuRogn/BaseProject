using System.Security.Claims;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Module.Core.Data;
using Module.Core.Models;

namespace Module.Core.Extensions
{
    public class SimplRoleStore: RoleStore<Role, SimplDbContext, long, UserRole, IdentityRoleClaim<long>>
    {
        public SimplRoleStore(SimplDbContext context) : base(context)
        {
        }

        protected override IdentityRoleClaim<long> CreateRoleClaim(Role role, Claim claim)
        {
            return new IdentityRoleClaim<long> { RoleId = role.Id, ClaimType = claim.Type, ClaimValue = claim.Value };
        }
    }
}
