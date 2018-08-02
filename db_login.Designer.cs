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
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbBox
            // 
            this.dbBox.Location = new System.Drawing.Point(15, 245);
            this.dbBox.Name = "dbBox";
            this.dbBox.Size = new System.Drawing.Size(181, 20);
            this.dbBox.TabIndex = 32;
            this.dbBox.Text = "pkl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Database";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(15, 292);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(181, 36);
            this.loginBtn.TabIndex = 30;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(15, 189);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(181, 20);
            this.passBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Password";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(15, 132);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(181, 20);
            this.userBox.TabIndex = 27;
            this.userBox.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Username";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(15, 78);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(181, 20);
            this.portBox.TabIndex = 25;
            this.portBox.Text = "3306";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Port";
            // 
            // srvBox
            // 
            this.srvBox.Location = new System.Drawing.Point(15, 25);
            this.srvBox.Name = "srvBox";
            this.srvBox.Size = new System.Drawing.Size(181, 20);
            this.srvBox.TabIndex = 23;
            this.srvBox.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Server";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(15, 350);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(181, 36);
            this.createBtn.TabIndex = 33;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click_1);
            // 
            // db_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 398);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.dbBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.srvBox);
            this.Controls.Add(this.label1);
            this.Name = "db_login";
            this.Text = "db_login";
            this.Load += new System.EventHandler(this.db_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button createBtn;
    }
}