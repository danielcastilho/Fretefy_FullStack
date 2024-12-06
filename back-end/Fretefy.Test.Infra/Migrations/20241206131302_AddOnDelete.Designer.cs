﻿// <auto-generated />
using System;
using Fretefy.Test.Infra.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fretefy.Test.Infra.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20241206131302_AddOnDelete")]
    partial class AddOnDelete
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RegiaoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RegiaoId");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92d653b1-a374-4e62-be54-88ba4d149366"),
                            Nome = "Rio Branco",
                            UF = "AC"
                        },
                        new
                        {
                            Id = new Guid("d2edd6be-5c6f-4075-acae-0e3ed055a861"),
                            Nome = "Maceió",
                            UF = "AL"
                        },
                        new
                        {
                            Id = new Guid("53c2902c-fdd0-4f2e-b991-16411d1420c4"),
                            Nome = "Macapá",
                            UF = "AP"
                        },
                        new
                        {
                            Id = new Guid("72fa25d7-c064-4954-9ddf-4717ee89eada"),
                            Nome = "Manaus",
                            UF = "AM"
                        },
                        new
                        {
                            Id = new Guid("ae8ff805-1251-4552-bb3b-95476a22c96a"),
                            Nome = "Salvador",
                            UF = "BA"
                        },
                        new
                        {
                            Id = new Guid("560b89a7-bcc7-430e-b74e-8b9e5b853f15"),
                            Nome = "Fortaleza",
                            UF = "CE"
                        },
                        new
                        {
                            Id = new Guid("f4ea1384-ec25-47bf-9195-922e766cfccc"),
                            Nome = "Brasília",
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("326a71f4-dbff-49ba-a44f-3cc6bb546258"),
                            Nome = "Vitória",
                            UF = "ES"
                        },
                        new
                        {
                            Id = new Guid("8f804648-0fc1-45a0-b769-d9022d720b38"),
                            Nome = "Goiânia",
                            UF = "GO"
                        },
                        new
                        {
                            Id = new Guid("055fa15f-36d2-4efc-93e2-7e62a5171ac7"),
                            Nome = "São Luís",
                            UF = "MA"
                        },
                        new
                        {
                            Id = new Guid("2ea21034-b845-4448-b6c5-1d74469f8cf3"),
                            Nome = "Cuiabá",
                            UF = "MT"
                        },
                        new
                        {
                            Id = new Guid("fbac76ea-8631-4eae-b2c4-265ac1801f76"),
                            Nome = "Campo Grande",
                            UF = "MS"
                        },
                        new
                        {
                            Id = new Guid("2e8b5e8c-04ae-4220-bd06-6b42dc315257"),
                            Nome = "Belo Horizonte",
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("9e44fded-560d-47d9-9e69-b6cf7af426b3"),
                            Nome = "Belém",
                            UF = "PA"
                        },
                        new
                        {
                            Id = new Guid("0e4918ef-5dfc-4ea7-af47-cf3e236a7638"),
                            Nome = "João Pessoa",
                            UF = "PB"
                        },
                        new
                        {
                            Id = new Guid("c1f9d478-00dc-4808-adbc-77f243ab2310"),
                            Nome = "Curitiba",
                            UF = "PR"
                        },
                        new
                        {
                            Id = new Guid("49ecada7-a106-423d-a4e7-08c0d736c00b"),
                            Nome = "Recife",
                            UF = "PE"
                        },
                        new
                        {
                            Id = new Guid("76f5cdf7-4a47-4f10-ad8a-27f671365d58"),
                            Nome = "Teresina",
                            UF = "PI"
                        },
                        new
                        {
                            Id = new Guid("daf88b80-7a86-4cbe-a300-bf22978344ec"),
                            Nome = "Rio de Janeiro",
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("7c6f4e9d-f39e-4b28-b5d9-41fb9382ba10"),
                            Nome = "Natal",
                            UF = "RN"
                        },
                        new
                        {
                            Id = new Guid("a8df1417-aba0-4c4b-a9cf-a826a82d6753"),
                            Nome = "Porto Alegre",
                            UF = "RS"
                        },
                        new
                        {
                            Id = new Guid("d645eb2c-c329-48dd-af65-c985d87e58e8"),
                            Nome = "Porto Velho",
                            UF = "RO"
                        },
                        new
                        {
                            Id = new Guid("af3bb056-b8f2-47f1-95cd-c40dc2863841"),
                            Nome = "Boa Vista",
                            UF = "RR"
                        },
                        new
                        {
                            Id = new Guid("f48d1f8d-b000-4338-9b4f-960c866de45c"),
                            Nome = "Florianópolis",
                            UF = "SC"
                        },
                        new
                        {
                            Id = new Guid("2aa92533-49b7-4e50-8ed4-05d5d07c8c79"),
                            Nome = "São Paulo",
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("b562bcac-c933-4ec9-9bf3-1fd3869b79c9"),
                            Nome = "Aracaju",
                            UF = "SE"
                        },
                        new
                        {
                            Id = new Guid("6c7b57c2-65b9-4971-9501-b82378cc2b7a"),
                            Nome = "Palmas",
                            UF = "TO"
                        });
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Regiao");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Cidade", b =>
                {
                    b.HasOne("Fretefy.Test.Domain.Entities.Regiao", null)
                        .WithMany("Cidades")
                        .HasForeignKey("RegiaoId");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
