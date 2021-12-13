﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.GlobalContracts;
using Entities.Models;
using ServerCommunication;

namespace Blazor.Data
{
    public interface IOrderHandler : IEntityManager<Order>
    {
        Task<bool> ProcessOrder(Order order, List<Inventory> pickInventories);
    }
}