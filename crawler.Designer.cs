namespace LPSE_UGM_Winner_Parser
{
    partial class crawler
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Point";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "8000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Point";
            // 
            // locCombo
            // 
            this.locCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locCombo.FormattingEnabled = true;
            this.locCombo.Items.AddRange(new object[] {
            "Bantul",
            "Kulonprogo",
            "Sleman",
            "Gunungkidul",
            "Kota Yogyakarta",
            "D.I.Yogyakarta",
            "Universitas Gadjah Mada"});
            this.locCombo.Location = new System.Drawing.Point(12, 25);
            this.locCombo.Name = "locCombo";
            this.locCombo.Size = new System.Drawing.Size(184, 21);
            this.locCombo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wilayah";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(206, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 268);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contoh";
            // 
            // crawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locCombo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "crawler";
            this.Text = "crawler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox locCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}