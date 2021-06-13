using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Domain.Model;

namespace Inventory.Application.Models
{
    public class Result
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public static Result Success()
        {
            return new Result()
            {
                Successful = true,
                Errors = new string[] { }
            };
        }

        public static Result Fail(params string[] errors)
        {
            return new Result()
            {
                Successful = false,
                Errors = errors
            };
        }
    }
}