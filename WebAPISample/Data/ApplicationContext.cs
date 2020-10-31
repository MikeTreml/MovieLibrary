using Microsoft.EntityFrameworkCore;
using WebAPISample.Models;

namespace WebAPISample.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>()
              .HasData(
                 new Movie { MovieId = 1, Title = "The Departed", Genre = "Drama", Director = "Martin Scorsese",ImageURL= "https://i.pinimg.com/originals/86/f9/d1/86f9d1a47d81531f1e12e343d7a6ae0e.png", Summary="",Year="",Actors="",Rating="" },
                 new Movie { MovieId = 2, Title = "The Dark Knight", Genre = "Drama", Director = "Christopher Nolan", ImageURL = "https://i.pinimg.com/originals/28/1d/03/281d03d7e0fae42cf27ebf513c00c6eb.jpg", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 3, Title = "Inception", Genre = "Drama", Director = "Christopher Nolan", ImageURL = "https://i.pinimg.com/originals/77/bb/6d/77bb6d11954d639e10affff6565b213a.jpg", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 4, Title = "Pineapple Express", Genre = "Comedy", Director = "David Gordon Green", ImageURL = "https://i.pinimg.com/originals/8c/f2/4a/8cf24aa1b78365ea504eb5948470bfd4.jpg", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 5, Title = "Die Hard", Genre = "Action", Director = "John McTiernan", ImageURL = "https://2.bp.blogspot.com/-LrHDd4vdHHw/Tw6fI1XEoRI/AAAAAAAAAPY/ov2jgvNQt4k/w1200-h630-p-k-no-nu/poster-die-hard1resize.jpg", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 6, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 7, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 8, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 9, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 10, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 11, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 12, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 13, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 14, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" },
                 new Movie { MovieId = 15, Title = "", Genre = "", Director = "", ImageURL = "", Summary = "", Year = "", Actors = "", Rating = "" }
                              );

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
