namespace PrefijoTelefono {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnCargarContactos;
		private System.Windows.Forms.TextBox txtPrefijo;
		private System.Windows.Forms.Button btnBuscarPrefijo;
		private System.Windows.Forms.Label label1; // Para la etiqueta del prefijo

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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnCargarContactos = new System.Windows.Forms.Button();
			this.txtPrefijo = new System.Windows.Forms.TextBox();
			this.btnBuscarPrefijo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(776, 388);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnCargarContactos
			// 
			this.btnCargarContactos.Location = new System.Drawing.Point(12, 12);
			this.btnCargarContactos.Name = "btnCargarContactos";
			this.btnCargarContactos.Size = new System.Drawing.Size(120, 23);
			this.btnCargarContactos.TabIndex = 1;
			this.btnCargarContactos.Text = "Cargar Todos";
			this.btnCargarContactos.UseVisualStyleBackColor = true;
			this.btnCargarContactos.Click += new System.EventHandler(this.btnCargarContactos_Click);
			// 
			// txtPrefijo
			// 
			this.txtPrefijo.Location = new System.Drawing.Point(280, 14);
			this.txtPrefijo.Name = "txtPrefijo";
			this.txtPrefijo.Size = new System.Drawing.Size(100, 20);
			this.txtPrefijo.TabIndex = 2;
			// 
			// btnBuscarPrefijo
			// 
			this.btnBuscarPrefijo.Location = new System.Drawing.Point(386, 12);
			this.btnBuscarPrefijo.Name = "btnBuscarPrefijo";
			this.btnBuscarPrefijo.Size = new System.Drawing.Size(120, 23);
			this.btnBuscarPrefijo.TabIndex = 3;
			this.btnBuscarPrefijo.Text = "Buscar por Prefijo";
			this.btnBuscarPrefijo.UseVisualStyleBackColor = true;
			this.btnBuscarPrefijo.Click += new System.EventHandler(this.btnBuscarPrefijo_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(170, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Prefijo de Teléfono:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBuscarPrefijo);
			this.Controls.Add(this.txtPrefijo);
			this.Controls.Add(this.btnCargarContactos);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Gestión de Contactos";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
	}
}

