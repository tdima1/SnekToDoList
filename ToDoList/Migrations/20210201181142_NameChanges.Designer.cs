﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoList.Data.Context;

namespace ToDoList.Migrations
{
    [DbContext(typeof(TaskItemContext))]
    [Migration("20210201181142_NameChanges")]
    partial class NameChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ToDoList.Data.TaskItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Column = 1,
                            Description = "Default Description",
                            Title = "Default Entity"
                        },
                        new
                        {
                            Id = 2,
                            Column = 3,
                            Description = "Default Description",
                            Title = "Default Entity"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
