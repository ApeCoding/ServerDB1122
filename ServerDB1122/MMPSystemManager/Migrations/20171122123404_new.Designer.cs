﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MMPSystemManager.DBContext;
using System;

namespace MMPSystemManager.Migrations
{
    [DbContext(typeof(MMPContext))]
    [Migration("20171122123404_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("MMPSystemManager.Module.Admin", b =>
                {
                    b.Property<string>("AdminNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminContactEmail");

                    b.Property<string>("AdminContactPhone");

                    b.Property<string>("AdminGrade");

                    b.Property<string>("AdminId");

                    b.Property<string>("AdminIdPict");

                    b.Property<DateTime>("AdminLoginTime");

                    b.Property<string>("AdminName");

                    b.Property<string>("AdminOnline");

                    b.Property<string>("AdminPasswd");

                    b.Property<DateTime>("AdminPicTime");

                    b.Property<DateTime>("AdminPicUpdateTime");

                    b.Property<string>("AdminPicture");

                    b.Property<string>("Remark");

                    b.HasKey("AdminNumber");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MMPSystemManager.Module.Userinfo", b =>
                {
                    b.Property<string>("UserNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Remark");

                    b.Property<string>("UserContactEmail");

                    b.Property<string>("UserContactPhone");

                    b.Property<string>("UserFacepict");

                    b.Property<string>("UserId");

                    b.Property<string>("UserName");

                    b.Property<string>("UserWechatName");

                    b.HasKey("UserNumber");

                    b.ToTable("Userinfos");
                });

            modelBuilder.Entity("MMPSystemManager.Module.Userpicture", b =>
                {
                    b.Property<string>("UserNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Remark");

                    b.Property<string>("UserAerialPict");

                    b.Property<string>("UserChoosePict");

                    b.Property<string>("UserName");

                    b.Property<DateTime>("UserPicTime");

                    b.Property<string>("UserPictureLocation");

                    b.HasKey("UserNumber");

                    b.ToTable("Userpictures");
                });
#pragma warning restore 612, 618
        }
    }
}
