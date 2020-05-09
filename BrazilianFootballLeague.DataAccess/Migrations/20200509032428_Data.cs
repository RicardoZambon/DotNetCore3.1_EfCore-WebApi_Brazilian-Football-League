using Microsoft.EntityFrameworkCore.Migrations;

namespace BrazilianFootballLeague.DataAccess.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Série A" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 25, "SP", "São Paulo" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 24, "SC", "Santa Catarina" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 23, "RR", "Roraima" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 22, "RO", "Rondônia" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 21, "RS", "Rio Grande do Sul" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 20, "RN", "Rio Grande do Norte" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 19, "RJ", "Rio de Janeiro" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 18, "PI", "Piauí" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 17, "PE", "Pernambuco" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 16, "PR", "Paraná" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 15, "PB", "Paraíba" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 14, "PA", "Pará" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 13, "MG", "Minas Gerais" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 12, "MS", "Mato Grosso do Sul" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 11, "MT", "Mato Grosso" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 10, "MA", "Maranhão" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 9, "GO", "Goiás" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 8, "ES", "Espírito Santo" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 7, "DF", "Distrito Federal" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 6, "CE", "Ceará" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 5, "BA", "Bahia" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 4, "AM", "Amazonas" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 3, "AP", "Amapá" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 2, "AL", "Alagoas" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 1, "AC", "Acre" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 26, "SE", "Sergipe" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "ID", "Code", "Name" },
                values: new object[] { 27, "TO", "Tocantins" });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "ID", "CompetitionID", "Year" },
                values: new object[] { 1, 1, 2015 });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "ID", "CompetitionID", "Year" },
                values: new object[] { 2, 1, 2016 });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "ID", "CompetitionID", "Year" },
                values: new object[] { 3, 1, 2017 });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "ID", "CompetitionID", "Year" },
                values: new object[] { 4, 1, 2018 });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "ID", "CompetitionID", "Year" },
                values: new object[] { 5, 1, 2019 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 15, "Flamengo", 19 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 16, "Fluminense", 19 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 29, "Vasco da Gama", 19 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 19, "Grêmio", 21 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 20, "Internacional", 21 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 5, "Avaí", 24 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 14, "Figueirense", 24 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 7, "Botafogo", 19 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 21, "Joinvile", 24 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 10, "Corinthians", 25 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 22, "Palmeiras", 25 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 24, "Ponte Preta", 25 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 9, "Chapecoense", 24 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 28, "Sport", 17 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 23, "Paraná", 16 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 26, "Santos", 25 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 11, "Coritiba", 16 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 4, "Atlético PR", 16 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 12, "Cruzeiro", 13 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 3, "Atlético MG", 13 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 1, "América Mineiro", 13 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 18, "Goiás", 9 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 2, "Atlético Goiás", 9 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 17, "Fortaleza", 6 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 8, "Ceará", 6 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 30, "Vitória", 5 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 6, "Bahia", 5 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 13, "CSA", 2 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 25, "Santa Cruz", 17 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Name", "StateID" },
                values: new object[] { 27, "São Paulo", 25 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 98, 8, 58, 24, 22, 38, 32, 18, 5, 13, 8 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 74, 11, 50, 34, 16, 38, 44, 14, 4, 9, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 48, 9, 49, 47, 14, 38, 54, 8, 3, 9, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 31, 13, 56, 49, 12, 38, 52, 11, 2, 9, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 14, 11, 44, 34, 15, 38, 47, 14, 1, 9, 12 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 100, 11, 62, 18, 24, 38, 20, 20, 5, 5, 3 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 58, 13, 48, 29, 15, 38, 43, 18, 3, 5, 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 17, 9, 60, 38, 18, 38, 42, 17, 1, 5, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 87, 9, 39, 44, 13, 38, 57, 7, 5, 20, 16 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 63, 12, 29, 51, 7, 38, 69, 3, 4, 20, 19 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 37, 10, 41, 35, 17, 38, 43, 17, 2, 20, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 5, 9, 38, 39, 12, 38, 60, 5, 1, 20, 17 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 84, 8, 39, 64, 11, 38, 65, 4, 5, 19, 19 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 64, 12, 27, 48, 8, 38, 66, 4, 4, 19, 18 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 44, 8, 36, 55, 12, 38, 62, 4, 3, 19, 18 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 29, 11, 44, 41, 13, 38, 53, 9, 2, 19, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 3, 8, 32, 52, 10, 38, 68, 3, 1, 19, 20 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 92, 13, 45, 39, 13, 38, 49, 12, 5, 29, 12 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 76, 13, 48, 41, 15, 38, 43, 16, 4, 29, 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 47, 11, 47, 40, 12, 38, 56, 7, 3, 29, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 18, 11, 54, 28, 17, 38, 41, 18, 1, 29, 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 94, 10, 46, 38, 16, 38, 46, 14, 5, 16, 12 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 99, 11, 52, 31, 20, 38, 32, 19, 5, 9, 7 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 72, 9, 46, 32, 17, 38, 45, 12, 4, 16, 12 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 16, 10, 50, 36, 17, 38, 43, 16, 1, 14, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 20, 10, 48, 26, 21, 38, 31, 20, 1, 21, 7 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 53, 11, 49, 48, 14, 38, 50, 13, 3, 27, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 30, 10, 36, 44, 14, 38, 52, 10, 2, 27, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 4, 8, 32, 52, 10, 38, 68, 4, 1, 27, 20 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 82, 8, 33, 60, 8, 38, 74, 2, 5, 26, 22 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 70, 11, 40, 46, 14, 38, 50, 10, 4, 26, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 43, 12, 32, 42, 9, 38, 63, 3, 3, 26, 17 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 22, 5, 35, 59, 11, 38, 71, 2, 2, 26, 22 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 7, 10, 41, 59, 12, 38, 58, 7, 1, 26, 16 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 59, 9, 52, 37, 19, 38, 39, 19, 3, 24, 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 28, 8, 52, 48, 15, 38, 53, 8, 2, 24, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 11, 12, 40, 41, 13, 38, 51, 11, 1, 24, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 83, 11, 32, 61, 6, 38, 74, 3, 5, 22, 21 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 61, 11, 26, 64, 4, 38, 80, 1, 4, 22, 23 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 42, 6, 45, 61, 13, 38, 63, 2, 3, 22, 19 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 21, 8, 32, 62, 6, 38, 80, 1, 2, 22, 24 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 9, 8, 51, 60, 15, 38, 53, 9, 1, 22, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 88, 14, 34, 42, 10, 38, 56, 8, 5, 10, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 73, 11, 35, 34, 16, 38, 44, 13, 4, 10, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 41, 9, 30, 50, 8, 38, 72, 1, 3, 10, 21 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 27, 10, 42, 48, 13, 38, 55, 7, 2, 10, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 1, 9, 31, 71, 5, 38, 81, 1, 1, 10, 24 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 38, 13, 50, 30, 17, 38, 37, 18, 2, 14, 8 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 54, 14, 53, 50, 13, 38, 47, 14, 3, 16, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 33, 11, 45, 45, 14, 38, 50, 13, 2, 16, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 13, 5, 49, 40, 19, 38, 47, 13, 1, 16, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 32, 9, 49, 48, 15, 38, 51, 12, 2, 12, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 8, 10, 35, 44, 13, 38, 55, 8, 1, 12, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 93, 9, 49, 45, 16, 38, 48, 13, 5, 3, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 66, 8, 43, 56, 13, 38, 59, 6, 4, 3, 17 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 49, 12, 49, 52, 12, 38, 54, 9, 3, 3, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 24, 11, 53, 61, 10, 38, 62, 4, 2, 3, 17 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 2, 6, 47, 65, 11, 38, 69, 2, 1, 3, 21 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 77, 10, 47, 30, 18, 38, 40, 17, 4, 1, 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 40, 7, 58, 23, 24, 38, 28, 20, 2, 1, 7 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 90, 7, 64, 46, 16, 38, 52, 10, 5, 18, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 19, 8, 49, 39, 20, 38, 38, 19, 1, 18, 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 60, 9, 56, 38, 20, 38, 36, 20, 3, 2, 9 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 89, 8, 49, 50, 15, 38, 53, 9, 5, 17, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 96, 9, 41, 36, 19, 38, 39, 16, 5, 8, 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 75, 14, 38, 32, 14, 38, 44, 15, 4, 8, 10 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 79, 10, 63, 36, 19, 38, 37, 19, 4, 30, 9 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 56, 10, 58, 50, 17, 38, 43, 16, 3, 30, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 36, 9, 53, 51, 17, 38, 45, 16, 2, 30, 12 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 91, 13, 43, 44, 13, 38, 49, 11, 5, 6, 12 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 71, 12, 41, 39, 14, 38, 48, 11, 4, 6, 12 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 52, 11, 48, 50, 14, 38, 50, 12, 3, 6, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 45, 12, 39, 47, 11, 38, 57, 5, 3, 12, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 68, 11, 34, 34, 13, 38, 53, 8, 4, 12, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 97, 15, 46, 27, 16, 38, 36, 17, 5, 12, 7 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 10, 9, 48, 43, 15, 38, 51, 10, 1, 4, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 81, 6, 37, 86, 4, 38, 90, 1, 5, 15, 28 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 62, 9, 29, 59, 8, 38, 72, 2, 4, 15, 21 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 46, 11, 38, 49, 12, 38, 56, 6, 3, 15, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 23, 11, 35, 52, 7, 38, 71, 3, 2, 15, 20 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 12, 4, 53, 45, 19, 38, 49, 12, 1, 15, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 95, 4, 45, 31, 21, 38, 43, 15, 5, 7, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 69, 12, 46, 38, 13, 38, 51, 9, 4, 7, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 50, 11, 42, 45, 13, 38, 53, 10, 3, 7, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 25, 8, 39, 43, 13, 38, 59, 5, 2, 7, 17 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 78, 9, 57, 35, 18, 38, 39, 18, 4, 28, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 65, 15, 34, 46, 7, 38, 63, 5, 4, 27, 16 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 55, 9, 58, 46, 17, 38, 45, 15, 3, 28, 12 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 6, 14, 38, 53, 9, 38, 59, 6, 1, 28, 15 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 39, 7, 69, 45, 23, 38, 28, 19, 2, 25, 8 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 80, 11, 57, 18, 23, 38, 23, 20, 4, 23, 4 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 57, 10, 51, 42, 17, 38, 43, 17, 3, 11, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 35, 13, 42, 41, 14, 38, 46, 15, 2, 11, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 15, 11, 42, 31, 16, 38, 44, 15, 1, 11, 11 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 85, 10, 32, 51, 10, 38, 64, 5, 5, 4, 18 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 67, 9, 37, 54, 13, 38, 57, 7, 4, 4, 16 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 51, 9, 43, 45, 15, 38, 51, 11, 3, 4, 14 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 26, 6, 32, 38, 15, 38, 57, 6, 2, 4, 17 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 34, 8, 55, 49, 17, 38, 47, 14, 2, 28, 13 });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ID", "Drawn", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "Position", "SeasonID", "TeamID", "Won" },
                values: new object[] { 86, 12, 30, 39, 9, 38, 63, 6, 5, 27, 17 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "ID",
                keyValue: 25);
        }
    }
}
