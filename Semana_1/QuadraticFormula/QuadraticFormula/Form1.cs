using QuadraticFormula.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuadraticFormula {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e) {
			double a = Convert.ToDouble(txtA.Text);
			double b = Convert.ToDouble(txtB.Text);
			double c = Convert.ToDouble(txtC.Text);

			Formula f1 = new Formula(a, b, c);
			txtX1.Text = f1.X1.ToString();
			txtX2.Text = f1.X2.ToString();
		}

		private void btnLimpiar_Click(object sender, EventArgs e) {
			this.Controls.OfType<TextBox>().ToList().ForEach(textBox => { textBox.Clear(); });
		}
	}
}