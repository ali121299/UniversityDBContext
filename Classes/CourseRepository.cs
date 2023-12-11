using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CourseRepository
    {
        private readonly UniversityDBContext dbContext;

        public CourseRepository(UniversityDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<Course> GetAllCourses()
        {
            return dbContext.Courses;
        }

        public Course GetCourseById(int courseId)
        {
            return dbContext.Courses.FirstOrDefault(c => c.Id == courseId);
        }

        public IQueryable<Course> GetCoursesByLevel(string level)
        {
            return dbContext.Courses.Where(c => c.Level == level);
        }

        public void AddCourse(Course course)
        {
            dbContext.Courses.Add(course);
            dbContext.SaveChanges();
        }

        public void UpdateCourse(Course updatedCourse)
        {
            var existingCourse = dbContext.Courses.FirstOrDefault(c => c.Id == updatedCourse.Id);

            if (existingCourse != null)
            {
                existingCourse.Name = updatedCourse.Name;
                existingCourse.Level = updatedCourse.Level;

                dbContext.SaveChanges();
            }
        }

        public void DeleteCourse(int courseId)
        {
            var courseToDelete = dbContext.Courses.FirstOrDefault(c => c.Id == courseId);

            if (courseToDelete != null)
            {
                dbContext.Courses.Remove(courseToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
