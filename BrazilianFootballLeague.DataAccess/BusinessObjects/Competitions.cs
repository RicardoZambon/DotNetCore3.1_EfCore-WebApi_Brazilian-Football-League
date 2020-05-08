using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class Competitions : BaseDBEntity
    {
        [StringLength(100)]
        public string Name { get; set; }


        public virtual ICollection<Competitions_Seasons> Seasons { get; set; }
    }
}