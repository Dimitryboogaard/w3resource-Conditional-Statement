namespace _18
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
            this.tbKlantID = new System.Windows.Forms.TextBox();
            this.tbKlantNaam = new System.Windows.Forms.TextBox();
            this.tbVerbruik = new System.Windows.Forms.TextBox();
            this.lblKlantID = new System.Windows.Forms.Label();
            this.lblKlantNaam = new System.Windows.Forms.Label();
            this.lblVerbruik = new System.Windows.Forms.Label();
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbKlantID
            // 
            this.tbKlantID.Location = new System.Drawing.Point(79, 12);
            this.tbKlantID.Name = "tbKlantID";
            this.tbKlantID.Size = new System.Drawing.Size(100, 20);
            this.tbKlantID.TabIndex = 0;
            // 
            // tbKlantNaam
            // 
            this.tbKlantNaam.Location = new System.Drawing.Point(79, 38);
            this.tbKlantNaam.Name = "tbKlantNaam";
            this.tbKlantNaam.Size = new System.Drawing.Size(100, 20);
            this.tbKlantNaam.TabIndex = 1;
            // 
            // tbVerbruik
            // 
            this.tbVerbruik.Location = new System.Drawing.Point(79, 64);
            this.tbVerbruik.Name = "tbVerbruik";
            this.tbVerbruik.Size = new System.Drawing.Size(100, 20);
            this.tbVerbruik.TabIndex = 2;
            // 
            // lblKlantID
            // 
            this.lblKlantID.AutoSize = true;
            this.lblKlantID.Location = new System.Drawing.Point(24, 15);
            this.lblKlantID.Name = "lblKlantID";
            this.lblKlantID.Size = new System.Drawing.Size(45, 13);
            this.lblKlantID.TabIndex = 3;
            this.lblKlantID.Text = "Klant ID";
            // 
            // lblKlantNaam
            // 
            this.lblKlantNaam.AutoSize = true;
            this.lblKlantNaam.Location = new System.Drawing.Point(12, 41);
            this.lblKlantNaam.Name = "lblKlantNaam";
            this.lblKlantNaam.Size = new System.Drawing.Size(57, 13);
            this.lblKlantNaam.TabIndex = 4;
            this.lblKlantNaam.Text = "Klantnaam";
            // 
            // lblVerbruik
            // 
            this.lblVerbruik.AutoSize = true;
            this.lblVerbruik.Location = new System.Drawing.Point(23, 67);
            this.lblVerbruik.Name = "lblVerbruik";
            this.lblVerbruik.Size = new System.Drawing.Size(46, 13);
            this.lblVerbruik.TabIndex = 5;
            this.lblVerbruik.Text = "Verbruik";
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(185, 12);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(150, 184);
            this.rtUitvoer.TabIndex = 6;
            this.rtUitvoer.Text = "";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(79, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 7;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 211);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.rtUitvoer);
            this.Controls.Add(this.lblVerbruik);
            this.Controls.Add(this.lblKlantNaam);
            this.Controls.Add(this.lblKlantID);
            this.Controls.Add(this.tbVerbruik);
            this.Controls.Add(this.tbKlantNaam);
            this.Controls.Add(this.tbKlantID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKlantID;
        private System.Windows.Forms.TextBox tbKlantNaam;
        private System.Windows.Forms.TextBox tbVerbruik;
        private System.Windows.Forms.Label lblKlantID;
        private System.Windows.Forms.Label lblKlantNaam;
        private System.Windows.Forms.Label lblVerbruik;
        private System.Windows.Forms.RichTextBox rtUitvoer;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

