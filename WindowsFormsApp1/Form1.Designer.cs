
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btad = new System.Windows.Forms.Button();
            this.btsb = new System.Windows.Forms.Button();
            this.btmt = new System.Windows.Forms.Button();
            this.btdv = new System.Windows.Forms.Button();
            this.btpt = new System.Windows.Forms.Button();
            this.btcomp = new System.Windows.Forms.Button();
            this.btpar = new System.Windows.Forms.Button();
            this.lblsinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.num1.Location = new System.Drawing.Point(276, 115);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(246, 31);
            this.num1.TabIndex = 0;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.num2.Location = new System.Drawing.Point(276, 178);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(246, 31);
            this.num2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o primeiro número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira o segundo número";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(276, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "_________________________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "Resultado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblresultado
            // 
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(110, 275);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(564, 38);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btad
            // 
            this.btad.Location = new System.Drawing.Point(110, 316);
            this.btad.Name = "btad";
            this.btad.Size = new System.Drawing.Size(108, 28);
            this.btad.TabIndex = 8;
            this.btad.Text = "Adição";
            this.btad.UseVisualStyleBackColor = true;
            this.btad.Click += new System.EventHandler(this.btad_Click);
            // 
            // btsb
            // 
            this.btsb.Location = new System.Drawing.Point(224, 316);
            this.btsb.Name = "btsb";
            this.btsb.Size = new System.Drawing.Size(108, 28);
            this.btsb.TabIndex = 9;
            this.btsb.Text = "Subtração";
            this.btsb.UseVisualStyleBackColor = true;
            this.btsb.Click += new System.EventHandler(this.btsb_Click);
            // 
            // btmt
            // 
            this.btmt.Location = new System.Drawing.Point(338, 316);
            this.btmt.Name = "btmt";
            this.btmt.Size = new System.Drawing.Size(108, 28);
            this.btmt.TabIndex = 10;
            this.btmt.Text = "Multiplicação";
            this.btmt.UseVisualStyleBackColor = true;
            this.btmt.Click += new System.EventHandler(this.btmt_Click);
            // 
            // btdv
            // 
            this.btdv.Location = new System.Drawing.Point(452, 316);
            this.btdv.Name = "btdv";
            this.btdv.Size = new System.Drawing.Size(108, 28);
            this.btdv.TabIndex = 11;
            this.btdv.Text = "Divisão";
            this.btdv.UseVisualStyleBackColor = true;
            this.btdv.Click += new System.EventHandler(this.btdv_Click);
            // 
            // btpt
            // 
            this.btpt.Location = new System.Drawing.Point(566, 316);
            this.btpt.Name = "btpt";
            this.btpt.Size = new System.Drawing.Size(108, 28);
            this.btpt.TabIndex = 12;
            this.btpt.Text = "Potenciação";
            this.btpt.UseVisualStyleBackColor = true;
            this.btpt.Click += new System.EventHandler(this.btpt_Click);
            // 
            // btcomp
            // 
            this.btcomp.Location = new System.Drawing.Point(287, 350);
            this.btcomp.Name = "btcomp";
            this.btcomp.Size = new System.Drawing.Size(108, 28);
            this.btcomp.TabIndex = 14;
            this.btcomp.Text = "Comparar";
            this.btcomp.UseVisualStyleBackColor = true;
            this.btcomp.Click += new System.EventHandler(this.btcomp_Click);
            // 
            // btpar
            // 
            this.btpar.Location = new System.Drawing.Point(401, 350);
            this.btpar.Name = "btpar";
            this.btpar.Size = new System.Drawing.Size(108, 28);
            this.btpar.TabIndex = 15;
            this.btpar.Text = "Par ou Ímpar";
            this.btpar.UseVisualStyleBackColor = true;
            this.btpar.Click += new System.EventHandler(this.btpar_Click);
            // 
            // lblsinal
            // 
            this.lblsinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsinal.Location = new System.Drawing.Point(528, 150);
            this.lblsinal.Name = "lblsinal";
            this.lblsinal.Size = new System.Drawing.Size(42, 38);
            this.lblsinal.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsinal);
            this.Controls.Add(this.btpar);
            this.Controls.Add(this.btcomp);
            this.Controls.Add(this.btpt);
            this.Controls.Add(this.btdv);
            this.Controls.Add(this.btmt);
            this.Controls.Add(this.btsb);
            this.Controls.Add(this.btad);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btad;
        private System.Windows.Forms.Button btsb;
        private System.Windows.Forms.Button btmt;
        private System.Windows.Forms.Button btdv;
        private System.Windows.Forms.Button btpt;
        private System.Windows.Forms.Button btcomp;
        private System.Windows.Forms.Button btpar;
        private System.Windows.Forms.Label lblsinal;
    }
}

