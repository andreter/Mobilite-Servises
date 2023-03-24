
namespace Mobilitec_Servises
{
    partial class frmEstruturadeRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstruturadeRepeticao));
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnExecultar = new System.Windows.Forms.Button();
            this.lstbSomatoria = new System.Windows.Forms.ListBox();
            this.lblRepeticoes = new System.Windows.Forms.Label();
            this.txtRepeticoes = new System.Windows.Forms.TextBox();
            this.lblSoma = new System.Windows.Forms.Label();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSomatoria = new System.Windows.Forms.Label();
            this.cbbSomatoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContador
            // 
            this.txtContador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContador.Location = new System.Drawing.Point(69, 55);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(174, 26);
            this.txtContador.TabIndex = 0;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Black;
            this.lblContador.Location = new System.Drawing.Point(64, 32);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(190, 20);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "Contador (Rep. Inicial)";
            // 
            // btnExecultar
            // 
            this.btnExecultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExecultar.FlatAppearance.BorderSize = 0;
            this.btnExecultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExecultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecultar.Location = new System.Drawing.Point(120, 358);
            this.btnExecultar.Name = "btnExecultar";
            this.btnExecultar.Size = new System.Drawing.Size(119, 41);
            this.btnExecultar.TabIndex = 4;
            this.btnExecultar.Text = "&Execultar";
            this.btnExecultar.UseVisualStyleBackColor = false;
            this.btnExecultar.Click += new System.EventHandler(this.btnExecultar_Click);
            // 
            // lstbSomatoria
            // 
            this.lstbSomatoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lstbSomatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbSomatoria.FormattingEnabled = true;
            this.lstbSomatoria.ItemHeight = 20;
            this.lstbSomatoria.Location = new System.Drawing.Point(308, 42);
            this.lstbSomatoria.Name = "lstbSomatoria";
            this.lstbSomatoria.Size = new System.Drawing.Size(164, 244);
            this.lstbSomatoria.TabIndex = 3;
            // 
            // lblRepeticoes
            // 
            this.lblRepeticoes.AutoSize = true;
            this.lblRepeticoes.BackColor = System.Drawing.Color.Silver;
            this.lblRepeticoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeticoes.ForeColor = System.Drawing.Color.Black;
            this.lblRepeticoes.Location = new System.Drawing.Point(64, 102);
            this.lblRepeticoes.Name = "lblRepeticoes";
            this.lblRepeticoes.Size = new System.Drawing.Size(100, 20);
            this.lblRepeticoes.TabIndex = 5;
            this.lblRepeticoes.Text = "Repetições";
            // 
            // txtRepeticoes
            // 
            this.txtRepeticoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtRepeticoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeticoes.Location = new System.Drawing.Point(69, 125);
            this.txtRepeticoes.MaxLength = 3;
            this.txtRepeticoes.Name = "txtRepeticoes";
            this.txtRepeticoes.Size = new System.Drawing.Size(174, 26);
            this.txtRepeticoes.TabIndex = 1;
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.BackColor = System.Drawing.Color.Silver;
            this.lblSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma.ForeColor = System.Drawing.Color.Black;
            this.lblSoma.Location = new System.Drawing.Point(64, 172);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(164, 20);
            this.lblSoma.TabIndex = 7;
            this.lblSoma.Text = "Soma (Valor inicial)";
            // 
            // txtSoma
            // 
            this.txtSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoma.Location = new System.Drawing.Point(69, 195);
            this.txtSoma.MaxLength = 10;
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(174, 26);
            this.txtSoma.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Silver;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(64, 237);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(112, 20);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor (Pulos)";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(69, 260);
            this.txtValor.MaxLength = 100;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(174, 26);
            this.txtValor.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(281, 358);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 41);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(439, 358);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 41);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSomatoria
            // 
            this.lblSomatoria.AutoSize = true;
            this.lblSomatoria.BackColor = System.Drawing.Color.Silver;
            this.lblSomatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomatoria.ForeColor = System.Drawing.Color.Black;
            this.lblSomatoria.Location = new System.Drawing.Point(304, 19);
            this.lblSomatoria.Name = "lblSomatoria";
            this.lblSomatoria.Size = new System.Drawing.Size(91, 20);
            this.lblSomatoria.TabIndex = 10;
            this.lblSomatoria.Text = "Somatória";
            // 
            // cbbSomatoria
            // 
            this.cbbSomatoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbSomatoria.FormattingEnabled = true;
            this.cbbSomatoria.Location = new System.Drawing.Point(502, 42);
            this.cbbSomatoria.Name = "cbbSomatoria";
            this.cbbSomatoria.Size = new System.Drawing.Size(140, 21);
            this.cbbSomatoria.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(497, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Somatória";
            // 
            // frmEstruturadeRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSomatoria);
            this.Controls.Add(this.lblSomatoria);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.lblRepeticoes);
            this.Controls.Add(this.txtRepeticoes);
            this.Controls.Add(this.lstbSomatoria);
            this.Controls.Add(this.btnExecultar);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.txtContador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEstruturadeRepeticao";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estrutura de Repetição";
            this.Load += new System.EventHandler(this.frmEstruturadeRepeticao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnExecultar;
        private System.Windows.Forms.ListBox lstbSomatoria;
        private System.Windows.Forms.Label lblRepeticoes;
        private System.Windows.Forms.TextBox txtRepeticoes;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSomatoria;
        private System.Windows.Forms.ComboBox cbbSomatoria;
        private System.Windows.Forms.Label label1;
    }
}