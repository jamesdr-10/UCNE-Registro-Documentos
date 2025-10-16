using System.ComponentModel.DataAnnotations;

namespace UCNE_Registro_Documentos.Models;

public class TipoDocumento
{
    [Key]
    public int TipoDocumentoId { get; set; }
    public string Nombre { get; set; } = string.Empty;
}
