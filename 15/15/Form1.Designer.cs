namespace _15
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
            this.tbHoekA = new System.Windows.Forms.TextBox();
            this.tbHoekB = new System.Windows.Forms.TextBox();
            this.tbHoekC = new System.Windows.Forms.TextBox();
            this.lblHoekA = new System.Windows.Forms.Label();
            this.lblHoekB = new System.Windows.Forms.Label();
            this.lblHoekC = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblJaOfNee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbHoekA
            // 
            this.tbHoekA.Location = new System.Drawing.Point(60, 12);
            this.tbHoekA.Name = "tbHoekA";
            this.tbHoekA.Size = new System.Drawing.Size(100, 20);
            this.tbHoekA.TabIndex = 0;
            // 
            // tbHoekB
            // 
            this.tbHoekB.Location = new System.Drawing.Point(60, 38);
            this.tbHoekB.Name = "tbHoekB";
            this.tbHoekB.Size = new System.Drawing.Size(100, 20);
            this.tbHoekB.TabIndex = 1;
            // 
            // tbHoekC
            // 
            this.tbHoekC.Location = new System.Drawing.Point(60, 64);
            this.tbHoekC.Name = "tbHoekC";
            this.tbHoekC.Size = new System.Drawing.Size(100, 20);
            this.tbHoekC.TabIndex = 2;
            // 
            // lblHoekA
            // 
            this.lblHoekA.AutoSize = true;
            this.lblHoekA.Location = new System.Drawing.Point(12, 15);
            this.lblHoekA.Name = "lblHoekA";
            this.lblHoekA.Size = new System.Drawing.Size(42, 13);
            this.lblHoekA.TabIndex = 3;
            this.lblHoekA.Text = "Hoek a";
            // 
            // lblHoekB
            // 
            this.lblHoekB.AutoSize = true;
            this.lblHoekB.Location = new System.Drawing.Point(12, 41);
            this.lblHoekB.Name = "lblHoekB";
            this.lblHoekB.Size = new System.Drawing.Size(42, 13);
            this.lblHoekB.TabIndex = 4;
            this.lblHoekB.Text = "Hoek b";
            // 
            // lblHoekC
            // 
            this.lblHoekC.AutoSize = true;
            this.lblHoekC.Location = new System.Drawing.Point(12, 67);
            this.lblHoekC.Name = "lblHoekC";
            this.lblHoekC.Size = new System.Drawing.Size(42, 13);
            this.lblHoekC.TabIndex = 5;
            this.lblHoekC.Text = "Hoek c";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(60, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 6;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblJaOfNee
            // 
            this.lblJaOfNee.AutoSize = true;
            this.lblJaOfNee.Location = new System.Drawing.Point(57, 116);
            this.lblJaOfNee.Name = "lblJaOfNee";
            this.lblJaOfNee.Size = new System.Drawing.Size(43, 13);
            this.lblJaOfNee.TabIndex = 7;
            this.lblJaOfNee.Text = "Ja/Nee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 167);
            this.Controls.Add(this.lblJaOfNee);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblHoekC);
            this.Controls.Add(this.lblHoekB);
            this.Controls.Add(this.lblHoekA);
            this.Controls.Add(this.tbHoekC);
            this.Controls.Add(this.tbHoekB);
            this.Controls.Add(this.tbHoekA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHoekA;
        private System.Windows.Forms.TextBox tbHoekB;
        private System.Windows.Forms.TextBox tbHoekC;
        private System.Windows.Forms.Label lblHoekA;
        private System.Windows.Forms.Label lblHoekB;
        private System.Windows.Forms.Label lblHoekC;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblJaOfNee;
    }
}

