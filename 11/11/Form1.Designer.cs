namespace _11
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblNulPunten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(31, 12);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 0;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(31, 38);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 1;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(31, 64);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 20);
            this.tbC.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 15);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "a";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 41);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(13, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "b";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(12, 67);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(13, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "c";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(31, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 6;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblNulPunten
            // 
            this.lblNulPunten.AutoSize = true;
            this.lblNulPunten.Location = new System.Drawing.Point(28, 116);
            this.lblNulPunten.Name = "lblNulPunten";
            this.lblNulPunten.Size = new System.Drawing.Size(56, 13);
            this.lblNulPunten.TabIndex = 7;
            this.lblNulPunten.Text = "Nulpunten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 160);
            this.Controls.Add(this.lblNulPunten);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblNulPunten;
    }
}

