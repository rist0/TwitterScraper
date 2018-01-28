namespace TwitterScraper.Forms
{
    partial class Main
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
            this.tabScraper = new System.Windows.Forms.TabPage();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dgvIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tweets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Following = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Followers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMedias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.rbFromFile = new System.Windows.Forms.RadioButton();
            this.rbSingleUser = new System.Windows.Forms.RadioButton();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnScrape = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.gbOtherSettings = new System.Windows.Forms.GroupBox();
            this.cbDumpDebugLogs = new System.Windows.Forms.CheckBox();
            this.gbDataSettings = new System.Windows.Forms.GroupBox();
            this.lblCsvDelimiter = new System.Windows.Forms.Label();
            this.btnCsvDelimiterHelp = new System.Windows.Forms.Button();
            this.txtCsvDelimiter = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.gbWebSettings = new System.Windows.Forms.GroupBox();
            this.lblThreads = new System.Windows.Forms.Label();
            this.btnRequestTimeoutHelp = new System.Windows.Forms.Button();
            this.btnProxyHelp = new System.Windows.Forms.Button();
            this.btnRandomizeUserAgent = new System.Windows.Forms.Button();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.txtRequestTimeout = new System.Windows.Forms.TextBox();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.labelRequestTimeout = new System.Windows.Forms.Label();
            this.labelProxy = new System.Windows.Forms.Label();
            this.labelUserAgent = new System.Windows.Forms.Label();
            this.tabNewsChangelog = new System.Windows.Forms.TabPage();
            this.gbVersion = new System.Windows.Forms.GroupBox();
            this.lblLatestVersion = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.gbNews = new System.Windows.Forms.GroupBox();
            this.txtNews = new System.Windows.Forms.TextBox();
            this.gbChangelog = new System.Windows.Forms.GroupBox();
            this.txtChangelog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tweetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreThanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMoreThanTweetsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeMoreThanTweets = new System.Windows.Forms.ToolStripMenuItem();
            this.lessMoreThanTweets = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLessThanTweetsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeLessThanTweets = new System.Windows.Forms.ToolStripMenuItem();
            this.followingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreThanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMoreThanFollowingsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeMoreThanFollowings = new System.Windows.Forms.ToolStripMenuItem();
            this.lessThanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLessThanFollowingsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeLessThanFollowings = new System.Windows.Forms.ToolStripMenuItem();
            this.followersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreThanToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMoreThanFollowersTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeMoreThanFollowers = new System.Windows.Forms.ToolStripMenuItem();
            this.lessThanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLessThanFollowersTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeLessThanFollowers = new System.Windows.Forms.ToolStripMenuItem();
            this.likesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreThanToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMoreThanLikesTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeMoreThanLikes = new System.Windows.Forms.ToolStripMenuItem();
            this.lessThanToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLessThanLikesTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.removeLessThanLikes = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabScraper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.gbInput.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.gbOtherSettings.SuspendLayout();
            this.gbDataSettings.SuspendLayout();
            this.gbWebSettings.SuspendLayout();
            this.tabNewsChangelog.SuspendLayout();
            this.gbVersion.SuspendLayout();
            this.gbNews.SuspendLayout();
            this.gbChangelog.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabScraper);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabNewsChangelog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabScraper
            // 
            this.tabScraper.Controls.Add(this.dgvItems);
            this.tabScraper.Controls.Add(this.gbInput);
            this.tabScraper.Location = new System.Drawing.Point(4, 22);
            this.tabScraper.Name = "tabScraper";
            this.tabScraper.Padding = new System.Windows.Forms.Padding(3);
            this.tabScraper.Size = new System.Drawing.Size(615, 452);
            this.tabScraper.TabIndex = 0;
            this.tabScraper.Text = "Scraper";
            this.tabScraper.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdColumn,
            this.dgvUsernameColumn,
            this.Tweets,
            this.Following,
            this.Followers,
            this.Likes,
            this.Description,
            this.UserLocation,
            this.DateOfBirth,
            this.RegistrationDate,
            this.TotalMedias,
            this.Verified});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(3, 3);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(609, 379);
            this.dgvItems.TabIndex = 0;
            // 
            // dgvIdColumn
            // 
            this.dgvIdColumn.HeaderText = "ID";
            this.dgvIdColumn.Name = "dgvIdColumn";
            this.dgvIdColumn.Width = 30;
            // 
            // dgvUsernameColumn
            // 
            this.dgvUsernameColumn.HeaderText = "Username";
            this.dgvUsernameColumn.Name = "dgvUsernameColumn";
            // 
            // Tweets
            // 
            this.Tweets.HeaderText = "Tweets";
            this.Tweets.Name = "Tweets";
            this.Tweets.Width = 80;
            // 
            // Following
            // 
            this.Following.HeaderText = "Following";
            this.Following.Name = "Following";
            this.Following.Width = 80;
            // 
            // Followers
            // 
            this.Followers.HeaderText = "Followers";
            this.Followers.Name = "Followers";
            this.Followers.Width = 80;
            // 
            // Likes
            // 
            this.Likes.HeaderText = "Likes";
            this.Likes.Name = "Likes";
            this.Likes.Width = 80;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // UserLocation
            // 
            this.UserLocation.HeaderText = "Location";
            this.UserLocation.Name = "UserLocation";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date of birth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.HeaderText = "Registration Date";
            this.RegistrationDate.Name = "RegistrationDate";
            // 
            // TotalMedias
            // 
            this.TotalMedias.HeaderText = "Total Medias";
            this.TotalMedias.Name = "TotalMedias";
            this.TotalMedias.Width = 80;
            // 
            // Verified
            // 
            this.Verified.HeaderText = "Verified";
            this.Verified.Name = "Verified";
            this.Verified.Width = 80;
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.rbFromFile);
            this.gbInput.Controls.Add(this.rbSingleUser);
            this.gbInput.Controls.Add(this.btnClearAll);
            this.gbInput.Controls.Add(this.btnScrape);
            this.gbInput.Controls.Add(this.txtInput);
            this.gbInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbInput.Location = new System.Drawing.Point(3, 382);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(609, 67);
            this.gbInput.TabIndex = 3;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // rbFromFile
            // 
            this.rbFromFile.AutoSize = true;
            this.rbFromFile.Location = new System.Drawing.Point(136, 19);
            this.rbFromFile.Name = "rbFromFile";
            this.rbFromFile.Size = new System.Drawing.Size(67, 17);
            this.rbFromFile.TabIndex = 3;
            this.rbFromFile.Text = "From File";
            this.rbFromFile.UseVisualStyleBackColor = true;
            this.rbFromFile.CheckedChanged += new System.EventHandler(this.rbFromFile_CheckedChanged);
            // 
            // rbSingleUser
            // 
            this.rbSingleUser.AutoSize = true;
            this.rbSingleUser.Checked = true;
            this.rbSingleUser.Location = new System.Drawing.Point(22, 19);
            this.rbSingleUser.Name = "rbSingleUser";
            this.rbSingleUser.Size = new System.Drawing.Size(79, 17);
            this.rbSingleUser.TabIndex = 3;
            this.rbSingleUser.TabStop = true;
            this.rbSingleUser.Text = "Single User";
            this.rbSingleUser.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(516, 13);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(516, 38);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(75, 23);
            this.btnScrape.TabIndex = 1;
            this.btnScrape.Text = "Scrape";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(22, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(487, 20);
            this.txtInput.TabIndex = 2;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.gbOtherSettings);
            this.tabSettings.Controls.Add(this.gbDataSettings);
            this.tabSettings.Controls.Add(this.gbWebSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(615, 452);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // gbOtherSettings
            // 
            this.gbOtherSettings.Controls.Add(this.cbDumpDebugLogs);
            this.gbOtherSettings.Location = new System.Drawing.Point(19, 287);
            this.gbOtherSettings.Name = "gbOtherSettings";
            this.gbOtherSettings.Size = new System.Drawing.Size(579, 100);
            this.gbOtherSettings.TabIndex = 1;
            this.gbOtherSettings.TabStop = false;
            this.gbOtherSettings.Text = "Other Settings";
            // 
            // cbDumpDebugLogs
            // 
            this.cbDumpDebugLogs.AutoSize = true;
            this.cbDumpDebugLogs.Location = new System.Drawing.Point(33, 32);
            this.cbDumpDebugLogs.Name = "cbDumpDebugLogs";
            this.cbDumpDebugLogs.Size = new System.Drawing.Size(159, 17);
            this.cbDumpDebugLogs.TabIndex = 0;
            this.cbDumpDebugLogs.Text = "Dump debug logs on error(s)";
            this.cbDumpDebugLogs.UseVisualStyleBackColor = true;
            // 
            // gbDataSettings
            // 
            this.gbDataSettings.Controls.Add(this.lblCsvDelimiter);
            this.gbDataSettings.Controls.Add(this.btnCsvDelimiterHelp);
            this.gbDataSettings.Controls.Add(this.txtCsvDelimiter);
            this.gbDataSettings.Controls.Add(this.txtOutput);
            this.gbDataSettings.Controls.Add(this.btnOutputFolder);
            this.gbDataSettings.Controls.Add(this.lblOutputFolder);
            this.gbDataSettings.Location = new System.Drawing.Point(19, 181);
            this.gbDataSettings.Name = "gbDataSettings";
            this.gbDataSettings.Size = new System.Drawing.Size(579, 100);
            this.gbDataSettings.TabIndex = 1;
            this.gbDataSettings.TabStop = false;
            this.gbDataSettings.Text = "Data Settings";
            // 
            // lblCsvDelimiter
            // 
            this.lblCsvDelimiter.AutoSize = true;
            this.lblCsvDelimiter.Location = new System.Drawing.Point(31, 55);
            this.lblCsvDelimiter.Name = "lblCsvDelimiter";
            this.lblCsvDelimiter.Size = new System.Drawing.Size(74, 13);
            this.lblCsvDelimiter.TabIndex = 4;
            this.lblCsvDelimiter.Text = "CSV Delimiter:";
            // 
            // btnCsvDelimiterHelp
            // 
            this.btnCsvDelimiterHelp.Location = new System.Drawing.Point(534, 52);
            this.btnCsvDelimiterHelp.Name = "btnCsvDelimiterHelp";
            this.btnCsvDelimiterHelp.Size = new System.Drawing.Size(26, 20);
            this.btnCsvDelimiterHelp.TabIndex = 2;
            this.btnCsvDelimiterHelp.TabStop = false;
            this.btnCsvDelimiterHelp.Text = "?";
            this.btnCsvDelimiterHelp.UseVisualStyleBackColor = true;
            // 
            // txtCsvDelimiter
            // 
            this.txtCsvDelimiter.Location = new System.Drawing.Point(122, 52);
            this.txtCsvDelimiter.Name = "txtCsvDelimiter";
            this.txtCsvDelimiter.Size = new System.Drawing.Size(406, 20);
            this.txtCsvDelimiter.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(122, 26);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(406, 20);
            this.txtOutput.TabIndex = 2;
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(534, 26);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(26, 20);
            this.btnOutputFolder.TabIndex = 1;
            this.btnOutputFolder.Text = "...";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Location = new System.Drawing.Point(34, 29);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(71, 13);
            this.lblOutputFolder.TabIndex = 0;
            this.lblOutputFolder.Text = "Output folder:";
            // 
            // gbWebSettings
            // 
            this.gbWebSettings.Controls.Add(this.lblThreads);
            this.gbWebSettings.Controls.Add(this.btnRequestTimeoutHelp);
            this.gbWebSettings.Controls.Add(this.btnProxyHelp);
            this.gbWebSettings.Controls.Add(this.btnRandomizeUserAgent);
            this.gbWebSettings.Controls.Add(this.txtThreads);
            this.gbWebSettings.Controls.Add(this.txtRequestTimeout);
            this.gbWebSettings.Controls.Add(this.txtProxy);
            this.gbWebSettings.Controls.Add(this.txtUserAgent);
            this.gbWebSettings.Controls.Add(this.labelRequestTimeout);
            this.gbWebSettings.Controls.Add(this.labelProxy);
            this.gbWebSettings.Controls.Add(this.labelUserAgent);
            this.gbWebSettings.Location = new System.Drawing.Point(19, 18);
            this.gbWebSettings.Name = "gbWebSettings";
            this.gbWebSettings.Size = new System.Drawing.Size(579, 157);
            this.gbWebSettings.TabIndex = 0;
            this.gbWebSettings.TabStop = false;
            this.gbWebSettings.Text = "Web Settings";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(56, 129);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(49, 13);
            this.lblThreads.TabIndex = 3;
            this.lblThreads.Text = "Threads:";
            // 
            // btnRequestTimeoutHelp
            // 
            this.btnRequestTimeoutHelp.Location = new System.Drawing.Point(534, 94);
            this.btnRequestTimeoutHelp.Name = "btnRequestTimeoutHelp";
            this.btnRequestTimeoutHelp.Size = new System.Drawing.Size(26, 20);
            this.btnRequestTimeoutHelp.TabIndex = 2;
            this.btnRequestTimeoutHelp.TabStop = false;
            this.btnRequestTimeoutHelp.Text = "?";
            this.btnRequestTimeoutHelp.UseVisualStyleBackColor = true;
            // 
            // btnProxyHelp
            // 
            this.btnProxyHelp.Location = new System.Drawing.Point(534, 60);
            this.btnProxyHelp.Name = "btnProxyHelp";
            this.btnProxyHelp.Size = new System.Drawing.Size(26, 20);
            this.btnProxyHelp.TabIndex = 2;
            this.btnProxyHelp.TabStop = false;
            this.btnProxyHelp.Text = "?";
            this.btnProxyHelp.UseVisualStyleBackColor = true;
            // 
            // btnRandomizeUserAgent
            // 
            this.btnRandomizeUserAgent.Location = new System.Drawing.Point(534, 28);
            this.btnRandomizeUserAgent.Name = "btnRandomizeUserAgent";
            this.btnRandomizeUserAgent.Size = new System.Drawing.Size(26, 20);
            this.btnRandomizeUserAgent.TabIndex = 2;
            this.btnRandomizeUserAgent.TabStop = false;
            this.btnRandomizeUserAgent.Text = "R";
            this.btnRandomizeUserAgent.UseVisualStyleBackColor = true;
            this.btnRandomizeUserAgent.Click += new System.EventHandler(this.btnRandomizeUserAgent_Click);
            // 
            // txtThreads
            // 
            this.txtThreads.Location = new System.Drawing.Point(122, 126);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(406, 20);
            this.txtThreads.TabIndex = 3;
            // 
            // txtRequestTimeout
            // 
            this.txtRequestTimeout.Location = new System.Drawing.Point(122, 95);
            this.txtRequestTimeout.Name = "txtRequestTimeout";
            this.txtRequestTimeout.Size = new System.Drawing.Size(406, 20);
            this.txtRequestTimeout.TabIndex = 2;
            // 
            // txtProxy
            // 
            this.txtProxy.Location = new System.Drawing.Point(122, 61);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(406, 20);
            this.txtProxy.TabIndex = 1;
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Location = new System.Drawing.Point(122, 28);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(406, 20);
            this.txtUserAgent.TabIndex = 0;
            // 
            // labelRequestTimeout
            // 
            this.labelRequestTimeout.AutoSize = true;
            this.labelRequestTimeout.Location = new System.Drawing.Point(18, 98);
            this.labelRequestTimeout.Name = "labelRequestTimeout";
            this.labelRequestTimeout.Size = new System.Drawing.Size(87, 13);
            this.labelRequestTimeout.TabIndex = 0;
            this.labelRequestTimeout.Text = "Request timeout:";
            // 
            // labelProxy
            // 
            this.labelProxy.AutoSize = true;
            this.labelProxy.Location = new System.Drawing.Point(69, 64);
            this.labelProxy.Name = "labelProxy";
            this.labelProxy.Size = new System.Drawing.Size(36, 13);
            this.labelProxy.TabIndex = 0;
            this.labelProxy.Text = "Proxy:";
            // 
            // labelUserAgent
            // 
            this.labelUserAgent.AutoSize = true;
            this.labelUserAgent.Location = new System.Drawing.Point(42, 31);
            this.labelUserAgent.Name = "labelUserAgent";
            this.labelUserAgent.Size = new System.Drawing.Size(63, 13);
            this.labelUserAgent.TabIndex = 0;
            this.labelUserAgent.Text = "User Agent:";
            // 
            // tabNewsChangelog
            // 
            this.tabNewsChangelog.Controls.Add(this.gbVersion);
            this.tabNewsChangelog.Controls.Add(this.gbNews);
            this.tabNewsChangelog.Controls.Add(this.gbChangelog);
            this.tabNewsChangelog.Location = new System.Drawing.Point(4, 22);
            this.tabNewsChangelog.Name = "tabNewsChangelog";
            this.tabNewsChangelog.Size = new System.Drawing.Size(615, 452);
            this.tabNewsChangelog.TabIndex = 2;
            this.tabNewsChangelog.Text = "News & Changelog";
            this.tabNewsChangelog.UseVisualStyleBackColor = true;
            // 
            // gbVersion
            // 
            this.gbVersion.Controls.Add(this.lblLatestVersion);
            this.gbVersion.Controls.Add(this.lblCurrentVersion);
            this.gbVersion.Location = new System.Drawing.Point(23, 18);
            this.gbVersion.Name = "gbVersion";
            this.gbVersion.Size = new System.Drawing.Size(169, 100);
            this.gbVersion.TabIndex = 0;
            this.gbVersion.TabStop = false;
            this.gbVersion.Text = "Version details";
            // 
            // lblLatestVersion
            // 
            this.lblLatestVersion.AutoSize = true;
            this.lblLatestVersion.Location = new System.Drawing.Point(21, 65);
            this.lblLatestVersion.Name = "lblLatestVersion";
            this.lblLatestVersion.Size = new System.Drawing.Size(79, 13);
            this.lblLatestVersion.TabIndex = 0;
            this.lblLatestVersion.Text = "Latest version: ";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(16, 31);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(84, 13);
            this.lblCurrentVersion.TabIndex = 0;
            this.lblCurrentVersion.Text = "Current version: ";
            // 
            // gbNews
            // 
            this.gbNews.Controls.Add(this.txtNews);
            this.gbNews.Location = new System.Drawing.Point(198, 18);
            this.gbNews.Name = "gbNews";
            this.gbNews.Size = new System.Drawing.Size(399, 100);
            this.gbNews.TabIndex = 0;
            this.gbNews.TabStop = false;
            this.gbNews.Text = "News";
            // 
            // txtNews
            // 
            this.txtNews.Location = new System.Drawing.Point(6, 19);
            this.txtNews.Multiline = true;
            this.txtNews.Name = "txtNews";
            this.txtNews.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNews.Size = new System.Drawing.Size(387, 75);
            this.txtNews.TabIndex = 0;
            // 
            // gbChangelog
            // 
            this.gbChangelog.Controls.Add(this.txtChangelog);
            this.gbChangelog.Location = new System.Drawing.Point(23, 137);
            this.gbChangelog.Name = "gbChangelog";
            this.gbChangelog.Size = new System.Drawing.Size(574, 281);
            this.gbChangelog.TabIndex = 0;
            this.gbChangelog.TabStop = false;
            this.gbChangelog.Text = "Changelog";
            // 
            // txtChangelog
            // 
            this.txtChangelog.Location = new System.Drawing.Point(6, 19);
            this.txtChangelog.Multiline = true;
            this.txtChangelog.Name = "txtChangelog";
            this.txtChangelog.Size = new System.Drawing.Size(562, 256);
            this.txtChangelog.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDataToolStripMenuItem,
            this.selectedRowsToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // allDataToolStripMenuItem
            // 
            this.allDataToolStripMenuItem.Name = "allDataToolStripMenuItem";
            this.allDataToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.allDataToolStripMenuItem.Text = "All data";
            this.allDataToolStripMenuItem.Click += new System.EventHandler(this.ExportData);
            // 
            // selectedRowsToolStripMenuItem
            // 
            this.selectedRowsToolStripMenuItem.Name = "selectedRowsToolStripMenuItem";
            this.selectedRowsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.selectedRowsToolStripMenuItem.Text = "Selected rows";
            this.selectedRowsToolStripMenuItem.Click += new System.EventHandler(this.ExportData);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tweetsToolStripMenuItem,
            this.followingsToolStripMenuItem,
            this.followersToolStripMenuItem,
            this.likesToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // tweetsToolStripMenuItem
            // 
            this.tweetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreThanToolStripMenuItem,
            this.lessMoreThanTweets});
            this.tweetsToolStripMenuItem.Name = "tweetsToolStripMenuItem";
            this.tweetsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.tweetsToolStripMenuItem.Text = "Tweets";
            // 
            // moreThanToolStripMenuItem
            // 
            this.moreThanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeMoreThanTweetsTextBox,
            this.removeMoreThanTweets});
            this.moreThanToolStripMenuItem.Name = "moreThanToolStripMenuItem";
            this.moreThanToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.moreThanToolStripMenuItem.Text = "More than";
            // 
            // removeMoreThanTweetsTextBox
            // 
            this.removeMoreThanTweetsTextBox.Name = "removeMoreThanTweetsTextBox";
            this.removeMoreThanTweetsTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // removeMoreThanTweets
            // 
            this.removeMoreThanTweets.Name = "removeMoreThanTweets";
            this.removeMoreThanTweets.Size = new System.Drawing.Size(160, 22);
            this.removeMoreThanTweets.Text = "Remove";
            this.removeMoreThanTweets.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // lessMoreThanTweets
            // 
            this.lessMoreThanTweets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeLessThanTweetsTextBox,
            this.removeLessThanTweets});
            this.lessMoreThanTweets.Name = "lessMoreThanTweets";
            this.lessMoreThanTweets.Size = new System.Drawing.Size(129, 22);
            this.lessMoreThanTweets.Text = "Less than";
            // 
            // removeLessThanTweetsTextBox
            // 
            this.removeLessThanTweetsTextBox.Name = "removeLessThanTweetsTextBox";
            this.removeLessThanTweetsTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // removeLessThanTweets
            // 
            this.removeLessThanTweets.Name = "removeLessThanTweets";
            this.removeLessThanTweets.Size = new System.Drawing.Size(160, 22);
            this.removeLessThanTweets.Text = "Remove";
            this.removeLessThanTweets.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // followingsToolStripMenuItem
            // 
            this.followingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreThanToolStripMenuItem1,
            this.lessThanToolStripMenuItem});
            this.followingsToolStripMenuItem.Name = "followingsToolStripMenuItem";
            this.followingsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.followingsToolStripMenuItem.Text = "Followings";
            // 
            // moreThanToolStripMenuItem1
            // 
            this.moreThanToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeMoreThanFollowingsTextBox,
            this.removeMoreThanFollowings});
            this.moreThanToolStripMenuItem1.Name = "moreThanToolStripMenuItem1";
            this.moreThanToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.moreThanToolStripMenuItem1.Text = "More than";
            // 
            // removeMoreThanFollowingsTextBox
            // 
            this.removeMoreThanFollowingsTextBox.Name = "removeMoreThanFollowingsTextBox";
            this.removeMoreThanFollowingsTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // removeMoreThanFollowings
            // 
            this.removeMoreThanFollowings.Name = "removeMoreThanFollowings";
            this.removeMoreThanFollowings.Size = new System.Drawing.Size(160, 22);
            this.removeMoreThanFollowings.Text = "Remove";
            this.removeMoreThanFollowings.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // lessThanToolStripMenuItem
            // 
            this.lessThanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeLessThanFollowingsTextBox,
            this.removeLessThanFollowings});
            this.lessThanToolStripMenuItem.Name = "lessThanToolStripMenuItem";
            this.lessThanToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.lessThanToolStripMenuItem.Text = "Less than";
            // 
            // removeLessThanFollowingsTextBox
            // 
            this.removeLessThanFollowingsTextBox.Name = "removeLessThanFollowingsTextBox";
            this.removeLessThanFollowingsTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // removeLessThanFollowings
            // 
            this.removeLessThanFollowings.Name = "removeLessThanFollowings";
            this.removeLessThanFollowings.Size = new System.Drawing.Size(160, 22);
            this.removeLessThanFollowings.Text = "Remove";
            this.removeLessThanFollowings.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // followersToolStripMenuItem
            // 
            this.followersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreThanToolStripMenuItem2,
            this.lessThanToolStripMenuItem1});
            this.followersToolStripMenuItem.Name = "followersToolStripMenuItem";
            this.followersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.followersToolStripMenuItem.Text = "Followers";
            // 
            // moreThanToolStripMenuItem2
            // 
            this.moreThanToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeMoreThanFollowersTextBox,
            this.removeMoreThanFollowers});
            this.moreThanToolStripMenuItem2.Name = "moreThanToolStripMenuItem2";
            this.moreThanToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.moreThanToolStripMenuItem2.Text = "More than";
            // 
            // removeMoreThanFollowersTextBox
            // 
            this.removeMoreThanFollowersTextBox.Name = "removeMoreThanFollowersTextBox";
            this.removeMoreThanFollowersTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // removeMoreThanFollowers
            // 
            this.removeMoreThanFollowers.Name = "removeMoreThanFollowers";
            this.removeMoreThanFollowers.Size = new System.Drawing.Size(160, 22);
            this.removeMoreThanFollowers.Text = "Remove";
            this.removeMoreThanFollowers.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // lessThanToolStripMenuItem1
            // 
            this.lessThanToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeLessThanFollowersTextBox,
            this.removeLessThanFollowers});
            this.lessThanToolStripMenuItem1.Name = "lessThanToolStripMenuItem1";
            this.lessThanToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.lessThanToolStripMenuItem1.Text = "Less than";
            this.lessThanToolStripMenuItem1.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // removeLessThanFollowersTextBox
            // 
            this.removeLessThanFollowersTextBox.Name = "removeLessThanFollowersTextBox";
            this.removeLessThanFollowersTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // removeLessThanFollowers
            // 
            this.removeLessThanFollowers.Name = "removeLessThanFollowers";
            this.removeLessThanFollowers.Size = new System.Drawing.Size(160, 22);
            this.removeLessThanFollowers.Text = "Remove";
            this.removeLessThanFollowers.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // likesToolStripMenuItem
            // 
            this.likesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreThanToolStripMenuItem3,
            this.lessThanToolStripMenuItem2});
            this.likesToolStripMenuItem.Name = "likesToolStripMenuItem";
            this.likesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.likesToolStripMenuItem.Text = "Likes";
            // 
            // moreThanToolStripMenuItem3
            // 
            this.moreThanToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeMoreThanLikesTextBox,
            this.removeMoreThanLikes});
            this.moreThanToolStripMenuItem3.Name = "moreThanToolStripMenuItem3";
            this.moreThanToolStripMenuItem3.Size = new System.Drawing.Size(129, 22);
            this.moreThanToolStripMenuItem3.Text = "More than";
            // 
            // removeMoreThanLikesTextBox
            // 
            this.removeMoreThanLikesTextBox.Name = "removeMoreThanLikesTextBox";
            this.removeMoreThanLikesTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // removeMoreThanLikes
            // 
            this.removeMoreThanLikes.Name = "removeMoreThanLikes";
            this.removeMoreThanLikes.Size = new System.Drawing.Size(160, 22);
            this.removeMoreThanLikes.Text = "Remove";
            this.removeMoreThanLikes.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // lessThanToolStripMenuItem2
            // 
            this.lessThanToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeLessThanLikesTextBox,
            this.removeLessThanLikes});
            this.lessThanToolStripMenuItem2.Name = "lessThanToolStripMenuItem2";
            this.lessThanToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.lessThanToolStripMenuItem2.Text = "Less than";
            // 
            // removeLessThanLikesTextBox
            // 
            this.removeLessThanLikesTextBox.Name = "removeLessThanLikesTextBox";
            this.removeLessThanLikesTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // removeLessThanLikes
            // 
            this.removeLessThanLikes.Name = "removeLessThanLikes";
            this.removeLessThanLikes.Size = new System.Drawing.Size(160, 22);
            this.removeLessThanLikes.Text = "Remove";
            this.removeLessThanLikes.Click += new System.EventHandler(this.removeFilters_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Twitter Scraper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabScraper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.gbOtherSettings.ResumeLayout(false);
            this.gbOtherSettings.PerformLayout();
            this.gbDataSettings.ResumeLayout(false);
            this.gbDataSettings.PerformLayout();
            this.gbWebSettings.ResumeLayout(false);
            this.gbWebSettings.PerformLayout();
            this.tabNewsChangelog.ResumeLayout(false);
            this.gbVersion.ResumeLayout(false);
            this.gbVersion.PerformLayout();
            this.gbNews.ResumeLayout(false);
            this.gbNews.PerformLayout();
            this.gbChangelog.ResumeLayout(false);
            this.gbChangelog.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabScraper;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TabPage tabNewsChangelog;
        private System.Windows.Forms.GroupBox gbWebSettings;
        private System.Windows.Forms.Button btnRandomizeUserAgent;
        private System.Windows.Forms.TextBox txtRequestTimeout;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.Label labelRequestTimeout;
        private System.Windows.Forms.Label labelProxy;
        private System.Windows.Forms.Label labelUserAgent;
        private System.Windows.Forms.Button btnRequestTimeoutHelp;
        private System.Windows.Forms.Button btnProxyHelp;
        private System.Windows.Forms.GroupBox gbVersion;
        private System.Windows.Forms.GroupBox gbNews;
        private System.Windows.Forms.GroupBox gbChangelog;
        private System.Windows.Forms.TextBox txtChangelog;
        private System.Windows.Forms.Label lblLatestVersion;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnScrape;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.GroupBox gbOtherSettings;
        private System.Windows.Forms.GroupBox gbDataSettings;
        private System.Windows.Forms.CheckBox cbDumpDebugLogs;
        private System.Windows.Forms.RadioButton rbFromFile;
        private System.Windows.Forms.RadioButton rbSingleUser;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tweets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Following;
        private System.Windows.Forms.DataGridViewTextBoxColumn Followers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Likes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMedias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verified;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDataToolStripMenuItem;
        private System.Windows.Forms.Label lblCsvDelimiter;
        private System.Windows.Forms.TextBox txtCsvDelimiter;
        private System.Windows.Forms.Button btnCsvDelimiterHelp;
        private System.Windows.Forms.TextBox txtNews;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tweetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreThanToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox removeMoreThanTweetsTextBox;
        private System.Windows.Forms.ToolStripMenuItem lessMoreThanTweets;
        private System.Windows.Forms.ToolStripTextBox removeLessThanTweetsTextBox;
        private System.Windows.Forms.ToolStripMenuItem followingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem likesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMoreThanTweets;
        private System.Windows.Forms.ToolStripMenuItem removeLessThanTweets;
        private System.Windows.Forms.ToolStripMenuItem moreThanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox removeMoreThanFollowingsTextBox;
        private System.Windows.Forms.ToolStripMenuItem removeMoreThanFollowings;
        private System.Windows.Forms.ToolStripMenuItem lessThanToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox removeLessThanFollowingsTextBox;
        private System.Windows.Forms.ToolStripMenuItem removeLessThanFollowings;
        private System.Windows.Forms.ToolStripMenuItem moreThanToolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox removeMoreThanFollowersTextBox;
        private System.Windows.Forms.ToolStripMenuItem removeMoreThanFollowers;
        private System.Windows.Forms.ToolStripMenuItem lessThanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox removeLessThanFollowersTextBox;
        private System.Windows.Forms.ToolStripMenuItem removeLessThanFollowers;
        private System.Windows.Forms.ToolStripMenuItem moreThanToolStripMenuItem3;
        private System.Windows.Forms.ToolStripTextBox removeMoreThanLikesTextBox;
        private System.Windows.Forms.ToolStripMenuItem removeMoreThanLikes;
        private System.Windows.Forms.ToolStripMenuItem lessThanToolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox removeLessThanLikesTextBox;
        private System.Windows.Forms.ToolStripMenuItem removeLessThanLikes;
        private System.Windows.Forms.ToolStripMenuItem selectedRowsToolStripMenuItem;
    }
}

