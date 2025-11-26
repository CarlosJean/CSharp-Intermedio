

using EntradaDiarioEntity = EntradaDiario.Entities.EntradaDiario;

public interface IDiarioRepositorio
{
    void AgregarEntrada(EntradaDiarioEntity entrada);
    List<EntradaDiarioEntity> ObtenerTodasLasEntradas();
    EntradaDiarioEntity? ObtenerEntradaPorId(int id);
    void ActualizarEntrada(EntradaDiarioEntity entrada); 
    void EliminarEntrada(int id);
}