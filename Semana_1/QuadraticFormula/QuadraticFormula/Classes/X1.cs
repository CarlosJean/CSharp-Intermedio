using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticFormula.Classes {
	public class X1 : Formula {
		public X1(double a, double b, double c) : base(a, b, c) { }
		
		//-b + √b² - 4ac / 2a
		public override double Product => (-this.B + Math.Sqrt(this.Discriminant)) / this.Denominator;
	}
}
