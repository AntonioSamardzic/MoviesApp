using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt.Migrations
{
    public partial class FixCreatedAt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 817, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 817, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 817, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 817, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 817, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Boughts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 819, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Boughts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 820, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Boughts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 820, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Boughts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 820, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 821, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 821, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 821, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 821, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Engagements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 823, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Engagements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 823, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Engagements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 823, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Engagements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 823, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 826, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 826, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 826, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 826, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 826, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 825, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 825, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 825, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 825, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 827, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 827, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 827, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 827, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 40, 12, 827, DateTimeKind.Utc).AddTicks(7828));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 305, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 305, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 305, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 305, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 305, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Boughts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 307, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Boughts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 308, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Boughts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 308, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Boughts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 308, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 309, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 309, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 309, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 309, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Engagements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 311, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Engagements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 311, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Engagements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 311, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Engagements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 311, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 314, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 314, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 314, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 314, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 314, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 313, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 313, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 313, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 313, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 315, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 315, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 315, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 315, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 10, 16, 5, 315, DateTimeKind.Utc).AddTicks(4995));
        }
    }
}
