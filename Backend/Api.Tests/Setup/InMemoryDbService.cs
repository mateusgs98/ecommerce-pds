using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Api.Adaptadores.BD;

namespace Api.Tests.Setup
{
    public static class InMemoryDbService
    {
        public static ContextoBd GerarContextoBd(string nomeBd)
        {
            var opcoes = new DbContextOptionsBuilder<ContextoBd>()
                .UseInMemoryDatabase(nomeBd)
                .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                .Options;

            return new ContextoBd(opcoes);
        }
    }
}