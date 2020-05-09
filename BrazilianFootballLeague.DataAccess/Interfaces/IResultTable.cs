using System;
using System.Collections.Generic;
using System.Text;

namespace BrazilianFootballLeague.DataAccess.Interfaces
{
    public interface IResultTable
    {
        public int Position { get; set; }

        public int Points { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Drawn { get; set; }
        public int Lost { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
    }
}