namespace IR_BackOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eds_sheds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "eds_sheds.OfferItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Image = c.Binary(),
                        DateAdded = c.DateTime(nullable: false),
                        IsLive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("eds_sheds.OfferItem");
        }
    }
}
