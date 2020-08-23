using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatrFun.Data.Models;
using MediatrFun.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MediatrFun.Data.Repositories.Implementations
{
    public class BookRepository : IRepository<Book>
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            return await _context.Books.SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task<EntityEntry<Book>> Add(Book item)
        {
            return await _context.Books.AddAsync(item);
        }

        public async Task<Book> Update(Book item)
        {
            var existing = await _context.Books.SingleOrDefaultAsync(b => b.Id == item.Id);
            
            if (existing == null) return null;
            
            existing.Name = item.Name;
            existing.UpdatedMoment = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return existing;
        }
    }
}