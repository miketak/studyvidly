namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) VALUES (1,0,0,0)"); //PayAsYouGo
            Sql("INSERT INTO MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) VALUES (2,30,1,10)"); //Monthly
            Sql("INSERT INTO MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) VALUES (3,90,3,15)"); //Quarterly
            Sql("INSERT INTO MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) VALUES (4,300,12,15)"); //Anual
        }
        
        public override void Down()
        {
        }
    }
}
