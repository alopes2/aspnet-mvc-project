namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (5, 'Horror')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (6, 'Suspense')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (7, 'Animation')");
        }
        
        public override void Down()
        {
        }
    }
}
