using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Schv3.Data;
using Schv3.Models;
using System.Reflection;

namespace Schv3.Query
{
    public class EditorQueries
    {
        //Here we input data models of entities 
        //And get nothing on output 
        //DB input methods for construnctor tab
        
        public static void CreateClass(Class par)
        {
            using (var db = new AppDataDbContext { })
            {
                throw new NotImplementedException();
            }
        }

        public static void CreateSublect(Subject par)
        {
            using (var db = new AppDataDbContext { })
            {
                throw new NotImplementedException();
            }
        }

        public static void CreateTeacher(Teacher par)
        {
            using (var db = new AppDataDbContext { })
            {
                throw new NotImplementedException();
            }
        }

        public static void CreateClassroom(ClassRoom par)
        {
            using (var db = new AppDataDbContext { })
            {
                throw new NotImplementedException();
            }
        }

        public static void CreateGroup(Group par)
        {
            using (var db = new AppDataDbContext { })
            {
                throw new NotImplementedException();
            }
        }


        public static void CreateAny(object par)
        {
            using (var db = new AppDataDbContext { })
            {
                switch (par)
                { 
                    case Class c:
                        db.Classes.Add((Class)par);
                        db.SaveChanges();
                        break;
                    case Subject s:
                        db.Subjects.Add((Subject)par);
                        db.SaveChanges();
                        break;
                    case Teacher t:
                        db.Teachers.Add((Teacher)par);
                        db.SaveChanges();
                        break;
                    case ClassRoom cr:
                        db.Classrooms.Add((ClassRoom)par);
                        db.SaveChanges();
                        break;
                    case Group g:
                        db.Groups.Add((Group)par);
                        db.SaveChanges();
                        break;
                    default:
                        throw new Exception("idinahuy");
                        
                };
            }
        }

    }
}
