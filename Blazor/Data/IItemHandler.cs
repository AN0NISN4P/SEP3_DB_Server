using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using ServerCommunication;

namespace Blazor.Data
{
    public interface IItemHandler : IEntityManager<Item>,IHandler
    {
        
    }
}