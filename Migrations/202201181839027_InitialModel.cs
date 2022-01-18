namespace PhoneBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        NumberPhone = c.Int(nullable: false, identity: true),
                        adress = c.String(),
                    })
                .PrimaryKey(t => t.NumberPhone);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        NumberPhone = c.Int(nullable: false, identity: true),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.NumberPhone);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        NumberPhone = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Adress = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.NumberPhone);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Emails");
            DropTable("dbo.Adresses");
        }
    }
}
