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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpSetup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lvResults = new System.Windows.Forms.ListView();
            this.chResultsCID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResultsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResultsBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clbColumns = new System.Windows.Forms.CheckedListBox();
            this.BtnParent = new System.Windows.Forms.Button();
            this.BtnGet = new System.Windows.Forms.Button();
            this.BtnChildren = new System.Windows.Forms.Button();
            this.LblCurrent = new System.Windows.Forms.Label();
            this.bgwMembers = new System.ComponentModel.BackgroundWorker();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.BtnRefilter = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.tbcMain.SuspendLayout();
            this.tbpSetup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.gbPositions.SuspendLayout();
            this.tlpPositions.SuspendLayout();
            this.gbMembers.SuspendLayout();
            this.tlpMembers.SuspendLayout();
            this.gbCondition.SuspendLayout();
            this.tlpConditions.SuspendLayout();
            this.tbpResults.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ssBottom.SuspendLayout();
            this.tscMain.BottomToolStripPanel.SuspendLayout();
            this.tscMain.ContentPanel.SuspendLayout();
            this.tscMain.SuspendLayout();
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
            this.tbpSetup.Controls.Add(this.tableLayoutPanel1);
            this.tbpSetup.Location = new System.Drawing.Point(4, 22);
            this.tbpSetup.Name = "tbpSetup";
            this.tbpSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSetup.Size = new System.Drawing.Size(792, 453);
            this.tbpSetup.TabIndex = 2;
            this.tbpSetup.Text = "Setup";
            this.tbpSetup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbDetails, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbPositions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbMembers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbCondition, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tlpDetails);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Location = new System.Drawing.Point(396, 286);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(387, 158);
            this.gbDetails.TabIndex = 11;
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
            this.tlpDetails.Size = new System.Drawing.Size(381, 139);
            this.tlpDetails.TabIndex = 2;
            this.tlpDetails.Visible = false;
            // 
            // BtnDetSave
            // 
            this.BtnDetSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDetSave.Location = new System.Drawing.Point(297, 3);
            this.BtnDetSave.Name = "BtnDetSave";
            this.BtnDetSave.Size = new System.Drawing.Size(81, 23);
            this.BtnDetSave.TabIndex = 15;
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
            this.LblParent.TabIndex = 0;
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
            this.cbDetParent.TabIndex = 2;
            // 
            // LblConditions
            // 
            this.LblConditions.AutoSize = true;
            this.LblConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblConditions.Location = new System.Drawing.Point(3, 58);
            this.LblConditions.Name = "LblConditions";
            this.LblConditions.Size = new System.Drawing.Size(59, 81);
            this.LblConditions.TabIndex = 1;
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
            this.lvConditions.Size = new System.Drawing.Size(310, 75);
            this.lvConditions.TabIndex = 3;
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
            this.LblDetName.TabIndex = 13;
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
            this.TxtDetName.TabIndex = 14;
            // 
            // BtnConRemove
            // 
            this.BtnConRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConRemove.Location = new System.Drawing.Point(297, 32);
            this.BtnConRemove.Name = "BtnConRemove";
            this.BtnConRemove.Size = new System.Drawing.Size(81, 23);
            this.BtnConRemove.TabIndex = 10;
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
            this.BtnConAdd.TabIndex = 12;
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
            this.gbPositions.Size = new System.Drawing.Size(387, 277);
            this.gbPositions.TabIndex = 0;
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
            this.tlpPositions.Size = new System.Drawing.Size(381, 258);
            this.tlpPositions.TabIndex = 7;
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
            this.lvPositions.Size = new System.Drawing.Size(375, 223);
            this.lvPositions.TabIndex = 10;
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
            this.TxtPosName.TabIndex = 9;
            // 
            // BtnPosRemove
            // 
            this.BtnPosRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPosRemove.Location = new System.Drawing.Point(303, 3);
            this.BtnPosRemove.Name = "BtnPosRemove";
            this.BtnPosRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnPosRemove.TabIndex = 8;
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
            this.BtnPosAdd.TabIndex = 7;
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
            this.gbMembers.Size = new System.Drawing.Size(387, 277);
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
            this.tlpMembers.Size = new System.Drawing.Size(381, 258);
            this.tlpMembers.TabIndex = 1;
            // 
            // LblMemCID
            // 
            this.LblMemCID.AutoSize = true;
            this.LblMemCID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMemCID.Location = new System.Drawing.Point(3, 0);
            this.LblMemCID.Name = "LblMemCID";
            this.LblMemCID.Size = new System.Drawing.Size(56, 29);
            this.LblMemCID.TabIndex = 6;
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
            this.lvMembers.Size = new System.Drawing.Size(375, 223);
            this.lvMembers.TabIndex = 0;
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
            this.BtnMemAdd.TabIndex = 1;
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
            this.BtnMemRemove.TabIndex = 2;
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
            this.TxtMemCID.TabIndex = 3;
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.tlpConditions);
            this.gbCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCondition.Location = new System.Drawing.Point(3, 286);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(387, 158);
            this.gbCondition.TabIndex = 12;
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
            this.TxtCon2.TabIndex = 21;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblType.Location = new System.Drawing.Point(3, 27);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(46, 29);
            this.LblType.TabIndex = 0;
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
            this.cbConType.TabIndex = 13;
            this.cbConType.SelectedIndexChanged += new System.EventHandler(this.cbConType_SelectedIndexChanged);
            // 
            // LblConName
            // 
            this.LblConName.AutoSize = true;
            this.LblConName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblConName.Location = new System.Drawing.Point(3, 0);
            this.LblConName.Name = "LblConName";
            this.LblConName.Size = new System.Drawing.Size(46, 27);
            this.LblConName.TabIndex = 16;
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
            this.TxtConName.TabIndex = 17;
            // 
            // LblCon2
            // 
            this.LblCon2.AutoSize = true;
            this.LblCon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCon2.Location = new System.Drawing.Point(3, 83);
            this.LblCon2.Name = "LblCon2";
            this.LblCon2.Size = new System.Drawing.Size(46, 27);
            this.LblCon2.TabIndex = 19;
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
            this.TxtCon1.TabIndex = 20;
            // 
            // LblCon1
            // 
            this.LblCon1.AutoSize = true;
            this.LblCon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCon1.Location = new System.Drawing.Point(3, 56);
            this.LblCon1.Name = "LblCon1";
            this.LblCon1.Size = new System.Drawing.Size(46, 27);
            this.LblCon1.TabIndex = 18;
            this.LblCon1.Text = "Part 1:";
            this.LblCon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnConSave
            // 
            this.BtnConSave.Location = new System.Drawing.Point(303, 113);
            this.BtnConSave.Name = "BtnConSave";
            this.BtnConSave.Size = new System.Drawing.Size(75, 23);
            this.BtnConSave.TabIndex = 14;
            this.BtnConSave.Text = "Save";
            this.BtnConSave.UseVisualStyleBackColor = true;
            this.BtnConSave.Click += new System.EventHandler(this.BtnConSave_Click);
            // 
            // tbpResults
            // 
            this.tbpResults.Controls.Add(this.tableLayoutPanel2);
            this.tbpResults.Location = new System.Drawing.Point(4, 22);
            this.tbpResults.Name = "tbpResults";
            this.tbpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResults.Size = new System.Drawing.Size(792, 453);
            this.tbpResults.TabIndex = 1;
            this.tbpResults.Text = "Results";
            this.tbpResults.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Controls.Add(this.lvResults, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.clbColumns, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblCurrent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnParent, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnGet, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnRefilter, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnChildren, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnExport, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 447);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chResultsCID,
            this.chResultsName,
            this.chResultsBlank});
            this.tableLayoutPanel2.SetColumnSpan(this.lvResults, 2);
            this.lvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResults.GridLines = true;
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(3, 32);
            this.lvResults.MultiSelect = false;
            this.lvResults.Name = "lvResults";
            this.tableLayoutPanel2.SetRowSpan(this.lvResults, 2);
            this.lvResults.Size = new System.Drawing.Size(618, 412);
            this.lvResults.TabIndex = 5;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // chResultsCID
            // 
            this.chResultsCID.Text = "CID";
            // 
            // chResultsName
            // 
            this.chResultsName.Text = "Name";
            // 
            // chResultsBlank
            // 
            this.chResultsBlank.Text = "";
            // 
            // clbColumns
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.clbColumns, 2);
            this.clbColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbColumns.FormattingEnabled = true;
            this.clbColumns.Location = new System.Drawing.Point(627, 32);
            this.clbColumns.Name = "clbColumns";
            this.clbColumns.Size = new System.Drawing.Size(156, 383);
            this.clbColumns.TabIndex = 1;
            // 
            // BtnParent
            // 
            this.BtnParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnParent.Location = new System.Drawing.Point(627, 421);
            this.BtnParent.Name = "BtnParent";
            this.BtnParent.Size = new System.Drawing.Size(75, 23);
            this.BtnParent.TabIndex = 2;
            this.BtnParent.Text = "Parent";
            this.BtnParent.UseVisualStyleBackColor = true;
            this.BtnParent.Click += new System.EventHandler(this.BtnParent_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGet.Location = new System.Drawing.Point(708, 3);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(75, 23);
            this.BtnGet.TabIndex = 1;
            this.BtnGet.Text = "Get Data";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // BtnChildren
            // 
            this.BtnChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnChildren.Location = new System.Drawing.Point(708, 421);
            this.BtnChildren.Name = "BtnChildren";
            this.BtnChildren.Size = new System.Drawing.Size(75, 23);
            this.BtnChildren.TabIndex = 3;
            this.BtnChildren.Text = "Children";
            this.BtnChildren.UseVisualStyleBackColor = true;
            this.BtnChildren.Click += new System.EventHandler(this.BtnChildren_Click);
            // 
            // LblCurrent
            // 
            this.LblCurrent.AutoSize = true;
            this.LblCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCurrent.Location = new System.Drawing.Point(3, 0);
            this.LblCurrent.Name = "LblCurrent";
            this.LblCurrent.Size = new System.Drawing.Size(537, 29);
            this.LblCurrent.TabIndex = 4;
            this.LblCurrent.Tag = "";
            this.LblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ssBottom
            // 
            this.ssBottom.Dock = System.Windows.Forms.DockStyle.None;
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbStatus});
            this.ssBottom.Location = new System.Drawing.Point(0, 0);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Size = new System.Drawing.Size(800, 22);
            this.ssBottom.TabIndex = 2;
            this.ssBottom.Text = "statusStrip1";
            // 
            // pbStatus
            // 
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 16);
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
            this.tscMain.Size = new System.Drawing.Size(800, 501);
            this.tscMain.TabIndex = 3;
            this.tscMain.TopToolStripPanelVisible = false;
            // 
            // BtnRefilter
            // 
            this.BtnRefilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRefilter.Location = new System.Drawing.Point(627, 3);
            this.BtnRefilter.Name = "BtnRefilter";
            this.BtnRefilter.Size = new System.Drawing.Size(75, 23);
            this.BtnRefilter.TabIndex = 6;
            this.BtnRefilter.Text = "Re-Filter";
            this.BtnRefilter.UseVisualStyleBackColor = true;
            this.BtnRefilter.Click += new System.EventHandler(this.BtnRefilter_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExport.Location = new System.Drawing.Point(546, 3);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 7;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.tscMain);
            this.MinimumSize = new System.Drawing.Size(521, 311);
            this.Name = "Main";
            this.Text = "VATSIM Hours Compiler";
            this.tbcMain.ResumeLayout(false);
            this.tbpSetup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.tscMain.BottomToolStripPanel.ResumeLayout(false);
            this.tscMain.BottomToolStripPanel.PerformLayout();
            this.tscMain.ContentPanel.ResumeLayout(false);
            this.tscMain.ResumeLayout(false);
            this.tscMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox clbColumns;
        private System.Windows.Forms.Button BtnParent;
        private System.Windows.Forms.Button BtnGet;
        private System.Windows.Forms.Button BtnChildren;
        private System.Windows.Forms.Label LblCurrent;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader chResultsCID;
        private System.Windows.Forms.ColumnHeader chResultsName;
        private System.ComponentModel.BackgroundWorker bgwMembers;
        private System.Windows.Forms.TabPage tbpSetup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Button BtnExport;
    }
}

