
namespace Mobilitec_Servises
{
    partial class frmFolhaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaDePagamento));
            this.ckbPlano = new System.Windows.Forms.CheckBox();
            this.cbbClub = new System.Windows.Forms.ComboBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtSalFolha = new System.Windows.Forms.TextBox();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblSalFolha = new System.Windows.Forms.Label();
            this.lblSalImposto = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbPlano
            // 
            this.ckbPlano.AutoSize = true;
            this.ckbPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlano.Location = new System.Drawing.Point(69, 197);
            this.ckbPlano.Name = "ckbPlano";
            this.ckbPlano.Size = new System.Drawing.Size(122, 20);
            this.ckbPlano.TabIndex = 1;
            this.ckbPlano.Text = "Plano de saúde";
            this.ckbPlano.UseVisualStyleBackColor = true;
            this.ckbPlano.CheckedChanged += new System.EventHandler(this.ckbPlano_CheckedChanged);
            // 
            // cbbClub
            // 
            this.cbbClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClub.FormattingEnabled = true;
            this.cbbClub.Items.AddRange(new object[] {
            "",
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClub.Location = new System.Drawing.Point(69, 278);
            this.cbbClub.Name = "cbbClub";
            this.cbbClub.Size = new System.Drawing.Size(121, 28);
            this.cbbClub.TabIndex = 2;
            this.cbbClub.SelectedIndexChanged += new System.EventHandler(this.cbbClub_SelectedIndexChanged);
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(69, 165);
            this.txtSal.MaxLength = 10;
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(147, 26);
            this.txtSal.TabIndex = 0;
            this.txtSal.TextChanged += new System.EventHandler(this.txtSal_TextChanged);
            // 
            // txtSalFolha
            // 
            this.txtSalFolha.Enabled = false;
            this.txtSalFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFolha.Location = new System.Drawing.Point(468, 114);
            this.txtSalFolha.MaxLength = 10;
            this.txtSalFolha.Name = "txtSalFolha";
            this.txtSalFolha.Size = new System.Drawing.Size(144, 26);
            this.txtSalFolha.TabIndex = 4;
            // 
            // txtImposto
            // 
            this.txtImposto.Enabled = false;
            this.txtImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImposto.Location = new System.Drawing.Point(468, 180);
            this.txtImposto.MaxLength = 10;
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(144, 26);
            this.txtImposto.TabIndex = 5;
            this.txtImposto.TextChanged += new System.EventHandler(this.txtImposto_TextChanged);
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Enabled = false;
            this.txtSalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalLiq.Location = new System.Drawing.Point(468, 246);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(144, 26);
            this.txtSalLiq.TabIndex = 6;
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(65, 142);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(58, 20);
            this.lblSal.TabIndex = 6;
            this.lblSal.Text = "Sálario";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(65, 255);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(116, 20);
            this.lblClub.TabIndex = 7;
            this.lblClub.Text = "Clube de Lazer";
            // 
            // lblSalFolha
            // 
            this.lblSalFolha.AutoSize = true;
            this.lblSalFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFolha.Location = new System.Drawing.Point(301, 117);
            this.lblSalFolha.Name = "lblSalFolha";
            this.lblSalFolha.Size = new System.Drawing.Size(102, 20);
            this.lblSalFolha.TabIndex = 8;
            this.lblSalFolha.Text = "Sálario Folha";
            // 
            // lblSalImposto
            // 
            this.lblSalImposto.AutoSize = true;
            this.lblSalImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalImposto.Location = new System.Drawing.Point(301, 183);
            this.lblSalImposto.Name = "lblSalImposto";
            this.lblSalImposto.Size = new System.Drawing.Size(141, 20);
            this.lblSalImposto.TabIndex = 9;
            this.lblSalImposto.Text = "Imposto de Renda";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiq.Location = new System.Drawing.Point(301, 249);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(113, 20);
            this.lblSalLiq.TabIndex = 10;
            this.lblSalLiq.Text = "Sálario Liquido";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(69, 82);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(147, 20);
            this.dtpData.TabIndex = 11;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(65, 59);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(110, 20);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data da Folha";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(304, 46);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 33);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Location = new System.Drawing.Point(305, 383);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(102, 38);
            this.btnLimp.TabIndex = 7;
            this.btnLimp.Text = "&Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(468, 383);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 38);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmFolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 470);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalImposto);
            this.Controls.Add(this.lblSalFolha);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.txtSalFolha);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.cbbClub);
            this.Controls.Add(this.ckbPlano);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaDePagamento";
            this.Text = "Folha de pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbPlano;
        private System.Windows.Forms.ComboBox cbbClub;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtSalFolha;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblSalFolha;
        private System.Windows.Forms.Label lblSalImposto;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnSair;
    }
}