using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BreeceWorks.IDP.DuendeIdentityServer.Migrations
{
    /// <inheritdoc />
    public partial class AddUserPasswordProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("033d0098-8c88-401f-876a-8477fcf07d14"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0955bf39-82d8-4d12-95a4-c59d81c7bfdb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("19155723-df21-4e0b-96fb-4f33971a8eda"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("28c8d790-f8da-48a8-b549-71569b770498"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5d1a0865-502f-492b-a4fd-bd4c9f9fe283"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9a042815-ecc5-4bdd-9f3e-67e51e082ee1"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b8eeef86-34d3-49e6-b490-09ec65cba140"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ed13733c-1793-4851-9b52-986a36ef4d55"));

            migrationBuilder.AddColumn<int>(
                name: "InvalidLoginAttempts",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastPasswordChangeDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "PasswordResetRequired",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("1151b680-5796-4d62-b8fa-9331fd47dcdb"), "815e4294-5605-4884-8ced-657e90b937c9", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("1f64eb9e-fde6-45d6-ba15-7165f0e35432"), "2fd16f41-6d4b-4692-bb13-2452fb729d7a", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("21a0a1c0-03ac-42e5-993b-c011c0de73ba"), "2f86ba21-6c8e-471e-a19e-81e4f78e76fa", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("98bf5da7-a501-44ba-9d69-fad459ebae17"), "a7712a24-ba28-4f9f-9440-7c022d8b9a66", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("a1c7d03d-20e1-4bac-8ce6-b09b5f9f77ab"), "c3d9212b-56ae-4532-9d73-36925ec72ca3", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("ec89ec21-a05a-45a4-b782-ab62518d3917"), "69d86990-4bbe-45ab-8128-081e96eef9cd", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("efb4b667-8e53-46af-8b53-5e399f5ccd85"), "812f610f-708e-4476-9af6-368a836a055d", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("fc17b5aa-8661-4d0b-a056-b64b32f4405d"), "a97128f5-c214-4d0b-89dd-466b47f88706", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "InvalidLoginAttempts", "LastPasswordChangeDate", "PasswordResetRequired" },
                values: new object[] { "2b6f3dea-3ab6-4658-8d65-740e2d22a88e", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "InvalidLoginAttempts", "LastPasswordChangeDate", "PasswordResetRequired" },
                values: new object[] { "8fc06dd2-d1b3-4d68-a4e2-deb9bbe35e7e", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1151b680-5796-4d62-b8fa-9331fd47dcdb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1f64eb9e-fde6-45d6-ba15-7165f0e35432"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("21a0a1c0-03ac-42e5-993b-c011c0de73ba"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("98bf5da7-a501-44ba-9d69-fad459ebae17"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a1c7d03d-20e1-4bac-8ce6-b09b5f9f77ab"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ec89ec21-a05a-45a4-b782-ab62518d3917"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("efb4b667-8e53-46af-8b53-5e399f5ccd85"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fc17b5aa-8661-4d0b-a056-b64b32f4405d"));

            migrationBuilder.DropColumn(
                name: "InvalidLoginAttempts",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastPasswordChangeDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordResetRequired",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("033d0098-8c88-401f-876a-8477fcf07d14"), "073deb96-28bc-4690-be07-7fbb32e19795", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("0955bf39-82d8-4d12-95a4-c59d81c7bfdb"), "661ea914-64fb-4fd4-8253-abcee91a3ba2", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("19155723-df21-4e0b-96fb-4f33971a8eda"), "a51d131f-ded1-4df7-8e10-3ee482e54540", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("28c8d790-f8da-48a8-b549-71569b770498"), "8cb13a31-dca0-44d6-8f37-f3e6e14a64cc", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("5d1a0865-502f-492b-a4fd-bd4c9f9fe283"), "6994c575-7db5-40a0-9222-364d8c12114c", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("9a042815-ecc5-4bdd-9f3e-67e51e082ee1"), "3e885aaa-55c2-4364-b609-4a3665f75a0b", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("b8eeef86-34d3-49e6-b490-09ec65cba140"), "0481aad7-4404-4f0d-9a4e-0d4b56292613", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("ed13733c-1793-4851-9b52-986a36ef4d55"), "eb2d6b74-e19e-473a-b157-265e903bd80f", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "f8c18703-227f-4a1a-a4ec-e7ce30ab5e0c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "641e0bad-1617-4f8a-afdc-bc64fecd8ecf");
        }
    }
}
