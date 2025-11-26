using Microsoft.Data.SqlClient;

namespace EntradaDiario.DAL.Repositories;

public class DiarioRepositorio : IDiarioRepositorio
{
    private readonly string _connectionString;

    public DiarioRepositorio(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void ActualizarEntrada(Entities.EntradaDiario entrada)
    {
        using SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();

        string query = "UPDATE Diario SET Fecha = @Fecha, Titulo = @Titulo, Contenido = @Contenido WHERE Id = @Id";

        using SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Id", entrada.Id);
        command.Parameters.AddWithValue("@Fecha", entrada.Fecha);
        command.Parameters.AddWithValue("@Titulo", entrada.Titulo);
        command.Parameters.AddWithValue("@Contenido", entrada.Contenido);
        command.ExecuteNonQuery();
    }

    //Método para agregar una nueva entrada de diario.
    public void AgregarEntrada(Entities.EntradaDiario entrada)
    {
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        string query = "INSERT INTO Diario (Fecha, Titulo, Contenido) VALUES (@Fecha, @Titulo, @Contenido)";

        using SqlCommand command = new(query, connection);

        command.Parameters.AddWithValue("@Fecha", entrada.Fecha);
        command.Parameters.AddWithValue("@Titulo", entrada.Titulo);
        command.Parameters.AddWithValue("@Contenido", entrada.Contenido);
        command.ExecuteNonQuery();
    }

    public void EliminarEntrada(int id) {
        using SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();

        string query = "DELETE FROM Diario WHERE Id = @Id";

        using SqlCommand command = new(query, connection);
        command.Parameters.AddWithValue("@Id", id);
        command.ExecuteNonQuery();
    }

    public Entities.EntradaDiario? ObtenerEntradaPorId(int id)
    {
        using SqlConnection connection = new(_connectionString);

        connection.Open();

        string query = "SELECT Id, Fecha, Titulo, Contenido, FechaCreacion FROM Diario WHERE Id = @Id";

        using SqlCommand command = new(query, connection);

        command.Parameters.AddWithValue("@Id", id);

        using SqlDataReader reader = command.ExecuteReader();

        if (reader.Read())
        {
            return new Entities.EntradaDiario
            {
                Id = Convert.ToInt32(reader["Id"]),
                Fecha = Convert.ToDateTime(reader["Fecha"]),
                Titulo = reader["Titulo"].ToString(),
                Contenido = reader["Contenido"].ToString(),
                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
            };
        }

        return null;
    }

    public List<Entities.EntradaDiario> ObtenerTodasLasEntradas()
    {
        List<Entities.EntradaDiario> entradas = new();

        using SqlConnection connection = new(_connectionString);
        connection.Open();

        string query = "SELECT Id, Fecha, Titulo, Contenido, FechaCreacion FROM Diario ORDER BY Fecha DESC";

        using SqlCommand command = new(query, connection);

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            entradas.Add(new Entities.EntradaDiario
            {
                Id = Convert.ToInt32(reader["Id"]),
                Fecha = Convert.ToDateTime(reader["Fecha"]),
                Titulo = reader["Titulo"].ToString(),
                Contenido = reader["Contenido"].ToString(),
                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
            });
        }

        return entradas;
    }
}