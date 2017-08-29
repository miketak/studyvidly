namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomersWithBirthDateValue : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate='1980/1/1' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
