namespace BillingsCoderDojo.Migrations
{
    using BillingsCoderDojo.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BillingsCoderDojo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BillingsCoderDojo.Models.ApplicationDbContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            roleManager.Create(new IdentityRole
            {
                Name = "Administrators"
            });

            roleManager.Create(new IdentityRole
            {
                Name = "Mentors"
            });

            roleManager.Create(new IdentityRole
            {
                Name = "Students"
            });

            //var mentorTaraUserId = context.Users.FirstOrDefault(userName => userName.UserName == "MentorTara").Id;
            //if(context.Roles.FirstOrDefault(role => role.Name == "Administrators").Users == null
            //  || context.Roles.FirstOrDefault(role => role.Name == "Administrators").Users.FirstOrDefault(user => user.UserId == mentorTaraUserId ) == null)
            //{
            //    var userStore = new UserStore<ApplicationUser>(context);
            //    var userManager = new UserManager<ApplicationUser>(userStore);

            //    userManager.AddToRole(mentorTaraUserId, "Administrators");
            //}
        }
    }
}
