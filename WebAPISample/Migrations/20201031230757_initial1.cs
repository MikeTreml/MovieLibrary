using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPISample.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Actors = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Actors", "Director", "Genre", "ImageURL", "Rating", "Summary", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "", "Martin Scorsese", "Drama", "https://i.pinimg.com/originals/86/f9/d1/86f9d1a47d81531f1e12e343d7a6ae0e.png", "", "", "The Departed", "" },
                    { 2, "", "Christopher Nolan", "Drama", "https://i.pinimg.com/originals/28/1d/03/281d03d7e0fae42cf27ebf513c00c6eb.jpg", "", "", "The Dark Knight", "" },
                    { 3, "", "Christopher Nolan", "Drama", "https://i.pinimg.com/originals/77/bb/6d/77bb6d11954d639e10affff6565b213a.jpg", "", "", "Inception", "" },
                    { 4, "", "David Gordon Green", "Comedy", "https://i.pinimg.com/originals/8c/f2/4a/8cf24aa1b78365ea504eb5948470bfd4.jpg", "", "", "Pineapple Express", "" },
                    { 5, "", "John McTiernan", "Action", "https://2.bp.blogspot.com/-LrHDd4vdHHw/Tw6fI1XEoRI/AAAAAAAAAPY/ov2jgvNQt4k/w1200-h630-p-k-no-nu/poster-die-hard1resize.jpg", "", "", "Die Hard", "" },
                    { 6, "", "", "", "", "", "", "", "" },
                    { 7, "", "", "", "", "", "", "", "" },
                    { 8, "", "", "", "", "", "", "", "" },
                    { 9, "", "", "", "", "", "", "", "" },
                    { 10, "", "", "", "", "", "", "", "" },
                    { 11, "", "", "", "", "", "", "", "" },
                    { 12, "", "", "", "", "", "", "", "" },
                    { 13, "", "", "", "", "", "", "", "" },
                    { 14, "", "", "", "", "", "", "", "" },
                    { 15, "", "", "", "", "", "", "", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
