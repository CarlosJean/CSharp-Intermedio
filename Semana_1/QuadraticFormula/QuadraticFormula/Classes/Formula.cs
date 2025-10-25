using System;

namespace QuadraticFormula.Classes {
	public abstract class Formula {

		protected readonly double Discriminant;
		protected readonly double B;
		protected readonly double Denominator;		

		public Formula(double a, double b, double c) {

			this.B = b;

			//b² - 4ac
			this.Discriminant = Math.Pow(b, 2) - 4 * a * c;

			// 2a
			this.Denominator = 2 * a;
		}

		public abstract double Product { get; }
	}
}
