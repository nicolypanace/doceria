namespace doceria
{
    partial class PageCad
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
            this.btnome = new System.Windows.Forms.TextBox();
            this.bttcpf = new System.Windows.Forms.MaskedTextBox();
            this.bttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttdata = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btConcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btsenha = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnome
            // 
            this.btnome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnome.Location = new System.Drawing.Point(32, 139);
            this.btnome.Name = "btnome";
            this.btnome.Size = new System.Drawing.Size(285, 20);
            this.btnome.TabIndex = 0;
            this.btnome.TextChanged += new System.EventHandler(this.btnome_TextChanged);
            // 
            // bttcpf
            // 
            this.bttcpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttcpf.Location = new System.Drawing.Point(32, 196);
            this.bttcpf.Mask = "000,000,000-00";
            this.bttcpf.Name = "bttcpf";
            this.bttcpf.Size = new System.Drawing.Size(85, 20);
            this.bttcpf.TabIndex = 4;
            // 
            // bttelefone
            // 
            this.bttelefone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttelefone.Location = new System.Drawing.Point(32, 256);
            this.bttelefone.Mask = "(00)000000000";
            this.bttelefone.Name = "bttelefone";
            this.bttelefone.Size = new System.Drawing.Size(78, 20);
            this.bttelefone.TabIndex = 5;
            this.bttelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::doceria.Properties.Resources.Logotipo_Doceria_Minimalista_Marrom_e_Rosa;
            this.pictureBox1.Location = new System.Drawing.Point(141, -56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 466);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btemail
            // 
            this.btemail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btemail.Location = new System.Drawing.Point(483, 143);
            this.btemail.Name = "btemail";
            this.btemail.Size = new System.Drawing.Size(295, 20);
            this.btemail.TabIndex = 8;
            this.btemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "e-mail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "telefone:";
            // 
            // bttdata
            // 
            this.bttdata.Location = new System.Drawing.Point(613, 207);
            this.bttdata.Mask = "00/00/0000";
            this.bttdata.Name = "bttdata";
            this.bttdata.Size = new System.Drawing.Size(68, 20);
            this.bttdata.TabIndex = 12;
            this.bttdata.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data:";
            // 
            // btConcluir
            // 
            this.btConcluir.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome__1_;
            this.btConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConcluir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConcluir.Location = new System.Drawing.Point(256, 341);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(278, 69);
            this.btConcluir.TabIndex = 14;
            this.btConcluir.Text = "Concluir";
            this.btConcluir.UseVisualStyleBackColor = true;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::doceria.Properties.Resources.Design_sem_nome;
            this.label6.Location = new System.Drawing.Point(609, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "SENHA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btsenha
            // 
            this.btsenha.Location = new System.Drawing.Point(613, 266);
            this.btsenha.Name = "btsenha";
            this.btsenha.Size = new System.Drawing.Size(93, 20);
            this.btsenha.TabIndex = 16;
            // 
            // PageCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttelefone);
            this.Controls.Add(this.bttcpf);
            this.Controls.Add(this.btnome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PageCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pagelogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btnome;
        private System.Windows.Forms.MaskedTextBox bttcpf;
        private System.Windows.Forms.MaskedTextBox bttelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox btemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox bttdata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox btsenha;
    }
}