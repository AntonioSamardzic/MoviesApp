﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt;

namespace Projekt.Migrations
{
    [DbContext(typeof(ProjektContext))]
    [Migration("20190827110121_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Projekt.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 15, DateTimeKind.Utc).AddTicks(7893),
                            FirstName = "Toby",
                            IsDeleted = false,
                            LastName = "guy"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 16, DateTimeKind.Utc).AddTicks(216),
                            FirstName = "Viggo",
                            IsDeleted = false,
                            LastName = "Mortensen"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 16, DateTimeKind.Utc).AddTicks(232),
                            FirstName = "Elijah",
                            IsDeleted = false,
                            LastName = "Wood"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 16, DateTimeKind.Utc).AddTicks(237),
                            FirstName = "Sean",
                            IsDeleted = false,
                            LastName = "Bean"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 16, DateTimeKind.Utc).AddTicks(237),
                            FirstName = "Orlando",
                            IsDeleted = false,
                            LastName = "Bloom"
                        });
                });

            modelBuilder.Entity("Projekt.Models.AuthUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Card")
                        .IsRequired();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            Card = "Membership",
                            ConcurrencyStamp = "66f580cb-6384-454f-9ec4-24cdba48e727",
                            Email = "tinopiskovic@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Tino",
                            LastName = "Piskovic",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            Card = "Membership",
                            ConcurrencyStamp = "046bcfb6-a478-423e-b07c-8d49f37725b0",
                            Email = "tinke@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Tinke",
                            LastName = "Stuban",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            Card = "No-Membership",
                            ConcurrencyStamp = "22ff458a-3339-44ec-bc8d-0f3574471616",
                            Email = "bkrajin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Bruno",
                            LastName = "Krajinovic",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            Card = "Membership",
                            ConcurrencyStamp = "ede8b957-531f-4af4-9a35-54da667829f6",
                            Email = "stelasipusic@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Stela",
                            LastName = "Sipusic",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            Card = "Membership",
                            ConcurrencyStamp = "fd3075ca-6a9c-4d66-9561-16e364b3b5dc",
                            Email = "antoniosamardzic@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Antonio",
                            LastName = "Samardzic",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Projekt.Models.Bought", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BoughtDate");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("MovieId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Boughts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BoughtDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 18, DateTimeKind.Utc).AddTicks(612),
                            IsDeleted = false,
                            MovieId = 1,
                            Price = 159.99m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BoughtDate = new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 19, DateTimeKind.Utc).AddTicks(4108),
                            IsDeleted = false,
                            MovieId = 2,
                            Price = 159.99m,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            BoughtDate = new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 19, DateTimeKind.Utc).AddTicks(4534),
                            IsDeleted = false,
                            MovieId = 3,
                            Price = 59.99m,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            BoughtDate = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 19, DateTimeKind.Utc).AddTicks(4580),
                            IsDeleted = false,
                            MovieId = 4,
                            Price = 9.99m,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Projekt.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("URL");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Pres CA",
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 20, DateTimeKind.Utc).AddTicks(9471),
                            IsDeleted = false,
                            Name = "Presidental",
                            PhoneNumber = "09809768",
                            URL = "www.presidental.com"
                        },
                        new
                        {
                            Id = 2,
                            Address = "WB CA",
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 21, DateTimeKind.Utc).AddTicks(2467),
                            IsDeleted = false,
                            Name = "Warner Bros",
                            PhoneNumber = "09509768",
                            URL = "www.WB.com"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Uni CA",
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 21, DateTimeKind.Utc).AddTicks(2493),
                            IsDeleted = false,
                            Name = "Universal",
                            PhoneNumber = "0209768",
                            URL = "www.Universal.com"
                        },
                        new
                        {
                            Id = 4,
                            Address = "WD CA",
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 21, DateTimeKind.Utc).AddTicks(2493),
                            IsDeleted = false,
                            Name = "Walt Disney",
                            PhoneNumber = "009768",
                            URL = "www.WD.com"
                        });
                });

            modelBuilder.Entity("Projekt.Models.Engagement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Ended");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("MovieId");

                    b.Property<DateTime>("Started");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Engagements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 22, DateTimeKind.Utc).AddTicks(6527),
                            Ended = new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 4999999.99m,
                            IsDeleted = false,
                            MovieId = 1,
                            Started = new DateTime(2002, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 2,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 23, DateTimeKind.Utc).AddTicks(216),
                            Ended = new DateTime(2015, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 29999.99m,
                            IsDeleted = false,
                            MovieId = 2,
                            Started = new DateTime(2014, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ActorId = 3,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 23, DateTimeKind.Utc).AddTicks(293),
                            Ended = new DateTime(2014, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 559999.99m,
                            IsDeleted = false,
                            MovieId = 3,
                            Started = new DateTime(2013, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ActorId = 4,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 23, DateTimeKind.Utc).AddTicks(323),
                            Ended = new DateTime(2012, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 499999.99m,
                            IsDeleted = false,
                            MovieId = 4,
                            Started = new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Projekt.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("MovieTypeId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(12, 2)");

                    b.Property<string>("Producent");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MovieTypeId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 24, DateTimeKind.Utc).AddTicks(4281),
                            Description = "Kum (eng. The Godfather) je kriminalistička drama Francisa Forda Coppole temeljena na istoimenom romanu Maria Puza. U glavnim ulogama pojavljuju se Marlon Brando, Al Pacino, Robert Duvall, Diane Keaton i James Caan. Radnja filma proteže se na deset godina od kraja 1945. do 1955. te predstavlja kronologiju mafijaške obitelji Corleone.",
                            IsDeleted = false,
                            MovieTypeId = 1,
                            Name = "GodFather",
                            Price = 99.99m,
                            Producent = "Albert S. Ruddy",
                            ReleaseDate = new DateTime(1974, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 24, DateTimeKind.Utc).AddTicks(8980),
                            Description = "Best movie ever",
                            IsDeleted = false,
                            MovieTypeId = 2,
                            Name = "Lord Of The Rings",
                            Price = 199.99m,
                            Producent = "Peter Jackson",
                            ReleaseDate = new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 3,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 24, DateTimeKind.Utc).AddTicks(9052),
                            Description = "mind fuck movie",
                            IsDeleted = false,
                            MovieTypeId = 2,
                            Name = "Interstellar",
                            Price = 49.99m,
                            Producent = "John Wayne",
                            ReleaseDate = new DateTime(2015, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 4,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 24, DateTimeKind.Utc).AddTicks(9072),
                            Description = "funny movie",
                            IsDeleted = false,
                            MovieTypeId = 5,
                            Name = "Ride Along",
                            Price = 29.99m,
                            Producent = "Don Jackobs",
                            ReleaseDate = new DateTime(2014, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Projekt.Models.MovieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Genre")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("MovieTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6038),
                            Genre = "Action",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6695),
                            Genre = "Fantasy",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6705),
                            Genre = "Drama",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6705),
                            Genre = "Documentary",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6710),
                            Genre = "Comedy",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Projekt.Models.AuthUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Projekt.Models.AuthUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projekt.Models.AuthUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Projekt.Models.AuthUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projekt.Models.Bought", b =>
                {
                    b.HasOne("Projekt.Models.Movie", "Movie")
                        .WithMany("Boughts")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projekt.Models.AuthUser", "User")
                        .WithMany("Boughts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projekt.Models.Engagement", b =>
                {
                    b.HasOne("Projekt.Models.Actor", "Actor")
                        .WithMany("Engagements")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projekt.Models.Movie", "Movie")
                        .WithMany("Engagements")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projekt.Models.Movie", b =>
                {
                    b.HasOne("Projekt.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projekt.Models.MovieType", "MovieType")
                        .WithMany()
                        .HasForeignKey("MovieTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}