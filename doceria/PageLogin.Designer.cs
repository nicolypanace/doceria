namespace doceria
{
    partial class PageLogin
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
            this.btenter2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttemail = new System.Windows.Forms.TextBox();
            this.btsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.senhaenter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btenter2
            // 
            this.btenter2.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome__1_;
            this.btenter2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btenter2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenter2.Location = new System.Drawing.Point(278, 356);
            this.btenter2.Name = "btenter2";
            this.btenter2.Size = new System.Drawing.Size(274, 82);
            this.btenter2.TabIndex = 0;
            this.btenter2.Text = "entrar";
            this.btenter2.UseVisualStyleBackColor = true;
            this.btenter2.Click += new System.EventHandler(this.btenter2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::doceria.Properties.Resources.Logotipo_Doceria_Minimalista_Marrom_e_Rosa;
            this.pictureBox1.Location = new System.Drawing.Point(138, -103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bttemail
            // 
            this.bttemail.Location = new System.Drawing.Point(119, 320);
            this.bttemail.Name = "bttemail";
            this.bttemail.Size = new System.Drawing.Size(288, 20);
            this.bttemail.TabIndex = 2;
            this.bttemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btsenha
            // 
            this.btsenha.Location = new System.Drawing.Point(435, 317);
            this.btsenha.Name = "btsenha";
            this.btsenha.PasswordChar = '*';
            this.btsenha.Size = new System.Drawing.Size(222, 20);
            this.btsenha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::doceria.Properties.Resources.Design_sem_nome;
            this.label1.Location = new System.Drawing.Point(115, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-MAIL";
            // 
            // senhaenter
            // 
            this.senhaenter.AutoSize = true;
            this.senhaenter.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaenter.Image = global::doceria.Properties.Resources.Design_sem_nome;
            this.senhaenter.Location = new System.Drawing.Point(431, 295);
            this.senhaenter.Name = "senhaenter";
            this.senhaenter.Size = new System.Drawing.Size(56, 19);
            this.senhaenter.TabIndex = 7;
            this.senhaenter.Text = "SENHA";
            this.senhaenter.Click += new System.EventHandler(this.label3_Click);
            // 
            // PageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doceria.Properties.Resources.Design_sem_nome;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senhaenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsenha);
            this.Controls.Add(this.bttemail);
            this.Controls.Add(this.btenter2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PageLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btenter2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox bttemail;
        private System.Windows.Forms.TextBox btsenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label senhaenter;
    }
}