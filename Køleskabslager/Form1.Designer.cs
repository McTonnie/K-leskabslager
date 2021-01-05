namespace Køleskabslager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.liste = new System.Windows.Forms.ListView();
            this.buttonTilføj = new System.Windows.Forms.Button();
            this.buttonFjern = new System.Windows.Forms.Button();
            this.textBoxVare = new System.Windows.Forms.TextBox();
            this.textBoxEfternavn = new System.Windows.Forms.TextBox();
            this.textBoxnavn = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listeold = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.HideSelection = false;
            this.liste.Location = new System.Drawing.Point(59, 57);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(552, 526);
            this.liste.TabIndex = 0;
            this.liste.UseCompatibleStateImageBehavior = false;
            // 
            // buttonTilføj
            // 
            this.buttonTilføj.Location = new System.Drawing.Point(828, 392);
            this.buttonTilføj.Name = "buttonTilføj";
            this.buttonTilføj.Size = new System.Drawing.Size(94, 55);
            this.buttonTilføj.TabIndex = 5;
            this.buttonTilføj.Text = "Tilføj";
            this.buttonTilføj.UseVisualStyleBackColor = true;
            this.buttonTilføj.Click += new System.EventHandler(this.buttonTilføj_Click);
            // 
            // buttonFjern
            // 
            this.buttonFjern.Location = new System.Drawing.Point(985, 392);
            this.buttonFjern.Name = "buttonFjern";
            this.buttonFjern.Size = new System.Drawing.Size(96, 55);
            this.buttonFjern.TabIndex = 6;
            this.buttonFjern.Text = "Fjern";
            this.buttonFjern.UseVisualStyleBackColor = true;
            this.buttonFjern.Click += new System.EventHandler(this.buttonFjern_Click);
            // 
            // textBoxVare
            // 
            this.textBoxVare.Location = new System.Drawing.Point(856, 237);
            this.textBoxVare.Name = "textBoxVare";
            this.textBoxVare.Size = new System.Drawing.Size(200, 22);
            this.textBoxVare.TabIndex = 3;
            this.textBoxVare.TextChanged += new System.EventHandler(this.textBoxVare_TextChanged);
            // 
            // textBoxEfternavn
            // 
            this.textBoxEfternavn.Location = new System.Drawing.Point(856, 188);
            this.textBoxEfternavn.Name = "textBoxEfternavn";
            this.textBoxEfternavn.Size = new System.Drawing.Size(200, 22);
            this.textBoxEfternavn.TabIndex = 2;
            this.textBoxEfternavn.TextChanged += new System.EventHandler(this.textBoxEfternavn_TextChanged);
            // 
            // textBoxnavn
            // 
            this.textBoxnavn.Location = new System.Drawing.Point(856, 138);
            this.textBoxnavn.Name = "textBoxnavn";
            this.textBoxnavn.Size = new System.Drawing.Size(200, 22);
            this.textBoxnavn.TabIndex = 1;
            this.textBoxnavn.TextChanged += new System.EventHandler(this.textBoxnavn_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(856, 305);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(907, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Navn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Efternavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Udløbsdato";
            // 
            // listeold
            // 
            this.listeold.HideSelection = false;
            this.listeold.Location = new System.Drawing.Point(1157, 57);
            this.listeold.Name = "listeold";
            this.listeold.Size = new System.Drawing.Size(228, 264);
            this.listeold.TabIndex = 13;
            this.listeold.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vare i køleskabet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1291, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vare i køleskabet for gammelt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1063, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1062, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1062, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(59, 533);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(333, 533);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 681);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listeold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxnavn);
            this.Controls.Add(this.textBoxEfternavn);
            this.Controls.Add(this.textBoxVare);
            this.Controls.Add(this.buttonFjern);
            this.Controls.Add(this.buttonTilføj);
            this.Controls.Add(this.liste);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView liste;
        private System.Windows.Forms.Button buttonTilføj;
        private System.Windows.Forms.Button buttonFjern;
        private System.Windows.Forms.TextBox textBoxVare;
        private System.Windows.Forms.TextBox textBoxEfternavn;
        private System.Windows.Forms.TextBox textBoxnavn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listeold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

