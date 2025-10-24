using Calculadora.Classes;
using Calculadora.Interfaces;
using System;
using System.Windows.Forms;

namespace Calculadora {
	public partial class Form1 : Form {

		private double first;
		private double second;
		private IOperation operation;

		public Form1() {
			InitializeComponent();
		}

		//Evento del botón igual (=)
		private void BtnEqual_Click(object sender, EventArgs e) {
			second = double.Parse(tbxScreen.Text);
			double result = this.operation.Do(first, second);
			tbxScreen.Text = result.ToString();
		}

		//Evento del botón CE
		private void BtnClear_Click(object sender, EventArgs e) {
			this.Clear();
		}

		//Evento del botón de borrar
		private void BtnDelete_Click(object sender, EventArgs e) {
			int length = (tbxScreen.Text.Length > 0) ? tbxScreen.Text.Length - 1 : 0;
			
			if (length <= 0) {
				this.Clear();
			}

			tbxScreen.Text = tbxScreen.Text.Remove(length);				
		}

		//Método para limpiar todo
		private void Clear() {
			tbxScreen.Text = "0";
			first = 0;
			second = 0;
			this.operation = null;
		}

		//Evento general para los números y el punto decimal
		private void BtnTerm_Click(object sender, EventArgs e) {
			Button btn = (Button)sender;
			tbxScreen.Text += btn.Text;
		}

		//Evento general para los operadores aritméticos
		private void BtnOperator_Click(object sender, EventArgs e) {

			string screen = (tbxScreen.Text == "") ? "0" : tbxScreen.Text;
			first = double.Parse(screen);
			tbxScreen.Clear();

			Button btn = (Button)sender;

			switch (btn.Text) {
				case "+":
					this.operation = new ClsAddition();
					break;
				case "-":
					this.operation = new ClsSubstraction();
					break;
				case "*":
					this.operation = new ClsMultiplication();
					break;
				case "/":
					this.operation = new ClsDivision();
					break;
				default:
					break;
			}
		}
	}
}