using Microsoft.EntityFrameworkCore;
using UCNE_Registro_Documentos.DAL;
using UCNE_Registro_Documentos.Models;

namespace UCNE_Registro_Documentos.Services;

public class RegistradorService(IDbContextFactory<Contexto> DbFactory)
{
    public async Task <bool> ExisteCredenciales (string nombreUsuario, string contrasena)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registradores
            .AnyAsync(r => r.NombreUsuario.Equals(nombreUsuario.Trim()) && r.Contrasena.Equals(contrasena));
    }

    public async Task<Registrador?> BuscarPorCredenciales (string nombreUsuario, string contrasena)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registradores
            .FirstOrDefaultAsync(r => r.NombreUsuario.Equals(nombreUsuario.Trim()) && r.Contrasena.Equals(contrasena));
    }
}
