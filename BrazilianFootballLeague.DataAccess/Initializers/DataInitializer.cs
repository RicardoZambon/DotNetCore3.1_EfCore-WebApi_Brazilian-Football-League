using BrazilianFootballLeague.DataAccess.BusinessObjects;
using BrazilianFootballLeague.DataAccess.Initializers.DataImport;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace BrazilianFootballLeague.DataAccess.Initializers
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            #region States

            modelBuilder.Entity<States>().HasData(new States() { ID = 1, Name = "Acre", Code = "AC" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 2, Name = "Alagoas", Code = "AL" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 3, Name = "Amapá", Code = "AP" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 4, Name = "Amazonas", Code = "AM" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 5, Name = "Bahia", Code = "BA" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 6, Name = "Ceará", Code = "CE" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 7, Name = "Distrito Federal", Code = "DF" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 8, Name = "Espírito Santo", Code = "ES" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 9, Name = "Goiás", Code = "GO" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 10, Name = "Maranhão", Code = "MA" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 11, Name = "Mato Grosso", Code = "MT" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 12, Name = "Mato Grosso do Sul", Code = "MS" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 13, Name = "Minas Gerais", Code = "MG" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 14, Name = "Pará", Code = "PA" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 15, Name = "Paraíba", Code = "PB" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 16, Name = "Paraná", Code = "PR" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 17, Name = "Pernambuco", Code = "PE" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 18, Name = "Piauí", Code = "PI" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 19, Name = "Rio de Janeiro", Code = "RJ" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 20, Name = "Rio Grande do Norte", Code = "RN" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 21, Name = "Rio Grande do Sul", Code = "RS" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 22, Name = "Rondônia", Code = "RO" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 23, Name = "Roraima", Code = "RR" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 24, Name = "Santa Catarina", Code = "SC" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 25, Name = "São Paulo", Code = "SP" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 26, Name = "Sergipe", Code = "SE" });
            modelBuilder.Entity<States>().HasData(new States() { ID = 27, Name = "Tocantins", Code = "TO" });

            #endregion

            #region Teams

            var teams = new Teams[]
            {
                new Teams() { ID = 1, Name = "América Mineiro", StateID = 13 },
                new Teams() { ID = 2, Name = "Atlético Goiás", StateID = 9 },
                new Teams() { ID = 3, Name = "Atlético MG", StateID = 13 },
                new Teams() { ID = 4, Name = "Atlético PR", StateID = 16 },
                new Teams() { ID = 5, Name = "Avaí", StateID = 24 },
                new Teams() { ID = 6, Name = "Bahia", StateID = 5 },
                new Teams() { ID = 7, Name = "Botafogo", StateID = 19 },
                new Teams() { ID = 8, Name = "Ceará", StateID = 6 },
                new Teams() { ID = 9, Name = "Chapecoense", StateID = 24 },
                new Teams() { ID = 10, Name = "Corinthians", StateID = 25 },
                new Teams() { ID = 11, Name = "Coritiba", StateID = 16 },
                new Teams() { ID = 12, Name = "Cruzeiro", StateID = 13 },
                new Teams() { ID = 13, Name = "CSA", StateID = 2 },
                new Teams() { ID = 14, Name = "Figueirense", StateID = 24 },
                new Teams() { ID = 15, Name = "Flamengo", StateID = 19 },
                new Teams() { ID = 16, Name = "Fluminense", StateID = 19 },
                new Teams() { ID = 17, Name = "Fortaleza", StateID = 6 },
                new Teams() { ID = 18, Name = "Goiás", StateID = 9 },
                new Teams() { ID = 19, Name = "Grêmio", StateID = 21 },
                new Teams() { ID = 20, Name = "Internacional", StateID = 21 },
                new Teams() { ID = 21, Name = "Joinvile", StateID = 24 },
                new Teams() { ID = 22, Name = "Palmeiras", StateID = 25 },
                new Teams() { ID = 23, Name = "Paraná", StateID = 16 },
                new Teams() { ID = 24, Name = "Ponte Preta", StateID = 25 },
                new Teams() { ID = 25, Name = "Santa Cruz", StateID = 17 },
                new Teams() { ID = 26, Name = "Santos", StateID = 25 },
                new Teams() { ID = 27, Name = "São Paulo", StateID = 25 },
                new Teams() { ID = 28, Name = "Sport", StateID = 17 },
                new Teams() { ID = 29, Name = "Vasco da Gama", StateID = 19 },
                new Teams() { ID = 30, Name = "Vitória", StateID = 5 }
            };

            modelBuilder.Entity<Teams>().HasData(teams);

            #endregion

            #region Competitions

            var jsonFile = File.ReadAllText("..\\BrazilianFootballLeague.DataAccess\\Initializers\\TablesDataImport.json");
            var jsonObject = JsonConvert.DeserializeObject<JsonFileImportType>(jsonFile);

            var competitionId = 1;
            int seasonId = 1;
            int resultId = 1;

            foreach (var competition in jsonObject.Competitions)
            {
                modelBuilder.Entity<Competitions>().HasData(new Competitions() { ID = competitionId, Name = competition.Name });

                foreach (var season in competition.Seasons)
                {
                    modelBuilder.Entity<Competitions_Seasons>().HasData(new Competitions_Seasons() { ID = seasonId, CompetitionID = competitionId, Year = season.Year });

                    foreach(var result in season.Results)
                    {
                        var team = teams.FirstOrDefault(x => x.Name == result.Team);

                        if (team == null)
                        {
                            throw new Exception($"Team {result.Team} not found!");
                        }

                        modelBuilder.Entity<Competitions_ResultTable>().HasData(new Competitions_ResultTable()
                        {
                            ID = resultId,
                            SeasonID = seasonId,
                            TeamID = team.ID,
                            Position = result.Position,
                            Points = result.Points,
                            Played = result.Played,
                            Won = result.Won,
                            Drawn = result.Drawn,
                            Lost = result.Lost,
                            GoalsFor = result.GoalsFor,
                            GoalsAgainst = result.GoalsAgainst
                        });
                        resultId++;
                    }
                    seasonId++;
                }
                competitionId++;
            }

            #endregion
        }
    }
}