
namespace Mobilitec_Servises
{
    partial class FormComponentes
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
            this.cbbEstados = new System.Windows.Forms.ComboBox();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.ltbPreferencias = new System.Windows.Forms.ListBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.ckbEsportes = new System.Windows.Forms.CheckBox();
            this.ckbCultura = new System.Windows.Forms.CheckBox();
            this.ckbAcademia = new System.Windows.Forms.CheckBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.lblEstados = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPreferencias = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbEstados
            // 
            this.cbbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstados.FormattingEnabled = true;
            this.cbbEstados.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Belo Horizonte"});
            this.cbbEstados.Location = new System.Drawing.Point(101, 83);
            this.cbbEstados.Name = "cbbEstados";
            this.cbbEstados.Size = new System.Drawing.Size(121, 28);
            this.cbbEstados.TabIndex = 0;
            this.cbbEstados.SelectedIndexChanged += new System.EventHandler(this.cbbEstados_SelectedIndexChanged);
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLivros.Location = new System.Drawing.Point(10, 23);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(61, 24);
            this.ckbLivros.TabIndex = 1;
            this.ckbLivros.Text = "Livro";
            this.ckbLivros.UseVisualStyleBackColor = true;
            // 
            // ltbPreferencias
            // 
            this.ltbPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPreferencias.FormattingEnabled = true;
            this.ltbPreferencias.ItemHeight = 20;
            this.ltbPreferencias.Items.AddRange(new object[] {
            "Amarelo",
            "Vermelho",
            "Azul",
            "Cinza",
            "Preto"});
            this.ltbPreferencias.Location = new System.Drawing.Point(300, 83);
            this.ltbPreferencias.Name = "ltbPreferencias";
            this.ltbPreferencias.Size = new System.Drawing.Size(120, 84);
            this.ltbPreferencias.TabIndex = 7;
            this.ltbPreferencias.SelectedIndexChanged += new System.EventHandler(this.ltbPreferencias_SelectedIndexChanged);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculino.Location = new System.Drawing.Point(114, 343);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbtMasculino.TabIndex = 5;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // ckbEsportes
            // 
            this.ckbEsportes.AutoSize = true;
            this.ckbEsportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEsportes.Location = new System.Drawing.Point(10, 113);
            this.ckbEsportes.Name = "ckbEsportes";
            this.ckbEsportes.Size = new System.Drawing.Size(92, 24);
            this.ckbEsportes.TabIndex = 4;
            this.ckbEsportes.Text = "Esportes";
            this.ckbEsportes.UseVisualStyleBackColor = true;
            // 
            // ckbCultura
            // 
            this.ckbCultura.AutoSize = true;
            this.ckbCultura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCultura.Location = new System.Drawing.Point(10, 83);
            this.ckbCultura.Name = "ckbCultura";
            this.ckbCultura.Size = new System.Drawing.Size(79, 24);
            this.ckbCultura.TabIndex = 3;
            this.ckbCultura.Text = "Cultura";
            this.ckbCultura.UseVisualStyleBackColor = true;
            // 
            // ckbAcademia
            // 
            this.ckbAcademia.AutoSize = true;
            this.ckbAcademia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAcademia.Location = new System.Drawing.Point(10, 53);
            this.ckbAcademia.Name = "ckbAcademia";
            this.ckbAcademia.Size = new System.Drawing.Size(99, 24);
            this.ckbAcademia.TabIndex = 2;
            this.ckbAcademia.Text = "Academia";
            this.ckbAcademia.UseVisualStyleBackColor = true;
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFeminino.Location = new System.Drawing.Point(114, 373);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbtFeminino.TabIndex = 6;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(105, 65);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(58, 16);
            this.lblEstados.TabIndex = 8;
            this.lblEstados.Text = "Estados";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(111, 327);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 16);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // lblPreferencias
            // 
            this.lblPreferencias.AutoSize = true;
            this.lblPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferencias.Location = new System.Drawing.Point(297, 67);
            this.lblPreferencias.Name = "lblPreferencias";
            this.lblPreferencias.Size = new System.Drawing.Size(84, 16);
            this.lblPreferencias.TabIndex = 11;
            this.lblPreferencias.Text = "Preferências";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(300, 256);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(120, 38);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(300, 302);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 38);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(300, 348);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 38);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Componentes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbAcademia);
            this.groupBox1.Controls.Add(this.ckbLivros);
            this.groupBox1.Controls.Add(this.ckbEsportes);
            this.groupBox1.Controls.Add(this.ckbCultura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(101, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 154);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione";
            // 
            // FormComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblPreferencias);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.rbtFeminino);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.ltbPreferencias);
            this.Controls.Add(this.cbbEstados);
            this.Name = "FormComponentes";
            this.Text = "FormComponentes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstados;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.ListBox ltbPreferencias;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.CheckBox ckbEsportes;
        private System.Windows.Forms.CheckBox ckbCultura;
        private System.Windows.Forms.CheckBox ckbAcademia;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPreferencias;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}