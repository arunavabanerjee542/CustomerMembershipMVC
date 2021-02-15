using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkMVC.Migrations
{
    public partial class CorrectName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Memberships_MemberShipId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MenbershipId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "MemberShipId",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Memberships_MemberShipId",
                table: "Customers",
                column: "MemberShipId",
                principalTable: "Memberships",
                principalColumn: "MemberShipId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Memberships_MemberShipId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "MemberShipId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MenbershipId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Memberships_MemberShipId",
                table: "Customers",
                column: "MemberShipId",
                principalTable: "Memberships",
                principalColumn: "MemberShipId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
