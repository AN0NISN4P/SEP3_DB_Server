using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseAccess.DataRepos.Impl
{
    public class ItemDataRepo: IDataRepo<Item>
    {

        private SEP_DBContext _sepDbContext;
        
        public ItemDataRepo(DbContext dbContext)
        {
            _sepDbContext = (SEP_DBContext) dbContext;
        }


        public async Task AddAsync(Item item)
        {
            // Adds Item to Database
            await _sepDbContext.Items.AddAsync(item);
            await _sepDbContext.SaveChangesAsync();
        }

        public async Task<Item> RemoveAsync(Object itemId)
        {
            // Find Item which is to be deleted
            Item itemToDelete = await _sepDbContext.Items.FindAsync((int)itemId);
            if (itemToDelete == null)
            {
                // If Item was not found, return 404 not found
                return null;
            }

            // Remove Item
            _sepDbContext.Items.Remove(itemToDelete);
            Console.WriteLine($"- {itemToDelete.ItemName}"); // FIXME
            // Save Changes done to DB
            await _sepDbContext.SaveChangesAsync();
            // Return deleted item
            return itemToDelete;
        }

        public async Task UpdateAsync(Item item)
        {
            _sepDbContext.Items.Update(item);
            await _sepDbContext.SaveChangesAsync();
        }

        public async Task<IList<Item>> GetAllAsync()
        {
            return await _sepDbContext.Items.ToListAsync();
        }

        public async Task<Item> GetAsync(Object itemId)
        {
            return await _sepDbContext.Items.FindAsync((int)itemId);
        }
        
    }
}