namespace StringSearch
{
    partial class Form1
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
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.lblRezultati = new System.Windows.Forms.Label();
            this.lblTeksti = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPattern
            // 
            this.txtPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPattern.Location = new System.Drawing.Point(32, 190);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(382, 30);
            this.txtPattern.TabIndex = 0;
            // 
            // rtbText
            // 
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(32, 46);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(382, 92);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // btnKerko
            // 
            this.btnKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.Location = new System.Drawing.Point(164, 293);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(114, 58);
            this.btnKerko.TabIndex = 2;
            this.btnKerko.Text = "Kerko";
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRezultati
            // 
            this.lblRezultati.AutoSize = true;
            this.lblRezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultati.ForeColor = System.Drawing.Color.Red;
            this.lblRezultati.Location = new System.Drawing.Point(30, 232);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(0, 20);
            this.lblRezultati.TabIndex = 3;
            // 
            // lblTeksti
            // 
            this.lblTeksti.AutoSize = true;
            this.lblTeksti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeksti.Location = new System.Drawing.Point(29, 14);
            this.lblTeksti.Name = "lblTeksti";
            this.lblTeksti.Size = new System.Drawing.Size(71, 25);
            this.lblTeksti.TabIndex = 4;
            this.lblTeksti.Text = "Teksti:";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattern.Location = new System.Drawing.Point(29, 162);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(166, 25);
            this.lblPattern.TabIndex = 5;
            this.lblPattern.Text = "Teksti per kerkim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(452, 369);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.lblTeksti);
            this.Controls.Add(this.lblRezultati);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.txtPattern);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horspool Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.Label lblRezultati;
        private System.Windows.Forms.Label lblTeksti;
        private System.Windows.Forms.Label lblPattern;
    }
}

