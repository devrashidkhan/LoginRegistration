using Membership.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Seeds
{
    internal static class RoleSeed
    {
        internal static Role[] Roles
        {
            get
            {
                return new Role[]
                {
                    new Role{Id = Guid.NewGuid(), Name="Admin", NormalizedName="ADMIN", ConcurrencyStamp= DateTime.Now.Ticks.ToString() }
                };
            }
        }
    }
}
