namespace VATSIMHoursCompiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpSetup = new System.Windows.Forms.TabPage();
            this.tlpSetupPage = new System.Windows.Forms.TableLayoutPanel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDetSave = new System.Windows.Forms.Button();
            this.LblParent = new System.Windows.Forms.Label();
            this.cbDetParent = new System.Windows.Forms.ComboBox();
            this.LblConditions = new System.Windows.Forms.Label();
            this.lvConditions = new System.Windows.Forms.ListView();
            this.chConName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chConType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chConValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chConBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblDetName = new System.Windows.Forms.Label();
            this.TxtDetName = new System.Windows.Forms.TextBox();
            this.BtnConRemove = new System.Windows.Forms.Button();
            this.BtnConAdd = new System.Windows.Forms.Button();
            this.gbPositions = new System.Windows.Forms.GroupBox();
            this.tlpPositions = new System.Windows.Forms.TableLayoutPanel();
            this.lvPositions = new System.Windows.Forms.ListView();
            this.chPosName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosParent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosNoCons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblName = new System.Windows.Forms.Label();
            this.TxtPosName = new System.Windows.Forms.TextBox();
            this.BtnPosRemove = new System.Windows.Forms.Button();
            this.BtnPosAdd = new System.Windows.Forms.Button();
            this.gbMembers = new System.Windows.Forms.GroupBox();
            this.tlpMembers = new System.Windows.Forms.TableLayoutPanel();
            this.LblMemCID = new System.Windows.Forms.Label();
            this.lvMembers = new System.Windows.Forms.ListView();
            this.chCID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnMemAdd = new System.Windows.Forms.Button();
            this.BtnMemRemove = new System.Windows.Forms.Button();
            this.TxtMemCID = new System.Windows.Forms.TextBox();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.tlpConditions = new System.Windows.Forms.TableLayoutPanel();
            this.TxtCon2 = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.cbConType = new System.Windows.Forms.ComboBox();
            this.LblConName = new System.Windows.Forms.Label();
            this.TxtConName = new System.Windows.Forms.TextBox();
            this.LblCon2 = new System.Windows.Forms.Label();
            this.TxtCon1 = new System.Windows.Forms.TextBox();
            this.LblCon1 = new System.Windows.Forms.Label();
            this.BtnConSave = new System.Windows.Forms.Button();
            this.tbpResults = new System.Windows.Forms.TabPage();
            this.tlpResultsPage = new System.Windows.Forms.TableLayoutPanel();
            this.gbColumns = new System.Windows.Forms.GroupBox();
            this.tlpColumns = new System.Windows.Forms.TableLayoutPanel();
            this.BtnChildren = new System.Windows.Forms.Button();
            this.BtnParent = new System.Windows.Forms.Button();
            this.clbColumns = new System.Windows.Forms.CheckedListBox();
            this.LblColumns = new System.Windows.Forms.Label();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.tlpResults = new System.Windows.Forms.TableLayoutPanel();
            this.lvResults = new System.Windows.Forms.ListView();
            this.chResultsCID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResultsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResultsBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnGet = new System.Windows.Forms.Button();
            this.BtnRefilter = new System.Windows.Forms.Button();
            this.bgwAPI = new System.ComponentModel.BackgroundWorker();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tssCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.sfdProfile = new System.Windows.Forms.SaveFileDialog();
            this.ofdProfile = new System.Windows.Forms.OpenFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            this.bgwLoadProfile = new System.ComponentModel.BackgroundWorker();
            this.bgwSaveProfile = new System.ComponentModel.BackgroundWorker();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.LblDatStart = new System.Windows.Forms.Label();
            this.LblDatEnd = new System.Windows.Forms.Label();
            this.dtpDatStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDatEnd = new System.Windows.Forms.DateTimePicker();
            this.cbDatStart = new System.Windows.Forms.CheckBox();
            this.cbDatEnd = new System.Windows.Forms.CheckBox();
            this.tbcMain.SuspendLayout();
            this.tbpSetup.SuspendLayout();
            this.tlpSetupPage.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.gbPositions.SuspendLayout();
            this.tlpPositions.SuspendLayout();
            this.gbMembers.SuspendLayout();
            this.tlpMembers.SuspendLayout();
            this.gbCondition.SuspendLayout();
            this.tlpConditions.SuspendLayout();
            this.tbpResults.SuspendLayout();
            this.tlpResultsPage.SuspendLayout();
            this.gbColumns.SuspendLayout();
            this.tlpColumns.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.tlpResults.SuspendLayout();
            this.ssBottom.SuspendLayout();
            this.tscMain.BottomToolStripPanel.SuspendLayout();
            this.tscMain.ContentPanel.SuspendLayout();
            this.tscMain.TopToolStripPanel.SuspendLayout();
            this.tscMain.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.tlpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpSetup);
            this.tbcMain.Controls.Add(this.tbpResults);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(800, 479);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpSetup
            // 
            this.tbpSetup.Controls.Add(this.tlpSetupPage);
            this.tbpSetup.Location = new System.Drawing.Point(4, 22);
            this.tbpSetup.Name = "tbpSetup";
            this.tbpSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSetup.Size = new System.Drawing.Size(792, 453);
            this.tbpSetup.TabIndex = 2;
            this.tbpSetup.Text = "Setup";
            this.tbpSetup.UseVisualStyleBackColor = true;
            // 
            // tlpSetupPage
            // 
            this.tlpSetupPage.ColumnCount = 2;
            this.tlpSetupPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSetupPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSetupPage.Controls.Add(this.gbDetails, 1, 1);
            this.tlpSetupPage.Controls.Add(this.gbPositions, 1, 0);
            this.tlpSetupPage.Controls.Add(this.gbMembers, 0, 0);
            this.tlpSetupPage.Controls.Add(this.gbCondition, 0, 1);
            this.tlpSetupPage.Controls.Add(this.gbDate, 0, 2);
            this.tlpSetupPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSetupPage.Location = new System.Drawing.Point(3, 3);
            this.tlpSetupPage.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSetupPage.Name = "tlpSetupPage";
            this.tlpSetupPage.RowCount = 3;
            this.tlpSetupPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetupPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tlpSetupPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpSetupPage.Size = new System.Drawing.Size(786, 447);
            this.tlpSetupPage.TabIndex = 0;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tlpDetails);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Location = new System.Drawing.Point(396, 209);
            this.gbDetails.Name = "gbDetails";
            this.tlpSetupPage.SetRowSpan(this.gbDetails, 2);
            this.gbDetails.Size = new System.Drawing.Size(387, 235);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Position Details";
            // 
            // tlpDetails
            // 
            this.tlpDetails.ColumnCount = 4;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpDetails.Controls.Add(this.BtnDetSave, 2, 0);
            this.tlpDetails.Controls.Add(this.LblParent, 0, 1);
            this.tlpDetails.Controls.Add(this.cbDetParent, 1, 1);
            this.tlpDetails.Controls.Add(this.LblConditions, 0, 2);
            this.tlpDetails.Controls.Add(this.lvConditions, 1, 2);
            this.tlpDetails.Controls.Add(this.LblDetName, 0, 0);
            this.tlpDetails.Controls.Add(this.TxtDetName, 1, 0);
            this.tlpDetails.Controls.Add(this.BtnConRemove, 3, 1);
            this.tlpDetails.Controls.Add(this.BtnConAdd, 2, 1);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Location = new System.Drawing.Point(3, 16);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.RowCount = 3;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetails.Size = new System.Drawing.Size(381, 216);
            this.tlpDetails.TabIndex = 0;
            this.tlpDetails.Visible = false;
            // 
            // BtnDetSave
            // 
            this.BtnDetSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDetSave.Location = new System.Drawing.Point(297, 3);
            this.BtnDetSave.Name = "BtnDetSave";
            this.BtnDetSave.Size = new System.Drawing.Size(81, 23);
            this.BtnDetSave.TabIndex = 2;
            this.BtnDetSave.Text = "Save";
            this.BtnDetSave.UseVisualStyleBackColor = true;
            this.BtnDetSave.Click += new System.EventHandler(this.BtnDetSave_Click);
            // 
            // LblParent
            // 
            this.LblParent.AutoSize = true;
            this.LblParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblParent.Location = new System.Drawing.Point(3, 29);
            this.LblParent.Name = "LblParent";
            this.LblParent.Size = new System.Drawing.Size(59, 29);
            this.LblParent.TabIndex = 3;
            this.LblParent.Text = "Parent:";
            this.LblParent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDetParent
            // 
            this.cbDetParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDetParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDetParent.FormattingEnabled = true;
            this.cbDetParent.Location = new System.Drawing.Point(68, 32);
            this.cbDetParent.Name = "cbDetParent";
            this.cbDetParent.Size = new System.Drawing.Size(136, 21);
            this.cbDetParent.TabIndex = 4;
            this.cbDetParent.SelectedIndexChanged += new System.EventHandler(this.cbDetParent_SelectedIndexChanged);
            // 
            // LblConditions
            // 
            this.LblConditions.AutoSize = true;
            this.LblConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblConditions.Location = new System.Drawing.Point(3, 58);
            this.LblConditions.Name = "LblConditions";
            this.LblConditions.Size = new System.Drawing.Size(59, 158);
            this.LblConditions.TabIndex = 7;
            this.LblConditions.Text = "Conditions:";
            this.LblConditions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvConditions
            // 
            this.lvConditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chConName,
            this.chConType,
            this.chConValue,
            this.chConBlank});
            this.tlpDetails.SetColumnSpan(this.lvConditions, 3);
            this.lvConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConditions.GridLines = true;
            this.lvConditions.HideSelection = false;
            this.lvConditions.Location = new System.Drawing.Point(68, 61);
            this.lvConditions.MultiSelect = false;
            this.lvConditions.Name = "lvConditions";
            this.lvConditions.Size = new System.Drawing.Size(310, 152);
            this.lvConditions.TabIndex = 8;
            this.lvConditions.UseCompatibleStateImageBehavior = false;
            this.lvConditions.View = System.Windows.Forms.View.Details;
            this.lvConditions.SelectedIndexChanged += new System.EventHandler(this.lvConditions_SelectedIndexChanged);
            // 
            // chConName
            // 
            this.chConName.Text = "Name";
            // 
            // chConType
            // 
            this.chConType.Text = "Type";
            // 
            // chConValue
            // 
            this.chConValue.Text = "Value";
            // 
            // chConBlank
            // 
            this.chConBlank.Text = "";
            // 
            // LblDetName
            // 
            this.LblDetName.AutoSize = true;
            this.LblDetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDetName.Location = new System.Drawing.Point(3, 0);
            this.LblDetName.Name = "LblDetName";
            this.LblDetName.Size = new System.Drawing.Size(59, 29);
            this.LblDetName.TabIndex = 0;
            this.LblDetName.Text = "Name:";
            this.LblDetName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDetName
            // 
            this.tlpDetails.SetColumnSpan(this.TxtDetName, 2);
            this.TxtDetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDetName.Location = new System.Drawing.Point(68, 3);
            this.TxtDetName.Name = "TxtDetName";
            this.TxtDetName.Size = new System.Drawing.Size(223, 20);
            this.TxtDetName.TabIndex = 1;
            // 
            // BtnConRemove
            // 
            this.BtnConRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConRemove.Location = new System.Drawing.Point(297, 32);
            this.BtnConRemove.Name = "BtnConRemove";
            this.BtnConRemove.Size = new System.Drawing.Size(81, 23);
            this.BtnConRemove.TabIndex = 6;
            this.BtnConRemove.Text = "Remove";
            this.BtnConRemove.UseVisualStyleBackColor = true;
            this.BtnConRemove.Click += new System.EventHandler(this.BtnConRemove_Click);
            // 
            // BtnConAdd
            // 
            this.BtnConAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConAdd.Location = new System.Drawing.Point(210, 32);
            this.BtnConAdd.Name = "BtnConAdd";
            this.BtnConAdd.Size = new System.Drawing.Size(81, 23);
            this.BtnConAdd.TabIndex = 5;
            this.BtnConAdd.Text = "Add";
            this.BtnConAdd.UseVisualStyleBackColor = true;
            this.BtnConAdd.Click += new System.EventHandler(this.BtnConAdd_Click);
            // 
            // gbPositions
            // 
            this.gbPositions.Controls.Add(this.tlpPositions);
            this.gbPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPositions.Location = new System.Drawing.Point(396, 3);
            this.gbPositions.Name = "gbPositions";
            this.gbPositions.Size = new System.Drawing.Size(387, 200);
            this.gbPositions.TabIndex = 1;
            this.gbPositions.TabStop = false;
            this.gbPositions.Text = "Positions";
            // 
            // tlpPositions
            // 
            this.tlpPositions.ColumnCount = 4;
            this.tlpPositions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPositions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPositions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpPositions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpPositions.Controls.Add(this.lvPositions, 0, 1);
            this.tlpPositions.Controls.Add(this.LblName, 0, 0);
            this.tlpPositions.Controls.Add(this.TxtPosName, 1, 0);
            this.tlpPositions.Controls.Add(this.BtnPosRemove, 3, 0);
            this.tlpPositions.Controls.Add(this.BtnPosAdd, 2, 0);
            this.tlpPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPositions.Location = new System.Drawing.Point(3, 16);
            this.tlpPositions.Name = "tlpPositions";
            this.tlpPositions.RowCount = 2;
            this.tlpPositions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpPositions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPositions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPositions.Size = new System.Drawing.Size(381, 181);
            this.tlpPositions.TabIndex = 0;
            // 
            // lvPositions
            // 
            this.lvPositions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPosName,
            this.chPosParent,
            this.chPosNoCons,
            this.chPosBlank});
            this.tlpPositions.SetColumnSpan(this.lvPositions, 4);
            this.lvPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPositions.GridLines = true;
            this.lvPositions.HideSelection = false;
            this.lvPositions.Location = new System.Drawing.Point(3, 32);
            this.lvPositions.MultiSelect = false;
            this.lvPositions.Name = "lvPositions";
            this.lvPositions.Size = new System.Drawing.Size(375, 146);
            this.lvPositions.TabIndex = 4;
            this.lvPositions.UseCompatibleStateImageBehavior = false;
            this.lvPositions.View = System.Windows.Forms.View.Details;
            this.lvPositions.SelectedIndexChanged += new System.EventHandler(this.lvPositions_SelectedIndexChanged);
            // 
            // chPosName
            // 
            this.chPosName.Text = "Name";
            // 
            // chPosParent
            // 
            this.chPosParent.Text = "Parent";
            // 
            // chPosNoCons
            // 
            this.chPosNoCons.Text = "Number of Conditions";
            // 
            // chPosBlank
            // 
            this.chPosBlank.Text = "";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Location = new System.Drawing.Point(3, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(66, 29);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Enter Name:";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPosName
            // 
            this.TxtPosName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPosName.Location = new System.Drawing.Point(75, 3);
            this.TxtPosName.Name = "TxtPosName";
            this.TxtPosName.Size = new System.Drawing.Size(141, 20);
            this.TxtPosName.TabIndex = 1;
            // 
            // BtnPosRemove
            // 
            this.BtnPosRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPosRemove.Location = new System.Drawing.Point(303, 3);
            this.BtnPosRemove.Name = "BtnPosRemove";
            this.BtnPosRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnPosRemove.TabIndex = 3;
            this.BtnPosRemove.Text = "Remove";
            this.BtnPosRemove.UseVisualStyleBackColor = true;
            this.BtnPosRemove.Click += new System.EventHandler(this.BtnPosRemove_Click);
            // 
            // BtnPosAdd
            // 
            this.BtnPosAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPosAdd.Location = new System.Drawing.Point(222, 3);
            this.BtnPosAdd.Name = "BtnPosAdd";
            this.BtnPosAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnPosAdd.TabIndex = 2;
            this.BtnPosAdd.Text = "Add";
            this.BtnPosAdd.UseVisualStyleBackColor = true;
            this.BtnPosAdd.Click += new System.EventHandler(this.BtnPosAdd_Click);
            // 
            // gbMembers
            // 
            this.gbMembers.Controls.Add(this.tlpMembers);
            this.gbMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMembers.Location = new System.Drawing.Point(3, 3);
            this.gbMembers.Name = "gbMembers";
            this.gbMembers.Size = new System.Drawing.Size(387, 200);
            this.gbMembers.TabIndex = 0;
            this.gbMembers.TabStop = false;
            this.gbMembers.Text = "Members";
            // 
            // tlpMembers
            // 
            this.tlpMembers.ColumnCount = 4;
            this.tlpMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpMembers.Controls.Add(this.LblMemCID, 0, 0);
            this.tlpMembers.Controls.Add(this.lvMembers, 0, 1);
            this.tlpMembers.Controls.Add(this.BtnMemAdd, 2, 0);
            this.tlpMembers.Controls.Add(this.BtnMemRemove, 3, 0);
            this.tlpMembers.Controls.Add(this.TxtMemCID, 1, 0);
            this.tlpMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMembers.Location = new System.Drawing.Point(3, 16);
            this.tlpMembers.Name = "tlpMembers";
            this.tlpMembers.RowCount = 2;
            this.tlpMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMembers.Size = new System.Drawing.Size(381, 181);
            this.tlpMembers.TabIndex = 0;
            // 
            // LblMemCID
            // 
            this.LblMemCID.AutoSize = true;
            this.LblMemCID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMemCID.Location = new System.Drawing.Point(3, 0);
            this.LblMemCID.Name = "LblMemCID";
            this.LblMemCID.Size = new System.Drawing.Size(56, 29);
            this.LblMemCID.TabIndex = 0;
            this.LblMemCID.Text = "Enter CID:";
            this.LblMemCID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvMembers
            // 
            this.lvMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCID,
            this.chName,
            this.chRating,
            this.chBlank});
            this.tlpMembers.SetColumnSpan(this.lvMembers, 4);
            this.lvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMembers.GridLines = true;
            this.lvMembers.HideSelection = false;
            this.lvMembers.Location = new System.Drawing.Point(3, 32);
            this.lvMembers.MultiSelect = false;
            this.lvMembers.Name = "lvMembers";
            this.lvMembers.Size = new System.Drawing.Size(375, 146);
            this.lvMembers.TabIndex = 4;
            this.lvMembers.UseCompatibleStateImageBehavior = false;
            this.lvMembers.View = System.Windows.Forms.View.Details;
            // 
            // chCID
            // 
            this.chCID.Text = "CID";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // chRating
            // 
            this.chRating.Text = "Rating";
            // 
            // chBlank
            // 
            this.chBlank.Text = "";
            // 
            // BtnMemAdd
            // 
            this.BtnMemAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMemAdd.Location = new System.Drawing.Point(222, 3);
            this.BtnMemAdd.Name = "BtnMemAdd";
            this.BtnMemAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnMemAdd.TabIndex = 2;
            this.BtnMemAdd.Text = "Add";
            this.BtnMemAdd.UseVisualStyleBackColor = true;
            this.BtnMemAdd.Click += new System.EventHandler(this.BtnMemAdd_Click);
            // 
            // BtnMemRemove
            // 
            this.BtnMemRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMemRemove.Location = new System.Drawing.Point(303, 3);
            this.BtnMemRemove.Name = "BtnMemRemove";
            this.BtnMemRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnMemRemove.TabIndex = 3;
            this.BtnMemRemove.Text = "Remove";
            this.BtnMemRemove.UseVisualStyleBackColor = true;
            this.BtnMemRemove.Click += new System.EventHandler(this.BtnMemRemove_Click);
            // 
            // TxtMemCID
            // 
            this.TxtMemCID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMemCID.Location = new System.Drawing.Point(65, 3);
            this.TxtMemCID.Name = "TxtMemCID";
            this.TxtMemCID.Size = new System.Drawing.Size(151, 20);
            this.TxtMemCID.TabIndex = 1;
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.tlpConditions);
            this.gbCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCondition.Location = new System.Drawing.Point(3, 209);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(387, 158);
            this.gbCondition.TabIndex = 3;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "Condition Setup";
            // 
            // tlpConditions
            // 
            this.tlpConditions.ColumnCount = 3;
            this.tlpConditions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpConditions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConditions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpConditions.Controls.Add(this.TxtCon2, 1, 3);
            this.tlpConditions.Controls.Add(this.LblType, 0, 1);
            this.tlpConditions.Controls.Add(this.cbConType, 1, 1);
            this.tlpConditions.Controls.Add(this.LblConName, 0, 0);
            this.tlpConditions.Controls.Add(this.TxtConName, 1, 0);
            this.tlpConditions.Controls.Add(this.LblCon2, 0, 3);
            this.tlpConditions.Controls.Add(this.TxtCon1, 1, 2);
            this.tlpConditions.Controls.Add(this.LblCon1, 0, 2);
            this.tlpConditions.Controls.Add(this.BtnConSave, 2, 4);
            this.tlpConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConditions.Location = new System.Drawing.Point(3, 16);
            this.tlpConditions.Name = "tlpConditions";
            this.tlpConditions.RowCount = 5;
            this.tlpConditions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpConditions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpConditions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpConditions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpConditions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpConditions.Size = new System.Drawing.Size(381, 139);
            this.tlpConditions.TabIndex = 0;
            this.tlpConditions.Visible = false;
            // 
            // TxtCon2
            // 
            this.tlpConditions.SetColumnSpan(this.TxtCon2, 2);
            this.TxtCon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCon2.Location = new System.Drawing.Point(55, 86);
            this.TxtCon2.Name = "TxtCon2";
            this.TxtCon2.Size = new System.Drawing.Size(323, 20);
            this.TxtCon2.TabIndex = 7;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblType.Location = new System.Drawing.Point(3, 27);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(46, 29);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type:";
            this.LblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbConType
            // 
            this.tlpConditions.SetColumnSpan(this.cbConType, 2);
            this.cbConType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbConType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConType.FormattingEnabled = true;
            this.cbConType.Items.AddRange(new object[] {
            "Prefix Only",
            "Suffix Only",
            "Prefix and Suffix",
            "Specific Callsign"});
            this.cbConType.Location = new System.Drawing.Point(55, 30);
            this.cbConType.Name = "cbConType";
            this.cbConType.Size = new System.Drawing.Size(323, 21);
            this.cbConType.TabIndex = 3;
            this.cbConType.SelectedIndexChanged += new System.EventHandler(this.cbConType_SelectedIndexChanged);
            // 
            // LblConName
            // 
            this.LblConName.AutoSize = true;
            this.LblConName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblConName.Location = new System.Drawing.Point(3, 0);
            this.LblConName.Name = "LblConName";
            this.LblConName.Size = new System.Drawing.Size(46, 27);
            this.LblConName.TabIndex = 0;
            this.LblConName.Text = "Name:";
            this.LblConName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtConName
            // 
            this.tlpConditions.SetColumnSpan(this.TxtConName, 2);
            this.TxtConName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtConName.Location = new System.Drawing.Point(55, 3);
            this.TxtConName.Name = "TxtConName";
            this.TxtConName.Size = new System.Drawing.Size(323, 20);
            this.TxtConName.TabIndex = 1;
            // 
            // LblCon2
            // 
            this.LblCon2.AutoSize = true;
            this.LblCon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCon2.Location = new System.Drawing.Point(3, 83);
            this.LblCon2.Name = "LblCon2";
            this.LblCon2.Size = new System.Drawing.Size(46, 27);
            this.LblCon2.TabIndex = 6;
            this.LblCon2.Text = "Part 2:";
            this.LblCon2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCon1
            // 
            this.tlpConditions.SetColumnSpan(this.TxtCon1, 2);
            this.TxtCon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCon1.Location = new System.Drawing.Point(55, 59);
            this.TxtCon1.Name = "TxtCon1";
            this.TxtCon1.Size = new System.Drawing.Size(323, 20);
            this.TxtCon1.TabIndex = 5;
            // 
            // LblCon1
            // 
            this.LblCon1.AutoSize = true;
            this.LblCon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCon1.Location = new System.Drawing.Point(3, 56);
            this.LblCon1.Name = "LblCon1";
            this.LblCon1.Size = new System.Drawing.Size(46, 27);
            this.LblCon1.TabIndex = 4;
            this.LblCon1.Text = "Part 1:";
            this.LblCon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnConSave
            // 
            this.BtnConSave.Location = new System.Drawing.Point(303, 113);
            this.BtnConSave.Name = "BtnConSave";
            this.BtnConSave.Size = new System.Drawing.Size(75, 23);
            this.BtnConSave.TabIndex = 8;
            this.BtnConSave.Text = "Save";
            this.BtnConSave.UseVisualStyleBackColor = true;
            this.BtnConSave.Click += new System.EventHandler(this.BtnConSave_Click);
            // 
            // tbpResults
            // 
            this.tbpResults.Controls.Add(this.tlpResultsPage);
            this.tbpResults.Location = new System.Drawing.Point(4, 22);
            this.tbpResults.Name = "tbpResults";
            this.tbpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResults.Size = new System.Drawing.Size(792, 453);
            this.tbpResults.TabIndex = 1;
            this.tbpResults.Text = "Results";
            this.tbpResults.UseVisualStyleBackColor = true;
            // 
            // tlpResultsPage
            // 
            this.tlpResultsPage.ColumnCount = 2;
            this.tlpResultsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResultsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tlpResultsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpResultsPage.Controls.Add(this.gbColumns, 1, 0);
            this.tlpResultsPage.Controls.Add(this.gbResults, 0, 0);
            this.tlpResultsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResultsPage.Location = new System.Drawing.Point(3, 3);
            this.tlpResultsPage.Name = "tlpResultsPage";
            this.tlpResultsPage.RowCount = 1;
            this.tlpResultsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResultsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 447F));
            this.tlpResultsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 447F));
            this.tlpResultsPage.Size = new System.Drawing.Size(786, 447);
            this.tlpResultsPage.TabIndex = 0;
            // 
            // gbColumns
            // 
            this.gbColumns.Controls.Add(this.tlpColumns);
            this.gbColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbColumns.Location = new System.Drawing.Point(615, 3);
            this.gbColumns.Name = "gbColumns";
            this.gbColumns.Size = new System.Drawing.Size(168, 441);
            this.gbColumns.TabIndex = 1;
            this.gbColumns.TabStop = false;
            this.gbColumns.Text = "Select Columns";
            // 
            // tlpColumns
            // 
            this.tlpColumns.ColumnCount = 2;
            this.tlpColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpColumns.Controls.Add(this.BtnChildren, 1, 2);
            this.tlpColumns.Controls.Add(this.BtnParent, 0, 2);
            this.tlpColumns.Controls.Add(this.clbColumns, 0, 1);
            this.tlpColumns.Controls.Add(this.LblColumns, 0, 0);
            this.tlpColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpColumns.Location = new System.Drawing.Point(3, 16);
            this.tlpColumns.Name = "tlpColumns";
            this.tlpColumns.RowCount = 3;
            this.tlpColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpColumns.Size = new System.Drawing.Size(162, 422);
            this.tlpColumns.TabIndex = 0;
            // 
            // BtnChildren
            // 
            this.BtnChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnChildren.Location = new System.Drawing.Point(84, 396);
            this.BtnChildren.Name = "BtnChildren";
            this.BtnChildren.Size = new System.Drawing.Size(75, 23);
            this.BtnChildren.TabIndex = 3;
            this.BtnChildren.Text = "Children";
            this.BtnChildren.UseVisualStyleBackColor = true;
            this.BtnChildren.Click += new System.EventHandler(this.BtnChildren_Click);
            // 
            // BtnParent
            // 
            this.BtnParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnParent.Location = new System.Drawing.Point(3, 396);
            this.BtnParent.Name = "BtnParent";
            this.BtnParent.Size = new System.Drawing.Size(75, 23);
            this.BtnParent.TabIndex = 2;
            this.BtnParent.Text = "Parent";
            this.BtnParent.UseVisualStyleBackColor = true;
            this.BtnParent.Click += new System.EventHandler(this.BtnParent_Click);
            // 
            // clbColumns
            // 
            this.tlpColumns.SetColumnSpan(this.clbColumns, 2);
            this.clbColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbColumns.FormattingEnabled = true;
            this.clbColumns.Location = new System.Drawing.Point(3, 32);
            this.clbColumns.Name = "clbColumns";
            this.clbColumns.Size = new System.Drawing.Size(156, 358);
            this.clbColumns.TabIndex = 1;
            // 
            // LblColumns
            // 
            this.LblColumns.AutoSize = true;
            this.tlpColumns.SetColumnSpan(this.LblColumns, 2);
            this.LblColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblColumns.Location = new System.Drawing.Point(3, 0);
            this.LblColumns.Name = "LblColumns";
            this.LblColumns.Size = new System.Drawing.Size(156, 29);
            this.LblColumns.TabIndex = 0;
            this.LblColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.tlpResults);
            this.gbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResults.Location = new System.Drawing.Point(3, 3);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(606, 441);
            this.gbResults.TabIndex = 0;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // tlpResults
            // 
            this.tlpResults.ColumnCount = 3;
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResults.Controls.Add(this.lvResults, 0, 1);
            this.tlpResults.Controls.Add(this.BtnGet, 1, 0);
            this.tlpResults.Controls.Add(this.BtnRefilter, 0, 0);
            this.tlpResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResults.Location = new System.Drawing.Point(3, 16);
            this.tlpResults.Name = "tlpResults";
            this.tlpResults.RowCount = 2;
            this.tlpResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResults.Size = new System.Drawing.Size(600, 422);
            this.tlpResults.TabIndex = 0;
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chResultsCID,
            this.chResultsName,
            this.chResultsBlank});
            this.tlpResults.SetColumnSpan(this.lvResults, 3);
            this.lvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResults.GridLines = true;
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(3, 32);
            this.lvResults.MultiSelect = false;
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(594, 387);
            this.lvResults.TabIndex = 2;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // chResultsCID
            // 
            this.chResultsCID.Text = "CID";
            this.chResultsCID.Width = 35;
            // 
            // chResultsName
            // 
            this.chResultsName.Text = "Name";
            // 
            // chResultsBlank
            // 
            this.chResultsBlank.Text = "";
            // 
            // BtnGet
            // 
            this.BtnGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGet.Location = new System.Drawing.Point(84, 3);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(75, 23);
            this.BtnGet.TabIndex = 1;
            this.BtnGet.Text = "Get Data";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // BtnRefilter
            // 
            this.BtnRefilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRefilter.Location = new System.Drawing.Point(3, 3);
            this.BtnRefilter.Name = "BtnRefilter";
            this.BtnRefilter.Size = new System.Drawing.Size(75, 23);
            this.BtnRefilter.TabIndex = 0;
            this.BtnRefilter.Text = "Re-Filter";
            this.BtnRefilter.UseVisualStyleBackColor = true;
            this.BtnRefilter.Click += new System.EventHandler(this.BtnRefilter_Click);
            // 
            // ssBottom
            // 
            this.ssBottom.Dock = System.Windows.Forms.DockStyle.None;
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbStatus,
            this.tssCopyright});
            this.ssBottom.Location = new System.Drawing.Point(0, 0);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Size = new System.Drawing.Size(800, 22);
            this.ssBottom.TabIndex = 0;
            this.ssBottom.Text = "statusStrip1";
            // 
            // pbStatus
            // 
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // tssCopyright
            // 
            this.tssCopyright.Name = "tssCopyright";
            this.tssCopyright.Size = new System.Drawing.Size(683, 17);
            this.tssCopyright.Spring = true;
            this.tssCopyright.Text = "© 2020 Lenny Colton - All Rights Reserved";
            this.tssCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tscMain
            // 
            // 
            // tscMain.BottomToolStripPanel
            // 
            this.tscMain.BottomToolStripPanel.Controls.Add(this.ssBottom);
            // 
            // tscMain.ContentPanel
            // 
            this.tscMain.ContentPanel.Controls.Add(this.tbcMain);
            this.tscMain.ContentPanel.Size = new System.Drawing.Size(800, 479);
            this.tscMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMain.LeftToolStripPanelVisible = false;
            this.tscMain.Location = new System.Drawing.Point(0, 0);
            this.tscMain.Name = "tscMain";
            this.tscMain.RightToolStripPanelVisible = false;
            this.tscMain.Size = new System.Drawing.Size(800, 525);
            this.tscMain.TabIndex = 3;
            // 
            // tscMain.TopToolStripPanel
            // 
            this.tscMain.TopToolStripPanel.Controls.Add(this.msMenu);
            // 
            // msMenu
            // 
            this.msMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileToolStripMenuItem,
            this.saveProfileToolStripMenuItem,
            this.exportResultsToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.loadProfileToolStripMenuItem.Text = "Load Profile";
            this.loadProfileToolStripMenuItem.Click += new System.EventHandler(this.loadProfileToolStripMenuItem_Click);
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.saveProfileToolStripMenuItem.Text = "Save Profile";
            this.saveProfileToolStripMenuItem.Click += new System.EventHandler(this.saveProfileToolStripMenuItem_Click);
            // 
            // exportResultsToolStripMenuItem
            // 
            this.exportResultsToolStripMenuItem.Name = "exportResultsToolStripMenuItem";
            this.exportResultsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.exportResultsToolStripMenuItem.Text = "Export Results";
            this.exportResultsToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "csv";
            this.sfdExport.Filter = "CSV (Comma delimited)|*.csv";
            this.sfdExport.Title = "Export Results";
            // 
            // sfdProfile
            // 
            this.sfdProfile.DefaultExt = "xml";
            this.sfdProfile.Filter = "XML|*.xml";
            this.sfdProfile.Title = "Save Profile";
            // 
            // ofdProfile
            // 
            this.ofdProfile.DefaultExt = "xml";
            this.ofdProfile.Filter = "XML|*.xml|All Files|*.*";
            this.ofdProfile.Title = "Load Profile";
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.tlpDate);
            this.gbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDate.Location = new System.Drawing.Point(3, 373);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(387, 71);
            this.gbDate.TabIndex = 4;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date Range";
            // 
            // tlpDate
            // 
            this.tlpDate.ColumnCount = 3;
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDate.Controls.Add(this.cbDatEnd, 2, 1);
            this.tlpDate.Controls.Add(this.LblDatStart, 0, 0);
            this.tlpDate.Controls.Add(this.LblDatEnd, 0, 1);
            this.tlpDate.Controls.Add(this.dtpDatStart, 1, 0);
            this.tlpDate.Controls.Add(this.dtpDatEnd, 1, 1);
            this.tlpDate.Controls.Add(this.cbDatStart, 2, 0);
            this.tlpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDate.Location = new System.Drawing.Point(3, 16);
            this.tlpDate.Name = "tlpDate";
            this.tlpDate.RowCount = 2;
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDate.Size = new System.Drawing.Size(381, 52);
            this.tlpDate.TabIndex = 0;
            // 
            // LblDatStart
            // 
            this.LblDatStart.AutoSize = true;
            this.LblDatStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDatStart.Location = new System.Drawing.Point(3, 0);
            this.LblDatStart.Name = "LblDatStart";
            this.LblDatStart.Size = new System.Drawing.Size(32, 26);
            this.LblDatStart.TabIndex = 0;
            this.LblDatStart.Text = "Start:";
            this.LblDatStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDatEnd
            // 
            this.LblDatEnd.AutoSize = true;
            this.LblDatEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDatEnd.Location = new System.Drawing.Point(3, 26);
            this.LblDatEnd.Name = "LblDatEnd";
            this.LblDatEnd.Size = new System.Drawing.Size(32, 26);
            this.LblDatEnd.TabIndex = 1;
            this.LblDatEnd.Text = "End:";
            this.LblDatEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDatStart
            // 
            this.dtpDatStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDatStart.Enabled = false;
            this.dtpDatStart.Location = new System.Drawing.Point(41, 3);
            this.dtpDatStart.Name = "dtpDatStart";
            this.dtpDatStart.Size = new System.Drawing.Size(317, 20);
            this.dtpDatStart.TabIndex = 2;
            // 
            // dtpDatEnd
            // 
            this.dtpDatEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDatEnd.Enabled = false;
            this.dtpDatEnd.Location = new System.Drawing.Point(41, 29);
            this.dtpDatEnd.Name = "dtpDatEnd";
            this.dtpDatEnd.Size = new System.Drawing.Size(317, 20);
            this.dtpDatEnd.TabIndex = 3;
            // 
            // cbDatStart
            // 
            this.cbDatStart.AutoSize = true;
            this.cbDatStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDatStart.Location = new System.Drawing.Point(364, 3);
            this.cbDatStart.Name = "cbDatStart";
            this.cbDatStart.Size = new System.Drawing.Size(14, 20);
            this.cbDatStart.TabIndex = 4;
            this.cbDatStart.UseVisualStyleBackColor = true;
            this.cbDatStart.CheckedChanged += new System.EventHandler(this.cbDatStart_CheckedChanged);
            // 
            // cbDatEnd
            // 
            this.cbDatEnd.AutoSize = true;
            this.cbDatEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDatEnd.Location = new System.Drawing.Point(364, 29);
            this.cbDatEnd.Name = "cbDatEnd";
            this.cbDatEnd.Size = new System.Drawing.Size(14, 20);
            this.cbDatEnd.TabIndex = 5;
            this.cbDatEnd.UseVisualStyleBackColor = true;
            this.cbDatEnd.CheckedChanged += new System.EventHandler(this.cbDatEnd_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.tscMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(521, 335);
            this.Name = "Main";
            this.Text = "VATSIM Hours Compiler";
            this.tbcMain.ResumeLayout(false);
            this.tbpSetup.ResumeLayout(false);
            this.tlpSetupPage.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.gbPositions.ResumeLayout(false);
            this.tlpPositions.ResumeLayout(false);
            this.tlpPositions.PerformLayout();
            this.gbMembers.ResumeLayout(false);
            this.tlpMembers.ResumeLayout(false);
            this.tlpMembers.PerformLayout();
            this.gbCondition.ResumeLayout(false);
            this.tlpConditions.ResumeLayout(false);
            this.tlpConditions.PerformLayout();
            this.tbpResults.ResumeLayout(false);
            this.tlpResultsPage.ResumeLayout(false);
            this.gbColumns.ResumeLayout(false);
            this.tlpColumns.ResumeLayout(false);
            this.tlpColumns.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.tlpResults.ResumeLayout(false);
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.tscMain.BottomToolStripPanel.ResumeLayout(false);
            this.tscMain.BottomToolStripPanel.PerformLayout();
            this.tscMain.ContentPanel.ResumeLayout(false);
            this.tscMain.TopToolStripPanel.ResumeLayout(false);
            this.tscMain.TopToolStripPanel.PerformLayout();
            this.tscMain.ResumeLayout(false);
            this.tscMain.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.tlpDate.ResumeLayout(false);
            this.tlpDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpResults;
        private System.Windows.Forms.TableLayoutPanel tlpResultsPage;
        private System.Windows.Forms.CheckedListBox clbColumns;
        private System.Windows.Forms.Button BtnParent;
        private System.Windows.Forms.Button BtnGet;
        private System.Windows.Forms.Button BtnChildren;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader chResultsCID;
        private System.Windows.Forms.ColumnHeader chResultsName;
        private System.ComponentModel.BackgroundWorker bgwAPI;
        private System.Windows.Forms.TabPage tbpSetup;
        private System.Windows.Forms.TableLayoutPanel tlpSetupPage;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Button BtnDetSave;
        private System.Windows.Forms.Label LblParent;
        private System.Windows.Forms.ComboBox cbDetParent;
        private System.Windows.Forms.Label LblConditions;
        private System.Windows.Forms.ListView lvConditions;
        private System.Windows.Forms.ColumnHeader chConName;
        private System.Windows.Forms.ColumnHeader chConType;
        private System.Windows.Forms.ColumnHeader chConValue;
        private System.Windows.Forms.ColumnHeader chConBlank;
        private System.Windows.Forms.Label LblDetName;
        private System.Windows.Forms.TextBox TxtDetName;
        private System.Windows.Forms.Button BtnConRemove;
        private System.Windows.Forms.Button BtnConAdd;
        private System.Windows.Forms.GroupBox gbPositions;
        private System.Windows.Forms.TableLayoutPanel tlpPositions;
        private System.Windows.Forms.ListView lvPositions;
        private System.Windows.Forms.ColumnHeader chPosName;
        private System.Windows.Forms.ColumnHeader chPosParent;
        private System.Windows.Forms.ColumnHeader chPosNoCons;
        private System.Windows.Forms.ColumnHeader chPosBlank;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtPosName;
        private System.Windows.Forms.Button BtnPosRemove;
        private System.Windows.Forms.Button BtnPosAdd;
        private System.Windows.Forms.GroupBox gbMembers;
        private System.Windows.Forms.TableLayoutPanel tlpMembers;
        private System.Windows.Forms.Label LblMemCID;
        private System.Windows.Forms.ListView lvMembers;
        private System.Windows.Forms.ColumnHeader chCID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chRating;
        private System.Windows.Forms.ColumnHeader chBlank;
        private System.Windows.Forms.Button BtnMemAdd;
        private System.Windows.Forms.Button BtnMemRemove;
        private System.Windows.Forms.TextBox TxtMemCID;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.TableLayoutPanel tlpConditions;
        private System.Windows.Forms.TextBox TxtCon2;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.ComboBox cbConType;
        private System.Windows.Forms.Label LblConName;
        private System.Windows.Forms.TextBox TxtConName;
        private System.Windows.Forms.Label LblCon2;
        private System.Windows.Forms.TextBox TxtCon1;
        private System.Windows.Forms.Label LblCon1;
        private System.Windows.Forms.Button BtnConSave;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.ToolStripContainer tscMain;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.ColumnHeader chResultsBlank;
        private System.Windows.Forms.Button BtnRefilter;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportResultsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbColumns;
        private System.Windows.Forms.TableLayoutPanel tlpColumns;
        private System.Windows.Forms.Label LblColumns;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.TableLayoutPanel tlpResults;
        private System.Windows.Forms.SaveFileDialog sfdProfile;
        private System.Windows.Forms.OpenFileDialog ofdProfile;
        private System.Windows.Forms.ToolStripStatusLabel tssCopyright;
        private System.ComponentModel.BackgroundWorker bgwExport;
        private System.ComponentModel.BackgroundWorker bgwLoadProfile;
        private System.ComponentModel.BackgroundWorker bgwSaveProfile;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private System.Windows.Forms.CheckBox cbDatEnd;
        private System.Windows.Forms.Label LblDatStart;
        private System.Windows.Forms.Label LblDatEnd;
        private System.Windows.Forms.DateTimePicker dtpDatStart;
        private System.Windows.Forms.DateTimePicker dtpDatEnd;
        private System.Windows.Forms.CheckBox cbDatStart;
    }
}

