using System.Collections.Generic;

namespace Inventory.Domain.Model
{
    public class StoreRequest
    {

        public int Id { get; set; }
        public Employee Requester { get; set; }
        public IEnumerable<Item> items { get; set; }
        public string Description { get; set; }

    }
}