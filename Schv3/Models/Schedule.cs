using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schv3.Models
{
    public class Schedule
    {
        [Key][Required] public int Id { get; set; }
        [Required] public DateOnly date { get; set; }
        [ForeignKey(nameof(Class))] public int Id_1Class { get; set; }
        [ForeignKey(nameof(Class))] public int Id_2Class { get; set; }
        [ForeignKey(nameof(Class))] public int Id_3Class { get; set; }
        [ForeignKey(nameof(Class))] public int Id_4Class { get; set; }
        [ForeignKey(nameof(Class))] public int Id_5Class { get; set; }
        [ForeignKey(nameof(Class))] public int Id_6Class { get; set; }
        [ForeignKey(nameof(Class))] public int Id_7Class { get; set; }
        [ForeignKey(nameof(Class))] public int Id_8Class { get; set; }
        [Required] public int week { get; set; }
    }
}
