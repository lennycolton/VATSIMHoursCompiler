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
            this.tbpResults = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbMembers = new System.Windows.Forms.GroupBox();
            this.gbPositions = new System.Windows.Forms.GroupBox();
            this.tbcMain.SuspendLayout();
            this.tbpSetup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbPositions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbMembers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbMembers
            // 
            this.gbMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMembers.Location = new System.Drawing.Point(3, 3);
            this.gbMembers.Name = "gbMembers";
            this.gbMembers.Size = new System.Drawing.Size(387, 412);
            this.gbMembers.TabIndex = 0;
            this.gbMembers.TabStop = false;
            this.gbMembers.Text = "Members";
            // 
            // gbPositions
            // 
            this.gbPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPositions.Location = new System.Drawing.Point(396, 3);
            this.gbPositions.Name = "gbPositions";
            this.gbPositions.Size = new System.Drawing.Size(387, 412);
            this.gbPositions.TabIndex = 0;
            this.gbPositions.TabStop = false;
            this.gbPositions.Text = "Positions";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcMain);
            this.Name = "Main";
            this.Text = "VATSIM Hours Compiler";
            this.tbcMain.ResumeLayout(false);
            this.tbpSetup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpSetup;
        private System.Windows.Forms.TabPage tbpResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbPositions;
        private System.Windows.Forms.GroupBox gbMembers;
    }
}

