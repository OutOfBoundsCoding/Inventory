using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Domain.Model;

namespace Inventory.Application.Interfaces
{
    public interface IApplicationDbCommands
    {
        #region Item
        Task DeleteItem(int id);
        Task<Item> CreateItem(Item item);
        Task<Item> UpdateItem(int id, Item item);
        #endregion

    }
}