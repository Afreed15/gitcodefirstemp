namespace WebAppcodeFirstpra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpTabledb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emp",
                c => new
                    {
                        EmpID = c.Int(nullable: false, identity: true),
                        EName = c.String(),
                        ESalary = c.Double(nullable: false),
                        EDoj = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmpID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emp");
        }
    }
}
