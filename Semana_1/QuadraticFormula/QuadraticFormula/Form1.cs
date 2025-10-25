using QuadraticFormula.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuadraticFormula {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void BtnCalculate_Click(object sender, EventArgs e) {
			double a = Convert.ToDouble(txtA.Text);
			double b = Convert.ToDouble(txtB.Text);
			double c = Convert.ToDouble(txtC.Text);

			Formula formula = new X1(a, b, c);
			txtX1.Text = formula
					.Product
					.ToString();

			formula = new X2(a, b, c);
			txtX2.Text = formula
					.Product
					.ToString();
		}

		private void BtnClear_Click(object sender, EventArgs e) {
			this.Controls.OfType<TextBox>().ToList().ForEach(textBox => { textBox.Clear(); });
		}
	}
}