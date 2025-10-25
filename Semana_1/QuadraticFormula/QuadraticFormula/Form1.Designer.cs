namespace QuadraticFormula {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblA = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.lblB = new System.Windows.Forms.Label();
			this.txtC = new System.Windows.Forms.TextBox();
			this.lblC = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.lblX1 = new System.Windows.Forms.Label();
			this.txtX2 = new System.Windows.Forms.TextBox();
			this.lblX2 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA.Location = new System.Drawing.Point(3, 9);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(30, 32);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "a";
			// 
			// txtA
			// 
			this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtA.Location = new System.Drawing.Point(37, 6);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 38);
			this.txtA.TabIndex = 1;
			// 
			// txtB
			// 
			this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtB.Location = new System.Drawing.Point(37, 53);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 38);
			this.txtB.TabIndex = 3;
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblB.Location = new System.Drawing.Point(3, 53);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(30, 32);
			this.lblB.TabIndex = 2;
			this.lblB.Text = "b";
			// 
			// txtC
			// 
			this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtC.Location = new System.Drawing.Point(37, 102);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 38);
			this.txtC.TabIndex = 5;
			// 
			// lblC
			// 
			this.lblC.AutoSize = true;
			this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblC.Location = new System.Drawing.Point(3, 105);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(28, 32);
			this.lblC.TabIndex = 4;
			this.lblC.Text = "c";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(319, 147);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(150, 80);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalculate_Click);
			// 
			// txtX1
			// 
			this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtX1.Location = new System.Drawing.Point(198, 31);
			this.txtX1.Name = "txtX1";
			this.txtX1.ReadOnly = true;
			this.txtX1.Size = new System.Drawing.Size(427, 38);
			this.txtX1.TabIndex = 8;
			// 
			// lblX1
			// 
			this.lblX1.AutoSize = true;
			this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX1.Location = new System.Drawing.Point(143, 34);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(49, 32);
			this.lblX1.TabIndex = 7;
			this.lblX1.Text = "X1";
			// 
			// txtX2
			// 
			this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtX2.Location = new System.Drawing.Point(198, 92);
			this.txtX2.Name = "txtX2";
			this.txtX2.ReadOnly = true;
			this.txtX2.Size = new System.Drawing.Size(427, 38);
			this.txtX2.TabIndex = 10;
			// 
			// lblX2
			// 
			this.lblX2.AutoSize = true;
			this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX2.Location = new System.Drawing.Point(143, 92);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(49, 32);
			this.lblX2.TabIndex = 9;
			this.lblX2.Text = "X2";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(475, 147);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(150, 80);
			this.btnLimpiar.TabIndex = 11;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 239);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.txtX2);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.txtX1);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblA);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Fórmula cuadrática";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.Label lblC;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.TextBox txtX2;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Button btnLimpiar;
	}
}

