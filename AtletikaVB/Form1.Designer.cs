namespace AtletikaVB
{
    partial class AtletikaVB
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
            this.nemzetek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ermenum = new System.Windows.Forms.NumericUpDown();
            this.kereses = new System.Windows.Forms.Button();
            this.érme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.versenyszam = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.Label();
            this.eredmeny = new System.Windows.Forms.Label();
            this.nemzete = new System.Windows.Forms.Label();
            this.nevt = new System.Windows.Forms.TextBox();
            this.eredmenyt = new System.Windows.Forms.TextBox();
            this.nemzett = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ermenum)).BeginInit();
            this.SuspendLayout();
            // 
            // nemzetek
            // 
            this.nemzetek.FormattingEnabled = true;
            this.nemzetek.ItemHeight = 18;
            this.nemzetek.Location = new System.Drawing.Point(21, 55);
            this.nemzetek.Name = "nemzetek";
            this.nemzetek.Size = new System.Drawing.Size(253, 400);
            this.nemzetek.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // ermenum
            // 
            this.ermenum.Location = new System.Drawing.Point(329, 214);
            this.ermenum.Name = "ermenum";
            this.ermenum.Size = new System.Drawing.Size(64, 27);
            this.ermenum.TabIndex = 2;
            // 
            // kereses
            // 
            this.kereses.Location = new System.Drawing.Point(387, 285);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(109, 42);
            this.kereses.TabIndex = 3;
            this.kereses.Text = "keresés";
            this.kereses.UseVisualStyleBackColor = false;
            // 
            // érme
            // 
            this.érme.AutoSize = true;
            this.érme.Location = new System.Drawing.Point(326, 168);
            this.érme.Name = "érme";
            this.érme.Size = new System.Drawing.Size(274, 18);
            this.érme.TabIndex = 4;
            this.érme.Text = "Válassza ki az érmes helyezést:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Válassza ki a versenyszámot:";
            // 
            // versenyszam
            // 
            this.versenyszam.FormattingEnabled = true;
            this.versenyszam.ItemHeight = 18;
            this.versenyszam.Location = new System.Drawing.Point(329, 55);
            this.versenyszam.Name = "versenyszam";
            this.versenyszam.Size = new System.Drawing.Size(196, 76);
            this.versenyszam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Versenyző adatai:";
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(321, 423);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(56, 18);
            this.nev.TabIndex = 8;
            this.nev.Text = "Neve:";
            this.nev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // eredmeny
            // 
            this.eredmeny.AutoSize = true;
            this.eredmeny.Location = new System.Drawing.Point(321, 454);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(105, 18);
            this.eredmeny.TabIndex = 9;
            this.eredmeny.Text = "eredmenye:";
            this.eredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nemzete
            // 
            this.nemzete.AutoSize = true;
            this.nemzete.Location = new System.Drawing.Point(321, 484);
            this.nemzete.Name = "nemzete";
            this.nemzete.Size = new System.Drawing.Size(86, 18);
            this.nemzete.TabIndex = 10;
            this.nemzete.Text = "nemzete:";
            this.nemzete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nevt
            // 
            this.nevt.Location = new System.Drawing.Point(432, 414);
            this.nevt.Name = "nevt";
            this.nevt.Size = new System.Drawing.Size(228, 27);
            this.nevt.TabIndex = 11;
            this.nevt.Visible = false;
            // 
            // eredmenyt
            // 
            this.eredmenyt.Location = new System.Drawing.Point(432, 445);
            this.eredmenyt.Name = "eredmenyt";
            this.eredmenyt.Size = new System.Drawing.Size(307, 27);
            this.eredmenyt.TabIndex = 12;
            this.eredmenyt.Visible = false;
            // 
            // nemzett
            // 
            this.nemzett.Location = new System.Drawing.Point(432, 475);
            this.nemzett.Name = "nemzett";
            this.nemzett.Size = new System.Drawing.Size(282, 27);
            this.nemzett.TabIndex = 13;
            this.nemzett.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "aranyos - nemzetek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AtletikaVB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1640, 915);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nemzett);
            this.Controls.Add(this.eredmenyt);
            this.Controls.Add(this.nevt);
            this.Controls.Add(this.nemzete);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versenyszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.érme);
            this.Controls.Add(this.kereses);
            this.Controls.Add(this.ermenum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nemzetek);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AtletikaVB";
            this.Text = "Atletika";
            ((System.ComponentModel.ISupportInitialize)(this.ermenum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nemzetek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ermenum;
        private System.Windows.Forms.Button kereses;
        private System.Windows.Forms.Label érme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox versenyszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label eredmeny;
        private System.Windows.Forms.Label nemzete;
        private System.Windows.Forms.TextBox nevt;
        private System.Windows.Forms.TextBox eredmenyt;
        private System.Windows.Forms.TextBox nemzett;
        private System.Windows.Forms.Button button1;
    }
}

