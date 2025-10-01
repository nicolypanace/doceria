namespace doceria
{
    partial class PageCadr
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btsenha = new System.Windows.Forms.TextBox();
            this.btemail = new System.Windows.Forms.TextBox();
            this.btnome = new System.Windows.Forms.TextBox();
            this.bttelefone = new System.Windows.Forms.MaskedTextBox();
            this.bttdata = new System.Windows.Forms.MaskedTextBox();
            this.bttcpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "TELEFONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "CPF";
            // 
            // btsenha
            // 
            this.btsenha.Location = new System.Drawing.Point(592, 230);
            this.btsenha.Name = "btsenha";
            this.btsenha.Size = new System.Drawing.Size(134, 20);
            this.btsenha.TabIndex = 24;
            // 
            // btemail
            // 
            this.btemail.Location = new System.Drawing.Point(592, 170);
            this.btemail.Name = "btemail";
            this.btemail.Size = new System.Drawing.Size(169, 20);
            this.btemail.TabIndex = 23;
            // 
            // btnome
            // 
            this.btnome.Location = new System.Drawing.Point(59, 170);
            this.btnome.Name = "btnome";
            this.btnome.Size = new System.Drawing.Size(162, 20);
            this.btnome.TabIndex = 22;
            // 
            // bttelefone
            // 
            this.bttelefone.Location = new System.Drawing.Point(59, 230);
            this.bttelefone.Mask = "(00)000000000";
            this.bttelefone.Name = "bttelefone";
            this.bttelefone.Size = new System.Drawing.Size(107, 20);
            this.bttelefone.TabIndex = 21;
            // 
            // bttdata
            // 
            this.bttdata.Location = new System.Drawing.Point(59, 275);
            this.bttdata.Mask = "00/00/0000";
            this.bttdata.Name = "bttdata";
            this.bttdata.Size = new System.Drawing.Size(64, 20);
            this.bttdata.TabIndex = 20;
            // 
            // bttcpf
            // 
            this.bttcpf.Location = new System.Drawing.Point(592, 275);
            this.bttcpf.Mask = "000,000,000-00";
            this.bttcpf.Name = "bttcpf";
            this.bttcpf.Size = new System.Drawing.Size(90, 20);
            this.bttcpf.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "DATA DE NASCIMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "SENHA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btConcluir
            // 
            this.btConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConcluir.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConcluir.Image = global::doceria.Properties.Resources.Design_sem_nome__1_;
            this.btConcluir.Location = new System.Drawing.Point(297, 348);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(205, 67);
            this.btConcluir.TabIndex = 26;
            this.btConcluir.Text = "CADASTRAR";
            this.btConcluir.UseVisualStyleBackColor = true;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::doceria.Properties.Resources.Design_sem_nome;
            this.label1.Location = new System.Drawing.Point(588, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "EMAIL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.BackgroundImage = global::doceria.Properties.Resources.Logotipo_Doceria_Minimalista_Marrom_e_Rosa;
            this.pictureBox2.Location = new System.Drawing.Point(158, -70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(486, 412);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // PageCadr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btsenha);
            this.Controls.Add(this.btemail);
            this.Controls.Add(this.btnome);
            this.Controls.Add(this.bttelefone);
            this.Controls.Add(this.bttdata);
            this.Controls.Add(this.bttcpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "PageCadr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageCadr";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btsenha;
        private System.Windows.Forms.TextBox btemail;
        private System.Windows.Forms.TextBox btnome;
        private System.Windows.Forms.MaskedTextBox bttelefone;
        private System.Windows.Forms.MaskedTextBox bttdata;
        private System.Windows.Forms.MaskedTextBox bttcpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}