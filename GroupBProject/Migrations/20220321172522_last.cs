using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupBProject.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           var sp = @"CREATE PROCEDURE  sp_GetAllDob 
                AS
                Begin
                SELECT* FROM Employees
                End ";

          
            migrationBuilder.Sql(sp);
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
