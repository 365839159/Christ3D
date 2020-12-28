using Christ3D.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Application.ServiceInterface
{
   public interface IStudentService:IDisposable
    {
        void Register(StudentViewModel customerViewModel);

        IEnumerable<StudentViewModel> GetAll();

        StudentViewModel GetById(Guid id);

        void Update(StudentViewModel customerViewModel);

        void Remove(Guid id);

        
    }
}
