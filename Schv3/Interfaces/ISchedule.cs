using Schv3.Models;

namespace Schv3.Interfaces
{
    public interface ISchedule
    {
        IEnumerable<Schedule> schedules { get; }   
    }
}
