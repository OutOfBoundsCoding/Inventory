using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Domain.Model;

namespace Inventory.Application.Interfaces
{
    public interface IApplicationDbQueries
    {
        Task<Item> GetItem(string SKU);
        Task<IEnumerable<Item>> GetItems();
        Task<IEnumerable<Item>> GetItemsFromDepartment(IEnumerable<Department> departments);

        //employee
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> GetEmployees();
        //departments
        Task<Department> GetDepartment(int id);
        Task<IEnumerable<Department>> GetDepartments();
        //store requests
        Task<StoreRequest> GetStoreRequest(int id);
        Task<IEnumerable<StoreRequest>> GetStoreRequestsByRequester(Employee requester);
        Task<IEnumerable<StoreRequest>> GetStoreRequestsWithItem(Item item);


    }
}