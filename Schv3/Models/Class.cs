using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schv3.Models
{
    public class Class
    {
        [Key][Required] public int Id { get; set; }
        [Required] public int Id_Subject { get; set; }
        [Required] public int Id_Teacher { get; set; }
        [Required] public int Id_Classroom { get; set; }
        [Required] public int ClassType { get; set; }
        [Required] public int Group_Code { get; set; }
        public int Comment { get; set; }
    }
}
