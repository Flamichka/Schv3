using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schv3.Models
{
    public class Schedule
    {
        [Key][Required] public int Id { get; set; }
        [Required] public DateOnly date { get; set; }
        public Class Id_1Class { get; set; }
        public Class Id_2Class { get; set; }
        public Class Id_3Class { get; set; }
        public Class Id_4Class { get; set; }
        public Class Id_5Class { get; set; }
        public Class Id_6Class { get; set; }
        public Class Id_7Class { get; set; }
        public Class Id_8Class { get; set; }
        [Required] public int week { get; set; }
    }
}
