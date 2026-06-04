    namespace ProjetoCSharp
{
    partial class Idade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Idade));
            this.lblQualAsuaIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.rdSaoPaulo = new System.Windows.Forms.RadioButton();
            this.rdRiodeJaneiro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pctRiodeJaneiro = new System.Windows.Forms.PictureBox();
            this.pctSaoPaulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctRiodeJaneiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSaoPaulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQualAsuaIdade
            // 
            this.lblQualAsuaIdade.AutoSize = true;
            this.lblQualAsuaIdade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualAsuaIdade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQualAsuaIdade.Location = new System.Drawing.Point(164, 32);
            this.lblQualAsuaIdade.Name = "lblQualAsuaIdade";
            this.lblQualAsuaIdade.Size = new System.Drawing.Size(164, 22);
            this.lblQualAsuaIdade.TabIndex = 0;
            this.lblQualAsuaIdade.Text = "Qual a sua Idade? ";
            this.lblQualAsuaIdade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(168, 67);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(148, 29);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // rdSaoPaulo
            // 
            this.rdSaoPaulo.AutoSize = true;
            this.rdSaoPaulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSaoPaulo.Location = new System.Drawing.Point(168, 135);
            this.rdSaoPaulo.Name = "rdSaoPaulo";
            this.rdSaoPaulo.Size = new System.Drawing.Size(124, 23);
            this.rdSaoPaulo.TabIndex = 2;
            this.rdSaoPaulo.TabStop = true;
            this.rdSaoPaulo.Text = "São Paulo - SP";
            this.rdSaoPaulo.UseVisualStyleBackColor = true;
            this.rdSaoPaulo.CheckedChanged += new System.EventHandler(this.rdSaoPaulo_CheckedChanged);
            // 
            // rdRiodeJaneiro
            // 
            this.rdRiodeJaneiro.AutoSize = true;
            this.rdRiodeJaneiro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRiodeJaneiro.Location = new System.Drawing.Point(158, 164);
            this.rdRiodeJaneiro.Name = "rdRiodeJaneiro";
            this.rdRiodeJaneiro.Size = new System.Drawing.Size(158, 23);
            this.rdRiodeJaneiro.TabIndex = 3;
            this.rdRiodeJaneiro.TabStop = true;
            this.rdRiodeJaneiro.Text = "Rio de Janeiro - RJ";
            this.rdRiodeJaneiro.UseVisualStyleBackColor = true;
            this.rdRiodeJaneiro.CheckedChanged += new System.EventHandler(this.rdRiodeJaneiro_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(128, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o seu estado atual!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIdade.Location = new System.Drawing.Point(111, 244);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(71, 22);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade : ";
            this.lblIdade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEstado.Location = new System.Drawing.Point(111, 266);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 22);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado : ";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(168, 193);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(135, 39);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pctRiodeJaneiro
            // 
            this.pctRiodeJaneiro.Image = global::ProjetoCSharp.Properties.Resources.Capa;
            this.pctRiodeJaneiro.Location = new System.Drawing.Point(102, 317);
            this.pctRiodeJaneiro.Name = "pctRiodeJaneiro";
            this.pctRiodeJaneiro.Size = new System.Drawing.Size(350, 198);
            this.pctRiodeJaneiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRiodeJaneiro.TabIndex = 9;
            this.pctRiodeJaneiro.TabStop = false;
            this.pctRiodeJaneiro.Visible = false;
            this.pctRiodeJaneiro.Click += new System.EventHandler(this.pctRiodeJaneiro_Click);
            // 
            // pctSaoPaulo
            // 
            this.pctSaoPaulo.Image = global::ProjetoCSharp.Properties.Resources.Coringao;
            this.pctSaoPaulo.Location = new System.Drawing.Point(102, 291);
            this.pctSaoPaulo.Name = "pctSaoPaulo";
            this.pctSaoPaulo.Size = new System.Drawing.Size(343, 255);
            this.pctSaoPaulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSaoPaulo.TabIndex = 8;
            this.pctSaoPaulo.TabStop = false;
            this.pctSaoPaulo.Visible = false;
            this.pctSaoPaulo.Click += new System.EventHandler(this.pctSaoPaulo_Click);
            // 
            // Idade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 680);
            this.Controls.Add(this.pctRiodeJaneiro);
            this.Controls.Add(this.pctSaoPaulo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdRiodeJaneiro);
            this.Controls.Add(this.rdSaoPaulo);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblQualAsuaIdade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Idade";
            this.Text = "Idade\\Estado";
            ((System.ComponentModel.ISupportInitialize)(this.pctRiodeJaneiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSaoPaulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQualAsuaIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.RadioButton rdSaoPaulo;
        private System.Windows.Forms.RadioButton rdRiodeJaneiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pctSaoPaulo;
        private System.Windows.Forms.PictureBox pctRiodeJaneiro;
    }
}