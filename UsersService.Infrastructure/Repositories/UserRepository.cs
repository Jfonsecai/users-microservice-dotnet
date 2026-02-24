using Microsoft.EntityFrameworkCore;
using UsersService.Application.Interfaces;
using UsersService.Domain.Entities;
using UsersService.Infrastructure.Data;

namespace UsersService.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<List<User>> GetAllAsync()
        => _context.Users.ToListAsync();

    public Task<User?> GetByIdAsync(Guid id)
        => _context.Users.FindAsync(id).AsTask();

    public async Task AddAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}