using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPISample.Migrations
{
    public partial class _2 : Migration
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
                    { 1, "Leonardo DiCaprio, Matt Damon, Mark Wahlberg, Jack Nicholson, Vera Farmiga", "Martin Scorsese", "Drama", "https://i.pinimg.com/originals/86/f9/d1/86f9d1a47d81531f1e12e343d7a6ae0e.png", "8.5", "South Boston cop Billy Costigan (Leonardo DiCaprio) goes under cover to infiltrate the organization of gangland chief Frank Costello (Jack Nicholson). As Billy gains the mobster's trust, a career criminal named Colin Sullivan (Matt Damon) infiltrates the police department and reports on its activities to his syndicate bosses. When both organizations learn they have a mole in their midst, Billy and Colin must figure out each other's identities to save their own lives.", "The Departed", "2006" },
                    { 2, "Christian Bale, Gary Oldman, Heath Ledger, Michael Caine, Morgan Freeman", "Christopher Nolan", "Drama", "https://i.pinimg.com/originals/28/1d/03/281d03d7e0fae42cf27ebf513c00c6eb.jpg", "9", "With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism.", "The Dark Knight", "2008" },
                    { 3, "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page, Tom Hardy, Cillian Murphy", "Christopher Nolan", "Drama", "https://i.pinimg.com/originals/77/bb/6d/77bb6d11954d639e10affff6565b213a.jpg", "8.8", "Dom Cobb (Leonardo DiCaprio) is a thief with the rare ability to enter people's dreams and steal their secrets from their subconscious. His skill has made him a hot commodity in the world of corporate espionage but has also cost him everything he loves. Cobb gets a chance at redemption when he is offered a seemingly impossible task: Plant an idea in someone's mind. If he succeeds, it will be the perfect crime, but a dangerous enemy anticipates Cobb's every move.", "Inception", "2010" },
                    { 4, "Seth Rogen, James Franco, Danny McBride, Amber Heard, Gary Cole", "David Gordon Green", "Comedy", "https://i.pinimg.com/originals/8c/f2/4a/8cf24aa1b78365ea504eb5948470bfd4.jpg", "2008", "Stoner Dale Denton's (Seth Rogen) enjoyment of a rare strain of marijuana may prove fatal when he drops his roach in a panic after witnessing a murder. Upon learning that the fancy weed can be traced back to them, Dale and his dealer (James Franco) go on the lam, with a dangerous drug lord (Gary Cole) and crooked cop (Rosie Perez) hot on their heels.", "Pineapple Express", "2008" },
                    { 5, "Bruce Willis, Alan Rickman, Bonnie Bedelia, Reginald VelJohnson, William Atherton", "John McTiernan", "Action", "https://2.bp.blogspot.com/-LrHDd4vdHHw/Tw6fI1XEoRI/AAAAAAAAAPY/ov2jgvNQt4k/w1200-h630-p-k-no-nu/poster-die-hard1resize.jpg", "8.2", "New York City policeman John McClane (Bruce Willis) is visiting his estranged wife (Bonnie Bedelia) and two daughters on Christmas Eve. He joins her at a holiday party in the headquarters of the Japanese-owned business she works for. But the festivities are interrupted by a group of terrorists who take over the exclusive high-rise, and everyone in it. Very soon McClane realizes that there's no one to save the hostages -- but him.", "Die Hard", "1988" },
                    { 6, "Mike Judge, Ron Livingston, Gary Cole, Jennifer Aniston, Stephen Root", "Mike Judge", "Comedy / Dark comedy ", "https://i.pinimg.com/originals/74/97/c9/7497c926fb7673de5e9e04f046f0715e.jpg", "7.7", "Corporate drone Peter Gibbons (Ron Livingston) hates his soul-killing job at software company Initech. While undergoing hypnotherapy, Peter is left in a blissful state when his therapist dies in the middle of their session. He refuses to work overtime, plays games at his desk and unintentionally charms two consultants into putting him on the management fast-track. When Peter's friends learn they're about to be downsized, they hatch a revenge plot against the company inspired by Superman III.", "Office Space", "1999" },
                    { 7, "Milla Jovovich, Bruce Willis, Gary Oldman, Chris Tucker, Ian Holm", "Luc Besson", "Action / Sci-fi ", "https://cdn.shopify.com/s/files/1/0969/9128/products/The_Fifth_Element_-_Luc_Besson_-_Tallenge_Hollywood_Minimalist_Movie_Poster_99b922a1-97ee-4f82-bfe9-97ffe30836ed.jpg?v=1549014210", "7.7", "In the 23rd century, a New York City cabbie, Korben Dallas (Bruce Willis), finds the fate of the world in his hands when Leeloo (Milla Jovovich) falls into his cab. As the embodiment of the fifth element, Leeloo needs to combine with the other four to keep the approaching Great Evil from destroying the world. Together with Father Vito Cornelius (Ian Holm) and zany broadcaster Ruby Rhod (Chris Tucker), Dallas must race against time and the wicked industrialist Zorg (Gary Oldman) to save humanity.", "The Fifth Element", "1997" },
                    { 8, "John Cusack, Minnie Driver, Dan Aykroyd, Joan Cusack, Jeremy Piven", "George Armitage", "Romance / Comedy", "https://i.etsystatic.com/5576899/r/il/46c3b7/1678388829/il_570xN.1678388829_fcgp.jpg", "7.3", "After assassin Martin Blank (John Cusack) has trouble focusing on his work, resulting in a failed assignment, he returns to his hometown, Grosse Point, Mich., for his 10-year high school reunion. There he meets Debi Newberry (Minnie Driver), an old girlfriend that he stood up for the prom. Martin's secretary (Joan Cusack) sets up a hit for him while he is in town, but Martin starts to reconsider his life. Meanwhile, he is hounded by an unstable rival hit man, Grocer (Dan Aykroyd).", "Grosse Pointe Blank", "1997" },
                    { 9, "Natalie Portman, Jean Reno, Gary Oldman, Danny Aiello, Michael Badalucco", "", "Action / Drama", "https://piecesofpaint.com/wp-content/uploads/2013/12/leon_the_professional_credits.jpg", "8.5", "Michael Badalucco", "The Professional", "1994" },
                    { 10, "Scarlett Johansson, Morgan Freeman, Amr Waked, Analeigh Tipton", "Luc Besson", "Thriller / Action", "https://i.pinimg.com/originals/e4/1c/7d/e41c7d86a30fc39e4532ea7dfe55e852.jpg", "6.4", "Lucy is a 2014 French science fiction action film written and directed by Luc Besson and produced by his wife Virginie Besson-Silla for his company EuropaCorp. It is an English-language film shot in Taipei, Paris, and New York City. It stars Scarlett Johansson, Morgan Freeman, Choi Min-sik, and Amr Waked.", "Lucy", "2014" },
                    { 11, "David Bowie, Jennifer Connelly ", "Jim Henson", "Fantasy/Musical ", "https://i.imgur.com/UQ8Fz.jpg", "7.4", "Teenage Sarah (Jennifer Connelly) journeys through a maze to recover her baby brother (Toby Froud) from a goblin king (David Bowie).", "Labyrinth", "1986" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
