using Kodlmaio2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlmaio2.Bussiness.Abstract
{
    public interface IInstructorService
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int id);
        List<Instructor> GetAll();
        Instructor Get(int id);
    }
}
