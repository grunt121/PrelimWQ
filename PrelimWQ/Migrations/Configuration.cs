namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PrelimWQ.Models;
    using System.Collections.Generic;


    internal sealed class Configuration : DbMigrationsConfiguration<PrelimWQ.Models.ApplicationDbContext>
    {


        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PrelimWQ.Models.ApplicationDbContext context)
        {




            //const string AllowedChars = "0123456789";

            //Random rngUserName = new Random();

            //foreach (var randomsUserName in RandomStringsUsernames(AllowedChars, 8, 8, 10000, rngUserName))
            //{
            //    if (!(context.Users.Any(u => u.UserName == randomsUserName)))
            //    {
            //        Random rng = new Random();
            //        foreach (var randomString in RandomStrings(AllowedChars, 8, 8, 1, rng))
            //        {
            //            var userStore = new UserStore<ApplicationUser>(context);
            //            var userManager = new UserManager<ApplicationUser>(userStore);
            //            var userToInsert = new ApplicationUser { UserName = randomsUserName, Email = randomsUserName };

            //            userManager.Create(userToInsert, randomString);
            //            var password = randomString;
            //            context.Export.Add(new Export()
            //            {
            //                OnlineIdLogin = userToInsert.UserName,
            //                OnlineIdPassword = password,

            //            });
            //            context.SaveChanges();
            //        }
            //    }
            //}
        }

        private static IEnumerable<string> RandomStrings(string allowedChars, int minLength, int maxLength, int count, Random rng)
        {
            char[] chars = new char[maxLength];
            int setLength = allowedChars.Length;

            while (count-- > 0)
            {
                int length = rng.Next(minLength, maxLength + 1);

                for (int i = 0; i < length; ++i)
                {
                    chars[i] = allowedChars[rng.Next(setLength)];
                }

                yield return new string(chars, 0, length);
            }
        }

        private static IEnumerable<string> RandomStringsUsernames(string allowedChars, int minLength, int maxLength, int count, Random rngUsername)
        {
            char[] chars = new char[maxLength];
            int setLength = allowedChars.Length;

            while (count-- > 0)
            {
                int length = rngUsername.Next(minLength, maxLength + 1);

                for (int i = 0; i < length; ++i)
                {
                    chars[i] = allowedChars[rngUsername.Next(setLength)];
                }

                yield return new string(chars, 0, length);
            }
        }


    }




}

