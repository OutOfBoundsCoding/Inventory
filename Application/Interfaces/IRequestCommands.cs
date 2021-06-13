using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Domain.Model;

namespace Inventory.Application.Interfaces
{
    public interface IRequestCommands
    {
        //ItemUnavailable(wich)
        //EmployeeNotFound
        //EmployeeOutOfDepartment(wich)
        //FIXME: q no reciba storerequest
        Task<StoreRequest> GenerateRequest(StoreRequest request);
    }
}