using System.ComponentModel.DataAnnotations;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class States : BaseDBEntity
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(2)]
        public string Code { get; set; }
    }
}