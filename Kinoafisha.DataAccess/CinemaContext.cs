using Microsoft.EntityFrameworkCore;

namespace Kinoafisha.DataAccess
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        public DbSet<Models.Film> Films { get; set; }
        public DbSet<Models.FilmRole> FilmRoles { get; set; }
        public DbSet<Models.Genre> Genres { get; set; }
        public DbSet<Models.Entity> Entities { get; set; }
        public DbSet<Models.Country> Countries { get; set; }
        public DbSet<Models.FilmGenre> FilmGenres { get; set; }
        public DbSet<Models.FilmCountry> FilmCountries { get; set; }
        public DbSet<Models.FilmRoleFilm> FilmRoleFilms { get; set; }
        public DbSet<Models.Cinema> Cinemas { get; set; }
        public DbSet<Models.CinemaHall> CinemaHalls { get; set; }
        public DbSet<Models.City> Cities { get; set; }
        public DbSet<Models.Session> Sessions { get; set; }
        public DbSet<Models.Image> Images { get; set; }
        public DbSet<Models.Person> People { get; set; }
        public DbSet<Models.FilmRolePerson> FilmRolePeople { get; set; }
        public DbSet<Models.FilmPerson> FilmPeople { get; set; }
        public DbSet<Models.Seat> Seats { get; set; }
        public DbSet<Models.Ticket> Tickets { get; set; }
        public DbSet<Models.Visitor> Visitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.FilmGenre>()
                .HasKey(fg => new { fg.FilmId, fg.GenreId });

            modelBuilder.Entity<Models.FilmCountry>()
                .HasKey(fc => new { fc.FilmId, fc.CountryId });

            modelBuilder.Entity<Models.FilmRoleFilm>()
                .HasKey(frf => new { frf.FilmId, frf.FilmRoleId });

            modelBuilder.Entity<Models.FilmRolePerson>()
                .HasKey(frp => new { frp.FilmRoleId, frp.PersonId });

            modelBuilder.Entity<Models.FilmPerson>()
                .HasKey(fp => new { fp.FilmId, fp.PersonId });

            modelBuilder.Entity<Models.Genre>()
                .HasData(new Models.Genre { GenreId = 1, Name = "Action" },
                         new Models.Genre { GenreId = 2, Name = "Adventure" },
new Models.Genre { GenreId = 3, Name = "Comedy" },
new Models.Genre { GenreId = 4, Name = "Crime" },
new Models.Genre { GenreId = 5, Name = "Drama" },
new Models.Genre { GenreId = 6, Name = "Fantasy" },
new Models.Genre { GenreId = 7, Name = "Historical" },
new Models.Genre { GenreId = 8, Name = "Horror" },
new Models.Genre { GenreId = 9, Name = "Mystery" },
new Models.Genre { GenreId = 10, Name = "Romance" },
new Models.Genre { GenreId = 11, Name = "Science Fiction" },
new Models.Genre { GenreId = 12, Name = "Thriller" },
new Models.Genre { GenreId = 13, Name = "Western" }
);
            modelBuilder.Entity<Models.Country>()
                    .HasData(new Models.Country { CountryId = 1, Name = "USA" },
new Models.Country { CountryId = 2, Name = "UK" },
new Models.Country { CountryId = 3, Name = "France" },
new Models.Country { CountryId = 4, Name = "Germany" },
new Models.Country { CountryId = 5, Name = "Italy" },
new Models.Country { CountryId = 6, Name = "Spain" },
new Models.Country { CountryId = 7, Name = "Russia" },
new Models.Country { CountryId = 8, Name = "China" },
new Models.Country { CountryId = 9, Name = "Japan" },
new Models.Country { CountryId = 10, Name = "India" },
new Models.Country { CountryId = 11, Name = "Canada" },
new Models.Country { CountryId = 12, Name = "Australia" },
new Models.Country { CountryId = 13, Name = "Brazil" },
new Models.Country { CountryId = 14, Name = "Mexico" },
new Models.Country { CountryId = 15, Name = "South Korea" },
new Models.Country { CountryId = 16, Name = "Argentina" },
new Models.Country { CountryId = 17, Name = "Sweden" },
new Models.Country { CountryId = 18, Name = "Norway" },
new Models.Country { CountryId = 19, Name = "Denmark" },
new Models.Country { CountryId = 20, Name = "Finland" },
new Models.Country { CountryId = 21, Name = "Netherlands" },
new Models.Country { CountryId = 22, Name = "Belgium" },
new Models.Country { CountryId = 23, Name = "Austria" },
new Models.Country { CountryId = 24, Name = "Switzerland" },
new Models.Country { CountryId = 25, Name = "Poland" },
new Models.Country { CountryId = 26, Name = "Czech Republic" },
new Models.Country { CountryId = 27, Name = "Hungary" },
new Models.Country { CountryId = 28, Name = "Ukraine" }

    );

            modelBuilder.Entity<Models.City>()
                .HasData(new Models.City { CityId = 1, Name = "New York", CountryId = 1 },
new Models.City { CityId = 2, Name = "Rivne", CountryId = 28 },
new Models.City { CityId = 3, Name = "Los Angeles", CountryId = 1 },
new Models.City { CityId = 4, Name = "Chicago", CountryId = 1 },
new Models.City { CityId = 5, Name = "Houston", CountryId = 1 },
new Models.City { CityId = 6, Name = "Philadelphia", CountryId = 1 },
new Models.City { CityId = 7, Name = "Phoenix", CountryId = 1 },
new Models.City { CityId = 8, Name = "San Antonio", CountryId = 1 },
new Models.City { CityId = 9, Name = "San Diego", CountryId = 1 },
new Models.City { CityId = 10, Name = "Dallas", CountryId = 1 },
new Models.City { CityId = 11, Name = "San Jose", CountryId = 1 },
new Models.City { CityId = 12, Name = "Austin", CountryId = 1 },
new Models.City { CityId = 13, Name = "Jacksonville", CountryId = 1 },
new Models.City { CityId = 14, Name = "Indianapolis", CountryId = 1 },
new Models.City { CityId = 15, Name = "San Francisco", CountryId = 1 },
new Models.City { CityId = 16, Name = "Columbus", CountryId = 1 },
new Models.City { CityId = 17, Name = "Fort Worth", CountryId = 1 },
new Models.City { CityId = 18, Name = "Charlotte", CountryId = 1 },
new Models.City { CityId = 19, Name = "Detroit", CountryId = 1 },
new Models.City { CityId = 20, Name = "El Paso", CountryId = 1 },
new Models.City { CityId = 21, Name = "Memphis", CountryId = 1 },
new Models.City { CityId = 22, Name = "Boston", CountryId = 1 },
new Models.City { CityId = 23, Name = "Seattle", CountryId = 1 },
new Models.City { CityId = 24, Name = "Denver", CountryId = 1 },
new Models.City { CityId = 25, Name = "Washington", CountryId = 1 },
new Models.City { CityId = 26, Name = "Nashville", CountryId = 1 },
new Models.City { CityId = 27, Name = "Baltimore", CountryId = 1 },
new Models.City { CityId = 28, Name = "Louisville", CountryId = 1 },
new Models.City { CityId = 29, Name = "Portland", CountryId = 1 },
new Models.City { CityId = 30, Name = "Oklahoma City", CountryId = 1 },
new Models.City { CityId = 31, Name = "Milwaukee", CountryId = 1 },
new Models.City { CityId = 32, Name = "Las Vegas", CountryId = 1 },
new Models.City { CityId = 33, Name = "Albuquerque", CountryId = 1 },
new Models.City { CityId = 34, Name = "Tucson", CountryId = 1 },
new Models.City { CityId = 35, Name = "Fresno", CountryId = 1 },
new Models.City { CityId = 36, Name = "Sacramento", CountryId = 1 },
new Models.City { CityId = 37, Name = "Long Beach", CountryId = 1 },
new Models.City { CityId = 38, Name = "Kansas City", CountryId = 1 },
new Models.City { CityId = 39, Name = "Mesa", CountryId = 1 },
new Models.City { CityId = 40, Name = "Virginia Beach", CountryId = 1 },
new Models.City { CityId = 41, Name = "Atlanta", CountryId = 1 },
new Models.City { CityId = 42, Name = "Colorado Springs", CountryId = 1 },
new Models.City { CityId = 43, Name = "Omaha", CountryId = 1 },
new Models.City { CityId = 44, Name = "Raleigh", CountryId = 1 },
new Models.City { CityId = 45, Name = "Miami", CountryId = 1 },
new Models.City { CityId = 46, Name = "Oakland", CountryId = 1 },
new Models.City { CityId = 47, Name = "Minneapolis", CountryId = 1 },
new Models.City { CityId = 48, Name = "Tulsa", CountryId = 1 },
new Models.City { CityId = 49, Name = "Cleveland", CountryId = 1 },
new Models.City { CityId = 50, Name = "Wichita", CountryId = 1 },
new Models.City { CityId = 51, Name = "Arlington", CountryId = 1 },
new Models.City { CityId = 52, Name = "New Orleans", CountryId = 1 },
new Models.City { CityId = 53, Name = "Bakersfield", CountryId = 1 },
new Models.City { CityId = 54, Name = "Tampa", CountryId = 1 },
new Models.City { CityId = 55, Name = "Honolulu", CountryId = 1 },
new Models.City { CityId = 56, Name = "Aurora", CountryId = 1 },
new Models.City { CityId = 57, Name = "Anaheim", CountryId = 1 },
new Models.City { CityId = 58, Name = "Santa Ana", CountryId = 1 },
new Models.City { CityId = 59, Name = "St. Louis", CountryId = 1 });

            modelBuilder.Entity<Models.Cinema>()
.HasData(new Models.Cinema { CinemaId = 1, Name = "Multiplex", CityId = 1, Address = "Times Square", Description = "The best cinema in the world", Phone = "+1 234 567 89 00", Site = "https://multiplex.com" },
new Models.Cinema { CinemaId = 2, Name = "Rivne Plaza", CityId = 2, Address = "Soborna 12", Description = "The best cinema in Rivne", Phone = "+380 67 123 45 67", Site = "https://rivneplaza.com" },
new Models.Cinema { CinemaId = 3, Name = "Cinema City", CityId = 3, Address = "Hollywood Blvd", Description = "The best cinema in Los Angeles", Phone = "+1 234 567 89 00", Site = "https://cinemacity.com" },
new Models.Cinema { CinemaId = 4, Name = "AMC", CityId = 3, Address = "Sunset Blvd", Description = "The best cinema in Los Angeles", Phone = "+1 234 567 89 00", Site = "https://amc.com" },
new Models.Cinema { CinemaId = 5, Name = "Cinemark", CityId = 3, Address = "Santa Monica Blvd", Description = "The best cinema in Los Angeles", Phone = "+1 234 567 89 00", Site = "https://cinemark.com" },
new Models.Cinema { CinemaId = 6, Name = "Regal", CityId = 3, Address = "Wilshire Blvd", Description = "The best cinema in Los Angeles", Phone = "+1 234 567 89 00", Site = "https://regal.com" },
new Models.Cinema { CinemaId = 7, Name = "Cineworld", CityId = 2, Address = "Soborna 12", Description = "The best cinema in Rivne", Phone = "+380 67 123 45 67", Site = "https://cineworld.com" },
new Models.Cinema { CinemaId = 8, Name = "Odeon", CityId = 2, Address = "Soborna 12", Description = "The best cinema in Rivne", Phone = "+380 67 123 45 67", Site = "https://odeon.com" },
new Models.Cinema { CinemaId = 9, Name = "Vue", CityId = 2, Address = "Soborna 12", Description = "The best cinema in Rivne", Phone = "+380 67 123 45 67", Site = "https://vue.com" },
new Models.Cinema { CinemaId = 10, Name = "Gaumont", CityId = 2, Address = "Soborna 12", Description = "The best cinema in Rivne", Phone = "+380 67 123 45 67", Site = "https://gaumont.com" },
new Models.Cinema { CinemaId = 11, Name = "Pathe", CityId = 2, Address = "Soborna 12", Description = "The best cinema in Rivne", Phone = "+380 67 123 45 67", Site = "https://pathe.com" },
new Models.Cinema { CinemaId = 12, Name = "Kinoplex", CityId = 2, Address = "Soborna 12", Description = "The best cinema in Rivne", Phone = "+380 67 123 45 67", Site = "https://kinoplex.com" },
new Models.Cinema { CinemaId = 13, Name = "Cinepolis", CityId = 3, Address = "Hollywood Blvd", Description = "The best cinema in Los Angeles", Phone = "+1 234 567 89 00", Site = "https://cinepolis.com" },
new Models.Cinema { CinemaId = 14, Name = "Cineplex", CityId = 3, Address = "Hollywood Blvd", Description = "The best cinema in Los Angeles", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 15, Name = "Landmark", CityId = 4, Address = "Michigan Ave", Description = "The best cinema in Chicago", Phone = "+1 234 567 89 00", Site = "https://landmark.com" },
new Models.Cinema { CinemaId = 16, Name = "Showplace", CityId = 5, Address = "Main St", Description = "The best cinema in Houston", Phone = "+1 234 567 89 00", Site = "https://showplace.com" },
new Models.Cinema { CinemaId = 17, Name = "Ritz", CityId = 6, Address = "Market St", Description = "The best cinema in Philadelphia", Phone = "+1 234 567 89 00", Site = "https://ritz.com" },
new Models.Cinema { CinemaId = 18, Name = "Harkins", CityId = 7, Address = "Main St", Description = "The best cinema in Phoenix", Phone = "+1 234 567 89 00", Site = "https://harkins.com" },
new Models.Cinema { CinemaId = 19, Name = "Alamo", CityId = 8, Address = "Main St", Description = "The best cinema in San Antonio", Phone = "+1 234 567 89 00", Site = "https://alamo.com" },
new Models.Cinema { CinemaId = 20, Name = "Angelika", CityId = 9, Address = "Main St", Description = "The best cinema in San Diego", Phone = "+1 234 567 89 00", Site = "https://angelika.com" },
new Models.Cinema { CinemaId = 21, Name = "Arclight", CityId = 10, Address = "Main St", Description = "The best cinema in Dallas", Phone = "+1 234 567 89 00", Site = "https://arclight.com" },
new Models.Cinema { CinemaId = 22, Name = "Cineplex", CityId = 11, Address = "Main St", Description = "The best cinema in San Jose", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 23, Name = "Cineplex", CityId = 12, Address = "Main St", Description = "The best cinema in Austin", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 24, Name = "Cineplex", CityId = 13, Address = "Main St", Description = "The best cinema in Jacksonville", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 25, Name = "Cineplex", CityId = 14, Address = "Main St", Description = "The best cinema in Indianapolis", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 26, Name = "Cineplex", CityId = 15, Address = "Main St", Description = "The best cinema in San Francisco", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 27, Name = "Cineplex", CityId = 16, Address = "Main St", Description = "The best cinema in Columbus", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 28, Name = "Cineplex", CityId = 17, Address = "Main St", Description = "The best cinema in Fort Worth", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 29, Name = "Cineplex", CityId = 18, Address = "Main St", Description = "The best cinema in Charlotte", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 30, Name = "Cineplex", CityId = 19, Address = "Main St", Description = "The best cinema in Detroit", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" },
new Models.Cinema { CinemaId = 31, Name = "Cineplex", CityId = 20, Address = "Main St", Description = "The best cinema in El Paso", Phone = "+1 234 567 89 00", Site = "https://cineplex.com" }


                );

            modelBuilder.Entity<Models.CinemaHall>()
                .HasData(new Models.CinemaHall { CinemaHallId = 1, Name = "Hall 1", CinemaId = 1, SeatsCount = 100 },
                new Models.CinemaHall { CinemaHallId = 2, Name = "Hall 2", CinemaId = 1, SeatsCount = 150 },
                new Models.CinemaHall { CinemaHallId = 3, Name = "Hall 3", CinemaId = 1, SeatsCount = 200 },
                new Models.CinemaHall { CinemaHallId = 4, Name = "Hall 1", CinemaId = 2, SeatsCount = 100 },
                new Models.CinemaHall { CinemaHallId = 5, Name = "Hall 2", CinemaId = 2, SeatsCount = 150 },
                new Models.CinemaHall { CinemaHallId = 6, Name = "Hall 3", CinemaId = 2, SeatsCount = 200 },
                new Models.CinemaHall { CinemaHallId = 7, Name = "Hall 1", CinemaId = 3, SeatsCount = 100 },
                new Models.CinemaHall { CinemaHallId = 8, Name = "Hall 2", CinemaId = 3, SeatsCount = 150 },
                new Models.CinemaHall { CinemaHallId = 9, Name = "Hall 3", CinemaId = 3, SeatsCount = 200 },
                new Models.CinemaHall { CinemaHallId = 10, Name = "Hall 1", CinemaId = 4, SeatsCount = 100 },
                new Models.CinemaHall { CinemaHallId = 11, Name = "Hall 2", CinemaId = 4, SeatsCount = 150 },
                new Models.CinemaHall { CinemaHallId = 12, Name = "Hall 3", CinemaId = 4, SeatsCount = 200 },
                new Models.CinemaHall { CinemaHallId = 13, Name = "Hall 1", CinemaId = 5, SeatsCount = 100 },
                new Models.CinemaHall { CinemaHallId = 14, Name = "Hall 2", CinemaId = 5, SeatsCount = 150 },
                new Models.CinemaHall { CinemaHallId = 15, Name = "Hall 3", CinemaId = 5, SeatsCount = 200 },
                new Models.CinemaHall { CinemaHallId = 16, Name = "Hall 1", CinemaId = 6, SeatsCount = 100 },
                new Models.CinemaHall { CinemaHallId = 17, Name = "Hall 2", CinemaId = 6, SeatsCount = 150 }


                );

            modelBuilder.Entity<Models.Session>()
                .HasData(new Models.Session { SessionId = 1, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 1, 10, 0, 0), Price = 10 },
                               new Models.Session { SessionId = 2, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 1, 12, 0, 0), Price = 10 },
                                              new Models.Session { SessionId = 3, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 1, 14, 0, 0), Price = 10 },
                                                             new Models.Session { SessionId = 4, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 1, 16, 0, 0), Price = 10 },
                                                                            new Models.Session { SessionId = 5, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 1, 18, 0, 0), Price = 10 },
                                                                                           new Models.Session { SessionId = 6, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 1, 20, 0, 0), Price = 10 },
                                                                                                          new Models.Session { SessionId = 7, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 1, 22, 0, 0), Price = 10 },
                                                                                                                         new Models.Session { SessionId = 8, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 2, 10, 0, 0), Price = 10 },
                                                                                                                                        new Models.Session { SessionId = 9, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 2, 12, 0, 0), Price = 10 },
                                                                                                                                                       new Models.Session { SessionId = 10, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 2, 14, 0, 0), Price = 10 },
                                                                                                                                                                      new Models.Session { SessionId = 11, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 2, 16, 0, 0), Price = 10 },
                                                                                                                                                                     new Models.Session { SessionId = 12, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 2, 18, 0, 0), Price = 10 },
                                                                                                                                                                    new Models.Session { SessionId = 13, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 2, 20, 0, 0), Price = 10 },
                                                                                                                                                                   new Models.Session { SessionId = 14, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 2, 22, 0, 0), Price = 10 },
                                                                                                                                                                  new Models.Session { SessionId = 15, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 3, 10, 0, 0), Price = 10 },
                                                                                                                                                                 new Models.Session { SessionId = 16, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 3, 12, 0, 0), Price = 10 },
                                                                                                                                                                new Models.Session { SessionId = 17, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 3, 14, 0, 0), Price = 10 },
                                                                                                                                                               new Models.Session { SessionId = 18, FilmId = 1, CinemaHallId = 1, Date = new DateTime(2021, 1, 3, 16, 0, 0), Price = 10 });

                         modelBuilder.Entity<Models.Seat>()
                  .HasData(new Models.Seat { SeatId = 1, Number = 1, Row = 1, CinemaHallId = 1 },
                            new Models.Seat { SeatId = 2, Number = 2, Row = 1, CinemaHallId = 1 },
                            new Models.Seat { SeatId = 3, Number = 3, Row = 1, CinemaHallId = 1 },
                            new Models.Seat { SeatId = 4, Number = 4, Row = 1, CinemaHallId = 1 },
                            new Models.Seat { SeatId = 5, Number = 5, Row = 1, CinemaHallId = 1 },
                            new Models.Seat { SeatId = 6, Number = 6, Row = 1, CinemaHallId = 1 },
                            new Models.Seat { SeatId = 7, Number = 7, Row = 1, CinemaHallId = 1 },
                            // Add seats for other CinemaHalls here
                            new Models.Seat { SeatId = 8, Number = 1, Row = 1, CinemaHallId = 2 },
                            new Models.Seat { SeatId = 9, Number = 2, Row = 1, CinemaHallId = 2 },
                            new Models.Seat { SeatId = 10, Number = 3, Row = 1, CinemaHallId = 2 },
                            // Add seats for other CinemaHalls here
                            new Models.Seat { SeatId = 21, Number = 1, Row = 1, CinemaHallId = 3 },
                            new Models.Seat { SeatId = 22, Number = 2, Row = 1, CinemaHallId = 3 },
                            new Models.Seat { SeatId = 23, Number = 3, Row = 1, CinemaHallId = 3 }
                            // Add seats for other CinemaHalls here
                  );

            modelBuilder.Entity<Models.Entity>()
                .HasData(new Models.Entity { EntityId = 1, Name = "Film" },
                new Models.Entity { EntityId = 2, Name = "FilmRole" },
                new Models.Entity { EntityId = 3, Name = "Genre" },
                new Models.Entity { EntityId = 4, Name = "Country" },
                new Models.Entity { EntityId = 5, Name = "Person" },
                new Models.Entity { EntityId = 6, Name = "Cinema" },
                new Models.Entity { EntityId = 7, Name = "CinemaHall" });

            modelBuilder.Entity<Models.Person>()
                .HasData(new Models.Person { PersonId = 1, Name = "Steven Spielberg", BirthDate = new DateTime(1946, 12, 18) },
                               new Models.Person { PersonId = 2, Name = "George Lucas", BirthDate = new DateTime(1944, 5, 14) },
                                              new Models.Person { PersonId = 3, Name = "Martin Scorsese", BirthDate = new DateTime(1942, 11, 17) },
                                                             new Models.Person { PersonId = 4, Name = "Quentin Tarantino", BirthDate = new DateTime(1963, 3, 27) },
                                                                            new Models.Person { PersonId = 5, Name = "Christopher Nolan", BirthDate = new DateTime(1970, 7, 30) },
                                                                                           new Models.Person { PersonId = 6, Name = "James Cameron", BirthDate = new DateTime(1954, 8, 16) },
                                                                                                          new Models.Person { PersonId = 7, Name = "Tim Burton", BirthDate = new DateTime(1958, 8, 25) },
                                                                                                                         new Models.Person { PersonId = 8, Name = "Ridley Scott", BirthDate = new DateTime(1937, 11, 30) },
                                                                                                                                        new Models.Person { PersonId = 9, Name = "David Fincher", BirthDate = new DateTime(1962, 8, 28) },
                                                                                                                                                       new Models.Person { PersonId = 10, Name = "Clint Eastwood", BirthDate = new DateTime(1930, 5, 31) },
                                                                                                                                                                      new Models.Person { PersonId = 11, Name = "Alfred Hitchcock", BirthDate = new DateTime(1899, 8, 13) },
                                                                                                                                                                                     new Models.Person { PersonId = 12, Name = "Stanley Kubrick", BirthDate = new DateTime(1928, 7, 26) },
                                                                                                                                                                                                    new Models.Person { PersonId = 13, Name = "Woody Allen", BirthDate = new DateTime(1935, 12, 1) },
                                                                                                                                                                                                                   new Models.Person { PersonId = 14, Name = "Spike Lee", BirthDate = new DateTime(1957, 3, 20) },
                                                                                                                                                                                                                                  new Models.Person { PersonId = 15, Name = "Francis Ford Coppola" });

            modelBuilder.Entity<Models.Film>()
                .HasData(new Models.Film { FilmId = 1, Title = "The Shawshank Redemption", Year = 1994, Duration = 142, Description = "Two imprisoned", Rating = 9.3m, DirectorId = 1 },
                new Models.Film { FilmId = 2, Title = "The Godfather", Year = 1972, Duration = 175, Description = "The aging patriarch", Rating = 9.2m, DirectorId = 15 },
                                                 new Models.Film { FilmId = 3, Title = "The Dark Knight", Year = 2008, Duration = 152, Description = "When the menace", Rating = 9.0m, DirectorId = 5 },
                                                                 new Models.Film { FilmId = 4, Title = "12 Angry", Year = 1957, Duration = 96, Description = "The defense", Rating = 8.9m, DirectorId = 12 },
                                                                                new Models.Film { FilmId = 5, Title = "Schindler's List", Year = 1993, Duration = 195, Description = "Oskar Schindler", Rating = 8.9m, DirectorId = 1 },
                                                                                               new Models.Film { FilmId = 6, Title = "The Lord of the Rings", Year = 2003, Duration = 201, Description = "The former Fellowship", Rating = 8.9m, DirectorId = 15 },
                                                                                              new Models.Film { FilmId = 7, Title = "Pulp Fiction", Year = 1994, Duration = 154, Description = "The lives of two", Rating = 8.9m, DirectorId = 4 },
                                                                                              new Models.Film { FilmId = 8, Title = "The Lord of the Rings", Year = 2001, Duration = 178, Description = "An ancient Ring", Rating = 8.8m, DirectorId = 15 },
                                                                                              new Models.Film { FilmId = 9, Title = "The Good, the Bad", Year = 1966, Duration = 161, Description = "Blondie (The Good)", Rating = 8.8m, DirectorId = 15 },
                                                                                              new Models.Film { FilmId = 10, Title = "Forrest Gump", Year = 1994, Duration = 142, Description = "Forrest Gump", Rating = 8.8m, DirectorId = 1 },
                                                                                              new Models.Film { FilmId = 11, Title = "Inception", Year = 2010, Duration = 148, Description = "Dom Cobb", Rating = 8.8m, DirectorId = 5 },
                                                                                              new Models.Film { FilmId = 12, Title = "The Lord of the Rings", Year = 2002, Duration = 179, Description = "While Frodo", Rating = 8.7m, DirectorId = 15 },
                                                                                              new Models.Film { FilmId = 13, Title = "The Matrix", Year = 1999, Duration = 136, Description = "Thomas A. Anderson", Rating = 8.7m, DirectorId = 15 },
                                                                                              new Models.Film { FilmId = 14, Title = "Goodfellas", Year = 1990, Duration = 146, Description = "Henry Hill", Rating = 8.7m, DirectorId = 3 },
                                                                                              new Models.Film { FilmId = 15, Title = "One Flew Over the Cuckoo's Nest", Year = 1975, Duration = 133, Description = "McMurphy", Rating = 8.7m, DirectorId = 15 },
                                                                                              new Models.Film { FilmId = 16, Title = "Seven Samurai", Year = 1954, Duration = 207, Description = "A veteran samurai", Rating = 8.6m, DirectorId = 15 },
                                                                                              new Models.Film { FilmId = 17, Title = "Se7en", Year = 1995, Duration = 127, Description = "A film about two", Rating = 8.6m, DirectorId = 9 });





                }



    }

}
