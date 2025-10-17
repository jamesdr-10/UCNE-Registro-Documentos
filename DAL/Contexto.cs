using Microsoft.EntityFrameworkCore;
using UCNE_Registro_Documentos.Models;

namespace UCNE_Registro_Documentos.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Registrador> Registradores { get; set; }
}
