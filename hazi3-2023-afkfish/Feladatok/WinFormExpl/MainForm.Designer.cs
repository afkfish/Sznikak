namespace WinFormExpl
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            miOpen = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            tContent = new TextBox();
            detailsPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            lCreated = new Label();
            lName = new Label();
            reloadTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            detailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(989, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miOpen, miExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // miOpen
            // 
            miOpen.Name = "miOpen";
            miOpen.Size = new Size(158, 34);
            miOpen.Text = "Open";
            miOpen.Click += miOpen_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(158, 34);
            miExit.Text = "Exit";
            miExit.Click += exitToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tContent);
            splitContainer1.Panel2.Controls.Add(detailsPanel);
            splitContainer1.Size = new Size(989, 586);
            splitContainer1.SplitterDistance = 486;
            splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(486, 586);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Size";
            columnHeader2.Width = 200;
            // 
            // tContent
            // 
            tContent.Dock = DockStyle.Fill;
            tContent.Location = new Point(0, 142);
            tContent.Multiline = true;
            tContent.Name = "tContent";
            tContent.Size = new Size(499, 444);
            tContent.TabIndex = 1;
            // 
            // detailsPanel
            // 
            detailsPanel.Controls.Add(label2);
            detailsPanel.Controls.Add(label1);
            detailsPanel.Controls.Add(lCreated);
            detailsPanel.Controls.Add(lName);
            detailsPanel.Dock = DockStyle.Top;
            detailsPanel.Location = new Point(0, 0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(499, 142);
            detailsPanel.TabIndex = 0;
            detailsPanel.Paint += detailsPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 89);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 3;
            label2.Text = "Created:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // lCreated
            // 
            lCreated.AutoSize = true;
            lCreated.Location = new Point(139, 89);
            lCreated.Name = "lCreated";
            lCreated.Size = new Size(0, 25);
            lCreated.TabIndex = 1;
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Location = new Point(139, 37);
            lName.Name = "lName";
            lName.Size = new Size(0, 25);
            lName.TabIndex = 0;
            // 
            // reloadTimer
            // 
            reloadTimer.Tick += reloadTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 619);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MiniExplorer-JOYAXJ";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miExit;
        private SplitContainer splitContainer1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox tContent;
        private Panel detailsPanel;
        private Label lCreated;
        private Label lName;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer reloadTimer;
    }
}