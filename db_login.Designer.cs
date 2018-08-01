namespace LPSE_UGM_Winner_Parser
{
    partial class db_login
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dbBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srvBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dbCreateBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.passCreateBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userCreateRoot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.portCreateBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.srvCreateBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dbBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.loginBtn);
            this.tabPage1.Controls.Add(this.passBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.userBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.portBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.srvBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login to Existing Database";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dbBox
            // 
            this.dbBox.Location = new System.Drawing.Point(34, 260);
            this.dbBox.Name = "dbBox";
            this.dbBox.Size = new System.Drawing.Size(181, 20);
            this.dbBox.TabIndex = 21;
            this.dbBox.Text = "pkl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Database";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(85, 350);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 19;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click_1);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(34, 204);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(181, 20);
            this.passBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(34, 147);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(181, 20);
            this.userBox.TabIndex = 16;
            this.userBox.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Username";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(34, 93);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(181, 20);
            this.portBox.TabIndex = 14;
            this.portBox.Text = "3306";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port";
            // 
            // srvBox
            // 
            this.srvBox.Location = new System.Drawing.Point(34, 40);
            this.srvBox.Name = "srvBox";
            this.srvBox.Size = new System.Drawing.Size(181, 20);
            this.srvBox.TabIndex = 12;
            this.srvBox.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dbCreateBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.createBtn);
            this.tabPage2.Controls.Add(this.passCreateBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.userCreateRoot);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.portCreateBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.srvCreateBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(246, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dbCreateBox
            // 
            this.dbCreateBox.Location = new System.Drawing.Point(34, 260);
            this.dbCreateBox.Name = "dbCreateBox";
            this.dbCreateBox.Size = new System.Drawing.Size(181, 20);
            this.dbCreateBox.TabIndex = 32;
            this.dbCreateBox.Text = "pkl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Database";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(85, 350);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 30;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // passCreateBox
            // 
            this.passCreateBox.Location = new System.Drawing.Point(34, 204);
            this.passCreateBox.Name = "passCreateBox";
            this.passCreateBox.Size = new System.Drawing.Size(181, 20);
            this.passCreateBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Password";
            // 
            // userCreateRoot
            // 
            this.userCreateRoot.Location = new System.Drawing.Point(34, 147);
            this.userCreateRoot.Name = "userCreateRoot";
            this.userCreateRoot.Size = new System.Drawing.Size(181, 20);
            this.userCreateRoot.TabIndex = 27;
            this.userCreateRoot.Text = "root";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Username";
            // 
            // portCreateBox
            // 
            this.portCreateBox.Location = new System.Drawing.Point(34, 93);
            this.portCreateBox.Name = "portCreateBox";
            this.portCreateBox.Size = new System.Drawing.Size(181, 20);
            this.portCreateBox.TabIndex = 25;
            this.portCreateBox.Text = "3306";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Port";
            // 
            // srvCreateBox
            // 
            this.srvCreateBox.Location = new System.Drawing.Point(34, 40);
            this.srvCreateBox.Name = "srvCreateBox";
            this.srvCreateBox.Size = new System.Drawing.Size(181, 20);
            this.srvCreateBox.TabIndex = 23;
            this.srvCreateBox.Text = "localhost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Server";
            // 
            // db_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "db_login";
            this.Text = "db_login";
            this.Load += new System.EventHandler(this.db_login_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox dbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srvBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox dbCreateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox passCreateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userCreateRoot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox portCreateBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox srvCreateBox;
        private System.Windows.Forms.Label label10;
    }
}