using Framework.TokenAuth.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Framework.TokenAuth
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
     
        }

        public DbSet<Framework.TokenAuth.Entities.Client> Clients { get; set; }
        public DbSet<Framework.TokenAuth.Entities.RefreshToken> RefreshTokens { get; set; }
    }

}

