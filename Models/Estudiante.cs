    using System.ComponentModel.DataAnnotations;

namespace UCNE_Registro_Documentos.Models;

public class Estudiante : Usuario
{
    [Key]
    public int EstudianteId { get; set; }
    public string Matricula { get; set; } = string.Empty;
    public string Carrera { get; set; } = string.Empty;
    public bool EsEgresado { get; set; }
    public ICollection<Documento> Documentos { get; set; } = new List<Documento>();
}
