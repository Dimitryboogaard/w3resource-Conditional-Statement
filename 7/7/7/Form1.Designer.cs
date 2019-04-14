namespace _7
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
            this.tbLengte = new System.Windows.Forms.TextBox();
            this.lblLengteCm = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLengte
            // 
            this.tbLengte.Location = new System.Drawing.Point(81, 12);
            this.tbLengte.Name = "tbLengte";
            this.tbLengte.Size = new System.Drawing.Size(100, 20);
            this.tbLengte.TabIndex = 0;
            // 
            // lblLengteCm
            // 
            this.lblLengteCm.AutoSize = true;
            this.lblLengteCm.Location = new System.Drawing.Point(12, 15);
            this.lblLengteCm.Name = "lblLengteCm";
            this.lblLengteCm.Size = new System.Drawing.Size(63, 13);
            this.lblLengteCm.TabIndex = 1;
            this.lblLengteCm.Text = "Lengte (cm)";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(81, 38);
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
            this.lblAntwoord.Location = new System.Drawing.Point(78, 64);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 3;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 89);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblLengteCm);
            this.Controls.Add(this.tbLengte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLengte;
        private System.Windows.Forms.Label lblLengteCm;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

