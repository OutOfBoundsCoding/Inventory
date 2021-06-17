using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Domain.Model;

namespace Inventory.Application.Interfaces
{
    public class ApplicationDbCommands
    {
        Task<Item> UpdateItem(int id, Item item)
        {
            return new Task<Item>(() => new Item());
        }
    }
}