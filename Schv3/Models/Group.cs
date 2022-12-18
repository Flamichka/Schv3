using System.ComponentModel.DataAnnotations;

namespace Schv3.Models
{
    public class Group
    {
        [Key][Required] public int GrouoCode { get; set; }
        [Required] public int Quantity { get; set; }
        [Required] public string Institute { get; set; }
        [Required] public int course { get; set; }
        [Required] public int education { get; set; }
        [Required] public int study_form { get; set; }
    }
}
