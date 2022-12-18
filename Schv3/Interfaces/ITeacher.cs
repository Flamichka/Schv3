using Schv3.Models;

namespace Schv3.Interfaces
{
    public interface ITeacher
    {
        IEnumerable<Teacher> teachers { get; }
    }
}
