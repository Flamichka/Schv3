using System.ComponentModel.DataAnnotations;

namespace Schv3.Models
{
    public class ClassRoom
    {
        [Key][Required] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int Size { get; set; }
        [Required] public string Building { get; set; }
    }
}
