namespace _12
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
            this.tbRollNummer = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbNatuurkunde = new System.Windows.Forms.TextBox();
            this.tbScheikunde = new System.Windows.Forms.TextBox();
            this.tbComputer = new System.Windows.Forms.TextBox();
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.lblRollNummer = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblNatuurkunde = new System.Windows.Forms.Label();
            this.lblScheikunde = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRollNummer
            // 
            this.tbRollNummer.Location = new System.Drawing.Point(87, 12);
            this.tbRollNummer.Name = "tbRollNummer";
            this.tbRollNummer.Size = new System.Drawing.Size(100, 20);
            this.tbRollNummer.TabIndex = 0;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(87, 38);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 1;
            // 
            // tbNatuurkunde
            // 
            this.tbNatuurkunde.Location = new System.Drawing.Point(87, 64);
            this.tbNatuurkunde.Name = "tbNatuurkunde";
            this.tbNatuurkunde.Size = new System.Drawing.Size(100, 20);
            this.tbNatuurkunde.TabIndex = 2;
            // 
            // tbScheikunde
            // 
            this.tbScheikunde.Location = new System.Drawing.Point(87, 90);
            this.tbScheikunde.Name = "tbScheikunde";
            this.tbScheikunde.Size = new System.Drawing.Size(100, 20);
            this.tbScheikunde.TabIndex = 3;
            // 
            // tbComputer
            // 
            this.tbComputer.Location = new System.Drawing.Point(87, 116);
            this.tbComputer.Name = "tbComputer";
            this.tbComputer.Size = new System.Drawing.Size(100, 20);
            this.tbComputer.TabIndex = 4;
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(193, 12);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(169, 196);
            this.rtUitvoer.TabIndex = 5;
            this.rtUitvoer.Text = "";
            // 
            // lblRollNummer
            // 
            this.lblRollNummer.AutoSize = true;
            this.lblRollNummer.Location = new System.Drawing.Point(16, 15);
            this.lblRollNummer.Name = "lblRollNummer";
            this.lblRollNummer.Size = new System.Drawing.Size(65, 13);
            this.lblRollNummer.TabIndex = 6;
            this.lblRollNummer.Text = "Roll nummer";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(46, 41);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 7;
            this.lblNaam.Text = "Naam";
            // 
            // lblNatuurkunde
            // 
            this.lblNatuurkunde.AutoSize = true;
            this.lblNatuurkunde.Location = new System.Drawing.Point(12, 67);
            this.lblNatuurkunde.Name = "lblNatuurkunde";
            this.lblNatuurkunde.Size = new System.Drawing.Size(69, 13);
            this.lblNatuurkunde.TabIndex = 8;
            this.lblNatuurkunde.Text = "Natuurkunde";
            // 
            // lblScheikunde
            // 
            this.lblScheikunde.AutoSize = true;
            this.lblScheikunde.Location = new System.Drawing.Point(17, 93);
            this.lblScheikunde.Name = "lblScheikunde";
            this.lblScheikunde.Size = new System.Drawing.Size(64, 13);
            this.lblScheikunde.TabIndex = 9;
            this.lblScheikunde.Text = "Scheikunde";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(29, 119);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(52, 13);
            this.lblComputer.TabIndex = 10;
            this.lblComputer.Text = "Computer";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(87, 142);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 11;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 249);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblScheikunde);
            this.Controls.Add(this.lblNatuurkunde);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblRollNummer);
            this.Controls.Add(this.rtUitvoer);
            this.Controls.Add(this.tbComputer);
            this.Controls.Add(this.tbScheikunde);
            this.Controls.Add(this.tbNatuurkunde);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.tbRollNummer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRollNummer;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbNatuurkunde;
        private System.Windows.Forms.TextBox tbScheikunde;
        private System.Windows.Forms.TextBox tbComputer;
        private System.Windows.Forms.RichTextBox rtUitvoer;
        private System.Windows.Forms.Label lblRollNummer;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblNatuurkunde;
        private System.Windows.Forms.Label lblScheikunde;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

