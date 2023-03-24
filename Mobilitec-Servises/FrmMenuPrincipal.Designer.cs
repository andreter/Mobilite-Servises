
namespace Mobilitec_Servises
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btnChamados = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSAC = new System.Windows.Forms.Button();
            this.btnServiços = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChamados
            // 
            this.btnChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamados.Image = ((System.Drawing.Image)(resources.GetObject("btnChamados.Image")));
            this.btnChamados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChamados.Location = new System.Drawing.Point(34, 28);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(209, 190);
            this.btnChamados.TabIndex = 0;
            this.btnChamados.Text = "&Chamados";
            this.btnChamados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChamados.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionarios.Image")));
            this.btnFuncionarios.Location = new System.Drawing.Point(287, 28);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(209, 190);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "&Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(545, 28);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(209, 190);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "C&lientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSAC
            // 
            this.btnSAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAC.Location = new System.Drawing.Point(545, 259);
            this.btnSAC.Name = "btnSAC";
            this.btnSAC.Size = new System.Drawing.Size(209, 190);
            this.btnSAC.TabIndex = 5;
            this.btnSAC.Text = "S&AC";
            this.btnSAC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSAC.UseVisualStyleBackColor = true;
            // 
            // btnServiços
            // 
            this.btnServiços.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiços.Location = new System.Drawing.Point(287, 259);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(209, 190);
            this.btnServiços.TabIndex = 4;
            this.btnServiços.Text = "&Serviços";
            this.btnServiços.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServiços.UseVisualStyleBackColor = true;
            this.btnServiços.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.Location = new System.Drawing.Point(34, 259);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(209, 190);
            this.btnContatos.TabIndex = 3;
            this.btnContatos.Text = "Con&tatos";
            this.btnContatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContatos.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(545, 482);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(209, 48);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSAC);
            this.Controls.Add(this.btnServiços);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnChamados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobilite-Services";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChamados;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSAC;
        private System.Windows.Forms.Button btnServiços;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnVoltar;
    }
}