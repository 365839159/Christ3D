using Christ3D.Domain.Commands.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Domain.Validations.Student
{
    class UpdateStudentCommandValidation : StudentValidation<UpdateStudentCommand>
    {
        public UpdateStudentCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateBirthDate();
            ValidateEmail();
            ValidatePhone();
        }

    }
}
