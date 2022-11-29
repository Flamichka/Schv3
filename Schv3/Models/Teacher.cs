using System.ComponentModel.DataAnnotations;

namespace Schv3.Models
{
    public class Teacher
    {
        [Key] [Required] public int Id { get; set; }
        [Required] public string LName { get; set; }
        [Required] public string FName { get; set; }
        [Required] public string MName { get; set; }
        [Required] public string Post { get; set; }

    }
}
