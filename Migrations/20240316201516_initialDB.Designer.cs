﻿// <auto-generated />
using System;
using ConsoleApp7;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCodefirstAssignment.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240316201516_initialDB")]
    partial class initialDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp7.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("930b69b4-e6e5-4f00-aa02-8c43becc206f"),
                            Description = "Description 0",
                            Name = "Product 0"
                        },
                        new
                        {
                            Id = new Guid("038a4f71-645b-43ea-a666-a41b71f94417"),
                            Description = "Description 1",
                            Name = "Product 1"
                        },
                        new
                        {
                            Id = new Guid("83017a70-a8e4-4d8f-bbfe-93fbf068469e"),
                            Description = "Description 2",
                            Name = "Product 2"
                        },
                        new
                        {
                            Id = new Guid("53156d54-0837-4c47-989c-355a33b3a226"),
                            Description = "Description 3",
                            Name = "Product 3"
                        },
                        new
                        {
                            Id = new Guid("0abb6263-ba44-4302-ab37-29b774591c0e"),
                            Description = "Description 4",
                            Name = "Product 4"
                        });
                });

            modelBuilder.Entity("ConsoleApp7.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80c56fa9-a7e2-4e95-9573-24ce1292f0be"),
                            Email = "User0@gmail.com",
                            EmailConfirmed = true,
                            Name = "User 0",
                            Password = "12345"
                        },
                        new
                        {
                            Id = new Guid("0054059f-d62a-41cb-8fe7-674cc674212c"),
                            Email = "User1@gmail.com",
                            EmailConfirmed = true,
                            Name = "User 1",
                            Password = "12345"
                        },
                        new
                        {
                            Id = new Guid("c08295cf-8d01-4c46-8a23-c53d351e3304"),
                            Email = "User2@gmail.com",
                            EmailConfirmed = true,
                            Name = "User 2",
                            Password = "12345"
                        },
                        new
                        {
                            Id = new Guid("a2e0227b-7b8a-4eb0-9663-3df28d89fb49"),
                            Email = "User3@gmail.com",
                            EmailConfirmed = true,
                            Name = "User 3",
                            Password = "12345"
                        },
                        new
                        {
                            Id = new Guid("a9da98bf-3d14-4819-be14-a7c0f0dac180"),
                            Email = "User4@gmail.com",
                            EmailConfirmed = true,
                            Name = "User 4",
                            Password = "12345"
                        });
                });

            modelBuilder.Entity("EFCodefirstAssignment.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3af74220-4919-409f-aa36-2367f416bf7b"),
                            Description = "Description0",
                            Name = "Order 0",
                            UserId = new Guid("80c56fa9-a7e2-4e95-9573-24ce1292f0be")
                        },
                        new
                        {
                            Id = new Guid("59bdb25d-17f9-4442-9394-faab604a78e1"),
                            Description = "Description1",
                            Name = "Order 1",
                            UserId = new Guid("0054059f-d62a-41cb-8fe7-674cc674212c")
                        },
                        new
                        {
                            Id = new Guid("39844691-1115-41fd-89cb-2621a85da67a"),
                            Description = "Description2",
                            Name = "Order 2",
                            UserId = new Guid("c08295cf-8d01-4c46-8a23-c53d351e3304")
                        },
                        new
                        {
                            Id = new Guid("15a645c5-6668-4948-acc9-765eee3cc4f6"),
                            Description = "Description3",
                            Name = "Order 3",
                            UserId = new Guid("a2e0227b-7b8a-4eb0-9663-3df28d89fb49")
                        },
                        new
                        {
                            Id = new Guid("a635ad77-178e-41e0-8166-847d354213e4"),
                            Description = "Description4",
                            Name = "Order 4",
                            UserId = new Guid("a9da98bf-3d14-4819-be14-a7c0f0dac180")
                        });
                });

            modelBuilder.Entity("EFCodefirstAssignment.Models.OrderProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("689a16ac-ec26-479b-a885-7b25f6180c9a"),
                            Description = "Description 0",
                            Discount = 0f,
                            Name = "Order Product0",
                            Note = "None",
                            OrderId = new Guid("3af74220-4919-409f-aa36-2367f416bf7b"),
                            Quantity = 0
                        },
                        new
                        {
                            Id = new Guid("85cf736a-4f7e-44b8-a98a-edacda0d9c4c"),
                            Description = "Description 1",
                            Discount = 0f,
                            Name = "Order Product1",
                            Note = "None",
                            OrderId = new Guid("3af74220-4919-409f-aa36-2367f416bf7b"),
                            Quantity = 1
                        },
                        new
                        {
                            Id = new Guid("068abe81-4295-425c-b70c-0352f4f5ca68"),
                            Description = "Description 2",
                            Discount = 0f,
                            Name = "Order Product2",
                            Note = "None",
                            OrderId = new Guid("3af74220-4919-409f-aa36-2367f416bf7b"),
                            Quantity = 2
                        },
                        new
                        {
                            Id = new Guid("febd503a-66d3-4e75-b900-332f290a6f03"),
                            Description = "Description 3",
                            Discount = 0f,
                            Name = "Order Product3",
                            Note = "None",
                            OrderId = new Guid("59bdb25d-17f9-4442-9394-faab604a78e1"),
                            Quantity = 3
                        },
                        new
                        {
                            Id = new Guid("4775280f-a5fe-4b5b-8c59-fd31802db728"),
                            Description = "Description 4",
                            Discount = 0f,
                            Name = "Order Product4",
                            Note = "None",
                            OrderId = new Guid("59bdb25d-17f9-4442-9394-faab604a78e1"),
                            Quantity = 4
                        },
                        new
                        {
                            Id = new Guid("91c466a1-8175-462f-b50d-9c0a4aadb8c3"),
                            Description = "Description 5",
                            Discount = 0f,
                            Name = "Order Product5",
                            Note = "None",
                            OrderId = new Guid("59bdb25d-17f9-4442-9394-faab604a78e1"),
                            Quantity = 5
                        },
                        new
                        {
                            Id = new Guid("f113d2aa-9df3-4356-9fd3-c9db55536ce4"),
                            Description = "Description 6",
                            Discount = 0f,
                            Name = "Order Product6",
                            Note = "None",
                            OrderId = new Guid("39844691-1115-41fd-89cb-2621a85da67a"),
                            Quantity = 6
                        },
                        new
                        {
                            Id = new Guid("1321180a-eb25-4c09-a546-d7725c4372ea"),
                            Description = "Description 7",
                            Discount = 0f,
                            Name = "Order Product7",
                            Note = "None",
                            OrderId = new Guid("39844691-1115-41fd-89cb-2621a85da67a"),
                            Quantity = 7
                        },
                        new
                        {
                            Id = new Guid("11efbe6a-f05c-47cc-812c-e80eaa09a338"),
                            Description = "Description 8",
                            Discount = 0f,
                            Name = "Order Product8",
                            Note = "None",
                            OrderId = new Guid("39844691-1115-41fd-89cb-2621a85da67a"),
                            Quantity = 8
                        },
                        new
                        {
                            Id = new Guid("1eec07e9-2c95-4673-8ba5-9bb1784adba7"),
                            Description = "Description 9",
                            Discount = 0f,
                            Name = "Order Product9",
                            Note = "None",
                            OrderId = new Guid("15a645c5-6668-4948-acc9-765eee3cc4f6"),
                            Quantity = 9
                        },
                        new
                        {
                            Id = new Guid("e4c68042-1033-4d99-9f5a-f1dab6bc905d"),
                            Description = "Description 10",
                            Discount = 0f,
                            Name = "Order Product10",
                            Note = "None",
                            OrderId = new Guid("15a645c5-6668-4948-acc9-765eee3cc4f6"),
                            Quantity = 10
                        },
                        new
                        {
                            Id = new Guid("035426e7-41f1-466a-ad85-d2ccf8cf24ca"),
                            Description = "Description 11",
                            Discount = 0f,
                            Name = "Order Product11",
                            Note = "None",
                            OrderId = new Guid("15a645c5-6668-4948-acc9-765eee3cc4f6"),
                            Quantity = 11
                        },
                        new
                        {
                            Id = new Guid("897e1a80-44cb-40d4-a394-f179e945018e"),
                            Description = "Description 12",
                            Discount = 0f,
                            Name = "Order Product12",
                            Note = "None",
                            OrderId = new Guid("a635ad77-178e-41e0-8166-847d354213e4"),
                            Quantity = 12
                        },
                        new
                        {
                            Id = new Guid("6bf231c5-da52-48db-9926-a6d88bc5c9c9"),
                            Description = "Description 13",
                            Discount = 0f,
                            Name = "Order Product13",
                            Note = "None",
                            OrderId = new Guid("a635ad77-178e-41e0-8166-847d354213e4"),
                            Quantity = 13
                        },
                        new
                        {
                            Id = new Guid("9529b65a-9111-44e8-a1b1-7251d02d6dda"),
                            Description = "Description 14",
                            Discount = 0f,
                            Name = "Order Product14",
                            Note = "None",
                            OrderId = new Guid("a635ad77-178e-41e0-8166-847d354213e4"),
                            Quantity = 14
                        });
                });

            modelBuilder.Entity("EFCodefirstAssignment.Models.Order", b =>
                {
                    b.HasOne("ConsoleApp7.Models.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFCodefirstAssignment.Models.OrderProduct", b =>
                {
                    b.HasOne("EFCodefirstAssignment.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ConsoleApp7.Models.User", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("EFCodefirstAssignment.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}