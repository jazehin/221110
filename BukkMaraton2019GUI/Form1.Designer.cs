namespace BukkMaraton2019GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbTav = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdo = new System.Windows.Forms.TextBox();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKmh = new System.Windows.Forms.Label();
            this.lblMs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Táv:";
            // 
            // cbTav
            // 
            this.cbTav.FormattingEnabled = true;
            this.cbTav.Items.AddRange(new object[] {
            "Mini - 16km",
            "Rövid - 38km",
            "Pedelec - 54km",
            "Közép - 57km",
            "Hosszú - 94km"});
            this.cbTav.Location = new System.Drawing.Point(81, 31);
            this.cbTav.Name = "cbTav";
            this.cbTav.Size = new System.Drawing.Size(157, 23);
            this.cbTav.TabIndex = 1;
            this.cbTav.Text = "Közép - 57km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idő [óra:perc:mp]:";
            // 
            // tbIdo
            // 
            this.tbIdo.Location = new System.Drawing.Point(143, 66);
            this.tbIdo.Name = "tbIdo";
            this.tbIdo.Size = new System.Drawing.Size(95, 23);
            this.tbIdo.TabIndex = 3;
            this.tbIdo.Text = "1:00:00";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(267, 30);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(81, 59);
            this.btnSzamol.TabIndex = 4;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Átlagsebesség [km/h]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Átlagsebesség [m/s]:";
            // 
            // lblKmh
            // 
            this.lblKmh.AutoSize = true;
            this.lblKmh.Location = new System.Drawing.Point(160, 120);
            this.lblKmh.Name = "lblKmh";
            this.lblKmh.Size = new System.Drawing.Size(0, 15);
            this.lblKmh.TabIndex = 7;
            // 
            // lblMs
            // 
            this.lblMs.AutoSize = true;
            this.lblMs.Location = new System.Drawing.Point(152, 148);
            this.lblMs.Name = "lblMs";
            this.lblMs.Size = new System.Drawing.Size(0, 15);
            this.lblMs.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 252);
            this.Controls.Add(this.lblMs);
            this.Controls.Add(this.lblKmh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.tbIdo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTav);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bükk Maraton 2019";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbTav;
        private Label label2;
        private TextBox tbIdo;
        private Button btnSzamol;
        private Label label3;
        private Label label4;
        private Label lblKmh;
        private Label lblMs;
    }
}