using DRAGONSTavern.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DRAGONSTavern.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Notice> Notices { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notice>().HasData(new Notice[]
            {
                new Notice("Tonikawa - Romance about teenagers who marry out of nowhere gets trailer with OP and date",@"# Tonikawa - Romance about teenagers who marry out of nowhere gets trailer with OP and date Crunchyroll today released a new video for the anime adaptation of Tonikaku Kawaii (Fly Me to The Moon). The trailer brings new details of the story, besides giving a preview of the opening “Koi no Uta”, sung by Akari Kitou (voice actress of the protagonist). The anime is scheduled to debut on October 2.",DateTime.Parse("02-05-2020"),DateTime.Parse("03-05-2020"),"1ae054383e.jpg","e13dc5d4ac"),
                new Notice("Yuru Camp - Popular anime about campsites gets trailer and data for season 2",@"The official website of the anime adaptation of Yuru Camp has released a trailer for the work. The video brings some scenes in the new season, featuring new characters and situations in which the protagonists find themselves. The anime is scheduled to debut in January 2021.",DateTime.Parse("21-09-2020"),DateTime.Parse("21-09-2020"),"747a8b59de.jpg","372444c72a"),
                new Notice("Horimiya - Romantic comedy anime with unusual couple gets first trailer",@"The official website for the anime adaptation of Horimiya has released the first trailer for the work. The video brings a little bit of history and how the protagonists met. The anime is scheduled to debut in January 2021.",DateTime.Parse("21-09-2020"),DateTime.Parse("21-09-2020"),"cee1d3487e.jpg","004ac2cc3d"),
                new Notice("Postponement confirmed? Attack on Titan final season has changed date on site",@"The official website for the anime adaptation of Attack on Titan (Shingeki no Kyojin) has made a change to the preview for the anime's final season. In place of the confirmation for the October season, as it had been for almost the entire year, the site changed to a generic message saying 'scheduled to be broadcast on TV'.",DateTime.Parse("18-09-2020"),DateTime.Now,"f1a7ac20e9.png","8d8d4b5798"),
                new Notice("September 19, 2020Jujutsu Kaisen - Supernatural action anime gets action trailer with OP",@"The official website of the anime adaptation of Jujutsu Kaisen has released a new trailer for the work. The video brings a little more history of the anime, featuring new characters and some of the action scenes of the work, as well as giving a preview of the opening 'Kaikai Kitan', sung by Eve. The anime is scheduled to debut on the 2nd of October.",DateTime.Parse("19-09-2020"),DateTime.Now,"0d5dff3c46.jpg","90d39d40a0")
            });

            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User("email@admin.com","admin","cu20awb50q"),
                new User("email@root.com","root","3js7zpr9ab")
            });
        }
    }
}
