
namespace JogoDaSorte
{
    partial class FrmJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJogo));
            this.label1 = new System.Windows.Forms.Label();
            this.LblNumeros = new System.Windows.Forms.Label();
            this.BtnSorteio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtN6 = new System.Windows.Forms.TextBox();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.TxtN4 = new System.Windows.Forms.TextBox();
            this.TxtN3 = new System.Windows.Forms.TextBox();
            this.TxtN5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números apostados";
            // 
            // LblNumeros
            // 
            this.LblNumeros.AutoSize = true;
            this.LblNumeros.Location = new System.Drawing.Point(27, 75);
            this.LblNumeros.Name = "LblNumeros";
            this.LblNumeros.Size = new System.Drawing.Size(35, 13);
            this.LblNumeros.TabIndex = 1;
            this.LblNumeros.Text = "label2";
            // 
            // BtnSorteio
            // 
            this.BtnSorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSorteio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSorteio.Location = new System.Drawing.Point(534, 282);
            this.BtnSorteio.Name = "BtnSorteio";
            this.BtnSorteio.Size = new System.Drawing.Size(117, 74);
            this.BtnSorteio.TabIndex = 7;
            this.BtnSorteio.Text = "Sorteio";
            this.BtnSorteio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Insira os seis números de sua aposta";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnLimpar.Location = new System.Drawing.Point(343, 309);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(113, 47);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // TxtN6
            // 
            this.TxtN6.Location = new System.Drawing.Point(573, 209);
            this.TxtN6.Name = "TxtN6";
            this.TxtN6.Size = new System.Drawing.Size(78, 20);
            this.TxtN6.TabIndex = 12;
            // 
            // TxtN2
            // 
            this.TxtN2.Location = new System.Drawing.Point(140, 209);
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(78, 20);
            this.TxtN2.TabIndex = 13;
            // 
            // TxtN1
            // 
            this.TxtN1.Location = new System.Drawing.Point(30, 209);
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(78, 20);
            this.TxtN1.TabIndex = 14;
            // 
            // TxtN4
            // 
            this.TxtN4.Location = new System.Drawing.Point(356, 209);
            this.TxtN4.Name = "TxtN4";
            this.TxtN4.Size = new System.Drawing.Size(78, 20);
            this.TxtN4.TabIndex = 15;
            // 
            // TxtN3
            // 
            this.TxtN3.Location = new System.Drawing.Point(248, 209);
            this.TxtN3.Name = "TxtN3";
            this.TxtN3.Size = new System.Drawing.Size(78, 20);
            this.TxtN3.TabIndex = 16;
            // 
            // TxtN5
            // 
            this.TxtN5.Location = new System.Drawing.Point(467, 209);
            this.TxtN5.Name = "TxtN5";
            this.TxtN5.Size = new System.Drawing.Size(78, 20);
            this.TxtN5.TabIndex = 17;
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 368);
            this.Controls.Add(this.TxtN5);
            this.Controls.Add(this.TxtN3);
            this.Controls.Add(this.TxtN4);
            this.Controls.Add(this.TxtN1);
            this.Controls.Add(this.TxtN2);
            this.Controls.Add(this.TxtN6);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSorteio);
            this.Controls.Add(this.LblNumeros);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmJogo";
            this.Text = "Jogue agora!!!";
            this.Load += new System.EventHandler(this.FrmJogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNumeros;
        private System.Windows.Forms.Button BtnSorteio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox TxtN6;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.TextBox TxtN4;
        private System.Windows.Forms.TextBox TxtN3;
        private System.Windows.Forms.TextBox TxtN5;
    }
}