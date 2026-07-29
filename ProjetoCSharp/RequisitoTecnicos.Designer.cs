namespace ProjetoCSharp
{
    partial class RequisitoTecnicos
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblOpcoes = new System.Windows.Forms.Label();
            this.lblEscalação = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblSubstituicao = new System.Windows.Forms.Label();
            this.lblEncerrar = new System.Windows.Forms.Label();
            this.cbBoxNumero = new System.Windows.Forms.ComboBox();
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.Location = new System.Drawing.Point(6, 32);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(161, 21);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "Digite um Número: ";
            // 
            // lblOpcoes
            // 
            this.lblOpcoes.AutoSize = true;
            this.lblOpcoes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcoes.Location = new System.Drawing.Point(24, 70);
            this.lblOpcoes.Name = "lblOpcoes";
            this.lblOpcoes.Size = new System.Drawing.Size(60, 20);
            this.lblOpcoes.TabIndex = 1;
            this.lblOpcoes.Text = "Opções";
            // 
            // lblEscalação
            // 
            this.lblEscalação.AutoSize = true;
            this.lblEscalação.Location = new System.Drawing.Point(7, 117);
            this.lblEscalação.Name = "lblEscalação";
            this.lblEscalação.Size = new System.Drawing.Size(113, 13);
            this.lblEscalação.TabIndex = 2;
            this.lblEscalação.Text = "1- Mostrar Escalação: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "2- Avaliar Jogador:";
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(7, 170);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(82, 13);
            this.lblHistorico.TabIndex = 4;
            this.lblHistorico.Text = "3- Ver Historico:";
            // 
            // lblSubstituicao
            // 
            this.lblSubstituicao.AutoSize = true;
            this.lblSubstituicao.Location = new System.Drawing.Point(6, 196);
            this.lblSubstituicao.Name = "lblSubstituicao";
            this.lblSubstituicao.Size = new System.Drawing.Size(83, 13);
            this.lblSubstituicao.TabIndex = 5;
            this.lblSubstituicao.Text = "4- Substituição: ";
            // 
            // lblEncerrar
            // 
            this.lblEncerrar.AutoSize = true;
            this.lblEncerrar.Location = new System.Drawing.Point(7, 222);
            this.lblEncerrar.Name = "lblEncerrar";
            this.lblEncerrar.Size = new System.Drawing.Size(65, 13);
            this.lblEncerrar.TabIndex = 6;
            this.lblEncerrar.Text = "5- Encerrar: ";
            // 
            // cbBoxNumero
            // 
            this.cbBoxNumero.FormattingEnabled = true;
            this.cbBoxNumero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbBoxNumero.Location = new System.Drawing.Point(174, 32);
            this.cbBoxNumero.Name = "cbBoxNumero";
            this.cbBoxNumero.Size = new System.Drawing.Size(121, 21);
            this.cbBoxNumero.TabIndex = 7;
            this.cbBoxNumero.SelectedIndexChanged += new System.EventHandler(this.cbBoxNumero_SelectedIndexChanged);
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(333, 12);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(455, 420);
            this.lstHistorico.TabIndex = 8;
            this.lstHistorico.SelectedIndexChanged += new System.EventHandler(this.lstHistorico_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Controls.Add(this.cbBoxNumero);
            this.groupBox1.Controls.Add(this.lblEncerrar);
            this.groupBox1.Controls.Add(this.lblSubstituicao);
            this.groupBox1.Controls.Add(this.lblHistorico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblEscalação);
            this.groupBox1.Controls.Add(this.lblOpcoes);
            this.groupBox1.Controls.Add(this.lblNumeros);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(186, 196);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(109, 43);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoCSharp.Properties.Resources._2006_2_7faaed788b;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RequisitoTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstHistorico);
            this.Name = "RequisitoTecnicos";
            this.Text = "OpcoesRequisitos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblOpcoes;
        private System.Windows.Forms.Label lblEscalação;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label lblSubstituicao;
        private System.Windows.Forms.Label lblEncerrar;
        private System.Windows.Forms.ComboBox cbBoxNumero;
        private System.Windows.Forms.ListBox lstHistorico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}