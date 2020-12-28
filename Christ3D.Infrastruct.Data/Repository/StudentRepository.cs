using Christ3D.Domain.Models;
using Christ3D.Domain.RepositoryInterface;
using Christ3D.Infrastruct.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Infrastruct.Data.Repository
{
    public class StudentRepository : Repository<Student> ,IStudentRepository
    {
        public StudentRepository(StudyContext studyContext) : base(studyContext) { }
        public Student GetByEmail(string email)
        {
            return DbSet.Find(email);
        }
    }
}
