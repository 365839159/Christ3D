using Christ3D.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Domain.Interfaces
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        //Customer 独有的接口
        Customer getByEmail(string email);
    }
}
