﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DRAGONSTavern.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 10, nullable: false),
                    Title = table.Column<string>(maxLength: 400, nullable: false),
                    Body = table.Column<string>(maxLength: 35000, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    BannerImageUrl = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notices",
                columns: new[] { "Id", "BannerImageUrl", "Body", "CreateDate", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { "e13dc5d4ac", "1ae054383e.jpg", "# Tonikawa - Romance about teenagers who marry out of nowhere gets trailer with OP and date Crunchyroll today released a new video for the anime adaptation of Tonikaku Kawaii (Fly Me to The Moon). The trailer brings new details of the story, besides giving a preview of the opening “Koi no Uta”, sung by Akari Kitou (voice actress of the protagonist). The anime is scheduled to debut on October 2.", new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tonikawa - Romance about teenagers who marry out of nowhere gets trailer with OP and date", new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "372444c72a", "747a8b59de.jpg", "The official website of the anime adaptation of Yuru Camp has released a trailer for the work. The video brings some scenes in the new season, featuring new characters and situations in which the protagonists find themselves. The anime is scheduled to debut in January 2021.", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yuru Camp - Popular anime about campsites gets trailer and data for season 2", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "004ac2cc3d", "cee1d3487e.jpg", "The official website for the anime adaptation of Horimiya has released the first trailer for the work. The video brings a little bit of history and how the protagonists met. The anime is scheduled to debut in January 2021.", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horimiya - Romantic comedy anime with unusual couple gets first trailer", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8d8d4b5798", "f1a7ac20e9.png", "The official website for the anime adaptation of Attack on Titan (Shingeki no Kyojin) has made a change to the preview for the anime's final season. In place of the confirmation for the October season, as it had been for almost the entire year, the site changed to a generic message saying 'scheduled to be broadcast on TV'.", new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Postponement confirmed? Attack on Titan final season has changed date on site", new DateTime(2020, 9, 21, 16, 21, 22, 579, DateTimeKind.Local).AddTicks(7171) },
                    { "90d39d40a0", "0d5dff3c46.jpg", "The official website of the anime adaptation of Jujutsu Kaisen has released a new trailer for the work. The video brings a little more history of the anime, featuring new characters and some of the action scenes of the work, as well as giving a preview of the opening 'Kaikai Kitan', sung by Eve. The anime is scheduled to debut on the 2nd of October.", new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "September 19, 2020Jujutsu Kaisen - Supernatural action anime gets action trailer with OP", new DateTime(2020, 9, 21, 16, 21, 22, 592, DateTimeKind.Local).AddTicks(9817) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notices");
        }
    }
}
