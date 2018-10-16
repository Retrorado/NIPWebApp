namespace NIPWebAppBase.Migrations
{
    using NIPWebAppBase.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NIPWebAppBase.Data.NIPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(NIPWebAppBase.Data.NIPContext context)
        {
            context.Companies.AddOrUpdate(g => g.Name, DummyData.GetCompanies().ToArray());
            context.SaveChanges();
        }
    }
}
