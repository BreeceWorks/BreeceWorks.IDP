using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreeceWorks.IDP.DuendeIdentityServer.Migrations
{
    public partial class AddAccountActivation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("278a7e1d-b030-43f7-a747-425264825202"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3c95ee95-54b9-4376-a836-d390cd4185c9"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7c772375-dd4d-49df-b317-b42e45c5c218"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7ed7d47a-d99a-49cb-839c-d0381e5f9dc4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("988180dc-5757-433a-af48-53fba1c8b077"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9f515174-da26-45dd-b9d5-42d458a7341e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a00c8320-84de-460e-8c4b-8f340bb130e7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b55ccb51-e8a9-43fa-9078-15892a2e5ca3"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("0092d320-c161-4c0e-9d05-9dc642048d2e"), "eb28ade0-82aa-43b7-a1f1-1751a83ee789", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("1d0bcfbf-77c8-4b75-95b2-b5351bba429a"), "5d88d6e8-a92e-4112-86e7-ba25e26ba44d", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("2e1f7d28-687d-45d2-ac74-89a9477653fb"), "fc4f44d8-406c-46dc-9537-a34c813720fb", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("3a1e1abc-2e02-4eea-950d-a6a6b8a75748"), "739a2309-f559-4f24-828d-dcb1584fb785", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("46ac5a79-6981-4af2-a144-1a64dbce1141"), "f15012cc-3685-4260-a74b-37bb33377d3a", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("90ed566b-5e0b-447c-bafb-b48dfebc4172"), "2dfb0287-7cda-46fd-8783-f6df087a1a6e", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("dac9b72e-604d-4fb3-8ee8-97661fd29f46"), "423e5365-8d95-416f-b32e-49d3220f4453", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("f31aadea-7127-4484-913f-40f65d667621"), "85170714-6d25-468c-ad85-8a5fd345d12c", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "91b9ad74-78f1-43b8-a764-fc5f30291223", "david@someprovider.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "70d690fe-0a02-419b-867e-6e60b5aea927", "emma@someprovider.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0092d320-c161-4c0e-9d05-9dc642048d2e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1d0bcfbf-77c8-4b75-95b2-b5351bba429a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2e1f7d28-687d-45d2-ac74-89a9477653fb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3a1e1abc-2e02-4eea-950d-a6a6b8a75748"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("46ac5a79-6981-4af2-a144-1a64dbce1141"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("90ed566b-5e0b-447c-bafb-b48dfebc4172"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("dac9b72e-604d-4fb3-8ee8-97661fd29f46"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f31aadea-7127-4484-913f-40f65d667621"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("278a7e1d-b030-43f7-a747-425264825202"), "a0398c57-4d77-4de8-9a98-216e6f0c4c1e", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("3c95ee95-54b9-4376-a836-d390cd4185c9"), "07109723-cf6c-4b69-9579-a8b5d1591ae0", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("7c772375-dd4d-49df-b317-b42e45c5c218"), "3dfa4bc4-4afa-4de1-bc21-79f06c26963d", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("7ed7d47a-d99a-49cb-839c-d0381e5f9dc4"), "fbd29463-5311-4d6b-a104-c98fb049c62d", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("988180dc-5757-433a-af48-53fba1c8b077"), "a55d78e0-cd55-4fdb-b8ae-33d4aaa85d3b", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("9f515174-da26-45dd-b9d5-42d458a7341e"), "9e8eb8b2-e2f8-4aba-aee7-4532b11043eb", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("a00c8320-84de-460e-8c4b-8f340bb130e7"), "de4a4131-59dd-4636-8684-9ea1365c0dd4", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("b55ccb51-e8a9-43fa-9078-15892a2e5ca3"), "249e6383-468f-4468-9c8f-0a6876074f2a", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "cb49adef-0644-4ac9-8270-2a89253f241c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "34e47327-7606-4793-b80d-b906a993b3d8");
        }
    }
}
