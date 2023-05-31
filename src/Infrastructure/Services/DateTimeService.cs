using MeusJogos.Application.Common.Interfaces;

namespace MeusJogos.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
