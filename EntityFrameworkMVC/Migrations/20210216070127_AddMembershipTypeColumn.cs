﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkMVC.Migrations
{
    public partial class AddMembershipTypeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 3);

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

            migrationBuilder.AddColumn<string>(
                name: "MembershipType",
                table: "Memberships",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembershipType",
                table: "Memberships");

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "MemberShipId", "Discount", "DurationInMonths", "SignUpFee" },
                values: new object[,]
                {
                    { 1, 0, 0, 0 },
                    { 2, 10, 3, 300 },
                    { 3, 15, 6, 600 },
                    { 4, 20, 12, 900 }
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
                values: new object[] { 6, 2, "Ramji" });
        }
    }
}
