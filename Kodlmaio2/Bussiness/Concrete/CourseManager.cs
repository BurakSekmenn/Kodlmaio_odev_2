﻿using Kodlmaio2.Bussiness.Abstract;
using Kodlmaio2.DataAccess.Abstract;
using Kodlmaio2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlmaio2.Bussiness.Concrete
{
    public class CourseManager:ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public Course Get(int id)
        {
            return _courseDal.Get(id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
