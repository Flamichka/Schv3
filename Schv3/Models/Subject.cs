using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schv3.Models
{
    public class Subject
    {
        [Key] [Required] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int Hours { get; set; }
        [Required] public int Id_teacher { get; set; }
    }
}
