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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dgvCarrinho = new System.Windows.Forms.DataGridView();
			this.lblTotal = new System.Windows.Forms.Label();
			this.cJ3027571PR2DataSet2 = new doceria.CJ3027571PR2DataSet2();
			this.carrinhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carrinhoTableAdapter = new doceria.CJ3027571PR2DataSet2TableAdapters.CarrinhoTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataAdicionadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(337, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "CARRINHO";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome__1_;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(588, 365);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 54);
			this.button1.TabIndex = 1;
			this.button1.Text = "CONFIRMAR COMPRA";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome__1_;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 396);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "VOLTAR";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// dgvCarrinho
			// 
			this.dgvCarrinho.AutoGenerateColumns = false;
			this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.saborDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.dataAdicionadoDataGridViewTextBoxColumn});
			this.dgvCarrinho.DataSource = this.carrinhoBindingSource;
			this.dgvCarrinho.Location = new System.Drawing.Point(87, 80);
			this.dgvCarrinho.Name = "dgvCarrinho";
			this.dgvCarrinho.Size = new System.Drawing.Size(630, 232);
			this.dgvCarrinho.TabIndex = 3;
			this.dgvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellContentClick);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(98, 333);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(45, 13);
			this.lblTotal.TabIndex = 4;
			this.lblTotal.Text = "TOTAL:";
			// 
			// cJ3027571PR2DataSet2
			// 
			this.cJ3027571PR2DataSet2.DataSetName = "CJ3027571PR2DataSet2";
			this.cJ3027571PR2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// carrinhoBindingSource
			// 
			this.carrinhoBindingSource.DataMember = "Carrinho";
			this.carrinhoBindingSource.DataSource = this.cJ3027571PR2DataSet2;
			// 
			// carrinhoTableAdapter
			// 
			this.carrinhoTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
			// precoUnitarioDataGridViewTextBoxColumn
			// 
			this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnitario";
			this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecoUnitario";
			this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
			// 
			// subtotalDataGridViewTextBoxColumn
			// 
			this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
			this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
			this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
			this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataAdicionadoDataGridViewTextBoxColumn
			// 
			this.dataAdicionadoDataGridViewTextBoxColumn.DataPropertyName = "DataAdicionado";
			this.dataAdicionadoDataGridViewTextBoxColumn.HeaderText = "DataAdicionado";
			this.dataAdicionadoDataGridViewTextBoxColumn.Name = "dataAdicionadoDataGridViewTextBoxColumn";
			// 
			// PageCarrinho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.dgvCarrinho);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "PageCarrinho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PageCarrinho";
			this.Load += new System.EventHandler(this.PageCarrinho_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cJ3027571PR2DataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Label lblTotal;
        private CJ3027571PR2DataSet2 cJ3027571PR2DataSet2;
        private System.Windows.Forms.BindingSource carrinhoBindingSource;
        private CJ3027571PR2DataSet2TableAdapters.CarrinhoTableAdapter carrinhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAdicionadoDataGridViewTextBoxColumn;
    }
}