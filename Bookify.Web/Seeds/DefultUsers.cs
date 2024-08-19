using Microsoft.AspNetCore.Identity;

namespace LibraryManagementSystem.Seeds
{
    public static class DefaultUsers
    {
        public static async Task SeedAdminUserAsync(UserManager<ApplicationUser> userManager)
        {
            ApplicationUser admin = new()
            {
                UserName = "admin",
                Email = "mmoo19701@gmail.com ",
                FullName = "Admin",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(admin.Email);

            if (user is null)
            {
                await userManager.CreateAsync(admin, "WWoo19701.");
                await userManager.AddToRoleAsync(admin, AppRoles.Admin);
            }
        }
    }
}
