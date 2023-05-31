using System.Globalization;
using MeusJogos.Application.Common.Interfaces;
using MeusJogos.Application.TodoLists.Queries.ExportTodos;
using MeusJogos.Infrastructure.Files.Maps;
using CsvHelper;

namespace MeusJogos.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
