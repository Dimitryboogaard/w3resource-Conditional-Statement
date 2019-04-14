namespace _4
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
            this.tbJaartal = new System.Windows.Forms.TextBox();
            this.lblJaartal = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblJaOfNee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbJaartal
            // 
            this.tbJaartal.Location = new System.Drawing.Point(56, 12);
            this.tbJaartal.Name = "tbJaartal";
            this.tbJaartal.Size = new System.Drawing.Size(100, 20);
            this.tbJaartal.TabIndex = 0;
            // 
            // lblJaartal
            // 
            this.lblJaartal.AutoSize = true;
            this.lblJaartal.Location = new System.Drawing.Point(12, 15);
            this.lblJaartal.Name = "lblJaartal";
            this.lblJaartal.Size = new System.Drawing.Size(38, 13);
            this.lblJaartal.TabIndex = 1;
            this.lblJaartal.Text = "Jaartal";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(56, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblJaOfNee
            // 
            this.lblJaOfNee.AutoSize = true;
            this.lblJaOfNee.Location = new System.Drawing.Point(53, 64);
            this.lblJaOfNee.Name = "lblJaOfNee";
            this.lblJaOfNee.Size = new System.Drawing.Size(43, 13);
            this.lblJaOfNee.TabIndex = 3;
            this.lblJaOfNee.Text = "Ja/Nee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 93);
            this.Controls.Add(this.lblJaOfNee);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblJaartal);
            this.Controls.Add(this.tbJaartal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbJaartal;
        private System.Windows.Forms.Label lblJaartal;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblJaOfNee;
    }
}

