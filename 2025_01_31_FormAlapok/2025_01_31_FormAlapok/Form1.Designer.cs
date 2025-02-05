namespace _2025_01_31_FormAlapok
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
            this.szinezesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MuveletCombo = new System.Windows.Forms.ComboBox();
            this.szam1NUD = new System.Windows.Forms.NumericUpDown();
            this.szam2NUD = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.EredmenyLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.szam1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szam2NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // szinezesBtn
            // 
            this.szinezesBtn.Location = new System.Drawing.Point(24, 24);
            this.szinezesBtn.Margin = new System.Windows.Forms.Padding(6);
            this.szinezesBtn.Name = "szinezesBtn";
            this.szinezesBtn.Size = new System.Drawing.Size(150, 44);
            this.szinezesBtn.TabIndex = 0;
            this.szinezesBtn.Text = "Szinezés";
            this.szinezesBtn.UseVisualStyleBackColor = true;
            this.szinezesBtn.Click += new System.EventHandler(this.szinezesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Művelet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 32);
            this.textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 163);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 30);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 208);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(153, 30);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(372, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 354);
            this.listBox1.TabIndex = 5;
            // 
            // MuveletCombo
            // 
            this.MuveletCombo.FormattingEnabled = true;
            this.MuveletCombo.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "maradék",
            "hatvány"});
            this.MuveletCombo.Location = new System.Drawing.Point(131, 362);
            this.MuveletCombo.Margin = new System.Windows.Forms.Padding(6);
            this.MuveletCombo.Name = "MuveletCombo";
            this.MuveletCombo.Size = new System.Drawing.Size(76, 33);
            this.MuveletCombo.TabIndex = 6;
            this.MuveletCombo.SelectedIndexChanged += new System.EventHandler(this.MuveletCombo_SelectedIndexChanged);
            // 
            // szam1NUD
            // 
            this.szam1NUD.Location = new System.Drawing.Point(24, 317);
            this.szam1NUD.Name = "szam1NUD";
            this.szam1NUD.Size = new System.Drawing.Size(120, 32);
            this.szam1NUD.TabIndex = 7;
            this.szam1NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.szam1NUD.ValueChanged += new System.EventHandler(this.szam1NUD_ValueChanged);
            // 
            // szam2NUD
            // 
            this.szam2NUD.Location = new System.Drawing.Point(150, 317);
            this.szam2NUD.Name = "szam2NUD";
            this.szam2NUD.Size = new System.Drawing.Size(120, 32);
            this.szam2NUD.TabIndex = 8;
            this.szam2NUD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.szam2NUD.ValueChanged += new System.EventHandler(this.szam2NUD_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Szamol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EredmenyLabel
            // 
            this.EredmenyLabel.AutoSize = true;
            this.EredmenyLabel.Location = new System.Drawing.Point(150, 417);
            this.EredmenyLabel.Name = "EredmenyLabel";
            this.EredmenyLabel.Size = new System.Drawing.Size(70, 26);
            this.EredmenyLabel.TabIndex = 10;
            this.EredmenyLabel.Text = "label2";
            this.EredmenyLabel.Click += new System.EventHandler(this.EredmenyLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 599);
            this.Controls.Add(this.EredmenyLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szam2NUD);
            this.Controls.Add(this.szam1NUD);
            this.Controls.Add(this.MuveletCombo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szinezesBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form alapok";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szam1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szam2NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szinezesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox MuveletCombo;
        private System.Windows.Forms.NumericUpDown szam1NUD;
        private System.Windows.Forms.NumericUpDown szam2NUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EredmenyLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

