namespace _14
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
            this.tbZijdeA = new System.Windows.Forms.TextBox();
            this.tbZijdeB = new System.Windows.Forms.TextBox();
            this.tbZijdeC = new System.Windows.Forms.TextBox();
            this.lblZijdeA = new System.Windows.Forms.Label();
            this.lblZijdeB = new System.Windows.Forms.Label();
            this.lblZijdeC = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbZijdeA
            // 
            this.tbZijdeA.Location = new System.Drawing.Point(57, 12);
            this.tbZijdeA.Name = "tbZijdeA";
            this.tbZijdeA.Size = new System.Drawing.Size(100, 20);
            this.tbZijdeA.TabIndex = 0;
            // 
            // tbZijdeB
            // 
            this.tbZijdeB.Location = new System.Drawing.Point(57, 38);
            this.tbZijdeB.Name = "tbZijdeB";
            this.tbZijdeB.Size = new System.Drawing.Size(100, 20);
            this.tbZijdeB.TabIndex = 1;
            // 
            // tbZijdeC
            // 
            this.tbZijdeC.Location = new System.Drawing.Point(57, 64);
            this.tbZijdeC.Name = "tbZijdeC";
            this.tbZijdeC.Size = new System.Drawing.Size(100, 20);
            this.tbZijdeC.TabIndex = 2;
            // 
            // lblZijdeA
            // 
            this.lblZijdeA.AutoSize = true;
            this.lblZijdeA.Location = new System.Drawing.Point(12, 15);
            this.lblZijdeA.Name = "lblZijdeA";
            this.lblZijdeA.Size = new System.Drawing.Size(39, 13);
            this.lblZijdeA.TabIndex = 3;
            this.lblZijdeA.Text = "Zijde a";
            // 
            // lblZijdeB
            // 
            this.lblZijdeB.AutoSize = true;
            this.lblZijdeB.Location = new System.Drawing.Point(12, 41);
            this.lblZijdeB.Name = "lblZijdeB";
            this.lblZijdeB.Size = new System.Drawing.Size(39, 13);
            this.lblZijdeB.TabIndex = 4;
            this.lblZijdeB.Text = "Zijde b";
            // 
            // lblZijdeC
            // 
            this.lblZijdeC.AutoSize = true;
            this.lblZijdeC.Location = new System.Drawing.Point(12, 67);
            this.lblZijdeC.Name = "lblZijdeC";
            this.lblZijdeC.Size = new System.Drawing.Size(39, 13);
            this.lblZijdeC.TabIndex = 5;
            this.lblZijdeC.Text = "Zijde c";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(57, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 6;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(54, 116);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 7;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 163);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblZijdeC);
            this.Controls.Add(this.lblZijdeB);
            this.Controls.Add(this.lblZijdeA);
            this.Controls.Add(this.tbZijdeC);
            this.Controls.Add(this.tbZijdeB);
            this.Controls.Add(this.tbZijdeA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbZijdeA;
        private System.Windows.Forms.TextBox tbZijdeB;
        private System.Windows.Forms.TextBox tbZijdeC;
        private System.Windows.Forms.Label lblZijdeA;
        private System.Windows.Forms.Label lblZijdeB;
        private System.Windows.Forms.Label lblZijdeC;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

