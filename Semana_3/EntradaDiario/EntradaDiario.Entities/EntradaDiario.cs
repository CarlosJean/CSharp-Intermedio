namespace EntradaDiario.Entities;
public class EntradaDiario {
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string? Titulo { get; set; }
    public string? Contenido { get; set; }
    public DateTime FechaCreacion { get; set; }
}