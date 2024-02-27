namespace Artikli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artikli",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false),
                        Kategorija = c.String(nullable: false),
                        Cijena = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Artikli");
        }
    }
}
