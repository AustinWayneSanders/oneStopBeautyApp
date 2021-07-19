//Create by Austin Sanders-05/05/2021
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopBeauty
{
    public class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            await EnsureRolesAsync(roleManager);

            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            await EnsureTestAdminAsync(userManager);
        }

        public static async Task EnsureRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            var adminAlreadyExists = await roleManager.RoleExistsAsync(Constants.AdminRole);

            if (adminAlreadyExists) return;

            await roleManager.CreateAsync(new IdentityRole(Constants.AdminRole));

            var stdUserAlreadyExists = await roleManager.RoleExistsAsync(Constants.StandardUserRole);

            if (stdUserAlreadyExists) return;

            await roleManager.CreateAsync(new IdentityRole(Constants.StandardUserRole));
        }

        public static async Task EnsureTestAdminAsync(UserManager<IdentityUser> userManager)
        {
            var testAdmin = await userManager.Users.Where(x => x.UserName == "asanders@gmail.com").SingleOrDefaultAsync();

            if (testAdmin != null) return;

            testAdmin = new IdentityUser { UserName = "asanders@gmail.com", Email = "asanders@gmail.com" };

            await userManager.CreateAsync(testAdmin, "Password1!");

            await userManager.AddToRoleAsync(testAdmin, Constants.AdminRole);
        }
    }
}
