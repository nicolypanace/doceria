using System.Windows.Forms;

namespace doceria
{
    partial class PagePagamento
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
			this.btnPagar = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblValidade = new System.Windows.Forms.Label();
			this.lblCVV = new System.Windows.Forms.Label();
			this.lblValor = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.txtCVV = new System.Windows.Forms.TextBox();
			this.txtValidade = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPagar
			// 
			this.btnPagar.Location = new System.Drawing.Point(298, 335);
			this.btnPagar.Name = "btnPagar";
			this.btnPagar.Size = new System.Drawing.Size(179, 43);
			this.btnPagar.TabIndex = 0;
			this.btnPagar.Text = "CONFIRMAR";
			this.btnPagar.UseVisualStyleBackColor = true;
			this.btnPagar.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Location = new System.Drawing.Point(346, 37);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(75, 13);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "PAGAMENTO";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(253, 110);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(42, 13);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "NOME:";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Location = new System.Drawing.Point(60, 160);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(124, 13);
			this.lblNumero.TabIndex = 3;
			this.lblNumero.Text = "NÚMERO DO CARTÃO:";
			// 
			// lblValidade
			// 
			this.lblValidade.AutoSize = true;
			this.lblValidade.Location = new System.Drawing.Point(423, 160);
			this.lblValidade.Name = "lblValidade";
			this.lblValidade.Size = new System.Drawing.Size(109, 13);
			this.lblValidade.TabIndex = 4;
			this.lblValidade.Text = "VALIDADE (MM/AA):";
			// 
			// lblCVV
			// 
			this.lblCVV.AutoSize = true;
			this.lblCVV.Location = new System.Drawing.Point(501, 211);
			this.lblCVV.Name = "lblCVV";
			this.lblCVV.Size = new System.Drawing.Size(31, 13);
			this.lblCVV.TabIndex = 5;
			this.lblCVV.Text = "CVV:";
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Location = new System.Drawing.Point(60, 204);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(46, 13);
			this.lblValor.TabIndex = 6;
			this.lblValor.Text = "VALOR:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(298, 103);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(164, 20);
			this.txtNome.TabIndex = 8;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(190, 157);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(125, 20);
			this.txtNumero.TabIndex = 9;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(112, 201);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(55, 20);
			this.txtValor.TabIndex = 10;
			// 
			// txtCVV
			// 
			this.txtCVV.Location = new System.Drawing.Point(547, 204);
			this.txtCVV.Name = "txtCVV";
			this.txtCVV.Size = new System.Drawing.Size(44, 20);
			this.txtCVV.TabIndex = 11;
			// 
			// txtValidade
			// 
			this.txtValidade.Location = new System.Drawing.Point(538, 153);
			this.txtValidade.Name = "txtValidade";
			this.txtValidade.Size = new System.Drawing.Size(53, 20);
			this.txtValidade.TabIndex = 12;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(346, 428);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblStatus.Size = new System.Drawing.Size(50, 13);
			this.lblStatus.TabIndex = 13;
			this.lblStatus.Text = "STATUS";
			// 
			// PagePagamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.txtValidade);
			this.Controls.Add(this.txtCVV);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.lblCVV);
			this.Controls.Add(this.lblValidade);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnPagar);
			this.Name = "PagePagamento";
			this.Text = "PagePagamento";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label btnPagar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtValidade;

        public PagePagamento(TextBox txtValidade)
        {
            this.txtValidade = txtValidade;
        }

        private System.Windows.Forms.Label lblStatus;
    }
}