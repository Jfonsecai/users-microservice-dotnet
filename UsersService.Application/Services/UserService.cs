using UsersService.Application.DTOs;
using UsersService.Application.Interfaces;
using UsersService.Domain.Entities;

namespace UsersService.Application.Services;

public class UserService
{
    private readonly IUserRepository _repo;

    public UserService(IUserRepository repo)
    {
        _repo = repo;
    }

    public Task<List<User>> GetAllAsync()
        => _repo.GetAllAsync();

    public Task<User?> GetByIdAsync(Guid id)
        => _repo.GetByIdAsync(id);

    public async Task AddAsync(CreateUserDto dto)
    {
        var user = new User
        {
            Name = dto.Name,
            Email = dto.Email
        };

        await _repo.AddAsync(user);
    }

    public async Task<bool> UpdateAsync(Guid id, UpdateUserDto dto)
    {
        var user = await _repo.GetByIdAsync(id);
        if (user is null) return false;

        user.Name = dto.Name;
        user.Email = dto.Email;

        await _repo.UpdateAsync(user);
        return true;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var user = await _repo.GetByIdAsync(id);
        if (user is null) return false;

        await _repo.DeleteAsync(user);
        return true;
    }
}