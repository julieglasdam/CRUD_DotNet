﻿// <auto-generated />
using Project02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Project02.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180509164316_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("MentorOnlineV3.Models.TestObject", b =>
                {
                    b.Property<int>("TestObjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Field01");

                    b.HasKey("TestObjectId");

                    b.ToTable("Table01");
                });
#pragma warning restore 612, 618
        }
    }
}
