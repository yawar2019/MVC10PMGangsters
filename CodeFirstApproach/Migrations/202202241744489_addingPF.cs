namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingPF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.employeeDetails", "PF", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.employeeDetails", "PF");
        }
    }
}
