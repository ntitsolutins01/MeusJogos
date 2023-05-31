using MeusJogos.Application.Common.Mappings;
using MeusJogos.Domain.Entities;

namespace MeusJogos.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
