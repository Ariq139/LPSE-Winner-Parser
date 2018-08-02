namespace LPSE_UGM_Winner_Parser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataLeaderboard = new System.Windows.Forms.DataGridView();
            this.topGraph = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.detailSearchGet = new System.Windows.Forms.Button();
            this.idGet = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.winnerSearch = new System.Windows.Forms.Label();
            this.typeSearch = new System.Windows.Forms.Label();
            this.instanceSearch = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.Label();
            this.idSearch = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchLocTab = new System.Windows.Forms.TabPage();
            this.exportBtn = new System.Windows.Forms.Button();
            this.locGraph = new System.Windows.Forms.Button();
            this.dataLelang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.locCombo = new System.Windows.Forms.ComboBox();
            this.locGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIDTab = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLeaderboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.searchLocTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLelang)).BeginInit();
            this.searchIDTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataLeaderboard);
            this.groupBox1.Controls.Add(this.topGraph);
            this.groupBox1.Location = new System.Drawing.Point(537, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leaderboard";
            // 
            // dataLeaderboard
            // 
            this.dataLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLeaderboard.Location = new System.Drawing.Point(7, 20);
            this.dataLeaderboard.Name = "dataLeaderboard";
            this.dataLeaderboard.Size = new System.Drawing.Size(223, 233);
            this.dataLeaderboard.TabIndex = 23;
            // 
            // topGraph
            // 
            this.topGraph.Location = new System.Drawing.Point(40, 259);
            this.topGraph.Name = "topGraph";
            this.topGraph.Size = new System.Drawing.Size(157, 23);
            this.topGraph.TabIndex = 22;
            this.topGraph.Text = "Open detail";
            this.topGraph.UseVisualStyleBackColor = true;
            this.topGraph.Click += new System.EventHandler(this.topGraph_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.detailSearchGet);
            this.tabPage3.Controls.Add(this.idGet);
            this.tabPage3.Controls.Add(this.searchBox);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.winnerSearch);
            this.tabPage3.Controls.Add(this.typeSearch);
            this.tabPage3.Controls.Add(this.instanceSearch);
            this.tabPage3.Controls.Add(this.nameSearch);
            this.tabPage3.Controls.Add(this.idSearch);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(510, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search by ID";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // detailSearchGet
            // 
            this.detailSearchGet.Location = new System.Drawing.Point(203, 26);
            this.detailSearchGet.Name = "detailSearchGet";
            this.detailSearchGet.Size = new System.Drawing.Size(114, 23);
            this.detailSearchGet.TabIndex = 13;
            this.detailSearchGet.Text = "Get more detail";
            this.detailSearchGet.UseVisualStyleBackColor = true;
            this.detailSearchGet.Click += new System.EventHandler(this.detailSearchGet_Click);
            // 
            // idGet
            // 
            this.idGet.Location = new System.Drawing.Point(122, 26);
            this.idGet.Name = "idGet";
            this.idGet.Size = new System.Drawing.Size(75, 23);
            this.idGet.TabIndex = 12;
            this.idGet.Text = "Get";
            this.idGet.UseVisualStyleBackColor = true;
            this.idGet.Click += new System.EventHandler(this.idGet_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(6, 28);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "ID";
            // 
            // winnerSearch
            // 
            this.winnerSearch.AutoSize = true;
            this.winnerSearch.Location = new System.Drawing.Point(156, 234);
            this.winnerSearch.Name = "winnerSearch";
            this.winnerSearch.Size = new System.Drawing.Size(24, 13);
            this.winnerSearch.TabIndex = 9;
            this.winnerSearch.Text = "n/a";
            // 
            // typeSearch
            // 
            this.typeSearch.AutoSize = true;
            this.typeSearch.Location = new System.Drawing.Point(156, 194);
            this.typeSearch.Name = "typeSearch";
            this.typeSearch.Size = new System.Drawing.Size(24, 13);
            this.typeSearch.TabIndex = 8;
            this.typeSearch.Text = "n/a";
            // 
            // instanceSearch
            // 
            this.instanceSearch.AutoSize = true;
            this.instanceSearch.Location = new System.Drawing.Point(156, 154);
            this.instanceSearch.Name = "instanceSearch";
            this.instanceSearch.Size = new System.Drawing.Size(24, 13);
            this.instanceSearch.TabIndex = 7;
            this.instanceSearch.Text = "n/a";
            // 
            // nameSearch
            // 
            this.nameSearch.AutoSize = true;
            this.nameSearch.Location = new System.Drawing.Point(156, 114);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(24, 13);
            this.nameSearch.TabIndex = 6;
            this.nameSearch.Text = "n/a";
            // 
            // idSearch
            // 
            this.idSearch.AutoSize = true;
            this.idSearch.Location = new System.Drawing.Point(156, 74);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(24, 13);
            this.idSearch.TabIndex = 5;
            this.idSearch.Text = "n/a";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Pemenang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tipe Lelang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Instansi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nama Lelang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // searchLocTab
            // 
            this.searchLocTab.Controls.Add(this.exportBtn);
            this.searchLocTab.Controls.Add(this.locGraph);
            this.searchLocTab.Controls.Add(this.dataLelang);
            this.searchLocTab.Controls.Add(this.label3);
            this.searchLocTab.Controls.Add(this.locCombo);
            this.searchLocTab.Controls.Add(this.locGet);
            this.searchLocTab.Controls.Add(this.label1);
            this.searchLocTab.Location = new System.Drawing.Point(4, 22);
            this.searchLocTab.Name = "searchLocTab";
            this.searchLocTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchLocTab.Size = new System.Drawing.Size(510, 276);
            this.searchLocTab.TabIndex = 0;
            this.searchLocTab.Text = "Search by Location";
            this.searchLocTab.UseVisualStyleBackColor = true;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(339, 26);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 17;
            this.exportBtn.Text = "Export...";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // locGraph
            // 
            this.locGraph.Location = new System.Drawing.Point(258, 26);
            this.locGraph.Name = "locGraph";
            this.locGraph.Size = new System.Drawing.Size(75, 23);
            this.locGraph.TabIndex = 16;
            this.locGraph.Text = "Open graph";
            this.locGraph.UseVisualStyleBackColor = true;
            this.locGraph.Click += new System.EventHandler(this.locGraph_Click);
            // 
            // dataLelang
            // 
            this.dataLelang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLelang.Location = new System.Drawing.Point(6, 77);
            this.dataLelang.Name = "dataLelang";
            this.dataLelang.Size = new System.Drawing.Size(498, 193);
            this.dataLelang.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data Lelang";
            // 
            // locCombo
            // 
            this.locCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locCombo.FormattingEnabled = true;
            this.locCombo.Items.AddRange(new object[] {
            "Semua",
            "Bantul",
            "Kulonprogo",
            "Sleman",
            "Gunungkidul",
            "Kota Yogyakarta",
            "D.I.Yogyakarta",
            "Universitas Gadjah Mada"});
            this.locCombo.Location = new System.Drawing.Point(6, 27);
            this.locCombo.Name = "locCombo";
            this.locCombo.Size = new System.Drawing.Size(165, 21);
            this.locCombo.TabIndex = 13;
            this.locCombo.SelectedIndexChanged += new System.EventHandler(this.locCombo_SelectedIndexChanged);
            // 
            // locGet
            // 
            this.locGet.Location = new System.Drawing.Point(177, 26);
            this.locGet.Name = "locGet";
            this.locGet.Size = new System.Drawing.Size(75, 23);
            this.locGet.TabIndex = 2;
            this.locGet.Text = "Get Data";
            this.locGet.UseVisualStyleBackColor = true;
            this.locGet.Click += new System.EventHandler(this.locGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wilayah";
            // 
            // searchIDTab
            // 
            this.searchIDTab.Controls.Add(this.searchLocTab);
            this.searchIDTab.Controls.Add(this.tabPage3);
            this.searchIDTab.Location = new System.Drawing.Point(13, 34);
            this.searchIDTab.Name = "searchIDTab";
            this.searchIDTab.SelectedIndex = 0;
            this.searchIDTab.Size = new System.Drawing.Size(518, 302);
            this.searchIDTab.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchIDTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLeaderboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.searchLocTab.ResumeLayout(false);
            this.searchLocTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLelang)).EndInit();
            this.searchIDTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage searchLocTab;
        private System.Windows.Forms.DataGridView dataLelang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button locGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl searchIDTab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idSearch;
        private System.Windows.Forms.Button idGet;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label winnerSearch;
        private System.Windows.Forms.Label typeSearch;
        private System.Windows.Forms.Label instanceSearch;
        private System.Windows.Forms.Label nameSearch;
        private System.Windows.Forms.Button detailSearchGet;
        private System.Windows.Forms.Button topGraph;
        private System.Windows.Forms.ComboBox locCombo;
        private System.Windows.Forms.Button locGraph;
        private System.Windows.Forms.DataGridView dataLeaderboard;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Button exportBtn;
    }
}

