using Microsoft.EntityFrameworkCore;
using UCNE_Registro_Documentos.DAL;
using UCNE_Registro_Documentos.Models;

namespace UCNE_Registro_Documentos.Services
{
    public class RegistradorService(IDbContextFactory<Contexto> DbFactory)
    {
        public async Task <bool> ExisteCredenciales (int registradoId, string registradorNombreUsuario)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Registradores.AnyAsync(r => r.RegistradorId == registradoId && r.NombreUsuario.Equals(registradorNombreUsuario.Trim()));
        }

        public async Task<Registrador?> BuscarRegistrador (int registradoId, string registradorNombreUsuario)
        {

        }
    }
}
