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
            this.BtnConAdd = new System.Windows.Forms.Button();
            this.LblParent = new System.Windows.Forms.Label();
            this.cbParent = new System.Windows.Forms.ComboBox();
            this.LblConditions = new System.Windows.Forms.Label();
            this.lvConditions = new System.Windows.Forms.ListView();
            this.chConName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chConType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chConValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnConRemove = new System.Windows.Forms.Button();
            this.gbPositions = new System.Windows.Forms.GroupBox();
            this.tlpPositions = new System.Windows.Forms.TableLayoutPanel();
            this.lvPositions = new System.Windows.Forms.ListView();
            this.chPosName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosParent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosNoCons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.chLastLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnMemAdd = new System.Windows.Forms.Button();
            this.BtnMemRemove = new System.Windows.Forms.Button();
            this.TxtMemCID = new System.Windows.Forms.TextBox();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.LblConName = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtConName = new System.Windows.Forms.TextBox();
            this.LblCon2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblCon1 = new System.Windows.Forms.Label();
            this.tbpResults = new System.Windows.Forms.TabPage();
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
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tbcMain.Size = new System.Drawing.Size(800, 450);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpSetup
            // 
            this.tbpSetup.Controls.Add(this.tableLayoutPanel1);
            this.tbpSetup.Location = new System.Drawing.Point(4, 22);
            this.tbpSetup.Name = "tbpSetup";
            this.tbpSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSetup.Size = new System.Drawing.Size(792, 424);
            this.tbpSetup.TabIndex = 0;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tlpDetails);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Location = new System.Drawing.Point(396, 286);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(387, 129);
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
            this.tlpDetails.Controls.Add(this.BtnConAdd, 2, 0);
            this.tlpDetails.Controls.Add(this.LblParent, 0, 0);
            this.tlpDetails.Controls.Add(this.cbParent, 1, 0);
            this.tlpDetails.Controls.Add(this.LblConditions, 0, 1);
            this.tlpDetails.Controls.Add(this.lvConditions, 1, 1);
            this.tlpDetails.Controls.Add(this.BtnConRemove, 3, 0);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Location = new System.Drawing.Point(3, 16);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.RowCount = 2;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Size = new System.Drawing.Size(381, 110);
            this.tlpDetails.TabIndex = 2;
            // 
            // BtnConAdd
            // 
            this.BtnConAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConAdd.Location = new System.Drawing.Point(210, 3);
            this.BtnConAdd.Name = "BtnConAdd";
            this.BtnConAdd.Size = new System.Drawing.Size(81, 23);
            this.BtnConAdd.TabIndex = 12;
            this.BtnConAdd.Text = "Add";
            this.BtnConAdd.UseVisualStyleBackColor = true;
            // 
            // LblParent
            // 
            this.LblParent.AutoSize = true;
            this.LblParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblParent.Location = new System.Drawing.Point(3, 0);
            this.LblParent.Name = "LblParent";
            this.LblParent.Size = new System.Drawing.Size(59, 29);
            this.LblParent.TabIndex = 0;
            this.LblParent.Text = "Parent:";
            this.LblParent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbParent
            // 
            this.cbParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParent.FormattingEnabled = true;
            this.cbParent.Location = new System.Drawing.Point(68, 3);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(136, 21);
            this.cbParent.TabIndex = 2;
            // 
            // LblConditions
            // 
            this.LblConditions.AutoSize = true;
            this.LblConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblConditions.Location = new System.Drawing.Point(3, 29);
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
            this.chConValue});
            this.tlpDetails.SetColumnSpan(this.lvConditions, 3);
            this.lvConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConditions.GridLines = true;
            this.lvConditions.HideSelection = false;
            this.lvConditions.Location = new System.Drawing.Point(68, 32);
            this.lvConditions.MultiSelect = false;
            this.lvConditions.Name = "lvConditions";
            this.lvConditions.Size = new System.Drawing.Size(310, 75);
            this.lvConditions.TabIndex = 3;
            this.lvConditions.UseCompatibleStateImageBehavior = false;
            this.lvConditions.View = System.Windows.Forms.View.Details;
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
            // BtnConRemove
            // 
            this.BtnConRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConRemove.Location = new System.Drawing.Point(297, 3);
            this.BtnConRemove.Name = "BtnConRemove";
            this.BtnConRemove.Size = new System.Drawing.Size(81, 23);
            this.BtnConRemove.TabIndex = 10;
            this.BtnConRemove.Text = "Remove";
            this.BtnConRemove.UseVisualStyleBackColor = true;
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
            this.tlpPositions.Size = new System.Drawing.Size(381, 258);
            this.tlpPositions.TabIndex = 7;
            // 
            // lvPositions
            // 
            this.lvPositions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPosName,
            this.chPosParent,
            this.chPosNoCons});
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
            this.chLastLogin,
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
            // chLastLogin
            // 
            this.chLastLogin.Text = "Last Login";
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
            this.gbCondition.Controls.Add(this.tableLayoutPanel2);
            this.gbCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCondition.Location = new System.Drawing.Point(3, 286);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(387, 129);
            this.gbCondition.TabIndex = 12;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "Condition Setup";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.LblType, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblConName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtConName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblCon2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LblCon1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 110);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox3, 2);
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(47, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 20);
            this.textBox3.TabIndex = 21;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblType.Location = new System.Drawing.Point(3, 27);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(38, 29);
            this.LblType.TabIndex = 0;
            this.LblType.Text = "Type:";
            this.LblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbType
            // 
            this.cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(47, 30);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(250, 21);
            this.cbType.TabIndex = 13;
            // 
            // LblConName
            // 
            this.LblConName.AutoSize = true;
            this.LblConName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblConName.Location = new System.Drawing.Point(3, 0);
            this.LblConName.Name = "LblConName";
            this.LblConName.Size = new System.Drawing.Size(38, 27);
            this.LblConName.TabIndex = 16;
            this.LblConName.Text = "Name:";
            this.LblConName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(303, 30);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtConName
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TxtConName, 2);
            this.TxtConName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtConName.Location = new System.Drawing.Point(47, 3);
            this.TxtConName.Name = "TxtConName";
            this.TxtConName.Size = new System.Drawing.Size(331, 20);
            this.TxtConName.TabIndex = 17;
            // 
            // LblCon2
            // 
            this.LblCon2.AutoSize = true;
            this.LblCon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCon2.Location = new System.Drawing.Point(3, 83);
            this.LblCon2.Name = "LblCon2";
            this.LblCon2.Size = new System.Drawing.Size(38, 27);
            this.LblCon2.TabIndex = 19;
            this.LblCon2.Text = "Part 2:";
            this.LblCon2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox2, 2);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(47, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 20);
            this.textBox2.TabIndex = 20;
            // 
            // LblCon1
            // 
            this.LblCon1.AutoSize = true;
            this.LblCon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCon1.Location = new System.Drawing.Point(3, 56);
            this.LblCon1.Name = "LblCon1";
            this.LblCon1.Size = new System.Drawing.Size(38, 27);
            this.LblCon1.TabIndex = 18;
            this.LblCon1.Text = "Part 1:";
            this.LblCon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbpResults
            // 
            this.tbpResults.Location = new System.Drawing.Point(4, 22);
            this.tbpResults.Name = "tbpResults";
            this.tbpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResults.Size = new System.Drawing.Size(792, 424);
            this.tbpResults.TabIndex = 1;
            this.tbpResults.Text = "Results";
            this.tbpResults.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcMain);
            this.MinimumSize = new System.Drawing.Size(521, 260);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpSetup;
        private System.Windows.Forms.TabPage tbpResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbPositions;
        private System.Windows.Forms.GroupBox gbMembers;
        private System.Windows.Forms.TableLayoutPanel tlpMembers;
        private System.Windows.Forms.ListView lvMembers;
        private System.Windows.Forms.ColumnHeader chCID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chRating;
        private System.Windows.Forms.ColumnHeader chLastLogin;
        private System.Windows.Forms.ColumnHeader chBlank;
        private System.Windows.Forms.Label LblMemCID;
        private System.Windows.Forms.Button BtnMemAdd;
        private System.Windows.Forms.Button BtnMemRemove;
        private System.Windows.Forms.TextBox TxtMemCID;
        private System.Windows.Forms.TableLayoutPanel tlpPositions;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnPosAdd;
        private System.Windows.Forms.Button BtnPosRemove;
        private System.Windows.Forms.TextBox TxtPosName;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Button BtnConAdd;
        private System.Windows.Forms.Label LblParent;
        private System.Windows.Forms.ComboBox cbParent;
        private System.Windows.Forms.Label LblConditions;
        private System.Windows.Forms.ListView lvConditions;
        private System.Windows.Forms.ColumnHeader chConName;
        private System.Windows.Forms.ColumnHeader chConType;
        private System.Windows.Forms.ColumnHeader chConValue;
        private System.Windows.Forms.Button BtnConRemove;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LblConName;
        private System.Windows.Forms.TextBox TxtConName;
        private System.Windows.Forms.Label LblCon2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblCon1;
        private System.Windows.Forms.ListView lvPositions;
        private System.Windows.Forms.ColumnHeader chPosName;
        private System.Windows.Forms.ColumnHeader chPosParent;
        private System.Windows.Forms.ColumnHeader chPosNoCons;
    }
}

