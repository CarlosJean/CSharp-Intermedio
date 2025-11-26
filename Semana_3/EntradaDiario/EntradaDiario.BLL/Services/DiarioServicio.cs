using EntradaDiario.BLL.Interfaces;

namespace EntradaDiario.BLL.Services;

public class DiarioServicio : IDiarioServicio
{
    private readonly IDiarioRepositorio _repositorio;

    public DiarioServicio(IDiarioRepositorio repositorio)
    {
        _repositorio = repositorio;
    }
    
    public void ActualizarEntrada(Entities.EntradaDiario entrada)
    {
        _repositorio.ActualizarEntrada(entrada);
    }

    public void AgregarEntrada(Entities.EntradaDiario entrada)
    {
        _repositorio.AgregarEntrada(entrada);
    }

    public void EliminarEntrada(int id)
    {
        _repositorio.EliminarEntrada(id);
    }

    public Entities.EntradaDiario? ObtenerEntradaPorId(int id)
    {
        return _repositorio.ObtenerEntradaPorId(id);
    }

    public List<Entities.EntradaDiario> ObtenerTodasLasEntradas()
    {
        return _repositorio.ObtenerTodasLasEntradas();
    }
}