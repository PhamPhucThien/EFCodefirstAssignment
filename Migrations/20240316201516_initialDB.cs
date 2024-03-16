using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCodefirstAssignment.Migrations
{
    /// <inheritdoc />
    public partial class initialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("038a4f71-645b-43ea-a666-a41b71f94417"), "Description 1", "Product 1" },
                    { new Guid("0abb6263-ba44-4302-ab37-29b774591c0e"), "Description 4", "Product 4" },
                    { new Guid("53156d54-0837-4c47-989c-355a33b3a226"), "Description 3", "Product 3" },
                    { new Guid("83017a70-a8e4-4d8f-bbfe-93fbf068469e"), "Description 2", "Product 2" },
                    { new Guid("930b69b4-e6e5-4f00-aa02-8c43becc206f"), "Description 0", "Product 0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EmailConfirmed", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("0054059f-d62a-41cb-8fe7-674cc674212c"), "User1@gmail.com", true, "User 1", "12345" },
                    { new Guid("80c56fa9-a7e2-4e95-9573-24ce1292f0be"), "User0@gmail.com", true, "User 0", "12345" },
                    { new Guid("a2e0227b-7b8a-4eb0-9663-3df28d89fb49"), "User3@gmail.com", true, "User 3", "12345" },
                    { new Guid("a9da98bf-3d14-4819-be14-a7c0f0dac180"), "User4@gmail.com", true, "User 4", "12345" },
                    { new Guid("c08295cf-8d01-4c46-8a23-c53d351e3304"), "User2@gmail.com", true, "User 2", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Description", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("15a645c5-6668-4948-acc9-765eee3cc4f6"), "Description3", "Order 3", new Guid("a2e0227b-7b8a-4eb0-9663-3df28d89fb49") },
                    { new Guid("39844691-1115-41fd-89cb-2621a85da67a"), "Description2", "Order 2", new Guid("c08295cf-8d01-4c46-8a23-c53d351e3304") },
                    { new Guid("3af74220-4919-409f-aa36-2367f416bf7b"), "Description0", "Order 0", new Guid("80c56fa9-a7e2-4e95-9573-24ce1292f0be") },
                    { new Guid("59bdb25d-17f9-4442-9394-faab604a78e1"), "Description1", "Order 1", new Guid("0054059f-d62a-41cb-8fe7-674cc674212c") },
                    { new Guid("a635ad77-178e-41e0-8166-847d354213e4"), "Description4", "Order 4", new Guid("a9da98bf-3d14-4819-be14-a7c0f0dac180") }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Description", "Discount", "Name", "Note", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("035426e7-41f1-466a-ad85-d2ccf8cf24ca"), "Description 11", 0f, "Order Product11", "None", new Guid("15a645c5-6668-4948-acc9-765eee3cc4f6"), 11 },
                    { new Guid("068abe81-4295-425c-b70c-0352f4f5ca68"), "Description 2", 0f, "Order Product2", "None", new Guid("3af74220-4919-409f-aa36-2367f416bf7b"), 2 },
                    { new Guid("11efbe6a-f05c-47cc-812c-e80eaa09a338"), "Description 8", 0f, "Order Product8", "None", new Guid("39844691-1115-41fd-89cb-2621a85da67a"), 8 },
                    { new Guid("1321180a-eb25-4c09-a546-d7725c4372ea"), "Description 7", 0f, "Order Product7", "None", new Guid("39844691-1115-41fd-89cb-2621a85da67a"), 7 },
                    { new Guid("1eec07e9-2c95-4673-8ba5-9bb1784adba7"), "Description 9", 0f, "Order Product9", "None", new Guid("15a645c5-6668-4948-acc9-765eee3cc4f6"), 9 },
                    { new Guid("4775280f-a5fe-4b5b-8c59-fd31802db728"), "Description 4", 0f, "Order Product4", "None", new Guid("59bdb25d-17f9-4442-9394-faab604a78e1"), 4 },
                    { new Guid("689a16ac-ec26-479b-a885-7b25f6180c9a"), "Description 0", 0f, "Order Product0", "None", new Guid("3af74220-4919-409f-aa36-2367f416bf7b"), 0 },
                    { new Guid("6bf231c5-da52-48db-9926-a6d88bc5c9c9"), "Description 13", 0f, "Order Product13", "None", new Guid("a635ad77-178e-41e0-8166-847d354213e4"), 13 },
                    { new Guid("85cf736a-4f7e-44b8-a98a-edacda0d9c4c"), "Description 1", 0f, "Order Product1", "None", new Guid("3af74220-4919-409f-aa36-2367f416bf7b"), 1 },
                    { new Guid("897e1a80-44cb-40d4-a394-f179e945018e"), "Description 12", 0f, "Order Product12", "None", new Guid("a635ad77-178e-41e0-8166-847d354213e4"), 12 },
                    { new Guid("91c466a1-8175-462f-b50d-9c0a4aadb8c3"), "Description 5", 0f, "Order Product5", "None", new Guid("59bdb25d-17f9-4442-9394-faab604a78e1"), 5 },
                    { new Guid("9529b65a-9111-44e8-a1b1-7251d02d6dda"), "Description 14", 0f, "Order Product14", "None", new Guid("a635ad77-178e-41e0-8166-847d354213e4"), 14 },
                    { new Guid("e4c68042-1033-4d99-9f5a-f1dab6bc905d"), "Description 10", 0f, "Order Product10", "None", new Guid("15a645c5-6668-4948-acc9-765eee3cc4f6"), 10 },
                    { new Guid("f113d2aa-9df3-4356-9fd3-c9db55536ce4"), "Description 6", 0f, "Order Product6", "None", new Guid("39844691-1115-41fd-89cb-2621a85da67a"), 6 },
                    { new Guid("febd503a-66d3-4e75-b900-332f290a6f03"), "Description 3", 0f, "Order Product3", "None", new Guid("59bdb25d-17f9-4442-9394-faab604a78e1"), 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
