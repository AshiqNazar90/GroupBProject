using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupBProject.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp3 = @"CREATE PROCEDURE  sp_GetAllbyID 
                    AS
                    Begin
                    SELECT ID FROM Employees
                    End ";
            migrationBuilder.Sql(sp3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
