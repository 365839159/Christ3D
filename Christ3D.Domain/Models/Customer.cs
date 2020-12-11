using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Domain.Models
{
    public class Customer
    {
        protected Customer() { }
        public Customer(Guid id, string name, string email, DateTime birthDate)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public Guid Id { get; }
        public string Name { get; }
        public string Email { get; }
        public DateTime BirthDate { get; }

    }
}
