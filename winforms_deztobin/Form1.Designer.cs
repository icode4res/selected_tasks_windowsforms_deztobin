namespace winforms_deztobin
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
            this.CmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDezimal = new System.Windows.Forms.TextBox();
            this.txtBinaerEingabe = new System.Windows.Forms.TextBox();
            this.txtBinAusgabe = new System.Windows.Forms.TextBox();
            this.txtHexAusgabe1 = new System.Windows.Forms.TextBox();
            this.txtDezAusgabe = new System.Windows.Forms.TextBox();
            this.txtHexAusgabe2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmdDezimal = new System.Windows.Forms.Button();
            this.CmdBinaer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.RosyBrown;
            this.CmdClose.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdClose.ForeColor = System.Drawing.Color.Transparent;
            this.CmdClose.Location = new System.Drawing.Point(747, 457);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(71, 45);
            this.CmdClose.TabIndex = 0;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dez";
            // 
            // txtDezimal
            // 
            this.txtDezimal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDezimal.Location = new System.Drawing.Point(160, 52);
            this.txtDezimal.Name = "txtDezimal";
            this.txtDezimal.Size = new System.Drawing.Size(490, 27);
            this.txtDezimal.TabIndex = 2;
            this.txtDezimal.TextChanged += new System.EventHandler(this.txtDezimal_TextChanged);
            // 
            // txtBinaerEingabe
            // 
            this.txtBinaerEingabe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBinaerEingabe.Location = new System.Drawing.Point(160, 256);
            this.txtBinaerEingabe.Name = "txtBinaerEingabe";
            this.txtBinaerEingabe.Size = new System.Drawing.Size(490, 27);
            this.txtBinaerEingabe.TabIndex = 3;
            // 
            // txtBinAusgabe
            // 
            this.txtBinAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBinAusgabe.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBinAusgabe.Location = new System.Drawing.Point(160, 102);
            this.txtBinAusgabe.Name = "txtBinAusgabe";
            this.txtBinAusgabe.Size = new System.Drawing.Size(490, 24);
            this.txtBinAusgabe.TabIndex = 5;
            this.txtBinAusgabe.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtHexAusgabe1
            // 
            this.txtHexAusgabe1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHexAusgabe1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHexAusgabe1.Location = new System.Drawing.Point(160, 151);
            this.txtHexAusgabe1.Name = "txtHexAusgabe1";
            this.txtHexAusgabe1.Size = new System.Drawing.Size(490, 24);
            this.txtHexAusgabe1.TabIndex = 6;
            this.txtHexAusgabe1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDezAusgabe
            // 
            this.txtDezAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDezAusgabe.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDezAusgabe.Location = new System.Drawing.Point(160, 311);
            this.txtDezAusgabe.Name = "txtDezAusgabe";
            this.txtDezAusgabe.Size = new System.Drawing.Size(490, 24);
            this.txtDezAusgabe.TabIndex = 7;
            this.txtDezAusgabe.TextChanged += new System.EventHandler(this.txtDezAusgabe_TextChanged);
            // 
            // txtHexAusgabe2
            // 
            this.txtHexAusgabe2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHexAusgabe2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHexAusgabe2.Location = new System.Drawing.Point(160, 365);
            this.txtHexAusgabe2.Name = "txtHexAusgabe2";
            this.txtHexAusgabe2.Size = new System.Drawing.Size(490, 24);
            this.txtHexAusgabe2.TabIndex = 8;
            this.txtHexAusgabe2.TextChanged += new System.EventHandler(this.txtHexAusgabe2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dez";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hex";
            // 
            // CmdDezimal
            // 
            this.CmdDezimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdDezimal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdDezimal.Location = new System.Drawing.Point(677, 52);
            this.CmdDezimal.Name = "CmdDezimal";
            this.CmdDezimal.Size = new System.Drawing.Size(141, 27);
            this.CmdDezimal.TabIndex = 14;
            this.CmdDezimal.Text = "Dezimal -> Binär";
            this.CmdDezimal.UseVisualStyleBackColor = true;
            this.CmdDezimal.Click += new System.EventHandler(this.CmdDezimal_Click);
            // 
            // CmdBinaer
            // 
            this.CmdBinaer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdBinaer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdBinaer.Location = new System.Drawing.Point(677, 256);
            this.CmdBinaer.Name = "CmdBinaer";
            this.CmdBinaer.Size = new System.Drawing.Size(141, 27);
            this.CmdBinaer.TabIndex = 16;
            this.CmdBinaer.Text = "Binär -> Dezimal";
            this.CmdBinaer.UseVisualStyleBackColor = true;
            this.CmdBinaer.Click += new System.EventHandler(this.CmdBinaer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 526);
            this.Controls.Add(this.CmdBinaer);
            this.Controls.Add(this.CmdDezimal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHexAusgabe2);
            this.Controls.Add(this.txtDezAusgabe);
            this.Controls.Add(this.txtHexAusgabe1);
            this.Controls.Add(this.txtBinAusgabe);
            this.Controls.Add(this.txtBinaerEingabe);
            this.Controls.Add(this.txtDezimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdClose);
            this.Name = "Form1";
            this.Text = "Aufgabe 06: WindowsForms (DezToBin)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdClose;
        private Label label1;
        private TextBox txtDezimal;
        private TextBox txtBinaerEingabe;
        private TextBox txtBinAusgabe;
        private TextBox txtHexAusgabe1;
        private TextBox txtDezAusgabe;
        private TextBox txtHexAusgabe2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button CmdDezimal;
        private Button CmdBinaer;
    }
}