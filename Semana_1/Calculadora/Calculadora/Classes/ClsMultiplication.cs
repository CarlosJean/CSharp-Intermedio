using Calculadora.Interfaces;

namespace Calculadora.Classes {
	public class ClsMultiplication : IOperation {
		public double Do(double n1, double n2) {
			return n1 * n2;
		}
	}
}