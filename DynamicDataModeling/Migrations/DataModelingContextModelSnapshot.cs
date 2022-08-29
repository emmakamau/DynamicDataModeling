﻿// <auto-generated />
using DynamicDataModeling;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DynamicDataModeling.Migrations
{
    [DbContext(typeof(DataModelingContext))]
    partial class DataModelingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DynamicDataModeling.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GlobalTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GlobalTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GlobalTypeId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            GlobalTypeId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("DynamicDataModeling.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("DynamicDataModeling.Models.GlobalType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GlobalTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PhoneNumber",
                            TableName = "Contacts"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fax",
                            TableName = "Contacts"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Email",
                            TableName = "Contacts"
                        });
                });

            modelBuilder.Entity("DynamicDataModeling.Models.PersonalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PersonalInfos");
                });

            modelBuilder.Entity("DynamicDataModeling.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "User3"
                        });
                });

            modelBuilder.Entity("DynamicDataModeling.Models.Contact", b =>
                {
                    b.HasOne("DynamicDataModeling.Models.GlobalType", "GlobalType")
                        .WithMany("Contacts")
                        .HasForeignKey("GlobalTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DynamicDataModeling.Models.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GlobalType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DynamicDataModeling.Models.Education", b =>
                {
                    b.HasOne("DynamicDataModeling.Models.User", "User")
                        .WithMany("EducationList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DynamicDataModeling.Models.PersonalInfo", b =>
                {
                    b.HasOne("DynamicDataModeling.Models.User", "User")
                        .WithMany("PersonalInfoList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DynamicDataModeling.Models.GlobalType", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("DynamicDataModeling.Models.User", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("EducationList");

                    b.Navigation("PersonalInfoList");
                });
#pragma warning restore 612, 618
        }
    }
}
