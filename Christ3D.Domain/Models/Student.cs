using Christ3D.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Domain.Models
{
    public class Student:Entity
    {
        protected Student() { }
        public Student(Guid id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Email = email;
            Name = name;
            BirthDate = birthDate;
        }

        //public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        public string Phone { get; private set; }
        public Address Address { get; private set; }
    }
}
