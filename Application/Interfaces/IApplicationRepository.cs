using System;
using System.Collections.Generic;
using Inventory.Domain.Model;

namespace Inventory.Application.Interfaces
{
    public interface IApplicationRepository
    {
        IEnumerable<Item> GetItems(Action<Item> filter = null);
        Item GetItem(string id);

        int UpdateItem(Item item, string id);

        int CreateItem(Item item);

        int DeleteItem(Item item);

    }
}