namespace WindowsFormsApp5
{
    partial class SampleForm1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.boxControlSample1 = new WindowsFormsApp5.UserControls.BoxControlSample();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.containerSample1 = new WindowsFormsApp5.UserControls.ContainerSample();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.datasetSample1 = new WindowsFormsApp5.UserControls.DatasetSample();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 529);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.boxControlSample1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Box 계열 Sample";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // boxControlSample1
            // 
            this.boxControlSample1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxControlSample1.Location = new System.Drawing.Point(3, 3);
            this.boxControlSample1.Name = "boxControlSample1";
            this.boxControlSample1.Size = new System.Drawing.Size(980, 497);
            this.boxControlSample1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.containerSample1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // containerSample1
            // 
            this.containerSample1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerSample1.Location = new System.Drawing.Point(3, 3);
            this.containerSample1.Name = "containerSample1";
            this.containerSample1.Size = new System.Drawing.Size(980, 497);
            this.containerSample1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.datasetSample1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(986, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DataSet";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // datasetSample1
            // 
            this.datasetSample1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetSample1.Location = new System.Drawing.Point(0, 0);
            this.datasetSample1.Name = "datasetSample1";
            this.datasetSample1.Size = new System.Drawing.Size(986, 503);
            this.datasetSample1.TabIndex = 0;
            // 
            // SampleForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 529);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SampleForm1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.BoxControlSample boxControlSample1;
        private UserControls.ContainerSample containerSample1;
        private System.Windows.Forms.TabPage tabPage3;
        private UserControls.DatasetSample datasetSample1;
    }
}

