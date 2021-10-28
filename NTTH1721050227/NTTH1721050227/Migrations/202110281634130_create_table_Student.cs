namespace NTTH1721050227.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        University = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.University);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
