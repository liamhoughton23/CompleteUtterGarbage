namespace CompleteUtterGarbage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedendvacation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "VacationStartDate", c => c.String());
            AddColumn("dbo.Customers", "VacationEndDate", c => c.String());
            DropColumn("dbo.Customers", "VacationDates");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "VacationDates", c => c.String());
            DropColumn("dbo.Customers", "VacationEndDate");
            DropColumn("dbo.Customers", "VacationStartDate");
        }
    }
}
