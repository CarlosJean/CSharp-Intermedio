using System;

namespace QuadraticFormula.Classes {
	public class Formula {

		private readonly double _x1;
		private readonly double _x2;

		public double X1 => _x1;
		public double X2 => _x2;

		public Formula(double a, double b, double c) {			
			//b² - 4ac
			double discriminant = Math.Pow(b, 2) - 4 * a * c;

			// 2a
			double denominator = 2 * a;

			//-b + √b² - 4ac / 2a
			this._x1 = (-b + Math.Sqrt(discriminant)) / denominator;

			//-b - √b²- 4ac / 2a
			this._x2 = (-b - Math.Sqrt(discriminant)) / denominator;
		}
	}
}
