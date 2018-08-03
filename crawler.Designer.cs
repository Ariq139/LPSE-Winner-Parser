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
            this.startBox = new System.Windows.Forms.TextBox();
            this.endBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startScript = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retryBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeoutBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Point";
            // 
            // startBox
            // 
            this.startBox.Location = new System.Drawing.Point(12, 81);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(82, 20);
            this.startBox.TabIndex = 1;
            this.startBox.Text = "1";
            // 
            // endBox
            // 
            this.endBox.Location = new System.Drawing.Point(109, 81);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(91, 20);
            this.endBox.TabIndex = 3;
            this.endBox.Text = "8000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 64);
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
            "LPSE Kabupaten Bantul",
            "LPSE Kabupaten Kulon Progo",
            "LPSE Kabupaten Sleman",
            "LPSE Kabupaten Gunung Kidul",
            "LPSE Kota Yogyakarta",
            "LPSE Provinsi Daerah Istimewa Yogyakarta",
            "LPSE Universitas Gadjah Mada"});
            this.locCombo.Location = new System.Drawing.Point(12, 28);
            this.locCombo.Name = "locCombo";
            this.locCombo.Size = new System.Drawing.Size(188, 21);
            this.locCombo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wilayah";
            // 
            // startScript
            // 
            this.startScript.Location = new System.Drawing.Point(102, 244);
            this.startScript.Name = "startScript";
            this.startScript.Size = new System.Drawing.Size(98, 37);
            this.startScript.TabIndex = 16;
            this.startScript.Text = "Start";
            this.startScript.UseVisualStyleBackColor = true;
            this.startScript.Click += new System.EventHandler(this.startScript_Click);
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
            // retryBox
            // 
            this.retryBox.Location = new System.Drawing.Point(109, 136);
            this.retryBox.Name = "retryBox";
            this.retryBox.Size = new System.Drawing.Size(91, 20);
            this.retryBox.TabIndex = 21;
            this.retryBox.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Max. Retry";
            // 
            // timeoutBox
            // 
            this.timeoutBox.Location = new System.Drawing.Point(12, 136);
            this.timeoutBox.Name = "timeoutBox";
            this.timeoutBox.Size = new System.Drawing.Size(82, 20);
            this.timeoutBox.TabIndex = 19;
            this.timeoutBox.Text = "60";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Timeout (sec)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Reset to default";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.retryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeoutBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startScript);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locCombo);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.label1);
            this.Name = "crawler";
            this.Text = "crawler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.TextBox endBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox locCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startScript;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox retryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeoutBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}