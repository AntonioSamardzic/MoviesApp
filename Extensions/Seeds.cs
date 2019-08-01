using System;
using Microsoft.EntityFrameworkCore;
using Projekt.Models;

namespace Projekt.Extensions
{
    public static class Seeds
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Actors(modelBuilder);
            Boughts(modelBuilder);
            Companies(modelBuilder);
            Engagements(modelBuilder);
            Movies(modelBuilder);
            MovieTypes(modelBuilder);
            Users(modelBuilder);
        }

    
        public static void Actors(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().HasData(new Actor()
            {
                Id = 1,
                FirstName = "Toby",
                LastName = "guy"

            },
            new Actor()
            {
                Id = 2,
                FirstName = "Viggo",
                LastName = "Mortensen"
            },
             new Actor()
            {
                Id = 3,
                FirstName = "Elijah",
                LastName = "Wood"
            },
             new Actor()
            {
                Id = 4,
                FirstName = "Sean",
                LastName = "Bean"
            },
             new Actor()
            {
                Id = 5,
                FirstName = "Orlando",
                LastName = "Bloom"
            }
        );

      
           
        
        }   

        public static void Boughts(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Bought>().HasData(new Bought()
                    {
                        Id = 1,
                        BoughtDate = DateTime.Parse ("2000-01-01"),
                        Price = 159.99m,
                        UserId = 1,
                        MovieId = 1
                    },

                    new Bought()
                    {
                        Id = 2,
                        BoughtDate = DateTime.Parse ("2018-02-01"),
                        Price = 159.99m,
                        UserId = 2,
                        MovieId = 2
                    },

                    new Bought()
                    {
                        Id = 3,
                        BoughtDate = DateTime.Parse ("2015-09-01"),
                        Price = 59.99m,
                        UserId = 3,
                        MovieId = 3
                    },

                    new Bought()
                    {
                        Id = 4,
                        BoughtDate = DateTime.Parse ("2019-01-01"),
                        Price = 9.99m,
                        UserId = 4,
                        MovieId = 4
                    }
                );
            }
        
        public static void Companies(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Company>().HasData(new Company()
                    {
                        Id = 1,
                        Name = "Presidental",
                        Address = "Pres CA",
                        PhoneNumber = "09809768",
                        URL = "www.presidental.com"
                    },

                    new Company()
                    {
                        Id = 2,
                        Name = "Warner Bros",
                        Address = "WB CA",
                        PhoneNumber = "09509768",
                        URL = "www.WB.com"
                    },

                    new Company()
                    {
                        Id = 3,
                        Name = "Universal",
                        Address = "Uni CA",
                        PhoneNumber = "0209768",
                        URL = "www.Universal.com"
                    },

                    new Company()
                    {
                        Id = 4,
                        Name = "Walt Disney",
                        Address = "WD CA",
                        PhoneNumber = "009768",
                        URL = "www.WD.com"
                    }
                );
            }

            public static void Engagements(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Engagement>().HasData(new Engagement()
                    {
                        Id = 1,
                        Started = DateTime.Parse ("2002-01-02"),
                        Ended = DateTime.Parse ("2003-01-02"),
                        Fee = 4999999.99m,
                        ActorId = 1,
                        MovieId = 1
                    },

                    new Engagement()
                    {
                        Id = 2,
                        Started = DateTime.Parse ("2014-01-02"),
                        Ended = DateTime.Parse ("2015-01-02"),
                        Fee = 29999.99m,
                        ActorId = 2,
                        MovieId = 2
                    },

                    new Engagement()
                    {
                        Id = 3,
                        Started = DateTime.Parse ("2013-05-02"),
                        Ended = DateTime.Parse ("2014-05-02"),
                        Fee = 559999.99m,
                        ActorId = 3,
                        MovieId = 3
                    },

                    new Engagement()
                    {
                        Id = 4,
                        Started = DateTime.Parse ("2005-01-02"),
                        Ended = DateTime.Parse ("2012-01-02"),
                        Fee = 499999.99m,
                        ActorId = 4,
                        MovieId = 4
                    }
                );
            }

            public static void Movies(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Movie>().HasData(new Movie()
                    {
                        Id = 1,
                        Name = "GodFather",
                        ReleaseDate = DateTime.Parse ("1974-09-08"),
                        Price = 99.99m,
                        Producent = "Albert S. Ruddy",
                        CompanyId = 1,
                        MovieTypeId = 1,
                        Description = "Kum (eng. The Godfather) je kriminalistička drama Francisa Forda Coppole temeljena na istoimenom romanu Maria Puza. U glavnim ulogama pojavljuju se Marlon Brando, Al Pacino, Robert Duvall, Diane Keaton i James Caan. Radnja filma proteže se na deset godina od kraja 1945. do 1955. te predstavlja kronologiju mafijaške obitelji Corleone."
                    },

                    new Movie()
                    {
                        Id = 2,
                        Name = "Lord Of The Rings",
                        ReleaseDate = DateTime.Parse ("2001-02-08"),
                        Price = 199.99m,
                        Producent = "Peter Jackson",
                        CompanyId = 2,
                        MovieTypeId = 2,
                        Description = "Best movie ever"
                    },

                    new Movie()
                    {
                        Id = 3,
                        Name = "Interstellar",
                        ReleaseDate = DateTime.Parse ("2015-01-09"),
                        Price = 49.99m,
                        Producent = "John Wayne",
                        CompanyId = 3,
                        MovieTypeId = 2,
                        Description = "mind fuck movie"
                    },

                    new Movie()
                    {
                        Id = 4,
                        Name = "Ride Along",
                        ReleaseDate = DateTime.Parse ("2014-01-05"),
                        Price = 29.99m,
                        Producent = "Don Jackobs",
                        CompanyId = 4,
                        MovieTypeId = 5,
                        Description = "funny movie"
                    }
                );
    
            }

            public static void MovieTypes(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<MovieType>().HasData(new MovieType()
                    {
                        Id = 1,
                        Genre = "Action"
                    },

                    new MovieType()
                    {
                        Id = 2,
                        Genre = "Fantasy"
                    },

                    new MovieType()
                    {
                        Id = 3,
                        Genre = "Drama"
                    },

                    new MovieType()
                    {
                        Id = 4,
                        Genre = "Documentary"
                    },

                    new MovieType()
                    {
                        Id = 5,
                        Genre = "Comedy"
                    }
                );
    
            }

            public static void Users(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().HasData(new User()
                    {
                        Id=1,
                        Email = "tinopiskovic@mail.com",
                        Card = "Membership",
                        FirstName ="Tino",
                        LastName = "Piskovic"
                    },

                    new User()
                    {
                        Id=2,
                        Email = "tinke@mail.com",
                        Card = "Membership",
                        FirstName ="Tinke",
                        LastName = "Stuban"
                    },

                    new User()
                    {
                        Id=3,
                        Email = "bkrajin@mail.com",
                        Card = "No-Membership",
                        FirstName ="Bruno",
                        LastName = "Krajinovic"
                    },

                    new User()
                    {
                        Id=4,
                        Email = "stelasipusic@mail.com",
                        Card = "Membership",
                        FirstName ="Stela",
                        LastName = "Sipusic"
                    },

                    new User()
                    {
                        Id=5,
                        Email = "antoniosamardzic@mail.com",
                        Card = "Membership",
                        FirstName ="Antonio",
                        LastName = "Samardzic"
                    }
                );
    
            }

    }

}
