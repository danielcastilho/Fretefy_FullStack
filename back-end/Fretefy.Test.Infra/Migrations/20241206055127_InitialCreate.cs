using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fretefy.Test.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    UF = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    RegiaoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_Regiao_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regiao",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_RegiaoId",
                table: "Cidade",
                column: "RegiaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Regiao");
        }
    }
}
