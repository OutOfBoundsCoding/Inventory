using System.Collections.Generic;

namespace Inventory.Domain.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CID { get; set; }
        public IEnumerable<Department> departments { get; set; }

    }
}