namespace HP_calculator
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
            this.knop7 = new System.Windows.Forms.Button();
            this.knop8 = new System.Windows.Forms.Button();
            this.knop9 = new System.Windows.Forms.Button();
            this.knopdelen = new System.Windows.Forms.Button();
            this.knop6 = new System.Windows.Forms.Button();
            this.knop5 = new System.Windows.Forms.Button();
            this.knop4 = new System.Windows.Forms.Button();
            this.knoppunt = new System.Windows.Forms.Button();
            this.knop0 = new System.Windows.Forms.Button();
            this.knopnegatief = new System.Windows.Forms.Button();
            this.knop3 = new System.Windows.Forms.Button();
            this.knop2 = new System.Windows.Forms.Button();
            this.knop1 = new System.Windows.Forms.Button();
            this.knopplus = new System.Windows.Forms.Button();
            this.knopmin = new System.Windows.Forms.Button();
            this.knopkeer = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.NaarRechts = new System.Windows.Forms.Button();
            this.NaarLinks = new System.Windows.Forms.Button();
            this.MyListStackRadio = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // knop7
            // 
            this.knop7.Location = new System.Drawing.Point(12, 77);
            this.knop7.Name = "knop7";
            this.knop7.Size = new System.Drawing.Size(44, 41);
            this.knop7.TabIndex = 0;
            this.knop7.Text = "7";
            this.knop7.UseVisualStyleBackColor = true;
            this.knop7.Click += new System.EventHandler(this.InputFilter);
            // 
            // knop8
            // 
            this.knop8.Location = new System.Drawing.Point(62, 77);
            this.knop8.Name = "knop8";
            this.knop8.Size = new System.Drawing.Size(44, 41);
            this.knop8.TabIndex = 4;
            this.knop8.Text = "8";
            this.knop8.UseVisualStyleBackColor = true;
            this.knop8.Click += new System.EventHandler(this.InputFilter);
            // 
            // knop9
            // 
            this.knop9.Location = new System.Drawing.Point(112, 77);
            this.knop9.Name = "knop9";
            this.knop9.Size = new System.Drawing.Size(44, 41);
            this.knop9.TabIndex = 5;
            this.knop9.Text = "9";
            this.knop9.UseVisualStyleBackColor = true;
            this.knop9.Click += new System.EventHandler(this.InputFilter);
            // 
            // knopdelen
            // 
            this.knopdelen.Location = new System.Drawing.Point(162, 77);
            this.knopdelen.Name = "knopdelen";
            this.knopdelen.Size = new System.Drawing.Size(44, 41);
            this.knopdelen.TabIndex = 6;
            this.knopdelen.Text = "/";
            this.knopdelen.UseVisualStyleBackColor = true;
            this.knopdelen.Click += new System.EventHandler(this.Calculate);
            // 
            // knop6
            // 
            this.knop6.Location = new System.Drawing.Point(112, 124);
            this.knop6.Name = "knop6";
            this.knop6.Size = new System.Drawing.Size(44, 41);
            this.knop6.TabIndex = 9;
            this.knop6.Text = "6";
            this.knop6.UseVisualStyleBackColor = true;
            this.knop6.Click += new System.EventHandler(this.InputFilter);
            // 
            // knop5
            // 
            this.knop5.Location = new System.Drawing.Point(62, 124);
            this.knop5.Name = "knop5";
            this.knop5.Size = new System.Drawing.Size(44, 41);
            this.knop5.TabIndex = 8;
            this.knop5.Text = "5";
            this.knop5.UseVisualStyleBackColor = true;
            this.knop5.Click += new System.EventHandler(this.InputFilter);
            // 
            // knop4
            // 
            this.knop4.Location = new System.Drawing.Point(12, 124);
            this.knop4.Name = "knop4";
            this.knop4.Size = new System.Drawing.Size(44, 41);
            this.knop4.TabIndex = 7;
            this.knop4.Text = "4";
            this.knop4.UseVisualStyleBackColor = true;
            this.knop4.Click += new System.EventHandler(this.InputFilter);
            // 
            // knoppunt
            // 
            this.knoppunt.Location = new System.Drawing.Point(112, 217);
            this.knoppunt.Name = "knoppunt";
            this.knoppunt.Size = new System.Drawing.Size(44, 41);
            this.knoppunt.TabIndex = 15;
            this.knoppunt.Text = ".";
            this.knoppunt.UseVisualStyleBackColor = true;
            this.knoppunt.Click += new System.EventHandler(this.InputFilter);
            // 
            // knop0
            // 
            this.knop0.Location = new System.Drawing.Point(62, 217);
            this.knop0.Name = "knop0";
            this.knop0.Size = new System.Drawing.Size(44, 41);
            this.knop0.TabIndex = 14;
            this.knop0.Text = "0";
            this.knop0.UseVisualStyleBackColor = true;
            this.knop0.Click += new System.EventHandler(this.InputFilter);
            // 
            // knopnegatief
            // 
            this.knopnegatief.Location = new System.Drawing.Point(12, 217);
            this.knopnegatief.Name = "knopnegatief";
            this.knopnegatief.Size = new System.Drawing.Size(44, 41);
            this.knopnegatief.TabIndex = 13;
            this.knopnegatief.Text = "(-)";
            this.knopnegatief.UseVisualStyleBackColor = true;
            this.knopnegatief.Click += new System.EventHandler(this.InputFilter);
            // 
            // knop3
            // 
            this.knop3.Location = new System.Drawing.Point(112, 170);
            this.knop3.Name = "knop3";
            this.knop3.Size = new System.Drawing.Size(44, 41);
            this.knop3.TabIndex = 12;
            this.knop3.Text = "3";
            this.knop3.UseVisualStyleBackColor = true;
            this.knop3.Click += new System.EventHandler(this.InputFilter);
            // 
            // knop2
            // 
            this.knop2.Location = new System.Drawing.Point(62, 170);
            this.knop2.Name = "knop2";
            this.knop2.Size = new System.Drawing.Size(44, 41);
            this.knop2.TabIndex = 11;
            this.knop2.Text = "2";
            this.knop2.UseVisualStyleBackColor = true;
            this.knop2.Click += new System.EventHandler(this.InputFilter);
            // 
            // knop1
            // 
            this.knop1.Location = new System.Drawing.Point(12, 170);
            this.knop1.Name = "knop1";
            this.knop1.Size = new System.Drawing.Size(44, 41);
            this.knop1.TabIndex = 10;
            this.knop1.Text = "1";
            this.knop1.UseVisualStyleBackColor = true;
            this.knop1.Click += new System.EventHandler(this.InputFilter);
            // 
            // knopplus
            // 
            this.knopplus.Location = new System.Drawing.Point(162, 217);
            this.knopplus.Name = "knopplus";
            this.knopplus.Size = new System.Drawing.Size(44, 41);
            this.knopplus.TabIndex = 16;
            this.knopplus.Text = "+";
            this.knopplus.UseVisualStyleBackColor = true;
            this.knopplus.Click += new System.EventHandler(this.Calculate);
            // 
            // knopmin
            // 
            this.knopmin.Location = new System.Drawing.Point(162, 170);
            this.knopmin.Name = "knopmin";
            this.knopmin.Size = new System.Drawing.Size(44, 41);
            this.knopmin.TabIndex = 17;
            this.knopmin.Text = "-";
            this.knopmin.UseVisualStyleBackColor = true;
            this.knopmin.Click += new System.EventHandler(this.Calculate);
            // 
            // knopkeer
            // 
            this.knopkeer.Location = new System.Drawing.Point(162, 124);
            this.knopkeer.Name = "knopkeer";
            this.knopkeer.Size = new System.Drawing.Size(44, 41);
            this.knopkeer.TabIndex = 18;
            this.knopkeer.Text = "*";
            this.knopkeer.UseVisualStyleBackColor = true;
            this.knopkeer.Click += new System.EventHandler(this.Calculate);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Black;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(194, 59);
            this.Display.TabIndex = 20;
            // 
            // NaarRechts
            // 
            this.NaarRechts.Location = new System.Drawing.Point(213, 12);
            this.NaarRechts.Name = "NaarRechts";
            this.NaarRechts.Size = new System.Drawing.Size(27, 27);
            this.NaarRechts.TabIndex = 21;
            this.NaarRechts.Text = ">";
            this.NaarRechts.UseVisualStyleBackColor = true;
            this.NaarRechts.Click += new System.EventHandler(this.NaarStack);
            // 
            // NaarLinks
            // 
            this.NaarLinks.Location = new System.Drawing.Point(213, 45);
            this.NaarLinks.Name = "NaarLinks";
            this.NaarLinks.Size = new System.Drawing.Size(27, 27);
            this.NaarLinks.TabIndex = 22;
            this.NaarLinks.Text = "<";
            this.NaarLinks.UseVisualStyleBackColor = true;
            this.NaarLinks.Click += new System.EventHandler(this.Backspace);
            // 
            // MyListStackRadio
            // 
            this.MyListStackRadio.AutoSize = true;
            this.MyListStackRadio.Location = new System.Drawing.Point(283, 279);
            this.MyListStackRadio.Name = "MyListStackRadio";
            this.MyListStackRadio.Size = new System.Drawing.Size(93, 19);
            this.MyListStackRadio.TabIndex = 25;
            this.MyListStackRadio.TabStop = true;
            this.MyListStackRadio.Text = "MyListStack";
            this.MyListStackRadio.UseVisualStyleBackColor = true;
            this.MyListStackRadio.CheckedChanged += new System.EventHandler(this.RadioClicked);
            this.MyListStackRadio.Click += new System.EventHandler(this.TheVoid);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(283, 304);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 19);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ListStack";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioClicked);
            this.radioButton3.Click += new System.EventHandler(this.TheVoid);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(283, 331);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 19);
            this.radioButton4.TabIndex = 27;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ArrayStack";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioClicked);
            this.radioButton4.Click += new System.EventHandler(this.TheVoid);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(283, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 251);
            this.listBox1.TabIndex = 28;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.TheVoid);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 378);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.MyListStackRadio);
            this.Controls.Add(this.NaarLinks);
            this.Controls.Add(this.NaarRechts);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.knopkeer);
            this.Controls.Add(this.knopmin);
            this.Controls.Add(this.knopplus);
            this.Controls.Add(this.knoppunt);
            this.Controls.Add(this.knop0);
            this.Controls.Add(this.knopnegatief);
            this.Controls.Add(this.knop3);
            this.Controls.Add(this.knop2);
            this.Controls.Add(this.knop1);
            this.Controls.Add(this.knop6);
            this.Controls.Add(this.knop5);
            this.Controls.Add(this.knop4);
            this.Controls.Add(this.knopdelen);
            this.Controls.Add(this.knop9);
            this.Controls.Add(this.knop8);
            this.Controls.Add(this.knop7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button knop7;
        private System.Windows.Forms.Button knop8;
        private System.Windows.Forms.Button knop9;
        private System.Windows.Forms.Button knopdelen;
        private System.Windows.Forms.Button knop6;
        private System.Windows.Forms.Button knop5;
        private System.Windows.Forms.Button knop4;
        private System.Windows.Forms.Button knoppunt;
        private System.Windows.Forms.Button knop0;
        private System.Windows.Forms.Button knopnegatief;
        private System.Windows.Forms.Button knop3;
        private System.Windows.Forms.Button knop2;
        private System.Windows.Forms.Button knop1;
        private System.Windows.Forms.Button knopplus;
        private System.Windows.Forms.Button knopmin;
        private System.Windows.Forms.Button knopkeer;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button NaarRechts;
        private System.Windows.Forms.Button NaarLinks;
        private System.Windows.Forms.RadioButton MyListStackRadio;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

