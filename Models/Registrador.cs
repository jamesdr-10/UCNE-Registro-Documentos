using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCNE_Registro_Documentos.Models;

public class Registrador : Usuario
{
    [Key]
    public int RegistradorId { get; set; }

    [InverseProperty(nameof(Documento.Registradores))]
    public ICollection<Documento> Documentos { get; set; } = new List<Documento>();
}
