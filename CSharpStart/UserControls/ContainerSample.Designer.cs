namespace WindowsFormsApp5.UserControls
{
    partial class ContainerSample
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerSample));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDockBottom = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDockTop = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDupPanel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firstMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 920);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.SplitterWidth = 16;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 203);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 717);
            this.panel2.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 175);
            this.splitter1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(248, 28);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 175);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer2.Panel1.Controls.Add(this.panel4);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Size = new System.Drawing.Size(811, 920);
            this.splitContainer2.SplitterDistance = 363;
            this.splitContainer2.SplitterWidth = 16;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDockBottom);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 745);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 175);
            this.panel4.TabIndex = 1;
            // 
            // lblDockBottom
            // 
            this.lblDockBottom.AutoSize = true;
            this.lblDockBottom.Location = new System.Drawing.Point(41, 32);
            this.lblDockBottom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDockBottom.Name = "lblDockBottom";
            this.lblDockBottom.Size = new System.Drawing.Size(122, 21);
            this.lblDockBottom.TabIndex = 2;
            this.lblDockBottom.Text = "Dock Bottom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDockTop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 175);
            this.panel3.TabIndex = 0;
            // 
            // lblDockTop
            // 
            this.lblDockTop.AutoSize = true;
            this.lblDockTop.Location = new System.Drawing.Point(24, 26);
            this.lblDockTop.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDockTop.Name = "lblDockTop";
            this.lblDockTop.Size = new System.Drawing.Size(95, 21);
            this.lblDockTop.TabIndex = 1;
            this.lblDockTop.Text = "Dock Top";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 920);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblDupPanel);
            this.panel6.Controls.Add(this.menuStrip1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(432, 920);
            this.panel6.TabIndex = 0;
            // 
            // lblDupPanel
            // 
            this.lblDupPanel.AutoSize = true;
            this.lblDupPanel.Location = new System.Drawing.Point(25, 26);
            this.lblDupPanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDupPanel.Name = "lblDupPanel";
            this.lblDupPanel.Size = new System.Drawing.Size(174, 21);
            this.lblDupPanel.TabIndex = 0;
            this.lblDupPanel.Text = "panel이 겹친 경우";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firstMenuToolStripMenuItem
            // 
            this.firstMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.firstMenuToolStripMenuItem.Name = "firstMenuToolStripMenuItem";
            this.firstMenuToolStripMenuItem.Size = new System.Drawing.Size(129, 34);
            this.firstMenuToolStripMenuItem.Text = "First Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsdToolStripMenuItem,
            this.sdfsdfToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.BackgroundImage")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem4.Text = "3";
            // 
            // sdfsdToolStripMenuItem
            // 
            this.sdfsdToolStripMenuItem.Name = "sdfsdToolStripMenuItem";
            this.sdfsdToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.sdfsdToolStripMenuItem.Text = "sdfsd";
            // 
            // sdfsdfToolStripMenuItem
            // 
            this.sdfsdfToolStripMenuItem.Name = "sdfsdfToolStripMenuItem";
            this.sdfsdfToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.sdfsdfToolStripMenuItem.Text = "sdfsdf";
            this.sdfsdfToolStripMenuItem.Click += new System.EventHandler(this.sdfsdfToolStripMenuItem_Click);
            // 
            // ContainerSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ContainerSample";
            this.Size = new System.Drawing.Size(1075, 920);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDupPanel;
        private System.Windows.Forms.Label lblDockBottom;
        private System.Windows.Forms.Label lblDockTop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firstMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sdfsdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfsdfToolStripMenuItem;
    }
}
