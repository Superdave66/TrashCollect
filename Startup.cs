﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashCollector.Models;

[assembly: OwinStartupAttribute(typeof(TrashCollector.Startup))]
namespace TrashCollector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }
        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();   
   
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));   
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));   
   
   
            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Admin"))   
            {   
   
                // first we create Admin rool   
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();   
                role.Name = "Admin";   
                roleManager.Create(role);   
   
                //Here we create a Admin super user who will maintain the website                  
   
                var user = new ApplicationUser();   
                user.UserName = "Dave";   
                user.Email = "illwill1592@yahoo.com";   
   
                string userPWD = "!3584Dwilliams";   
   
                var chkUser = UserManager.Create(user, userPWD);   
   
                //Add default User to Role Admin   
                if (chkUser.Succeeded)   
                {   
                    var result1 = UserManager.AddToRole(user.Id, "Admin");   
   
                }   
            }   
   
            // creating Creating Employee role    
            if (!roleManager.RoleExists("Employee"))   
            {   
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();   
                role.Name = "Employee";   
                roleManager.Create(role);   
   
            }

            // creating Creating Customer role    
            if (!roleManager.RoleExists("Customer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }
        }
    }
}
