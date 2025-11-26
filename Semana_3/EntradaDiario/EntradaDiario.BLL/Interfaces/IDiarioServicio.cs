namespace EntradaDiario.BLL.Interfaces;

using EntradaDiarioEntity = Entities.EntradaDiario;

public interface IDiarioServicio
{
    void AgregarEntrada(EntradaDiarioEntity entrada);
    List<EntradaDiarioEntity> ObtenerTodasLasEntradas();
    EntradaDiarioEntity? ObtenerEntradaPorId(int id);
    void ActualizarEntrada(EntradaDiarioEntity entrada);
    void EliminarEntrada(int id);
}