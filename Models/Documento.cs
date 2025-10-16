using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCNE_Registro_Documentos.Models;

public class Documento
{
    [Key]
    public int DocumentoId { get; set; }
    public int TipoDocumentoId { get; set; }
    public string Matricula { get; set; } = string.Empty;
    public DateTime FechaSolicitud { get; set; }
    public DateTime? FechaEntrega { get; set; }

    [InverseProperty(nameof(Registrador.Documentos))]
    public ICollection<Registrador> Registradores { get; set; } = new List<Registrador>();

    [ForeignKey(nameof(TipoDocumentoId))]
    public TipoDocumento TipoDocumento { get; set; }

    [ForeignKey(nameof(Matricula))]
    public Estudiante Estudiante { get; set; }
}
