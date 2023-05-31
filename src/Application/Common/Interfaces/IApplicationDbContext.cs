using MeusJogos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeusJogos.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
