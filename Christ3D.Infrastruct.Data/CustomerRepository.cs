using Christ3D.Domain.Interfaces;
using Christ3D.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Infrastruct.Data
{
    class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public Customer getByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
