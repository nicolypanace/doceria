namespace doceria
{
    partial class RegistroFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.Nome = new System.Windows.Forms.Label();
			this.Salário = new System.Windows.Forms.Label();
			this.Cargo = new System.Windows.Forms.Label();
			this.txtCargo = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtSalario = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cJ3027571PR2DataSet1 = new doceria.CJ3027571PR2DataSet1();
			this.funcionariosTableAdapter = new doceria.CJ3027571PR2DataSet1TableAdapters.FuncionariosTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// Nome
			// 
			this.Nome.AutoSize = true;
			this.Nome.BackColor = System.Drawing.Color.Transparent;
			this.Nome.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nome.Location = new System.Drawing.Point(210, 256);
			this.Nome.Name = "Nome";
			this.Nome.Size = new System.Drawing.Size(50, 19);
			this.Nome.TabIndex = 0;
			this.Nome.Text = "Nome";
			this.Nome.Click += new System.EventHandler(this.Nome_Click);
			// 
			// Salário
			// 
			this.Salário.AutoSize = true;
			this.Salário.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Salário.Image = global::doceria.Properties.Resources.Logotipo_Doceria_Minimalista_Marrom_e_Rosa;
			this.Salário.Location = new System.Drawing.Point(210, 334);
			this.Salário.Name = "Salário";
			this.Salário.Size = new System.Drawing.Size(56, 19);
			this.Salário.TabIndex = 1;
			this.Salário.Text = "Salário";
			// 
			// Cargo
			// 
			this.Cargo.AutoSize = true;
			this.Cargo.BackColor = System.Drawing.Color.Transparent;
			this.Cargo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cargo.Location = new System.Drawing.Point(210, 295);
			this.Cargo.Name = "Cargo";
			this.Cargo.Size = new System.Drawing.Size(50, 19);
			this.Cargo.TabIndex = 2;
			this.Cargo.Text = "Cargo";
			// 
			// txtCargo
			// 
			this.txtCargo.Location = new System.Drawing.Point(266, 296);
			this.txtCargo.Name = "txtCargo";
			this.txtCargo.Size = new System.Drawing.Size(259, 20);
			this.txtCargo.TabIndex = 3;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(266, 257);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(259, 20);
			this.txtNome.TabIndex = 4;
			// 
			// txtSalario
			// 
			this.txtSalario.Location = new System.Drawing.Point(266, 333);
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.Size = new System.Drawing.Size(109, 20);
			this.txtSalario.TabIndex = 5;
			this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
			// 
			// btnSalvar
			// 
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = global::doceria.Properties.Resources.Design_sem_nome__1_;
			this.btnSalvar.Location = new System.Drawing.Point(319, 380);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(162, 58);
			this.btnSalvar.TabIndex = 6;
			this.btnSalvar.Text = "salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(225, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 26);
			this.label1.TabIndex = 8;
			this.label1.Text = "REGISTRO DE FUNCIONÁRIOS";
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome__1_;
			this.button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(688, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 25);
			this.button1.TabIndex = 9;
			this.button1.Text = "avançar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(490, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "deseja adicionar/alterar produtos?";
			// 
			// dgvDados
			// 
			this.dgvDados.AutoGenerateColumns = false;
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn});
			this.dgvDados.DataSource = this.funcionariosBindingSource;
			this.dgvDados.Location = new System.Drawing.Point(164, 102);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.Size = new System.Drawing.Size(442, 119);
			this.dgvDados.TabIndex = 12;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			// 
			// cargoDataGridViewTextBoxColumn
			// 
			this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
			this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
			this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
			// 
			// salarioDataGridViewTextBoxColumn
			// 
			this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
			this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
			this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
			// 
			// funcionariosBindingSource
			// 
			this.funcionariosBindingSource.DataMember = "Funcionarios";
			this.funcionariosBindingSource.DataSource = this.cJ3027571PR2DataSet1;
			// 
			// cJ3027571PR2DataSet1
			// 
			this.cJ3027571PR2DataSet1.DataSetName = "CJ3027571PR2DataSet1";
			this.cJ3027571PR2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// funcionariosTableAdapter
			// 
			this.funcionariosTableAdapter.ClearBeforeFill = true;
			// 
			// RegistroFuncionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvDados);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtSalario);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtCargo);
			this.Controls.Add(this.Cargo);
			this.Controls.Add(this.Salário);
			this.Controls.Add(this.Nome);
			this.Name = "RegistroFuncionarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegistroFuncionarios";
			this.Load += new System.EventHandler(this.RegistroFuncionarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Salário;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDados;
        private CJ3027571PR2DataSet1 cJ3027571PR2DataSet1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private CJ3027571PR2DataSet1TableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
    }
}