namespace _24
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
            this.rbCirkel = new System.Windows.Forms.RadioButton();
            this.rbRechtHoek = new System.Windows.Forms.RadioButton();
            this.rbDrieHoek = new System.Windows.Forms.RadioButton();
            this.gbEen = new System.Windows.Forms.GroupBox();
            this.btnKeuze = new System.Windows.Forms.Button();
            this.tbEen = new System.Windows.Forms.TextBox();
            this.tbTwee = new System.Windows.Forms.TextBox();
            this.lblEen = new System.Windows.Forms.Label();
            this.lblTwee = new System.Windows.Forms.Label();
            this.tbAntwoord = new System.Windows.Forms.TextBox();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.gbEen.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCirkel
            // 
            this.rbCirkel.AutoSize = true;
            this.rbCirkel.Location = new System.Drawing.Point(5, 9);
            this.rbCirkel.Name = "rbCirkel";
            this.rbCirkel.Size = new System.Drawing.Size(51, 17);
            this.rbCirkel.TabIndex = 0;
            this.rbCirkel.TabStop = true;
            this.rbCirkel.Text = "Cirkel";
            this.rbCirkel.UseVisualStyleBackColor = true;
            // 
            // rbRechtHoek
            // 
            this.rbRechtHoek.AutoSize = true;
            this.rbRechtHoek.Location = new System.Drawing.Point(5, 32);
            this.rbRechtHoek.Name = "rbRechtHoek";
            this.rbRechtHoek.Size = new System.Drawing.Size(78, 17);
            this.rbRechtHoek.TabIndex = 1;
            this.rbRechtHoek.TabStop = true;
            this.rbRechtHoek.Text = "Rechthoek";
            this.rbRechtHoek.UseVisualStyleBackColor = true;
            // 
            // rbDrieHoek
            // 
            this.rbDrieHoek.AutoSize = true;
            this.rbDrieHoek.Location = new System.Drawing.Point(5, 55);
            this.rbDrieHoek.Name = "rbDrieHoek";
            this.rbDrieHoek.Size = new System.Drawing.Size(68, 17);
            this.rbDrieHoek.TabIndex = 2;
            this.rbDrieHoek.TabStop = true;
            this.rbDrieHoek.Text = "Driehoek";
            this.rbDrieHoek.UseVisualStyleBackColor = true;
            // 
            // gbEen
            // 
            this.gbEen.Controls.Add(this.rbDrieHoek);
            this.gbEen.Controls.Add(this.rbRechtHoek);
            this.gbEen.Controls.Add(this.rbCirkel);
            this.gbEen.Location = new System.Drawing.Point(7, 3);
            this.gbEen.Name = "gbEen";
            this.gbEen.Size = new System.Drawing.Size(100, 79);
            this.gbEen.TabIndex = 3;
            this.gbEen.TabStop = false;
            // 
            // btnKeuze
            // 
            this.btnKeuze.Location = new System.Drawing.Point(12, 88);
            this.btnKeuze.Name = "btnKeuze";
            this.btnKeuze.Size = new System.Drawing.Size(75, 23);
            this.btnKeuze.TabIndex = 4;
            this.btnKeuze.Text = "Keuze";
            this.btnKeuze.UseVisualStyleBackColor = true;
            this.btnKeuze.Click += new System.EventHandler(this.btnKeuze_Click);
            // 
            // tbEen
            // 
            this.tbEen.Location = new System.Drawing.Point(12, 117);
            this.tbEen.Name = "tbEen";
            this.tbEen.Size = new System.Drawing.Size(100, 20);
            this.tbEen.TabIndex = 5;
            this.tbEen.Visible = false;
            // 
            // tbTwee
            // 
            this.tbTwee.Location = new System.Drawing.Point(12, 143);
            this.tbTwee.Name = "tbTwee";
            this.tbTwee.Size = new System.Drawing.Size(100, 20);
            this.tbTwee.TabIndex = 6;
            this.tbTwee.Visible = false;
            // 
            // lblEen
            // 
            this.lblEen.AutoSize = true;
            this.lblEen.Location = new System.Drawing.Point(118, 120);
            this.lblEen.Name = "lblEen";
            this.lblEen.Size = new System.Drawing.Size(35, 13);
            this.lblEen.TabIndex = 7;
            this.lblEen.Text = "label1";
            this.lblEen.Visible = false;
            // 
            // lblTwee
            // 
            this.lblTwee.AutoSize = true;
            this.lblTwee.Location = new System.Drawing.Point(118, 146);
            this.lblTwee.Name = "lblTwee";
            this.lblTwee.Size = new System.Drawing.Size(35, 13);
            this.lblTwee.TabIndex = 8;
            this.lblTwee.Text = "label2";
            this.lblTwee.Visible = false;
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Location = new System.Drawing.Point(12, 169);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(100, 20);
            this.tbAntwoord.TabIndex = 9;
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(118, 172);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 10;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 250);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.tbAntwoord);
            this.Controls.Add(this.lblTwee);
            this.Controls.Add(this.lblEen);
            this.Controls.Add(this.tbTwee);
            this.Controls.Add(this.tbEen);
            this.Controls.Add(this.btnKeuze);
            this.Controls.Add(this.gbEen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbEen.ResumeLayout(false);
            this.gbEen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCirkel;
        private System.Windows.Forms.RadioButton rbRechtHoek;
        private System.Windows.Forms.RadioButton rbDrieHoek;
        private System.Windows.Forms.GroupBox gbEen;
        private System.Windows.Forms.Button btnKeuze;
        private System.Windows.Forms.TextBox tbEen;
        private System.Windows.Forms.TextBox tbTwee;
        private System.Windows.Forms.Label lblEen;
        private System.Windows.Forms.Label lblTwee;
        private System.Windows.Forms.TextBox tbAntwoord;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

