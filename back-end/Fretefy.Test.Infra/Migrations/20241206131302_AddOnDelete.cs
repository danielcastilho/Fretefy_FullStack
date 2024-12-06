using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fretefy.Test.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddOnDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("00d9cf96-0d83-47d7-bed0-021a88d94345"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0232bd8d-7198-4fe5-b830-a5632bbe673f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("02becc86-379c-4948-8e1a-4e9f8c09600c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("063328b5-f193-4be6-b23d-dd87299bf92d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("156d85c3-4182-4596-b21a-105be0634407"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1a129e7d-3986-4328-b89d-f0ee2c5ae1da"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1fe00a1f-60c9-4ab4-b0fa-4bf363e35810"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("207c5c16-67f9-4f46-abe2-5eb6e50f4fa1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2cb22f78-e7d0-4600-83e5-a6359a508995"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("38a29c23-6276-442e-85c6-63c4efd37225"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3ee7b7d0-08bb-4f8c-815a-d4b396c16d01"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("494cd2b6-bb31-437d-83ff-a6eac5f93ee5"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4aa6255e-8d01-4d96-bb5e-312d7577da5e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4ca49ec4-9911-482f-a07e-e807ae32532e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4efd7ca2-9f70-42bc-84ab-599ac7c74d8f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5be047f0-c2f3-44b2-993f-cd00f41e5f03"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("67fe4fbd-0e2f-4114-91bb-8e0694aa5404"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7bf68e3d-0d5f-459f-a98e-fd5402706544"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("80656b1f-96b7-47b6-bcc2-ec29497a22eb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a018f1c2-8929-4d7f-bbe2-97dc17d00c90"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a14018f2-459c-455a-8a35-cfcfcb5e8975"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a2a4d756-cf23-4656-84df-37d0c5c55e14"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("abeb5bf6-7e72-49da-8568-d29a6bf5ef6d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ce17d4c8-ac10-4474-b09d-5e2ffaa621cf"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ce68f269-f56e-4690-ac7a-e63063c05acc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("eeb01bdb-3264-42f5-b03a-a7db5a8dbe1d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("eff5ef12-81a9-45e8-b9be-d8a3df23a348"));

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[,]
                {
                    { new Guid("055fa15f-36d2-4efc-93e2-7e62a5171ac7"), "São Luís", null, "MA" },
                    { new Guid("0e4918ef-5dfc-4ea7-af47-cf3e236a7638"), "João Pessoa", null, "PB" },
                    { new Guid("2aa92533-49b7-4e50-8ed4-05d5d07c8c79"), "São Paulo", null, "SP" },
                    { new Guid("2e8b5e8c-04ae-4220-bd06-6b42dc315257"), "Belo Horizonte", null, "MG" },
                    { new Guid("2ea21034-b845-4448-b6c5-1d74469f8cf3"), "Cuiabá", null, "MT" },
                    { new Guid("326a71f4-dbff-49ba-a44f-3cc6bb546258"), "Vitória", null, "ES" },
                    { new Guid("49ecada7-a106-423d-a4e7-08c0d736c00b"), "Recife", null, "PE" },
                    { new Guid("53c2902c-fdd0-4f2e-b991-16411d1420c4"), "Macapá", null, "AP" },
                    { new Guid("560b89a7-bcc7-430e-b74e-8b9e5b853f15"), "Fortaleza", null, "CE" },
                    { new Guid("6c7b57c2-65b9-4971-9501-b82378cc2b7a"), "Palmas", null, "TO" },
                    { new Guid("72fa25d7-c064-4954-9ddf-4717ee89eada"), "Manaus", null, "AM" },
                    { new Guid("76f5cdf7-4a47-4f10-ad8a-27f671365d58"), "Teresina", null, "PI" },
                    { new Guid("7c6f4e9d-f39e-4b28-b5d9-41fb9382ba10"), "Natal", null, "RN" },
                    { new Guid("8f804648-0fc1-45a0-b769-d9022d720b38"), "Goiânia", null, "GO" },
                    { new Guid("92d653b1-a374-4e62-be54-88ba4d149366"), "Rio Branco", null, "AC" },
                    { new Guid("9e44fded-560d-47d9-9e69-b6cf7af426b3"), "Belém", null, "PA" },
                    { new Guid("a8df1417-aba0-4c4b-a9cf-a826a82d6753"), "Porto Alegre", null, "RS" },
                    { new Guid("ae8ff805-1251-4552-bb3b-95476a22c96a"), "Salvador", null, "BA" },
                    { new Guid("af3bb056-b8f2-47f1-95cd-c40dc2863841"), "Boa Vista", null, "RR" },
                    { new Guid("b562bcac-c933-4ec9-9bf3-1fd3869b79c9"), "Aracaju", null, "SE" },
                    { new Guid("c1f9d478-00dc-4808-adbc-77f243ab2310"), "Curitiba", null, "PR" },
                    { new Guid("d2edd6be-5c6f-4075-acae-0e3ed055a861"), "Maceió", null, "AL" },
                    { new Guid("d645eb2c-c329-48dd-af65-c985d87e58e8"), "Porto Velho", null, "RO" },
                    { new Guid("daf88b80-7a86-4cbe-a300-bf22978344ec"), "Rio de Janeiro", null, "RJ" },
                    { new Guid("f48d1f8d-b000-4338-9b4f-960c866de45c"), "Florianópolis", null, "SC" },
                    { new Guid("f4ea1384-ec25-47bf-9195-922e766cfccc"), "Brasília", null, "DF" },
                    { new Guid("fbac76ea-8631-4eae-b2c4-265ac1801f76"), "Campo Grande", null, "MS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("055fa15f-36d2-4efc-93e2-7e62a5171ac7"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0e4918ef-5dfc-4ea7-af47-cf3e236a7638"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2aa92533-49b7-4e50-8ed4-05d5d07c8c79"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2e8b5e8c-04ae-4220-bd06-6b42dc315257"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2ea21034-b845-4448-b6c5-1d74469f8cf3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("326a71f4-dbff-49ba-a44f-3cc6bb546258"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("49ecada7-a106-423d-a4e7-08c0d736c00b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("53c2902c-fdd0-4f2e-b991-16411d1420c4"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("560b89a7-bcc7-430e-b74e-8b9e5b853f15"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6c7b57c2-65b9-4971-9501-b82378cc2b7a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("72fa25d7-c064-4954-9ddf-4717ee89eada"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("76f5cdf7-4a47-4f10-ad8a-27f671365d58"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7c6f4e9d-f39e-4b28-b5d9-41fb9382ba10"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8f804648-0fc1-45a0-b769-d9022d720b38"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("92d653b1-a374-4e62-be54-88ba4d149366"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9e44fded-560d-47d9-9e69-b6cf7af426b3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a8df1417-aba0-4c4b-a9cf-a826a82d6753"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ae8ff805-1251-4552-bb3b-95476a22c96a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("af3bb056-b8f2-47f1-95cd-c40dc2863841"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b562bcac-c933-4ec9-9bf3-1fd3869b79c9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c1f9d478-00dc-4808-adbc-77f243ab2310"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d2edd6be-5c6f-4075-acae-0e3ed055a861"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d645eb2c-c329-48dd-af65-c985d87e58e8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("daf88b80-7a86-4cbe-a300-bf22978344ec"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f48d1f8d-b000-4338-9b4f-960c866de45c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f4ea1384-ec25-47bf-9195-922e766cfccc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fbac76ea-8631-4eae-b2c4-265ac1801f76"));

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[,]
                {
                    { new Guid("00d9cf96-0d83-47d7-bed0-021a88d94345"), "Palmas", null, "TO" },
                    { new Guid("0232bd8d-7198-4fe5-b830-a5632bbe673f"), "Belém", null, "PA" },
                    { new Guid("02becc86-379c-4948-8e1a-4e9f8c09600c"), "Cuiabá", null, "MT" },
                    { new Guid("063328b5-f193-4be6-b23d-dd87299bf92d"), "Porto Alegre", null, "RS" },
                    { new Guid("156d85c3-4182-4596-b21a-105be0634407"), "Boa Vista", null, "RR" },
                    { new Guid("1a129e7d-3986-4328-b89d-f0ee2c5ae1da"), "Macapá", null, "AP" },
                    { new Guid("1fe00a1f-60c9-4ab4-b0fa-4bf363e35810"), "Salvador", null, "BA" },
                    { new Guid("207c5c16-67f9-4f46-abe2-5eb6e50f4fa1"), "Natal", null, "RN" },
                    { new Guid("2cb22f78-e7d0-4600-83e5-a6359a508995"), "Porto Velho", null, "RO" },
                    { new Guid("38a29c23-6276-442e-85c6-63c4efd37225"), "Manaus", null, "AM" },
                    { new Guid("3ee7b7d0-08bb-4f8c-815a-d4b396c16d01"), "João Pessoa", null, "PB" },
                    { new Guid("494cd2b6-bb31-437d-83ff-a6eac5f93ee5"), "Vitória", null, "ES" },
                    { new Guid("4aa6255e-8d01-4d96-bb5e-312d7577da5e"), "Recife", null, "PE" },
                    { new Guid("4ca49ec4-9911-482f-a07e-e807ae32532e"), "Fortaleza", null, "CE" },
                    { new Guid("4efd7ca2-9f70-42bc-84ab-599ac7c74d8f"), "Brasília", null, "DF" },
                    { new Guid("5be047f0-c2f3-44b2-993f-cd00f41e5f03"), "Rio de Janeiro", null, "RJ" },
                    { new Guid("67fe4fbd-0e2f-4114-91bb-8e0694aa5404"), "Aracaju", null, "SE" },
                    { new Guid("7bf68e3d-0d5f-459f-a98e-fd5402706544"), "São Paulo", null, "SP" },
                    { new Guid("80656b1f-96b7-47b6-bcc2-ec29497a22eb"), "Florianópolis", null, "SC" },
                    { new Guid("a018f1c2-8929-4d7f-bbe2-97dc17d00c90"), "Curitiba", null, "PR" },
                    { new Guid("a14018f2-459c-455a-8a35-cfcfcb5e8975"), "Maceió", null, "AL" },
                    { new Guid("a2a4d756-cf23-4656-84df-37d0c5c55e14"), "Campo Grande", null, "MS" },
                    { new Guid("abeb5bf6-7e72-49da-8568-d29a6bf5ef6d"), "São Luís", null, "MA" },
                    { new Guid("ce17d4c8-ac10-4474-b09d-5e2ffaa621cf"), "Goiânia", null, "GO" },
                    { new Guid("ce68f269-f56e-4690-ac7a-e63063c05acc"), "Belo Horizonte", null, "MG" },
                    { new Guid("eeb01bdb-3264-42f5-b03a-a7db5a8dbe1d"), "Teresina", null, "PI" },
                    { new Guid("eff5ef12-81a9-45e8-b9be-d8a3df23a348"), "Rio Branco", null, "AC" }
                });
        }
    }
}
