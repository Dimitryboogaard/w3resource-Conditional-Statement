namespace _10
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
            this.tbWiskunde = new System.Windows.Forms.TextBox();
            this.tbNatuurkunde = new System.Windows.Forms.TextBox();
            this.tbScheikunde = new System.Windows.Forms.TextBox();
            this.lblWiskunde = new System.Windows.Forms.Label();
            this.lblNatuurkunde = new System.Windows.Forms.Label();
            this.lblScheikunde = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblToegelatenJaOfNee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWiskunde
            // 
            this.tbWiskunde.Location = new System.Drawing.Point(87, 12);
            this.tbWiskunde.Name = "tbWiskunde";
            this.tbWiskunde.Size = new System.Drawing.Size(100, 20);
            this.tbWiskunde.TabIndex = 0;
            // 
            // tbNatuurkunde
            // 
            this.tbNatuurkunde.Location = new System.Drawing.Point(87, 38);
            this.tbNatuurkunde.Name = "tbNatuurkunde";
            this.tbNatuurkunde.Size = new System.Drawing.Size(100, 20);
            this.tbNatuurkunde.TabIndex = 1;
            // 
            // tbScheikunde
            // 
            this.tbScheikunde.Location = new System.Drawing.Point(87, 64);
            this.tbScheikunde.Name = "tbScheikunde";
            this.tbScheikunde.Size = new System.Drawing.Size(100, 20);
            this.tbScheikunde.TabIndex = 2;
            // 
            // lblWiskunde
            // 
            this.lblWiskunde.AutoSize = true;
            this.lblWiskunde.Location = new System.Drawing.Point(26, 15);
            this.lblWiskunde.Name = "lblWiskunde";
            this.lblWiskunde.Size = new System.Drawing.Size(55, 13);
            this.lblWiskunde.TabIndex = 3;
            this.lblWiskunde.Text = "Wiskunde";
            // 
            // lblNatuurkunde
            // 
            this.lblNatuurkunde.AutoSize = true;
            this.lblNatuurkunde.Location = new System.Drawing.Point(12, 41);
            this.lblNatuurkunde.Name = "lblNatuurkunde";
            this.lblNatuurkunde.Size = new System.Drawing.Size(69, 13);
            this.lblNatuurkunde.TabIndex = 4;
            this.lblNatuurkunde.Text = "Natuurkunde";
            // 
            // lblScheikunde
            // 
            this.lblScheikunde.AutoSize = true;
            this.lblScheikunde.Location = new System.Drawing.Point(17, 67);
            this.lblScheikunde.Name = "lblScheikunde";
            this.lblScheikunde.Size = new System.Drawing.Size(64, 13);
            this.lblScheikunde.TabIndex = 5;
            this.lblScheikunde.Text = "Scheikunde";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(87, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 6;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblToegelatenJaOfNee
            // 
            this.lblToegelatenJaOfNee.AutoSize = true;
            this.lblToegelatenJaOfNee.Location = new System.Drawing.Point(84, 116);
            this.lblToegelatenJaOfNee.Name = "lblToegelatenJaOfNee";
            this.lblToegelatenJaOfNee.Size = new System.Drawing.Size(95, 13);
            this.lblToegelatenJaOfNee.TabIndex = 7;
            this.lblToegelatenJaOfNee.Text = "Toegelaten ja/nee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 176);
            this.Controls.Add(this.lblToegelatenJaOfNee);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblScheikunde);
            this.Controls.Add(this.lblNatuurkunde);
            this.Controls.Add(this.lblWiskunde);
            this.Controls.Add(this.tbScheikunde);
            this.Controls.Add(this.tbNatuurkunde);
            this.Controls.Add(this.tbWiskunde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWiskunde;
        private System.Windows.Forms.TextBox tbNatuurkunde;
        private System.Windows.Forms.TextBox tbScheikunde;
        private System.Windows.Forms.Label lblWiskunde;
        private System.Windows.Forms.Label lblNatuurkunde;
        private System.Windows.Forms.Label lblScheikunde;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblToegelatenJaOfNee;
    }
}

