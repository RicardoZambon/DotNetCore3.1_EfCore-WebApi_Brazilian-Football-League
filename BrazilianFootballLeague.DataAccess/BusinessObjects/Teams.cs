using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class Teams : BaseDBEntity
    {
        [StringLength(100)]
        public string Name { get; set; }

        public virtual States State { get; set; }
        public int StateID { get; set; }


        public virtual ICollection<Competitions_ResultTable> Results { get; set; }
    }
}