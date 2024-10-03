using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechStore.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Una variedad de laptops para diferentes necesidades.", "Laptops" },
                    { 2, "Los últimos smartphones del mercado.", "Smartphones" },
                    { 3, "Accesorios para mejorar tu experiencia tecnológica.", "Accesorios" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Calle Falsa 123", "juan.perez@example.com", "Juan Pérez", "123-456-7890" },
                    { 2, "Avenida Siempre Viva 742", "maria.lopez@example.com", "María López", "987-654-3210" },
                    { 3, "Paseo del Río 456", "carlos.garcia@example.com", "Carlos García", "555-123-4567" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateOrder", "IdClient", "QuantityProduct", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 3, 11, 15, 1, 660, DateTimeKind.Local).AddTicks(4301), 1, 2, "Pendiente" },
                    { 2, new DateTime(2024, 10, 2, 11, 15, 1, 660, DateTimeKind.Local).AddTicks(4330), 2, 1, "Completado" },
                    { 3, new DateTime(2024, 10, 1, 11, 15, 1, 660, DateTimeKind.Local).AddTicks(4336), 3, 3, "Cancelado" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "IdCategory", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Laptop potente para juegos y trabajo.", 1, "Laptop XYZ", 999.99000000000001, 10 },
                    { 2, "Smartphone con cámara de alta calidad.", 2, "Smartphone ABC", 599.99000000000001, 20 },
                    { 3, "Auriculares inalámbricos con cancelación de ruido.", 3, "Auriculares Bluetooth", 89.989999999999995, 50 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IdRole", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 1, "admin", "admin123" },
                    { 2, 2, "john_doe", "password" },
                    { 3, 3, "guest_user", "guest" }
                });

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "Id", "IdOrder", "IdProduct" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 1 },
                    { 4, 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
