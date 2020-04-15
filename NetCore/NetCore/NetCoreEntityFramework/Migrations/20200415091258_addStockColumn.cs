using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreEntityFramework.Migrations
{
    public partial class addStockColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Stock",
                table: "Products",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");
        }
    }
}

/*
    
     */
