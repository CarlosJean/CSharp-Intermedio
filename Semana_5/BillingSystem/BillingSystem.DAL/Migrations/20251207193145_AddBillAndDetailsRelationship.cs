using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddBillAndDetailsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BillDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BillDetails");
        }
    }
}
