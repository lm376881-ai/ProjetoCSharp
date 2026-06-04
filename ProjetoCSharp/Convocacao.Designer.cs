namespace ProjetoCSharp
{
    partial class Convocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convocacao));
            this.nmrIdade = new System.Windows.Forms.NumericUpDown();
            this.btnEspera = new System.Windows.Forms.Button();
            this.btnConvocacao = new System.Windows.Forms.Button();
            this.listEspera = new System.Windows.Forms.ListBox();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.cbxPosição = new System.Windows.Forms.ComboBox();
            this.listConvocação = new System.Windows.Forms.ListBox();
            this.lblPosição = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.pctBrasil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBrasil)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrIdade
            // 
            this.nmrIdade.Location = new System.Drawing.Point(125, 151);
            this.nmrIdade.Name = "nmrIdade";
            this.nmrIdade.Size = new System.Drawing.Size(51, 20);
            this.nmrIdade.TabIndex = 31;
            this.nmrIdade.ValueChanged += new System.EventHandler(this.nmrIdade_ValueChanged);
            // 
            // btnEspera
            // 
            this.btnEspera.Location = new System.Drawing.Point(324, 320);
            this.btnEspera.Name = "btnEspera";
            this.btnEspera.Size = new System.Drawing.Size(253, 27);
            this.btnEspera.TabIndex = 30;
            this.btnEspera.Text = "Espera";
            this.btnEspera.UseVisualStyleBackColor = true;
            this.btnEspera.Click += new System.EventHandler(this.btnEspera_Click);
            // 
            // btnConvocacao
            // 
            this.btnConvocacao.Location = new System.Drawing.Point(32, 320);
            this.btnConvocacao.Name = "btnConvocacao";
            this.btnConvocacao.Size = new System.Drawing.Size(238, 27);
            this.btnConvocacao.TabIndex = 29;
            this.btnConvocacao.Text = "Convocação";
            this.btnConvocacao.UseVisualStyleBackColor = true;
            this.btnConvocacao.Click += new System.EventHandler(this.btnConvocacao_Click);
            // 
            // listEspera
            // 
            this.listEspera.FormattingEnabled = true;
            this.listEspera.Location = new System.Drawing.Point(324, 389);
            this.listEspera.Name = "listEspera";
            this.listEspera.Size = new System.Drawing.Size(253, 134);
            this.listEspera.TabIndex = 28;
            this.listEspera.SelectedIndexChanged += new System.EventHandler(this.listEspera_SelectedIndexChanged);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(125, 81);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(261, 29);
            this.txtNomeJogador.TabIndex = 27;
            this.txtNomeJogador.TextChanged += new System.EventHandler(this.txtNomeJogador_TextChanged);
            // 
            // cbxPosição
            // 
            this.cbxPosição.FormattingEnabled = true;
            this.cbxPosição.Location = new System.Drawing.Point(124, 224);
            this.cbxPosição.Name = "cbxPosição";
            this.cbxPosição.Size = new System.Drawing.Size(121, 21);
            this.cbxPosição.TabIndex = 26;
            this.cbxPosição.SelectedIndexChanged += new System.EventHandler(this.cbxPosição_SelectedIndexChanged);
            // 
            // listConvocação
            // 
            this.listConvocação.FormattingEnabled = true;
            this.listConvocação.Location = new System.Drawing.Point(32, 389);
            this.listConvocação.Name = "listConvocação";
            this.listConvocação.Size = new System.Drawing.Size(238, 134);
            this.listConvocação.TabIndex = 25;
            this.listConvocação.SelectedIndexChanged += new System.EventHandler(this.listConvocação_SelectedIndexChanged);
            // 
            // lblPosição
            // 
            this.lblPosição.AutoSize = true;
            this.lblPosição.Location = new System.Drawing.Point(29, 227);
            this.lblPosição.Name = "lblPosição";
            this.lblPosição.Size = new System.Drawing.Size(45, 13);
            this.lblPosição.TabIndex = 24;
            this.lblPosição.Text = "Posição";
            this.lblPosição.Click += new System.EventHandler(this.lblPosição_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(29, 158);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 13);
            this.lblIdade.TabIndex = 23;
            this.lblIdade.Text = "Idade: ";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(29, 90);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(91, 13);
            this.lblNomeJogador.TabIndex = 22;
            this.lblNomeJogador.Text = "Nome do jogador:";
            this.lblNomeJogador.Click += new System.EventHandler(this.lblNomeJogador_Click);
            // 
            // pctBrasil
            // 
            this.pctBrasil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pctBrasil.Image = global::ProjetoCSharp.Properties.Resources.be66b799a95578a9d30d69318f03d0c6;
            this.pctBrasil.Location = new System.Drawing.Point(394, 12);
            this.pctBrasil.Name = "pctBrasil";
            this.pctBrasil.Size = new System.Drawing.Size(227, 228);
            this.pctBrasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBrasil.TabIndex = 32;
            this.pctBrasil.TabStop = false;
            // 
            // Convocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 583);
            this.Controls.Add(this.pctBrasil);
            this.Controls.Add(this.nmrIdade);
            this.Controls.Add(this.btnEspera);
            this.Controls.Add(this.btnConvocacao);
            this.Controls.Add(this.listEspera);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.cbxPosição);
            this.Controls.Add(this.listConvocação);
            this.Controls.Add(this.lblPosição);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNomeJogador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Convocacao";
            this.Text = "Convocacao";
            this.Load += new System.EventHandler(this.Convocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBrasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBrasil;
        private System.Windows.Forms.NumericUpDown nmrIdade;
        private System.Windows.Forms.Button btnEspera;
        private System.Windows.Forms.Button btnConvocacao;
        private System.Windows.Forms.ListBox listEspera;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.ComboBox cbxPosição;
        private System.Windows.Forms.ListBox listConvocação;
        private System.Windows.Forms.Label lblPosição;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNomeJogador;
    }
}