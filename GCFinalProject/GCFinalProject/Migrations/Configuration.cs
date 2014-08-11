namespace GCFinalProject.Migrations
{
    using GCFinalProject.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GCFinalProject.DAL.EventSiteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "GCFinalProject.DAL.EventSiteContext";
        }

        protected override void Seed(GCFinalProject.DAL.EventSiteContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var categorys = new List<Category>
            {
                new Category { CategoryID=1,CategoryName="Food and Drinks"},
                new Category { CategoryID=2,CategoryName="Music"},
                new Category { CategoryID=3,CategoryName="Art"},
                new Category { CategoryID=4,CategoryName="Sport"},
                new Category { CategoryID=5,CategoryName="Festival"},
                new Category { CategoryID=6,CategoryName="Conference"},
                new Category { CategoryID=7,CategoryName="Convention"},
                new Category { CategoryID=8,CategoryName="Parade"}

            };
            categorys.ForEach(c => context.Categorys.AddOrUpdate(p => p.CategoryID, c));
            context.SaveChanges();
        }
        
    }
}
