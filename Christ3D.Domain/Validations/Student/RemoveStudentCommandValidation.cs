using Christ3D.Domain.Commands.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Domain.Validations.Student
{
    class RemoveStudentCommandValidation: StudentValidation<RemoveStudentCommand>
    {
        public RemoveStudentCommandValidation()
        {
            ValidateId();
        }
    }
}
