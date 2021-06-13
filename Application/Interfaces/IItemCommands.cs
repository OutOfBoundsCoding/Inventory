using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Domain.Model;

namespace Inventory.Application.Interfaces
{
    public interface IItemCommands
    {

        //TODO: exceptions
        #region Item
        //ItemNotFound

        //SKU existente
        Task<Item> ChangePrice(string SKU, double Price);
        Task<Item> ChangeAvailability(string SKU, bool state);
        //OutOfStock
        //NotEnoughStock
        Task<Item> DecrementQuantity(string SKU, int amount);
        Task<Item> IncrementQuantity(string SKU, int amount);
        #endregion

        #region Department

        #endregion


    }
}