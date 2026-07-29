namespace ProjetoCSharp
{
    partial class VerificadorDePosicao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPosicao = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVerificarPosição = new System.Windows.Forms.Button();
            this.numPosicoes = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPosicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.picPosicao);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 268);
            this.panel1.TabIndex = 0;
            // 
            // picPosicao
            // 
            this.picPosicao.Location = new System.Drawing.Point(75, 17);
            this.picPosicao.Name = "picPosicao";
            this.picPosicao.Size = new System.Drawing.Size(228, 227);
            this.picPosicao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPosicao.TabIndex = 1;
            this.picPosicao.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoCSharp.Properties.Resources.pngtree_aerial_aerial_view_of_football_field_image_994411__1_;
            this.pictureBox1.Location = new System.Drawing.Point(384, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnVerificarPosição);
            this.panel2.Controls.Add(this.numPosicoes);
            this.panel2.Controls.Add(this.lblNumero);
            this.panel2.Location = new System.Drawing.Point(12, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 84);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnVerificarPosição
            // 
            this.btnVerificarPosição.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarPosição.Location = new System.Drawing.Point(525, 20);
            this.btnVerificarPosição.Name = "btnVerificarPosição";
            this.btnVerificarPosição.Size = new System.Drawing.Size(213, 43);
            this.btnVerificarPosição.TabIndex = 2;
            this.btnVerificarPosição.Text = "Verificar Posição";
            this.btnVerificarPosição.UseVisualStyleBackColor = true;
            this.btnVerificarPosição.Click += new System.EventHandler(this.btnVerificarPosição_Click);
            // 
            // numPosicoes
            // 
            this.numPosicoes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPosicoes.Location = new System.Drawing.Point(356, 28);
            this.numPosicoes.Name = "numPosicoes";
            this.numPosicoes.Size = new System.Drawing.Size(120, 27);
            this.numPosicoes.TabIndex = 1;
            this.numPosicoes.ValueChanged += new System.EventHandler(this.numPosicoes_ValueChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(19, 28);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(331, 25);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Digite o número da camisa ( 1 a 11):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verificar Posição";
            // 
            // VerificadorDePosicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VerificadorDePosicao";
            this.Text = "VerificadorDePosicao";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPosicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosicoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVerificarPosição;
        private System.Windows.Forms.NumericUpDown numPosicoes;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPosicao;
        private System.Windows.Forms.Label label1;
    }
}