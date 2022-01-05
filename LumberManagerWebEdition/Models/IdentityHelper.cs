using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Models
{
    public static class IdentityHelper
    {
        // Role names
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        public static void SetIdentityOptions(IdentityOptions options)
        {
            // Setting sign in options
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;

            // Set password strength
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;

            // Set lockout options
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
            options.Lockout.MaxFailedAccessAttempts = 3;
        }

        /// <summary>
        /// Creates admin and customer roles if they do not exist yet.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="roles">Admin and Customer.</param>
        public static async Task CreateRoles(IServiceProvider provider, params string[] roles)
        {
            RoleManager<IdentityRole> roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

            // Create role if it does not exist
            foreach (string role in roles)
            {
                bool doesRoleExist = await roleManager.RoleExistsAsync(role);
                if (!doesRoleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        /// <summary>
        /// Creates default admin role.
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static async Task CreateDefaultAdmin(IServiceProvider serviceProvider)
        {
            const string email = "admin@admin.com";
            const string username = "admin";
            const string password = "adminadmin";
            const string contactFirstName = "Bob";
            const string contactLastName = "Jones";
            const string address = "123 Any Street";
            const string city = "Tacoma";
            const string state = "WA";
            const int zip = 98444;
            const string business = "Lumber Everything";
            const string phoneNumber = "253-555-6556";

            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            // Check if any users are in database
            if (userManager.Users.Count() == 0)
            {
                User admin = new User()
                {
                    Email = email,
                    UserName = username,
                    ContactFirstName = contactFirstName,
                    ContactLastName = contactLastName,
                    Address = address,
                    City = city,
                    State = state,
                    ZipCode = zip,
                    Business = business,
                    PhoneNumber = phoneNumber
                };

                // Create admin
                await userManager.CreateAsync(admin, password);

                // Add to admin role
                await userManager.AddToRoleAsync(admin, Admin);
            }
        }
    }
}
