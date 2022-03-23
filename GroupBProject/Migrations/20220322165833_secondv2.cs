using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupBProject.Migrations
{
    public partial class secondv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp2 = @"CREATE PROCEDURE  sp_GetAllbyAge 
                    AS
                    Begin
                    SELECT Age FROM Employees
                    End ";
            migrationBuilder.Sql(sp2);

          

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
