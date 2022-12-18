using Microsoft.EntityFrameworkCore;
using Schv3.Data;
using Schv3.Interfaces;
using Schv3.Models;

namespace Schv3.Query
{
    public class Test
    {
        public void create()
        {
            using (var db = new AppDataDbContext { })
            {
                db.Classes.Add(new Group()
                {
                    GrouoCode = 5,
                    Quantity = 2,
                    Institute = "33",
                    course = 4,
                    education= 5,
                    study_form = 6,
                });
                db.SaveChanges();
            }
        }
    }
}
