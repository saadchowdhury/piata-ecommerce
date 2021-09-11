using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace work_01.Data
{
    public class MyUserClaimsPrincipalFactory:UserClaimsPrincipalFactory<ApplicationUser>
    {
        public MyUserClaimsPrincipalFactory(UserManager<ApplicationUser>
            userManager,IOptions<IdentityOptions> optionAccessor) : base(userManager, optionAccessor)
        {

            
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var Identity = await base.GenerateClaimsAsync(user);

            Identity.AddClaim(new Claim("FirstName",user.FirstName??"[Click to edit profile]"));
            Identity.AddClaim(new Claim("LastName", user.LastName ?? "[Click to edit profile]"));
            Identity.AddClaim(new Claim("Contact", user.Contact ?? "[Click to edit profile]"));
            Identity.AddClaim(new Claim("Country", user.Country ?? "[Click to edit profile]"));

            return Identity;
        }

    }
}
