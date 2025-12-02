namespace doceria
{
    partial class PageCarrinho
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
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.carrinhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3027571PR2DataSet2 = new doceria.CJ3027571PR2DataSet2();
            this.lblTotal = new System.Windows.Forms.Label();
            this.carrinhoTableAdapter = new doceria.CJ3027571PR2DataSet2TableAdapters.CarrinhoTableAdapter();
            this.cJ3027571PR2DataSet5 = new doceria.CJ3027571PR2DataSet5();
            this.carrinhoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carrinhoTableAdapter1 = new doceria.CJ3027571PR2DataSet5TableAdapters.CarrinhoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrinhoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3027571PR2DataSet6 = new doceria.CJ3027571PR2DataSet6();
            this.carrinhoTableAdapter2 = new doceria.CJ3027571PR2DataSet6TableAdapters.CarrinhoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARRINHO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome__1_;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.Location = new System.Drawing.Point(625, 380);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(150, 54);
            this.btConfirmar.TabIndex = 1;
            this.btConfirmar.Text = "CONFIRMAR COMPRA";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome__1_;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(39, 411);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(71, 23);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // carrinhoBindingSource
            // 
            this.carrinhoBindingSource.DataMember = "Carrinho";
            this.carrinhoBindingSource.DataSource = this.cJ3027571PR2DataSet2;
            // 
            // cJ3027571PR2DataSet2
            // 
            this.cJ3027571PR2DataSet2.DataSetName = "CJ3027571PR2DataSet2";
            this.cJ3027571PR2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(98, 333);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // carrinhoTableAdapter
            // 
            this.carrinhoTableAdapter.ClearBeforeFill = true;
            // 
            // cJ3027571PR2DataSet5
            // 
            this.cJ3027571PR2DataSet5.DataSetName = "CJ3027571PR2DataSet5";
            this.cJ3027571PR2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrinhoBindingSource1
            // 
            this.carrinhoBindingSource1.DataMember = "Carrinho";
            this.carrinhoBindingSource1.DataSource = this.cJ3027571PR2DataSet5;
            // 
            // carrinhoTableAdapter1
            // 
            this.carrinhoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoDoceDataGridViewTextBoxColumn,
            this.saborDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carrinhoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(102, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 257);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDoceDataGridViewTextBoxColumn
            // 
            this.tipoDoceDataGridViewTextBoxColumn.DataPropertyName = "TipoDoce";
            this.tipoDoceDataGridViewTextBoxColumn.HeaderText = "TipoDoce";
            this.tipoDoceDataGridViewTextBoxColumn.Name = "tipoDoceDataGridViewTextBoxColumn";
            // 
            // saborDataGridViewTextBoxColumn
            // 
            this.saborDataGridViewTextBoxColumn.DataPropertyName = "Sabor";
            this.saborDataGridViewTextBoxColumn.HeaderText = "Sabor";
            this.saborDataGridViewTextBoxColumn.Name = "saborDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carrinhoBindingSource2
            // 
            this.carrinhoBindingSource2.DataMember = "Carrinho";
            this.carrinhoBindingSource2.DataSource = this.cJ3027571PR2DataSet6;
            // 
            // cJ3027571PR2DataSet6
            // 
            this.cJ3027571PR2DataSet6.DataSetName = "CJ3027571PR2DataSet6";
            this.cJ3027571PR2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrinhoTableAdapter2
            // 
            this.carrinhoTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::doceria.Properties.Resources.Design_sem_nome__1_;
            this.button1.Location = new System.Drawing.Point(15, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PageCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.label1);
            this.Name = "PageCarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageCarrinho";
            this.Load += new System.EventHandler(this.PageCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lblTotal;
        private CJ3027571PR2DataSet2 cJ3027571PR2DataSet2;
        private System.Windows.Forms.BindingSource carrinhoBindingSource;
        private CJ3027571PR2DataSet2TableAdapters.CarrinhoTableAdapter carrinhoTableAdapter;
        private CJ3027571PR2DataSet5 cJ3027571PR2DataSet5;
        private System.Windows.Forms.BindingSource carrinhoBindingSource1;
        private CJ3027571PR2DataSet5TableAdapters.CarrinhoTableAdapter carrinhoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CJ3027571PR2DataSet6 cJ3027571PR2DataSet6;
        private System.Windows.Forms.BindingSource carrinhoBindingSource2;
        private CJ3027571PR2DataSet6TableAdapters.CarrinhoTableAdapter carrinhoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}