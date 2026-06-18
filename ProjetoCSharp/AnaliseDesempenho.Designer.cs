namespace ProjetoCSharp
{
    partial class AnaliseDesempenho
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
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.cbxPosição = new System.Windows.Forms.ComboBox();
            this.listAvaliacao = new System.Windows.Forms.ListBox();
            this.lblPosição = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblJogos = new System.Windows.Forms.Label();
            this.lblGols = new System.Windows.Forms.Label();
            this.lblAssistencia = new System.Windows.Forms.Label();
            this.txtGols = new System.Windows.Forms.TextBox();
            this.txtAssistencia = new System.Windows.Forms.TextBox();
            this.txtPartidas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pctBrasil = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBrasil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.Location = new System.Drawing.Point(12, 706);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(190, 55);
            this.btnAvaliar.TabIndex = 40;
            this.btnAvaliar.Text = "Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = true;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliação_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(121, 38);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(259, 29);
            this.txtNomeJogador.TabIndex = 38;
            this.txtNomeJogador.TextChanged += new System.EventHandler(this.txtNomeJogador_TextChanged);
            // 
            // cbxPosição
            // 
            this.cbxPosição.FormattingEnabled = true;
            this.cbxPosição.Location = new System.Drawing.Point(121, 93);
            this.cbxPosição.Name = "cbxPosição";
            this.cbxPosição.Size = new System.Drawing.Size(121, 21);
            this.cbxPosição.TabIndex = 37;
            this.cbxPosição.SelectedIndexChanged += new System.EventHandler(this.cbxPosição_SelectedIndexChanged);
            // 
            // listAvaliacao
            // 
            this.listAvaliacao.FormattingEnabled = true;
            this.listAvaliacao.Location = new System.Drawing.Point(424, 29);
            this.listAvaliacao.Name = "listAvaliacao";
            this.listAvaliacao.Size = new System.Drawing.Size(374, 732);
            this.listAvaliacao.TabIndex = 36;
            this.listAvaliacao.SelectedIndexChanged += new System.EventHandler(this.listAvaliacao_SelectedIndexChanged);
            // 
            // lblPosição
            // 
            this.lblPosição.AutoSize = true;
            this.lblPosição.Location = new System.Drawing.Point(14, 101);
            this.lblPosição.Name = "lblPosição";
            this.lblPosição.Size = new System.Drawing.Size(45, 13);
            this.lblPosição.TabIndex = 35;
            this.lblPosição.Text = "Posição";
            this.lblPosição.Click += new System.EventHandler(this.lblPosição_Click);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(14, 54);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(91, 13);
            this.lblNomeJogador.TabIndex = 33;
            this.lblNomeJogador.Text = "Nome do jogador:";
            this.lblNomeJogador.Click += new System.EventHandler(this.lblNomeJogador_Click);
            // 
            // lblJogos
            // 
            this.lblJogos.AutoSize = true;
            this.lblJogos.Location = new System.Drawing.Point(14, 143);
            this.lblJogos.Name = "lblJogos";
            this.lblJogos.Size = new System.Drawing.Size(101, 13);
            this.lblJogos.TabIndex = 44;
            this.lblJogos.Text = "Partidas Disputadas";
            this.lblJogos.Click += new System.EventHandler(this.lblJogos_Click);
            // 
            // lblGols
            // 
            this.lblGols.AutoSize = true;
            this.lblGols.Location = new System.Drawing.Point(14, 185);
            this.lblGols.Name = "lblGols";
            this.lblGols.Size = new System.Drawing.Size(28, 13);
            this.lblGols.TabIndex = 45;
            this.lblGols.Text = "Gols";
            this.lblGols.Click += new System.EventHandler(this.lblGols_Click);
            // 
            // lblAssistencia
            // 
            this.lblAssistencia.AutoSize = true;
            this.lblAssistencia.Location = new System.Drawing.Point(14, 225);
            this.lblAssistencia.Name = "lblAssistencia";
            this.lblAssistencia.Size = new System.Drawing.Size(63, 13);
            this.lblAssistencia.TabIndex = 46;
            this.lblAssistencia.Text = "Assistência ";
            this.lblAssistencia.Click += new System.EventHandler(this.lblAssistencia_Click);
            // 
            // txtGols
            // 
            this.txtGols.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGols.Location = new System.Drawing.Point(121, 173);
            this.txtGols.Name = "txtGols";
            this.txtGols.Size = new System.Drawing.Size(52, 25);
            this.txtGols.TabIndex = 48;
            this.txtGols.TextChanged += new System.EventHandler(this.txtGols_TextChanged);
            // 
            // txtAssistencia
            // 
            this.txtAssistencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssistencia.Location = new System.Drawing.Point(121, 213);
            this.txtAssistencia.Name = "txtAssistencia";
            this.txtAssistencia.Size = new System.Drawing.Size(52, 25);
            this.txtAssistencia.TabIndex = 49;
            this.txtAssistencia.TextChanged += new System.EventHandler(this.txtAssistencia_TextChanged);
            // 
            // txtPartidas
            // 
            this.txtPartidas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartidas.Location = new System.Drawing.Point(121, 131);
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(52, 25);
            this.txtPartidas.TabIndex = 50;
            this.txtPartidas.TextChanged += new System.EventHandler(this.txtPartidas_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPartidas);
            this.groupBox1.Controls.Add(this.txtAssistencia);
            this.groupBox1.Controls.Add(this.txtGols);
            this.groupBox1.Controls.Add(this.lblAssistencia);
            this.groupBox1.Controls.Add(this.lblGols);
            this.groupBox1.Controls.Add(this.lblJogos);
            this.groupBox1.Controls.Add(this.txtNomeJogador);
            this.groupBox1.Controls.Add(this.cbxPosição);
            this.groupBox1.Controls.Add(this.lblPosição);
            this.groupBox1.Controls.Add(this.lblNomeJogador);
            this.groupBox1.Location = new System.Drawing.Point(12, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 277);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avaliação ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(205, 706);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(190, 55);
            this.btnLimpar.TabIndex = 52;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pctBrasil
            // 
            this.pctBrasil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pctBrasil.Image = global::ProjetoCSharp.Properties.Resources._20250412_231627_1_2_;
            this.pctBrasil.Location = new System.Drawing.Point(15, 30);
            this.pctBrasil.Name = "pctBrasil";
            this.pctBrasil.Size = new System.Drawing.Size(393, 375);
            this.pctBrasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBrasil.TabIndex = 43;
            this.pctBrasil.TabStop = false;
            // 
            // AnaliseDesempenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 770);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctBrasil);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.listAvaliacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaliseDesempenho";
            this.Text = "AnaliseDesempenho";
            this.Load += new System.EventHandler(this.AnaliseDesempenho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBrasil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBrasil;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.ComboBox cbxPosição;
        private System.Windows.Forms.ListBox listAvaliacao;
        private System.Windows.Forms.Label lblPosição;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblJogos;
        private System.Windows.Forms.Label lblGols;
        private System.Windows.Forms.Label lblAssistencia;
        private System.Windows.Forms.TextBox txtGols;
        private System.Windows.Forms.TextBox txtAssistencia;
        private System.Windows.Forms.TextBox txtPartidas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
    }
}