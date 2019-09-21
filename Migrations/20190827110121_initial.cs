using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Card = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Genre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12, 2)", nullable: false),
                    Producent = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    MovieTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_MovieTypes_MovieTypeId",
                        column: x => x.MovieTypeId,
                        principalTable: "MovieTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boughts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    BoughtDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boughts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boughts_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boughts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Engagements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Started = table.Column<DateTime>(nullable: false),
                    Ended = table.Column<DateTime>(nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    ActorId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engagements_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engagements_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "CreatedAt", "FirstName", "IsDeleted", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 27, 11, 1, 20, 15, DateTimeKind.Utc).AddTicks(7893), "Toby", false, "guy", null },
                    { 2, new DateTime(2019, 8, 27, 11, 1, 20, 16, DateTimeKind.Utc).AddTicks(216), "Viggo", false, "Mortensen", null },
                    { 3, new DateTime(2019, 8, 27, 11, 1, 20, 16, DateTimeKind.Utc).AddTicks(232), "Elijah", false, "Wood", null },
                    { 4, new DateTime(2019, 8, 27, 11, 1, 20, 16, DateTimeKind.Utc).AddTicks(237), "Sean", false, "Bean", null },
                    { 5, new DateTime(2019, 8, 27, 11, 1, 20, 16, DateTimeKind.Utc).AddTicks(237), "Orlando", false, "Bloom", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Card", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 4, 0, "Membership", "ede8b957-531f-4af4-9a35-54da667829f6", "stelasipusic@mail.com", false, "Stela", "Sipusic", false, null, null, null, null, null, false, null, false, null },
                    { 3, 0, "No-Membership", "22ff458a-3339-44ec-bc8d-0f3574471616", "bkrajin@mail.com", false, "Bruno", "Krajinovic", false, null, null, null, null, null, false, null, false, null },
                    { 5, 0, "Membership", "fd3075ca-6a9c-4d66-9561-16e364b3b5dc", "antoniosamardzic@mail.com", false, "Antonio", "Samardzic", false, null, null, null, null, null, false, null, false, null },
                    { 1, 0, "Membership", "66f580cb-6384-454f-9ec4-24cdba48e727", "tinopiskovic@mail.com", false, "Tino", "Piskovic", false, null, null, null, null, null, false, null, false, null },
                    { 2, 0, "Membership", "046bcfb6-a478-423e-b07c-8d49f37725b0", "tinke@mail.com", false, "Tinke", "Stuban", false, null, null, null, null, null, false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Name", "PhoneNumber", "URL", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Pres CA", new DateTime(2019, 8, 27, 11, 1, 20, 20, DateTimeKind.Utc).AddTicks(9471), false, "Presidental", "09809768", "www.presidental.com", null },
                    { 2, "WB CA", new DateTime(2019, 8, 27, 11, 1, 20, 21, DateTimeKind.Utc).AddTicks(2467), false, "Warner Bros", "09509768", "www.WB.com", null },
                    { 3, "Uni CA", new DateTime(2019, 8, 27, 11, 1, 20, 21, DateTimeKind.Utc).AddTicks(2493), false, "Universal", "0209768", "www.Universal.com", null },
                    { 4, "WD CA", new DateTime(2019, 8, 27, 11, 1, 20, 21, DateTimeKind.Utc).AddTicks(2493), false, "Walt Disney", "009768", "www.WD.com", null }
                });

            migrationBuilder.InsertData(
                table: "MovieTypes",
                columns: new[] { "Id", "CreatedAt", "Genre", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6705), "Documentary", false, null },
                    { 1, new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6038), "Action", false, null },
                    { 2, new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6695), "Fantasy", false, null },
                    { 3, new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6705), "Drama", false, null },
                    { 5, new DateTime(2019, 8, 27, 11, 1, 20, 25, DateTimeKind.Utc).AddTicks(6710), "Comedy", false, null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "Description", "IsDeleted", "MovieTypeId", "Name", "Price", "Producent", "ReleaseDate", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 8, 27, 11, 1, 20, 24, DateTimeKind.Utc).AddTicks(4281), "Kum (eng. The Godfather) je kriminalistička drama Francisa Forda Coppole temeljena na istoimenom romanu Maria Puza. U glavnim ulogama pojavljuju se Marlon Brando, Al Pacino, Robert Duvall, Diane Keaton i James Caan. Radnja filma proteže se na deset godina od kraja 1945. do 1955. te predstavlja kronologiju mafijaške obitelji Corleone.", false, 1, "GodFather", 99.99m, "Albert S. Ruddy", new DateTime(1974, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, new DateTime(2019, 8, 27, 11, 1, 20, 24, DateTimeKind.Utc).AddTicks(8980), "Best movie ever", false, 2, "Lord Of The Rings", 199.99m, "Peter Jackson", new DateTime(2001, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 3, new DateTime(2019, 8, 27, 11, 1, 20, 24, DateTimeKind.Utc).AddTicks(9052), "mind fuck movie", false, 2, "Interstellar", 49.99m, "John Wayne", new DateTime(2015, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 4, new DateTime(2019, 8, 27, 11, 1, 20, 24, DateTimeKind.Utc).AddTicks(9072), "funny movie", false, 5, "Ride Along", 29.99m, "Don Jackobs", new DateTime(2014, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Boughts",
                columns: new[] { "Id", "BoughtDate", "CreatedAt", "IsDeleted", "MovieId", "Price", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 27, 11, 1, 20, 18, DateTimeKind.Utc).AddTicks(612), false, 1, 159.99m, null, 1 },
                    { 2, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 27, 11, 1, 20, 19, DateTimeKind.Utc).AddTicks(4108), false, 2, 159.99m, null, 2 },
                    { 3, new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 27, 11, 1, 20, 19, DateTimeKind.Utc).AddTicks(4534), false, 3, 59.99m, null, 3 },
                    { 4, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 27, 11, 1, 20, 19, DateTimeKind.Utc).AddTicks(4580), false, 4, 9.99m, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Engagements",
                columns: new[] { "Id", "ActorId", "CreatedAt", "Ended", "Fee", "IsDeleted", "MovieId", "Started", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 8, 27, 11, 1, 20, 22, DateTimeKind.Utc).AddTicks(6527), new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4999999.99m, false, 1, new DateTime(2002, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, new DateTime(2019, 8, 27, 11, 1, 20, 23, DateTimeKind.Utc).AddTicks(216), new DateTime(2015, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 29999.99m, false, 2, new DateTime(2014, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 3, new DateTime(2019, 8, 27, 11, 1, 20, 23, DateTimeKind.Utc).AddTicks(293), new DateTime(2014, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 559999.99m, false, 3, new DateTime(2013, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 4, new DateTime(2019, 8, 27, 11, 1, 20, 23, DateTimeKind.Utc).AddTicks(323), new DateTime(2012, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 499999.99m, false, 4, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Boughts_MovieId",
                table: "Boughts",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Boughts_UserId",
                table: "Boughts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Engagements_ActorId",
                table: "Engagements",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Engagements_MovieId",
                table: "Engagements",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CompanyId",
                table: "Movies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieTypeId",
                table: "Movies",
                column: "MovieTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Boughts");

            migrationBuilder.DropTable(
                name: "Engagements");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "MovieTypes");
        }
    }
}
