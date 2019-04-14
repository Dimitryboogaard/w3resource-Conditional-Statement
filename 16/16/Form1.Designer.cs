namespace _16
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
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.lblGeefEenLetterOp = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLetter
            // 
            this.tbLetter.Location = new System.Drawing.Point(110, 12);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(100, 20);
            this.tbLetter.TabIndex = 0;
            // 
            // lblGeefEenLetterOp
            // 
            this.lblGeefEenLetterOp.AutoSize = true;
            this.lblGeefEenLetterOp.Location = new System.Drawing.Point(12, 15);
            this.lblGeefEenLetterOp.Name = "lblGeefEenLetterOp";
            this.lblGeefEenLetterOp.Size = new System.Drawing.Size(92, 13);
            this.lblGeefEenLetterOp.TabIndex = 1;
            this.lblGeefEenLetterOp.Text = "Geef een letter op";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(110, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(107, 64);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 3;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 96);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblGeefEenLetterOp);
            this.Controls.Add(this.tbLetter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Label lblGeefEenLetterOp;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

