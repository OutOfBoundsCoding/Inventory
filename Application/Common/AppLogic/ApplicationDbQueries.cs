using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Domain.Model;

namespace Inventory.Application.Interfaces
{
    public class ApplicationDbQueries
    {
        public IApplicationRepository _repository { get; set; }

        public ApplicationDbQueries(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Item> GetItemsByEmployee(Employee employee)
        {
            var departments = employee.departments;
            var items = _repository.GetItems(i => departments.Contains(i.department));
            return items;
        }
        public IEnumerable<Item> GetItems()
        {
            var items = _repository.GetItems();
            return items;
        }

    }
}