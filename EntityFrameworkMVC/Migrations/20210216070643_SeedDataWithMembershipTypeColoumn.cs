using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkMVC.Migrations
{
    public partial class SeedDataWithMembershipTypeColoumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "MemberShipId", "Discount", "DurationInMonths", "MembershipType", "SignUpFee" },
                values: new object[,]
                {
                    { 1, 0, 0, "Pay AS You Go", 0 },
                    { 2, 10, 3, "Quaterly", 300 },
                    { 3, 15, 6, "Half Yearly", 600 },
                    { 4, 20, 12, "Yearly", 900 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "MemberShipId", "Name" },
                values: new object[] { 4, 1, "Ram" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "MemberShipId", "Name" },
                values: new object[] { 5, 2, "Rama" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "MemberShipId", "Name" },
                values: new object[] { 6, 3, "Ramji" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "MemberShipId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "MemberShipId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "MemberShipId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "MemberShipId",
                keyValue: 3);
        }
    }
}
