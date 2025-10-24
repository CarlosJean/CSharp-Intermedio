using Calculadora.Interfaces;

namespace Calculadora.Classes {
	public class ClsDivision : IOperation {
		public double Do(double n1, double n2) {
			return n1 / n2;
		}
	}
}
