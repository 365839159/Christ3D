using Christ3D.Domain.Validations.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Domain.Commands.Student
{
    class UpdateStudentCommand: StudentCommand
    {
        public UpdateStudentCommand(Guid id, string name, string email, DateTime birthDate, string phone, string province, string city, string county, string street)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Phone = phone;
            Province = province;
            City = city;
            County = county;
            Street = street;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateStudentCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
