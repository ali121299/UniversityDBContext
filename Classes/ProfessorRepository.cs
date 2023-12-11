using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ProfessorRepository
    {
        private readonly UniversityDBContext dbContext;

        public ProfessorRepository(UniversityDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<Professor> GetAllProfessors()
        {
            return dbContext.Professors;
        }

        public Professor GetProfessorById(int professorId)
        {
            return dbContext.Professors.FirstOrDefault(p => p.Id == professorId);
        }

        public void AddProfessor(Professor professor)
        {
            dbContext.Professors.Add(professor);
            dbContext.SaveChanges();
        }

        public void UpdateProfessor(Professor updatedProfessor)
        {
            var existingProfessor = dbContext.Professors.FirstOrDefault(p => p.Id == updatedProfessor.Id);

            if (existingProfessor != null)
            {
                existingProfessor.Name = updatedProfessor.Name;
                existingProfessor.Age = updatedProfessor.Age;
                existingProfessor.Phone = updatedProfessor.Phone;
                existingProfessor.YearsOfExperience = updatedProfessor.YearsOfExperience;

                dbContext.SaveChanges();
            }
        }

        public void DeleteProfessor(int professorId)
        {
            var professorToDelete = dbContext.Professors.FirstOrDefault(p => p.Id == professorId);

            if (professorToDelete != null)
            {
                dbContext.Professors.Remove(professorToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
