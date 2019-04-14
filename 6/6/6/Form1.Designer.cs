namespace _6
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
            this.tbGetalM = new System.Windows.Forms.TextBox();
            this.lblGetalM = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblNIs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGetalM
            // 
            this.tbGetalM.Location = new System.Drawing.Point(61, 12);
            this.tbGetalM.Name = "tbGetalM";
            this.tbGetalM.Size = new System.Drawing.Size(100, 20);
            this.tbGetalM.TabIndex = 0;
            // 
            // lblGetalM
            // 
            this.lblGetalM.AutoSize = true;
            this.lblGetalM.Location = new System.Drawing.Point(12, 15);
            this.lblGetalM.Name = "lblGetalM";
            this.lblGetalM.Size = new System.Drawing.Size(43, 13);
            this.lblGetalM.TabIndex = 1;
            this.lblGetalM.Text = "Getal m";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(61, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblNIs
            // 
            this.lblNIs.AutoSize = true;
            this.lblNIs.Location = new System.Drawing.Point(58, 64);
            this.lblNIs.Name = "lblNIs";
            this.lblNIs.Size = new System.Drawing.Size(22, 13);
            this.lblNIs.TabIndex = 3;
            this.lblNIs.Text = "n =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 100);
            this.Controls.Add(this.lblNIs);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblGetalM);
            this.Controls.Add(this.tbGetalM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetalM;
        private System.Windows.Forms.Label lblGetalM;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblNIs;
    }
}

