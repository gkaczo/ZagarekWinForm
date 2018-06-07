namespace ZegarekWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskTextGodzina = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKatStopnie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKatRadiany = new System.Windows.Forms.Label();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskTextGodzina
            // 
            this.mskTextGodzina.Location = new System.Drawing.Point(126, 26);
            this.mskTextGodzina.Mask = "90:00";
            this.mskTextGodzina.Name = "mskTextGodzina";
            this.mskTextGodzina.Size = new System.Drawing.Size(81, 20);
            this.mskTextGodzina.TabIndex = 0;
            this.mskTextGodzina.ValidatingType = typeof(System.DateTime);
            this.mskTextGodzina.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mskTextGodzina_TypeValidationCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj Godzine";
            // 
            // lblKatStopnie
            // 
            this.lblKatStopnie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKatStopnie.Location = new System.Drawing.Point(110, 89);
            this.lblKatStopnie.Name = "lblKatStopnie";
            this.lblKatStopnie.Size = new System.Drawing.Size(100, 23);
            this.lblKatStopnie.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "kąt stopnie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "kąt radiany";
            // 
            // lblKatRadiany
            // 
            this.lblKatRadiany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKatRadiany.Location = new System.Drawing.Point(110, 131);
            this.lblKatRadiany.Name = "lblKatRadiany";
            this.lblKatRadiany.Size = new System.Drawing.Size(100, 23);
            this.lblKatRadiany.TabIndex = 5;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(229, 52);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 6;
            this.btnOblicz.Text = "ObliczKat";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "gkaczo@wp.pl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 183);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.lblKatRadiany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKatStopnie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskTextGodzina);
            this.Name = "Form1";
            this.Text = "Zegarek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTextGodzina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKatStopnie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKatRadiany;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label label4;
    }
}

