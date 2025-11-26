using System.ComponentModel.DataAnnotations;

namespace GestionAlumnos.Models {
	public class Alumno {
		[Key]
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }

		[Display(Name = "Fecha de nacimiento")]
		public DateTime FechaNacimiento { get; set; }
		public Genero Genero { get; set; }
		public Carrera? Carrera { get; set; }

		[Display(Name = "Carrera")]
		public int CarreraId { get; set; }

		public int Edad {
			get {
				if (FechaNacimiento == null) return 0;

				var edad = DateTime.Now.Year - FechaNacimiento.Year;

				return edad;
			}
		}
	}

	public enum Genero {
			Femenino,
			Masculino
	}
}
