namespace HistoryViewer
{
    partial class HistoryViewer
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnGetTime = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtmTo = new System.Windows.Forms.DateTimePicker();
            this.dtmFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnlTop.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTo);
            this.pnlTop.Controls.Add(this.btnFilter);
            this.pnlTop.Controls.Add(this.btnGetTime);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.dtmTo);
            this.pnlTop.Controls.Add(this.dtmFrom);
            this.pnlTop.Controls.Add(this.lblFrom);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(935, 91);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(235, 16);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 12);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(568, 7);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(130, 32);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnGetTime
            // 
            this.btnGetTime.Location = new System.Drawing.Point(295, 43);
            this.btnGetTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetTime.Name = "btnGetTime";
            this.btnGetTime.Size = new System.Drawing.Size(130, 32);
            this.btnGetTime.TabIndex = 5;
            this.btnGetTime.Text = "Get Time";
            this.btnGetTime.UseVisualStyleBackColor = true;
            this.btnGetTime.Click += new System.EventHandler(this.btnGetTime_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(434, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtmTo
            // 
            this.dtmTo.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtmTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTo.Location = new System.Drawing.Point(260, 14);
            this.dtmTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtmTo.Name = "dtmTo";
            this.dtmTo.Size = new System.Drawing.Size(160, 21);
            this.dtmTo.TabIndex = 3;
            this.dtmTo.ValueChanged += new System.EventHandler(this.dtmTo_ValueChanged);
            // 
            // dtmFrom
            // 
            this.dtmFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFrom.Location = new System.Drawing.Point(66, 14);
            this.dtmFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtmFrom.Name = "dtmFrom";
            this.dtmFrom.Size = new System.Drawing.Size(129, 21);
            this.dtmFrom.TabIndex = 2;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(29, 16);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(34, 12);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.fpSpread1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 91);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(935, 451);
            this.pnlBody.TabIndex = 1;
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.Location = new System.Drawing.Point(0, 0);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(935, 451);
            this.fpSpread1.TabIndex = 3;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // HistoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 542);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistoryViewer";
            this.Text = "History Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DateTimePicker dtmTo;
        private System.Windows.Forms.DateTimePicker dtmFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGetTime;
        private System.Windows.Forms.Button btnFilter;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
    }
}

