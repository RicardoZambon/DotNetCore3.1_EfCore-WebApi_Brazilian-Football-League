using System.ComponentModel.DataAnnotations;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public abstract class BaseDBEntity
    {
        [Key]
        public int ID { get; set; }
    }
}