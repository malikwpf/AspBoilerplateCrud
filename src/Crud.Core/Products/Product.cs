using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Crud.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Products
{

    public class Product:Entity<int>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
     
    }
}
