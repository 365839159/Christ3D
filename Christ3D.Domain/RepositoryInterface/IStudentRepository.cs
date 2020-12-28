using Christ3D.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Domain.RepositoryInterface
{
    public interface IStudentRepository : IRepository<Student>
    {
        //Student 独有的接口
        Student GetByEmail(string email);
    }

}
