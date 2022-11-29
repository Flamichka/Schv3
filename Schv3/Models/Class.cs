using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schv3.Models
{
    public class Class
    {
        [Key][Required] public int Id { get; set; }
        [ForeignKey(nameof(Subject))][Required] public int Id_Subject { get; set; }
        [ForeignKey(nameof(Teacher))][Required] public int Id_Teacher { get; set; }
        [ForeignKey(nameof(ClassRoom))][Required] public int Id_Classroom { get; set; }
        [Required] public int ClassType { get; set; }
        [ForeignKey(nameof(Group))][Required] public int Group_Code { get; set; }
        public int Comment { get; set; }
    }
}
