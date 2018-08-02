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
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crawlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataLelang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.locCombo = new System.Windows.Forms.ComboBox();
            this.locGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIDTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.graphOpt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.fileLocBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLeaderboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.searchLocTab.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.dataLeaderboard);
            this.groupBox1.Controls.Add(this.topGraph);
            this.groupBox1.Location = new System.Drawing.Point(567, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leaderboard";
            // 
            // dataLeaderboard
            // 
            this.dataLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLeaderboard.Location = new System.Drawing.Point(7, 20);
            this.dataLeaderboard.Name = "dataLeaderboard";
            this.dataLeaderboard.Size = new System.Drawing.Size(223, 277);
            this.dataLeaderboard.TabIndex = 23;
            // 
            // topGraph
            // 
            this.topGraph.Location = new System.Drawing.Point(42, 303);
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
            this.dataToolStripMenuItem,
            this.disconnectFromDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.crawlerToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add Manually";
            // 
            // crawlerToolStripMenuItem
            // 
            this.crawlerToolStripMenuItem.Name = "crawlerToolStripMenuItem";
            this.crawlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crawlerToolStripMenuItem.Text = "Crawler";
            // 
            // disconnectFromDatabaseToolStripMenuItem
            // 
            this.disconnectFromDatabaseToolStripMenuItem.Name = "disconnectFromDatabaseToolStripMenuItem";
            this.disconnectFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectFromDatabaseToolStripMenuItem.Text = "Disconnect";
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
            this.tabPage3.Size = new System.Drawing.Size(540, 320);
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
            this.searchLocTab.Controls.Add(this.dataLelang);
            this.searchLocTab.Controls.Add(this.label3);
            this.searchLocTab.Controls.Add(this.locCombo);
            this.searchLocTab.Controls.Add(this.locGet);
            this.searchLocTab.Controls.Add(this.label1);
            this.searchLocTab.Location = new System.Drawing.Point(4, 22);
            this.searchLocTab.Name = "searchLocTab";
            this.searchLocTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchLocTab.Size = new System.Drawing.Size(540, 320);
            this.searchLocTab.TabIndex = 0;
            this.searchLocTab.Text = "Search by Location";
            this.searchLocTab.UseVisualStyleBackColor = true;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(258, 26);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 17;
            this.exportBtn.Text = "Export...";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // dataLelang
            // 
            this.dataLelang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLelang.Location = new System.Drawing.Point(6, 77);
            this.dataLelang.Name = "dataLelang";
            this.dataLelang.Size = new System.Drawing.Size(528, 237);
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
            this.searchIDTab.Controls.Add(this.tabPage1);
            this.searchIDTab.Location = new System.Drawing.Point(13, 34);
            this.searchIDTab.Name = "searchIDTab";
            this.searchIDTab.SelectedIndex = 0;
            this.searchIDTab.Size = new System.Drawing.Size(548, 346);
            this.searchIDTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.graphOpt);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.browseFileBtn);
            this.tabPage1.Controls.Add(this.fileLocBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 320);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Graph/Network";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(396, 156);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 146);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Extra";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 103);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(126, 20);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 52);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(126, 20);
            this.textBox9.TabIndex = 6;
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
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(267, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 146);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Label Size";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 103);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 52);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(111, 20);
            this.textBox7.TabIndex = 6;
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
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(138, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 146);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Node Size";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 20);
            this.textBox5.TabIndex = 6;
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
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 146);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edge Color";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 2;
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
            this.graphOpt.Location = new System.Drawing.Point(9, 106);
            this.graphOpt.Name = "graphOpt";
            this.graphOpt.Size = new System.Drawing.Size(75, 30);
            this.graphOpt.TabIndex = 7;
            this.graphOpt.Text = "Options";
            this.graphOpt.UseVisualStyleBackColor = true;
            this.graphOpt.Click += new System.EventHandler(this.graphOpt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create Graph";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = " Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File Destination";
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Location = new System.Drawing.Point(459, 27);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(75, 23);
            this.browseFileBtn.TabIndex = 2;
            this.browseFileBtn.Text = " Browse";
            this.browseFileBtn.UseVisualStyleBackColor = true;
            // 
            // fileLocBox
            // 
            this.fileLocBox.Location = new System.Drawing.Point(9, 29);
            this.fileLocBox.Name = "fileLocBox";
            this.fileLocBox.Size = new System.Drawing.Size(444, 20);
            this.fileLocBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File Source";
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
        private System.Windows.Forms.DataGridView dataLeaderboard;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crawlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.TextBox fileLocBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button graphOpt;
    }
}

