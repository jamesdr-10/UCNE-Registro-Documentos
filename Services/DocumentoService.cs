using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UCNE_Registro_Documentos.DAL;
using UCNE_Registro_Documentos.Models;

namespace UCNE_Registro_Documentos.Services;

public class DocumentoService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task <List<Documento>> Listar (Expression<Func<Documento, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Documentos
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
}
