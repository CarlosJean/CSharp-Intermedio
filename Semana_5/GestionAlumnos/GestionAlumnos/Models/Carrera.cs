using System.ComponentModel.DataAnnotations;

namespace GestionAlumnos.Models {
	public class Carrera {
		[Key]
		public int Id { get; set; }
		public string Nombre { get; set; }
		public ICollection<Alumno>? Alumnos { get; set; }
	}
}
