﻿// <auto-generated />
using System;
using DRAGONSTavern.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DRAGONSTavern.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DRAGONSTavern.Domain.Entities.Notice", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("BannerImageUrl")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(35000);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(400) CHARACTER SET utf8mb4")
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("Notices");

                    b.HasData(
                        new
                        {
                            Id = "e13dc5d4ac",
                            BannerImageUrl = "1ae054383e.jpg",
                            Body = "# Tonikawa - Romance about teenagers who marry out of nowhere gets trailer with OP and date Crunchyroll today released a new video for the anime adaptation of Tonikaku Kawaii (Fly Me to The Moon). The trailer brings new details of the story, besides giving a preview of the opening “Koi no Uta”, sung by Akari Kitou (voice actress of the protagonist). The anime is scheduled to debut on October 2.",
                            CreateDate = new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Tonikawa - Romance about teenagers who marry out of nowhere gets trailer with OP and date"
                        },
                        new
                        {
                            Id = "372444c72a",
                            BannerImageUrl = "747a8b59de.jpg",
                            Body = "The official website of the anime adaptation of Yuru Camp has released a trailer for the work. The video brings some scenes in the new season, featuring new characters and situations in which the protagonists find themselves. The anime is scheduled to debut in January 2021.",
                            CreateDate = new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Yuru Camp - Popular anime about campsites gets trailer and data for season 2"
                        },
                        new
                        {
                            Id = "004ac2cc3d",
                            BannerImageUrl = "cee1d3487e.jpg",
                            Body = "The official website for the anime adaptation of Horimiya has released the first trailer for the work. The video brings a little bit of history and how the protagonists met. The anime is scheduled to debut in January 2021.",
                            CreateDate = new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Horimiya - Romantic comedy anime with unusual couple gets first trailer"
                        },
                        new
                        {
                            Id = "8d8d4b5798",
                            BannerImageUrl = "f1a7ac20e9.png",
                            Body = "The official website for the anime adaptation of Attack on Titan (Shingeki no Kyojin) has made a change to the preview for the anime's final season. In place of the confirmation for the October season, as it had been for almost the entire year, the site changed to a generic message saying 'scheduled to be broadcast on TV'.",
                            CreateDate = new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Postponement confirmed? Attack on Titan final season has changed date on site"
                        },
                        new
                        {
                            Id = "90d39d40a0",
                            BannerImageUrl = "0d5dff3c46.jpg",
                            Body = "The official website of the anime adaptation of Jujutsu Kaisen has released a new trailer for the work. The video brings a little more history of the anime, featuring new characters and some of the action scenes of the work, as well as giving a preview of the opening 'Kaikai Kitan', sung by Eve. The anime is scheduled to debut on the 2nd of October.",
                            CreateDate = new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "September 19, 2020Jujutsu Kaisen - Supernatural action anime gets action trailer with OP"
                        });
                });

            modelBuilder.Entity("DRAGONSTavern.Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "cu20awb50q",
                            Email = "email@admin.com",
                            Password = "admin"
                        },
                        new
                        {
                            Id = "3js7zpr9ab",
                            Email = "email@root.com",
                            Password = "root"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
