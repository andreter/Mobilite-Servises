
namespace Mobilitec_Servises
{
    partial class frmCalculadoraSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraSimples));
            this.lblVar1 = new System.Windows.Forms.Label();
            this.lblVar2 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.gbbOperador = new System.Windows.Forms.GroupBox();
            this.rbtAdic = new System.Windows.Forms.RadioButton();
            this.rbtSub = new System.Windows.Forms.RadioButton();
            this.rbtMult = new System.Windows.Forms.RadioButton();
            this.rbtDiv = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.gbbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVar1
            // 
            this.lblVar1.AutoSize = true;
            this.lblVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar1.Location = new System.Drawing.Point(43, 110);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new System.Drawing.Size(78, 20);
            this.lblVar1.TabIndex = 0;
            this.lblVar1.Text = "Variável 1";
            // 
            // lblVar2
            // 
            this.lblVar2.AutoSize = true;
            this.lblVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar2.Location = new System.Drawing.Point(43, 183);
            this.lblVar2.Name = "lblVar2";
            this.lblVar2.Size = new System.Drawing.Size(78, 20);
            this.lblVar2.TabIndex = 1;
            this.lblVar2.Text = "Variável 2";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(426, 65);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(78, 20);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "Resposta";
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.Location = new System.Drawing.Point(127, 110);
            this.txtBox1.MaxLength = 10;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 26);
            this.txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(127, 183);
            this.txtBox2.MaxLength = 10;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 26);
            this.txtBox2.TabIndex = 1;
            // 
            // gbbOperador
            // 
            this.gbbOperador.Controls.Add(this.rbtDiv);
            this.gbbOperador.Controls.Add(this.rbtMult);
            this.gbbOperador.Controls.Add(this.rbtSub);
            this.gbbOperador.Controls.Add(this.rbtAdic);
            this.gbbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbbOperador.Location = new System.Drawing.Point(233, 234);
            this.gbbOperador.Name = "gbbOperador";
            this.gbbOperador.Size = new System.Drawing.Size(144, 203);
            this.gbbOperador.TabIndex = 2;
            this.gbbOperador.TabStop = false;
            this.gbbOperador.Text = "Operador";
            // 
            // rbtAdic
            // 
            this.rbtAdic.AutoSize = true;
            this.rbtAdic.Location = new System.Drawing.Point(6, 45);
            this.rbtAdic.Name = "rbtAdic";
            this.rbtAdic.Size = new System.Drawing.Size(99, 24);
            this.rbtAdic.TabIndex = 3;
            this.rbtAdic.TabStop = true;
            this.rbtAdic.Text = "Adição (+)";
            this.rbtAdic.UseVisualStyleBackColor = true;
            // 
            // rbtSub
            // 
            this.rbtSub.AutoSize = true;
            this.rbtSub.Location = new System.Drawing.Point(6, 75);
            this.rbtSub.Name = "rbtSub";
            this.rbtSub.Size = new System.Drawing.Size(123, 24);
            this.rbtSub.TabIndex = 4;
            this.rbtSub.TabStop = true;
            this.rbtSub.Text = "Subitração (-)";
            this.rbtSub.UseVisualStyleBackColor = true;
            // 
            // rbtMult
            // 
            this.rbtMult.AutoSize = true;
            this.rbtMult.Location = new System.Drawing.Point(6, 105);
            this.rbtMult.Name = "rbtMult";
            this.rbtMult.Size = new System.Drawing.Size(138, 24);
            this.rbtMult.TabIndex = 5;
            this.rbtMult.TabStop = true;
            this.rbtMult.Text = "Multiplicação (*)";
            this.rbtMult.UseVisualStyleBackColor = true;
            // 
            // rbtDiv
            // 
            this.rbtDiv.AutoSize = true;
            this.rbtDiv.Location = new System.Drawing.Point(6, 135);
            this.rbtDiv.Name = "rbtDiv";
            this.rbtDiv.Size = new System.Drawing.Size(96, 24);
            this.rbtDiv.TabIndex = 6;
            this.rbtDiv.TabStop = true;
            this.rbtDiv.Text = "Divisão (/)";
            this.rbtDiv.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.Location = new System.Drawing.Point(430, 234);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 37);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(430, 293);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 37);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(430, 355);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 37);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(430, 110);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(121, 57);
            this.lblResposta.TabIndex = 9;
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalculadoraSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(593, 537);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbbOperador);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblVar2);
            this.Controls.Add(this.lblVar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Simples";
            this.Load += new System.EventHandler(this.frmCalculadoraSimples_Load);
            this.gbbOperador.ResumeLayout(false);
            this.gbbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVar1;
        private System.Windows.Forms.Label lblVar2;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.GroupBox gbbOperador;
        private System.Windows.Forms.RadioButton rbtDiv;
        private System.Windows.Forms.RadioButton rbtMult;
        private System.Windows.Forms.RadioButton rbtSub;
        private System.Windows.Forms.RadioButton rbtAdic;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResposta;
    }
}