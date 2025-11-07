namespace FormularioContacto.WForm {
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
			components = new System.ComponentModel.Container();
			menuStrip1 = new MenuStrip();
			nuevoToolStripMenuItem = new ToolStripMenuItem();
			registrarToolStripMenuItem = new ToolStripMenuItem();
			modificarToolStripMenuItem1 = new ToolStripMenuItem();
			eliminarToolStripMenuItem = new ToolStripMenuItem();
			groupBox1 = new GroupBox();
			txtPhoneNumber = new TextBox();
			txtEmail = new TextBox();
			txtName = new TextBox();
			txtContactId = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			txtSearch = new TextBox();
			label5 = new Label();
			groupBox3 = new GroupBox();
			DgvContacts = new DataGridView();
			errorProvider1 = new ErrorProvider(components);
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DgvContacts).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, registrarToolStripMenuItem, modificarToolStripMenuItem1, eliminarToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(907, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// nuevoToolStripMenuItem
			// 
			nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			nuevoToolStripMenuItem.Size = new Size(54, 20);
			nuevoToolStripMenuItem.Text = "Nuevo";
			nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
			// 
			// registrarToolStripMenuItem
			// 
			registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
			registrarToolStripMenuItem.Size = new Size(65, 20);
			registrarToolStripMenuItem.Text = "Registrar";
			registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
			// 
			// modificarToolStripMenuItem1
			// 
			modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
			modificarToolStripMenuItem1.Size = new Size(70, 20);
			modificarToolStripMenuItem1.Text = "Modificar";
			modificarToolStripMenuItem1.Click += modificarToolStripMenuItem_Click;
			// 
			// eliminarToolStripMenuItem
			// 
			eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			eliminarToolStripMenuItem.Size = new Size(62, 20);
			eliminarToolStripMenuItem.Text = "Eliminar";
			eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtPhoneNumber);
			groupBox1.Controls.Add(txtEmail);
			groupBox1.Controls.Add(txtName);
			groupBox1.Controls.Add(txtContactId);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 27);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(883, 103);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Datos";
			// 
			// txtPhoneNumber
			// 
			txtPhoneNumber.Location = new Point(529, 60);
			txtPhoneNumber.Name = "txtPhoneNumber";
			txtPhoneNumber.Size = new Size(158, 23);
			txtPhoneNumber.TabIndex = 7;
			txtPhoneNumber.Validating += FrmContacts_Onvalidating;
			txtPhoneNumber.Validated += FrmContacts_Validated;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(529, 26);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(282, 23);
			txtEmail.TabIndex = 6;
			txtEmail.Validating += FrmContacts_Onvalidating;
			txtEmail.Validated += FrmContacts_Validated;
			// 
			// txtName
			// 
			txtName.Location = new Point(69, 60);
			txtName.Name = "txtName";
			txtName.Size = new Size(268, 23);
			txtName.TabIndex = 5;
			txtName.Validating += FrmContacts_Onvalidating;
			txtName.Validated += FrmContacts_Validated;
			// 
			// txtContactId
			// 
			txtContactId.Location = new Point(69, 29);
			txtContactId.Name = "txtContactId";
			txtContactId.ReadOnly = true;
			txtContactId.Size = new Size(150, 23);
			txtContactId.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(470, 60);
			label4.Name = "label4";
			label4.Size = new Size(53, 15);
			label4.TabIndex = 3;
			label4.Text = "Teléfono";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(470, 29);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 2;
			label3.Text = "Email";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(17, 63);
			label2.Name = "label2";
			label2.Size = new Size(51, 15);
			label2.TabIndex = 1;
			label2.Text = "Nombre";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 32);
			label1.Name = "label1";
			label1.Size = new Size(46, 15);
			label1.TabIndex = 0;
			label1.Text = "Código";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(txtSearch);
			groupBox2.Controls.Add(label5);
			groupBox2.Location = new Point(12, 136);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(883, 82);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Buscar";
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(63, 38);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(621, 23);
			txtSearch.TabIndex = 1;
			txtSearch.TextChanged += TxtSearch_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 41);
			label5.Name = "label5";
			label5.Size = new Size(51, 15);
			label5.TabIndex = 0;
			label5.Text = "Nombre";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(DgvContacts);
			groupBox3.Location = new Point(12, 224);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(883, 214);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "Listar";
			// 
			// DgvContacts
			// 
			DgvContacts.AllowUserToAddRows = false;
			DgvContacts.AllowUserToDeleteRows = false;
			DgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			DgvContacts.Dock = DockStyle.Fill;
			DgvContacts.Location = new Point(3, 19);
			DgvContacts.Name = "DgvContacts";
			DgvContacts.ReadOnly = true;
			DgvContacts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			DgvContacts.SelectionMode = DataGridViewSelectionMode.CellSelect;
			DgvContacts.Size = new Size(877, 192);
			DgvContacts.TabIndex = 0;
			DgvContacts.CellClick += DgvContacts_CellClick;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(907, 450);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			Name = "Form1";
			Text = "Formulario de contacto";
			Load += Form1_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)DgvContacts).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem nuevoToolStripMenuItem;
		private ToolStripMenuItem registrarToolStripMenuItem;
		private ToolStripMenuItem modificarToolStripMenuItem1;
		private ToolStripMenuItem eliminarToolStripMenuItem;
		private GroupBox groupBox1;
		private TextBox txtPhoneNumber;
		private TextBox txtEmail;
		private TextBox txtName;
		private TextBox txtContactId;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private GroupBox groupBox2;
		private TextBox txtSearch;
		private Label label5;
		private GroupBox groupBox3;
		private DataGridView DgvContacts;
		private ErrorProvider errorProvider1;
	}
}
