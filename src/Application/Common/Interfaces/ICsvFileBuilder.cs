using MeusJogos.Application.TodoLists.Queries.ExportTodos;

namespace MeusJogos.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
