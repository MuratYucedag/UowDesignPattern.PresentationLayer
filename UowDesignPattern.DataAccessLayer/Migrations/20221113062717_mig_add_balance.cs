using Microsoft.EntityFrameworkCore.Migrations;

namespace UowDesignPattern.DataAccessLayer.Migrations
{
    public partial class mig_add_balance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Customers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customers");
        }
    }
}
