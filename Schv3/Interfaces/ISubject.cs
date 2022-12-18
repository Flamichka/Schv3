using Schv3.Models;

namespace Schv3.Interfaces
{
    public interface ISubject
    {
        IEnumerable<Subject> subjects { get; }
    }
}
