namespace _17
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
            this.tbInkoopPrijs = new System.Windows.Forms.TextBox();
            this.tbVerkoopPrijs = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblInkoopPrijs = new System.Windows.Forms.Label();
            this.lblVerkoopPrijs = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInkoopPrijs
            // 
            this.tbInkoopPrijs.Location = new System.Drawing.Point(83, 12);
            this.tbInkoopPrijs.Name = "tbInkoopPrijs";
            this.tbInkoopPrijs.Size = new System.Drawing.Size(100, 20);
            this.tbInkoopPrijs.TabIndex = 0;
            // 
            // tbVerkoopPrijs
            // 
            this.tbVerkoopPrijs.Location = new System.Drawing.Point(83, 38);
            this.tbVerkoopPrijs.Name = "tbVerkoopPrijs";
            this.tbVerkoopPrijs.Size = new System.Drawing.Size(100, 20);
            this.tbVerkoopPrijs.TabIndex = 1;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(83, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblInkoopPrijs
            // 
            this.lblInkoopPrijs.AutoSize = true;
            this.lblInkoopPrijs.Location = new System.Drawing.Point(19, 15);
            this.lblInkoopPrijs.Name = "lblInkoopPrijs";
            this.lblInkoopPrijs.Size = new System.Drawing.Size(58, 13);
            this.lblInkoopPrijs.TabIndex = 3;
            this.lblInkoopPrijs.Text = "Inkoopprijs";
            // 
            // lblVerkoopPrijs
            // 
            this.lblVerkoopPrijs.AutoSize = true;
            this.lblVerkoopPrijs.Location = new System.Drawing.Point(12, 41);
            this.lblVerkoopPrijs.Name = "lblVerkoopPrijs";
            this.lblVerkoopPrijs.Size = new System.Drawing.Size(65, 13);
            this.lblVerkoopPrijs.TabIndex = 4;
            this.lblVerkoopPrijs.Text = "Verkoopprijs";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(80, 90);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 5;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 127);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblVerkoopPrijs);
            this.Controls.Add(this.lblInkoopPrijs);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbVerkoopPrijs);
            this.Controls.Add(this.tbInkoopPrijs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInkoopPrijs;
        private System.Windows.Forms.TextBox tbVerkoopPrijs;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblInkoopPrijs;
        private System.Windows.Forms.Label lblVerkoopPrijs;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

