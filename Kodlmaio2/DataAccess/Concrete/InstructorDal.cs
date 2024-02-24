using Kodlmaio2.DataAccess.Abstract;
using Kodlmaio2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlmaio2.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>
            {
                new Instructor {Id=1,FirstName="Engin", Surname="Demiroğ"},
                new Instructor {Id=2,FirstName="Sergen", Surname="Alkan"},
                new Instructor {Id=3,FirstName="Osman", Surname="Baş"},
                new Instructor {Id=4,FirstName="Sercan", Surname="Alkan"}
            };
        }
        public void Add(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(int id)
        {
            var deletedInstructor = instructors.First(i => i.Id == id);
            if (deletedInstructor != null)
            {
                instructors.Remove(deletedInstructor);
            }
        }

        public Instructor Get(int id)
        {
            return instructors.First(i => i.Id == id);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor entity)
        {
            var updatedInstructor = instructors.First(i => i.Id == entity.Id);
            if (updatedInstructor != null)
            {
                updatedInstructor.Id = entity.Id;
                updatedInstructor.FirstName = entity.FirstName;
                updatedInstructor.Surname = entity.Surname;
            }
        }
    }
}
