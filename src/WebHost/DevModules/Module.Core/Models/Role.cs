using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Infrastructure.Models;

namespace Module.Core.Models
{
    public class Role : IdentityRole<long, UserRole, IdentityRoleClaim<long>>, IEntityWithTypedId<long>
    {
    }
}
