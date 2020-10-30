using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPISample.Migrations
{
    public partial class intial6 : Migration
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
                    { 1, null, "Martin Scorsese", "Drama", null, null, null, "The Departed", null },
                    { 2, null, "Christopher Nolan", "Drama", null, null, null, "The Dark Knight", null },
                    { 3, null, "Christopher Nolan", "Drama", null, null, null, "Inception", null },
                    { 4, null, "David Gordon Green", "Comedy", null, null, null, "Pineapple Express", null },
                    { 5, null, "John McTiernan", "Action", null, null, null, "Die Hard", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
