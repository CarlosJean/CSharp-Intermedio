using System;

namespace QuadraticFormula.Classes {
	public class X2 : Formula {
		public X2(double a, double b, double c) : base(a, b, c) { }

		//-b - √b² - 4ac / 2a
		public override double Product => (-this.B - Math.Sqrt(this.Discriminant)) / this.Denominator;
	}
}