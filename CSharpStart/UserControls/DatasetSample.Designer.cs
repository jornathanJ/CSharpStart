namespace WindowsFormsApp5.UserControls
{
    partial class DatasetSample
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
            this.btnCreateDataSet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBindDataSet = new System.Windows.Forms.Button();
            this.tbxRow = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.tbxColumn = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.btnGetValue = new System.Windows.Forms.Button();
            this.btnSetValue = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.lblRemoveRow = new System.Windows.Forms.Label();
            this.tbxRemoveRow = new System.Windows.Forms.TextBox();
            this.btnDataTableSelect = new System.Windows.Forms.Button();
            this.btnDataTableFilter = new System.Windows.Forms.Button();
            this.lblSelectColumn = new System.Windows.Forms.Label();
            this.tbxSelectTargetColumn = new System.Windows.Forms.TextBox();
            this.lblSelectValue = new System.Windows.Forms.Label();
            this.tbxSelectTargetValue = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDataSet
            // 
            this.btnCreateDataSet.Location = new System.Drawing.Point(28, 31);
            this.btnCreateDataSet.Name = "btnCreateDataSet";
            this.btnCreateDataSet.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDataSet.TabIndex = 0;
            this.btnCreateDataSet.Text = "Create Dataset";
            this.btnCreateDataSet.UseVisualStyleBackColor = true;
            this.btnCreateDataSet.Click += new System.EventHandler(this.btnCreateDataSet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(396, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnBindDataSet
            // 
            this.btnBindDataSet.Location = new System.Drawing.Point(128, 31);
            this.btnBindDataSet.Name = "btnBindDataSet";
            this.btnBindDataSet.Size = new System.Drawing.Size(120, 23);
            this.btnBindDataSet.TabIndex = 2;
            this.btnBindDataSet.Text = "Bind dataset";
            this.btnBindDataSet.UseVisualStyleBackColor = true;
            this.btnBindDataSet.Click += new System.EventHandler(this.btnBindDataSet_Click);
            // 
            // tbxRow
            // 
            this.tbxRow.Location = new System.Drawing.Point(28, 271);
            this.tbxRow.Name = "tbxRow";
            this.tbxRow.Size = new System.Drawing.Size(100, 21);
            this.tbxRow.TabIndex = 3;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(31, 253);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(30, 12);
            this.lblRow.TabIndex = 5;
            this.lblRow.Text = "Row";
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(148, 253);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(49, 12);
            this.lblColumn.TabIndex = 7;
            this.lblColumn.Text = "Column";
            // 
            // tbxColumn
            // 
            this.tbxColumn.Location = new System.Drawing.Point(144, 271);
            this.tbxColumn.Name = "tbxColumn";
            this.tbxColumn.Size = new System.Drawing.Size(100, 21);
            this.tbxColumn.TabIndex = 6;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(265, 253);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 12);
            this.lblValue.TabIndex = 9;
            this.lblValue.Text = "Value";
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(260, 271);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(100, 21);
            this.tbxValue.TabIndex = 8;
            // 
            // btnGetValue
            // 
            this.btnGetValue.Location = new System.Drawing.Point(28, 311);
            this.btnGetValue.Name = "btnGetValue";
            this.btnGetValue.Size = new System.Drawing.Size(152, 23);
            this.btnGetValue.TabIndex = 10;
            this.btnGetValue.Text = "Get Value";
            this.btnGetValue.UseVisualStyleBackColor = true;
            this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
            // 
            // btnSetValue
            // 
            this.btnSetValue.Location = new System.Drawing.Point(208, 311);
            this.btnSetValue.Name = "btnSetValue";
            this.btnSetValue.Size = new System.Drawing.Size(152, 23);
            this.btnSetValue.TabIndex = 11;
            this.btnSetValue.Text = "Set Value";
            this.btnSetValue.UseVisualStyleBackColor = true;
            this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(395, 271);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(152, 23);
            this.btnAddRow.TabIndex = 12;
            this.btnAddRow.Text = "Add row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(395, 311);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(152, 23);
            this.btnRemoveRow.TabIndex = 13;
            this.btnRemoveRow.Text = "Remove row";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // lblRemoveRow
            // 
            this.lblRemoveRow.AutoSize = true;
            this.lblRemoveRow.Location = new System.Drawing.Point(563, 316);
            this.lblRemoveRow.Name = "lblRemoveRow";
            this.lblRemoveRow.Size = new System.Drawing.Size(111, 12);
            this.lblRemoveRow.TabIndex = 15;
            this.lblRemoveRow.Text = "Remove row index";
            // 
            // tbxRemoveRow
            // 
            this.tbxRemoveRow.Location = new System.Drawing.Point(680, 311);
            this.tbxRemoveRow.Name = "tbxRemoveRow";
            this.tbxRemoveRow.Size = new System.Drawing.Size(100, 21);
            this.tbxRemoveRow.TabIndex = 14;
            // 
            // btnDataTableSelect
            // 
            this.btnDataTableSelect.Location = new System.Drawing.Point(395, 369);
            this.btnDataTableSelect.Name = "btnDataTableSelect";
            this.btnDataTableSelect.Size = new System.Drawing.Size(152, 23);
            this.btnDataTableSelect.TabIndex = 16;
            this.btnDataTableSelect.Text = "DataTable.Select";
            this.btnDataTableSelect.UseVisualStyleBackColor = true;
            this.btnDataTableSelect.Click += new System.EventHandler(this.btnDataTableSelect_Click);
            // 
            // btnDataTableFilter
            // 
            this.btnDataTableFilter.Location = new System.Drawing.Point(395, 419);
            this.btnDataTableFilter.Name = "btnDataTableFilter";
            this.btnDataTableFilter.Size = new System.Drawing.Size(152, 23);
            this.btnDataTableFilter.TabIndex = 17;
            this.btnDataTableFilter.Text = "DataTable Filter";
            this.btnDataTableFilter.UseVisualStyleBackColor = true;
            this.btnDataTableFilter.Click += new System.EventHandler(this.btnDataTableFilter_Click);
            // 
            // lblSelectColumn
            // 
            this.lblSelectColumn.AutoSize = true;
            this.lblSelectColumn.Location = new System.Drawing.Point(563, 357);
            this.lblSelectColumn.Name = "lblSelectColumn";
            this.lblSelectColumn.Size = new System.Drawing.Size(88, 12);
            this.lblSelectColumn.TabIndex = 19;
            this.lblSelectColumn.Text = "Select Column";
            // 
            // tbxSelectTargetColumn
            // 
            this.tbxSelectTargetColumn.Location = new System.Drawing.Point(680, 352);
            this.tbxSelectTargetColumn.Name = "tbxSelectTargetColumn";
            this.tbxSelectTargetColumn.Size = new System.Drawing.Size(100, 21);
            this.tbxSelectTargetColumn.TabIndex = 18;
            // 
            // lblSelectValue
            // 
            this.lblSelectValue.AutoSize = true;
            this.lblSelectValue.Location = new System.Drawing.Point(563, 384);
            this.lblSelectValue.Name = "lblSelectValue";
            this.lblSelectValue.Size = new System.Drawing.Size(76, 12);
            this.lblSelectValue.TabIndex = 21;
            this.lblSelectValue.Text = "Select Value";
            // 
            // tbxSelectTargetValue
            // 
            this.tbxSelectTargetValue.Location = new System.Drawing.Point(680, 379);
            this.tbxSelectTargetValue.Name = "tbxSelectTargetValue";
            this.tbxSelectTargetValue.Size = new System.Drawing.Size(100, 21);
            this.tbxSelectTargetValue.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(430, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(396, 150);
            this.dataGridView2.TabIndex = 22;
            // 
            // DatasetSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblSelectValue);
            this.Controls.Add(this.tbxSelectTargetValue);
            this.Controls.Add(this.lblSelectColumn);
            this.Controls.Add(this.tbxSelectTargetColumn);
            this.Controls.Add(this.btnDataTableFilter);
            this.Controls.Add(this.btnDataTableSelect);
            this.Controls.Add(this.lblRemoveRow);
            this.Controls.Add(this.tbxRemoveRow);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnSetValue);
            this.Controls.Add(this.btnGetValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.tbxColumn);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.tbxRow);
            this.Controls.Add(this.btnBindDataSet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreateDataSet);
            this.Name = "DatasetSample";
            this.Size = new System.Drawing.Size(830, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBindDataSet;
        private System.Windows.Forms.TextBox tbxRow;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.TextBox tbxColumn;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Button btnGetValue;
        private System.Windows.Forms.Button btnSetValue;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Label lblRemoveRow;
        private System.Windows.Forms.TextBox tbxRemoveRow;
        private System.Windows.Forms.Button btnDataTableSelect;
        private System.Windows.Forms.Button btnDataTableFilter;
        private System.Windows.Forms.Label lblSelectColumn;
        private System.Windows.Forms.TextBox tbxSelectTargetColumn;
        private System.Windows.Forms.Label lblSelectValue;
        private System.Windows.Forms.TextBox tbxSelectTargetValue;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
