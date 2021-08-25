using System;
using System.Collections.Generic;

namespace CompanyTree.V1.Contracts
{
    public class RoleContract
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public ICollection<EmployeeContract> Employees { get; set; } = new HashSet<EmployeeContract>();
    }
}
