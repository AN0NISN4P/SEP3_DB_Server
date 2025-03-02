﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using T1Contracts.ServerCommunicationInterfaces;

namespace Blazor.Data.Implementation
{
    public class LocationHandler : ILocationHandler
    {
        private ILocationDataServerComm _locationDataServerComm;

        public LocationHandler(ILocationDataServerComm locationDataServerComm)
        {
            _locationDataServerComm = locationDataServerComm;
        }

        public async Task<Location> RegisterAsync(Location location)
        {
            return await _locationDataServerComm.RegisterAsync(location);
        }

        public Task<bool> RemoveAsync(int location)
        {
            throw new System.NotImplementedException();
        }

        public Task<Location> UpdateAsync(Location location)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Location>> GetAllAsync()
        {
            return await _locationDataServerComm.GetAllAsync();
        }

        public async Task<Location> GetAsync(int location)
        {
            throw new System.NotImplementedException();
        }
    }
}