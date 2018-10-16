namespace NIPWebAppBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Street = c.String(),
                        BuildingNumber = c.String(),
                        PostalCode = c.String(),
                        City = c.String(nullable: false),
                        NIP = c.String(),
                        KRS = c.String(),
                        REGON = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SearchedData = c.String(nullable: false),
                        HttpHeaders = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Requests");
            DropTable("dbo.Companies");
        }
    }
}
