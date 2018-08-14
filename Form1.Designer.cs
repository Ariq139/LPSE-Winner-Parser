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
            this.rldBtn = new System.Windows.Forms.Button();
            this.dataLeaderboard = new System.Windows.Forms.DataGridView();
            this.topGraph = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSampleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewTab = new System.Windows.Forms.TabPage();
            this.idGet = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataLelang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.searchIDTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.graphLocBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.repulsionBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelMaxBox = new System.Windows.Forms.TextBox();
            this.labelMinBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nodeMaxBox = new System.Windows.Forms.TextBox();
            this.nodeMinBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorMaxBox = new System.Windows.Forms.TextBox();
            this.colorMinBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.graphOpt = new System.Windows.Forms.Button();
            this.createGraphBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLeaderboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.overviewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLelang)).BeginInit();
            this.searchIDTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rldBtn);
            this.groupBox1.Controls.Add(this.dataLeaderboard);
            this.groupBox1.Controls.Add(this.topGraph);
            this.groupBox1.Location = new System.Drawing.Point(567, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leaderboard";
            // 
            // rldBtn
            // 
            this.rldBtn.Location = new System.Drawing.Point(7, 303);
            this.rldBtn.Name = "rldBtn";
            this.rldBtn.Size = new System.Drawing.Size(108, 23);
            this.rldBtn.TabIndex = 24;
            this.rldBtn.Text = "Reload";
            this.rldBtn.UseVisualStyleBackColor = true;
            this.rldBtn.Click += new System.EventHandler(this.rldBtn_Click);
            // 
            // dataLeaderboard
            // 
            this.dataLeaderboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLeaderboard.Location = new System.Drawing.Point(7, 20);
            this.dataLeaderboard.Name = "dataLeaderboard";
            this.dataLeaderboard.Size = new System.Drawing.Size(223, 277);
            this.dataLeaderboard.TabIndex = 23;
            // 
            // topGraph
            // 
            this.topGraph.Location = new System.Drawing.Point(122, 303);
            this.topGraph.Name = "topGraph";
            this.topGraph.Size = new System.Drawing.Size(108, 23);
            this.topGraph.TabIndex = 22;
            this.topGraph.Text = "Open detail";
            this.topGraph.UseVisualStyleBackColor = true;
            this.topGraph.Click += new System.EventHandler(this.topGraph_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importSampleDataToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.disconnectFromDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.databaseToolStripMenuItem.Text = "Data";
            // 
            // importSampleDataToolStripMenuItem
            // 
            this.importSampleDataToolStripMenuItem.Name = "importSampleDataToolStripMenuItem";
            this.importSampleDataToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.importSampleDataToolStripMenuItem.Text = "Import sample data";
            this.importSampleDataToolStripMenuItem.Click += new System.EventHandler(this.importSampleDataToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.dataToolStripMenuItem.Text = "Crawler";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // disconnectFromDatabaseToolStripMenuItem
            // 
            this.disconnectFromDatabaseToolStripMenuItem.Name = "disconnectFromDatabaseToolStripMenuItem";
            this.disconnectFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.disconnectFromDatabaseToolStripMenuItem.Text = "Disconnect";
            this.disconnectFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.disconnectFromDatabaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // overviewTab
            // 
            this.overviewTab.Controls.Add(this.idGet);
            this.overviewTab.Controls.Add(this.searchBox);
            this.overviewTab.Controls.Add(this.label16);
            this.overviewTab.Controls.Add(this.label1);
            this.overviewTab.Controls.Add(this.sortBox);
            this.overviewTab.Controls.Add(this.button1);
            this.overviewTab.Controls.Add(this.dataLelang);
            this.overviewTab.Controls.Add(this.label3);
            this.overviewTab.Location = new System.Drawing.Point(4, 22);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(540, 320);
            this.overviewTab.TabIndex = 0;
            this.overviewTab.Text = "Overview";
            this.overviewTab.UseVisualStyleBackColor = true;
            // 
            // idGet
            // 
            this.idGet.Location = new System.Drawing.Point(392, 27);
            this.idGet.Name = "idGet";
            this.idGet.Size = new System.Drawing.Size(75, 23);
            this.idGet.TabIndex = 21;
            this.idGet.Text = "Go";
            this.idGet.UseVisualStyleBackColor = true;
            this.idGet.Click += new System.EventHandler(this.idGet_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(286, 28);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(283, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Search ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order by:";
            // 
            // sortBox
            // 
            this.sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "None",
            "id_lelang",
            "nama_lelang",
            "tahap",
            "kategori"});
            this.sortBox.Location = new System.Drawing.Point(6, 27);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(152, 21);
            this.sortBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataLelang
            // 
            this.dataLelang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataLelang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLelang.Location = new System.Drawing.Point(6, 77);
            this.dataLelang.Name = "dataLelang";
            this.dataLelang.Size = new System.Drawing.Size(528, 237);
            this.dataLelang.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data";
            // 
            // searchIDTab
            // 
            this.searchIDTab.Controls.Add(this.overviewTab);
            this.searchIDTab.Controls.Add(this.tabPage1);
            this.searchIDTab.Location = new System.Drawing.Point(13, 34);
            this.searchIDTab.Name = "searchIDTab";
            this.searchIDTab.SelectedIndex = 0;
            this.searchIDTab.Size = new System.Drawing.Size(548, 346);
            this.searchIDTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.graphLocBox);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.graphOpt);
            this.tabPage1.Controls.Add(this.createGraphBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 320);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Graph/Network";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 22);
            this.button3.TabIndex = 16;
            this.button3.Text = "Reset to default";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // graphLocBox
            // 
            this.graphLocBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphLocBox.FormattingEnabled = true;
            this.graphLocBox.Items.AddRange(new object[] {
            "Leaderboard",
            "LPSE Kabupaten Bantul",
            "LPSE Kabupaten Kulon Progo",
            "LPSE Kabupaten Sleman",
            "LPSE Kabupaten Gunung Kidul",
            "LPSE Kota Yogyakarta",
            "LPSE Provinsi Daerah Istimewa Yogyakarta",
            "LPSE Universitas Gadjah Mada"});
            this.graphLocBox.Location = new System.Drawing.Point(9, 28);
            this.graphLocBox.Name = "graphLocBox";
            this.graphLocBox.Size = new System.Drawing.Size(251, 21);
            this.graphLocBox.TabIndex = 15;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.repulsionBox);
            this.groupBox5.Controls.Add(this.timeBox);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(395, 165);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 146);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Extra";
            // 
            // repulsionBox
            // 
            this.repulsionBox.Location = new System.Drawing.Point(6, 103);
            this.repulsionBox.Name = "repulsionBox";
            this.repulsionBox.Size = new System.Drawing.Size(126, 20);
            this.repulsionBox.TabIndex = 7;
            this.repulsionBox.Text = "2000.";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(6, 52);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(126, 20);
            this.timeBox.TabIndex = 6;
            this.timeBox.Text = "120";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Repulsion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Time (seconds)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelMaxBox);
            this.groupBox4.Controls.Add(this.labelMinBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(266, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 146);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Label Size";
            // 
            // labelMaxBox
            // 
            this.labelMaxBox.Location = new System.Drawing.Point(6, 103);
            this.labelMaxBox.Name = "labelMaxBox";
            this.labelMaxBox.Size = new System.Drawing.Size(111, 20);
            this.labelMaxBox.TabIndex = 7;
            this.labelMaxBox.Text = "3";
            // 
            // labelMinBox
            // 
            this.labelMinBox.Location = new System.Drawing.Point(6, 52);
            this.labelMinBox.Name = "labelMinBox";
            this.labelMinBox.Size = new System.Drawing.Size(111, 20);
            this.labelMinBox.TabIndex = 6;
            this.labelMinBox.Text = "0.6";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Max";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Min.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nodeMaxBox);
            this.groupBox3.Controls.Add(this.nodeMinBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(137, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 146);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Node Size";
            // 
            // nodeMaxBox
            // 
            this.nodeMaxBox.Location = new System.Drawing.Point(6, 103);
            this.nodeMaxBox.Name = "nodeMaxBox";
            this.nodeMaxBox.Size = new System.Drawing.Size(111, 20);
            this.nodeMaxBox.TabIndex = 7;
            this.nodeMaxBox.Text = "3";
            // 
            // nodeMinBox
            // 
            this.nodeMinBox.Location = new System.Drawing.Point(6, 52);
            this.nodeMinBox.Name = "nodeMinBox";
            this.nodeMinBox.Size = new System.Drawing.Size(111, 20);
            this.nodeMinBox.TabIndex = 6;
            this.nodeMinBox.Text = "0.8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Max";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Min.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorMaxBox);
            this.groupBox2.Controls.Add(this.colorMinBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 146);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edge Color";
            // 
            // colorMaxBox
            // 
            this.colorMaxBox.Location = new System.Drawing.Point(6, 103);
            this.colorMaxBox.Name = "colorMaxBox";
            this.colorMaxBox.Size = new System.Drawing.Size(111, 20);
            this.colorMaxBox.TabIndex = 3;
            this.colorMaxBox.Text = "0xAAAAFF";
            // 
            // colorMinBox
            // 
            this.colorMinBox.Location = new System.Drawing.Point(6, 52);
            this.colorMinBox.Name = "colorMinBox";
            this.colorMinBox.Size = new System.Drawing.Size(111, 20);
            this.colorMinBox.TabIndex = 2;
            this.colorMinBox.Text = "0xFFC0D9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min.";
            // 
            // graphOpt
            // 
            this.graphOpt.Location = new System.Drawing.Point(10, 90);
            this.graphOpt.Name = "graphOpt";
            this.graphOpt.Size = new System.Drawing.Size(75, 22);
            this.graphOpt.TabIndex = 7;
            this.graphOpt.Text = "Options";
            this.graphOpt.UseVisualStyleBackColor = true;
            this.graphOpt.Click += new System.EventHandler(this.graphOpt_Click);
            // 
            // createGraphBtn
            // 
            this.createGraphBtn.Location = new System.Drawing.Point(424, 86);
            this.createGraphBtn.Name = "createGraphBtn";
            this.createGraphBtn.Size = new System.Drawing.Size(110, 30);
            this.createGraphBtn.TabIndex = 6;
            this.createGraphBtn.Text = "Create Graph";
            this.createGraphBtn.UseVisualStyleBackColor = true;
            this.createGraphBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchIDTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LPSE Winner Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLeaderboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.overviewTab.ResumeLayout(false);
            this.overviewTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLelang)).EndInit();
            this.searchIDTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage overviewTab;
        private System.Windows.Forms.DataGridView dataLelang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl searchIDTab;
        private System.Windows.Forms.Button topGraph;
        private System.Windows.Forms.DataGridView dataLeaderboard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createGraphBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox repulsionBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox labelMaxBox;
        private System.Windows.Forms.TextBox labelMinBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nodeMaxBox;
        private System.Windows.Forms.TextBox nodeMinBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox colorMaxBox;
        private System.Windows.Forms.TextBox colorMinBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button graphOpt;
        private System.Windows.Forms.ComboBox graphLocBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSampleDataToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rldBtn;
        private System.Windows.Forms.Button idGet;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label16;
    }
}

