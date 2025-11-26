namespace EntradaDiario.WForm {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			groupBox1 = new GroupBox();
			btnGuardar = new Button();
			txtContenidoNuevo = new TextBox();
			label3 = new Label();
			txtTituloNuevo = new TextBox();
			label2 = new Label();
			dtpFechaNueva = new DateTimePicker();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btnVerDetalle = new Button();
			lstEntradas = new ListBox();
			txtDetalleEntrada = new TextBox();
			lblDetalle = new Label();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnGuardar);
			groupBox1.Controls.Add(txtContenidoNuevo);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(txtTituloNuevo);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(dtpFechaNueva);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(657, 280);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nueva entrada";
			// 
			// btnGuardar
			// 
			btnGuardar.Location = new Point(459, 89);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(192, 119);
			btnGuardar.TabIndex = 6;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// txtContenidoNuevo
			// 
			txtContenidoNuevo.Location = new Point(75, 89);
			txtContenidoNuevo.Multiline = true;
			txtContenidoNuevo.Name = "txtContenidoNuevo";
			txtContenidoNuevo.ScrollBars = ScrollBars.Vertical;
			txtContenidoNuevo.Size = new Size(374, 185);
			txtContenidoNuevo.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 97);
			label3.Name = "label3";
			label3.Size = new Size(63, 15);
			label3.TabIndex = 4;
			label3.Text = "Contenido";
			// 
			// txtTituloNuevo
			// 
			txtTituloNuevo.Location = new Point(75, 60);
			txtTituloNuevo.Name = "txtTituloNuevo";
			txtTituloNuevo.Size = new Size(374, 23);
			txtTituloNuevo.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 68);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 2;
			label2.Text = "Título";
			// 
			// dtpFechaNueva
			// 
			dtpFechaNueva.Location = new Point(75, 31);
			dtpFechaNueva.Name = "dtpFechaNueva";
			dtpFechaNueva.Size = new Size(200, 23);
			dtpFechaNueva.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 37);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 0;
			label1.Text = "Fecha";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnVerDetalle);
			groupBox2.Controls.Add(lstEntradas);
			groupBox2.Location = new Point(12, 298);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(657, 328);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Entradas anteriores";
			// 
			// btnVerDetalle
			// 
			btnVerDetalle.Dock = DockStyle.Bottom;
			btnVerDetalle.Location = new Point(3, 269);
			btnVerDetalle.Name = "btnVerDetalle";
			btnVerDetalle.Size = new Size(651, 56);
			btnVerDetalle.TabIndex = 1;
			btnVerDetalle.Text = "Ver detalle";
			btnVerDetalle.UseVisualStyleBackColor = true;
			btnVerDetalle.Click += btnVerDetalle_Click;
			// 
			// lstEntradas
			// 
			lstEntradas.Dock = DockStyle.Top;
			lstEntradas.FormattingEnabled = true;
			lstEntradas.ItemHeight = 15;
			lstEntradas.Location = new Point(3, 19);
			lstEntradas.Name = "lstEntradas";
			lstEntradas.Size = new Size(651, 244);
			lstEntradas.TabIndex = 0;
			lstEntradas.SelectedIndexChanged += lstEntradas_SelectedIndexChanged;
			// 
			// txtDetalleEntrada
			// 
			txtDetalleEntrada.Dock = DockStyle.Bottom;
			txtDetalleEntrada.Location = new Point(0, 661);
			txtDetalleEntrada.Multiline = true;
			txtDetalleEntrada.Name = "txtDetalleEntrada";
			txtDetalleEntrada.ScrollBars = ScrollBars.Vertical;
			txtDetalleEntrada.Size = new Size(678, 141);
			txtDetalleEntrada.TabIndex = 2;
			txtDetalleEntrada.Visible = false;
			// 
			// lblDetalle
			// 
			lblDetalle.AutoSize = true;
			lblDetalle.Location = new Point(12, 643);
			lblDetalle.Name = "lblDetalle";
			lblDetalle.Size = new Size(43, 15);
			lblDetalle.TabIndex = 3;
			lblDetalle.Text = "Detalle";
			lblDetalle.Visible = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 802);
			Controls.Add(lblDetalle);
			Controls.Add(txtDetalleEntrada);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			MaximizeBox = false;
			Name = "Form1";
			Text = "Entrada de diario";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private Label label1;
		private Button btnGuardar;
		private TextBox txtContenidoNuevo;
		private Label label3;
		private TextBox txtTituloNuevo;
		private Label label2;
		private DateTimePicker dtpFechaNueva;
		private GroupBox groupBox2;
		private ListBox lstEntradas;
		private TextBox txtDetalleEntrada;
		private Label lblDetalle;
		private Button btnVerDetalle;
	}
}
