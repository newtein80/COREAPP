﻿// <auto-generated />
using System;
using Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(SystemDbContext))]
    partial class SystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Entity.SystemModel.T_COMMON_CODE", b =>
                {
                    b.Property<string>("CODE_TYPE")
                        .HasMaxLength(32);

                    b.Property<string>("CODE_ID")
                        .HasMaxLength(32);

                    b.Property<string>("CODE_COMMENT")
                        .HasMaxLength(128);

                    b.Property<string>("CODE_NAME")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("CODE_TYPE_NAME")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int?>("CODE_VAL");

                    b.Property<DateTime?>("CREATE_DT")
                        .HasColumnType("datetime");

                    b.Property<string>("CREATE_USER_ID")
                        .HasMaxLength(16);

                    b.Property<int?>("SORT_ORDER");

                    b.Property<bool?>("USE_YN");

                    b.HasKey("CODE_TYPE", "CODE_ID");

                    b.ToTable("T_COMMON_CODE");
                });

            modelBuilder.Entity("ApplicationCore.Entity.SystemModel.T_MENU_MASTER", b =>
                {
                    b.Property<int>("MENU_IDENTITY")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("CSS_CLASS")
                        .HasMaxLength(64);

                    b.Property<string>("MENU_ACTION")
                        .HasMaxLength(64);

                    b.Property<string>("MENU_AREA")
                        .HasMaxLength(64);

                    b.Property<string>("MENU_CONTROLLER")
                        .HasMaxLength(64);

                    b.Property<string>("MENU_ID")
                        .HasMaxLength(64);

                    b.Property<string>("MENU_NAME")
                        .HasMaxLength(64);

                    b.Property<string>("PARENT_MENUID")
                        .HasMaxLength(64);

                    b.Property<int>("SORT_ORDER");

                    b.Property<int?>("USER_AUTH");

                    b.Property<int?>("USER_DUTY");

                    b.Property<string>("USER_ROLL")
                        .HasMaxLength(450);

                    b.Property<bool?>("USE_YN");

                    b.HasKey("MENU_IDENTITY");

                    b.ToTable("T_MENU_MASTER");
                });
#pragma warning restore 612, 618
        }
    }
}
