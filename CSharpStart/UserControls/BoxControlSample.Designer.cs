namespace WindowsFormsApp5.UserControls
{
    partial class BoxControlSample
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxControlSample));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rTbxResult = new System.Windows.Forms.RichTextBox();
            this.btnGetCbxStatus = new System.Windows.Forms.Button();
            this.btnSetCheckedListBox = new System.Windows.Forms.Button();
            this.btnGetCheckListBox = new System.Windows.Forms.Button();
            this.btnSetComboBox = new System.Windows.Forms.Button();
            this.btnGetComboBox = new System.Windows.Forms.Button();
            this.btnGetListBox = new System.Windows.Forms.Button();
            this.btnSetListBox = new System.Windows.Forms.Button();
            this.btnGetMaskedTextBox = new System.Windows.Forms.Button();
            this.btnSetMaskedTextBox = new System.Windows.Forms.Button();
            this.btnSetImageBox = new System.Windows.Forms.Button();
            this.btnGetRadioStatus = new System.Windows.Forms.Button();
            this.btnGetRichTextBox = new System.Windows.Forms.Button();
            this.btnSetRichTextBox = new System.Windows.Forms.Button();
            this.btnGetTextBox = new System.Windows.Forms.Button();
            this.btnSetTextBox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnChangeRadioBoxStatus = new System.Windows.Forms.Button();
            this.lblSampleText = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSetImageBoxFromImageList = new System.Windows.Forms.Button();
            this.btnBlink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(17, 43);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(17, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(17, 312);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(204, 21);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(17, 405);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 41);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(2, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(275, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rTbxResult
            // 
            this.rTbxResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.rTbxResult.Location = new System.Drawing.Point(530, 0);
            this.rTbxResult.Name = "rTbxResult";
            this.rTbxResult.Size = new System.Drawing.Size(397, 479);
            this.rTbxResult.TabIndex = 9;
            this.rTbxResult.Text = "";
            // 
            // btnGetCbxStatus
            // 
            this.btnGetCbxStatus.Location = new System.Drawing.Point(146, 13);
            this.btnGetCbxStatus.Name = "btnGetCbxStatus";
            this.btnGetCbxStatus.Size = new System.Drawing.Size(75, 23);
            this.btnGetCbxStatus.TabIndex = 10;
            this.btnGetCbxStatus.Text = "상태확인";
            this.btnGetCbxStatus.UseVisualStyleBackColor = true;
            this.btnGetCbxStatus.Click += new System.EventHandler(this.btnGetCbxStatus_Click);
            // 
            // btnSetCheckedListBox
            // 
            this.btnSetCheckedListBox.Location = new System.Drawing.Point(146, 43);
            this.btnSetCheckedListBox.Name = "btnSetCheckedListBox";
            this.btnSetCheckedListBox.Size = new System.Drawing.Size(75, 23);
            this.btnSetCheckedListBox.TabIndex = 11;
            this.btnSetCheckedListBox.Text = "값 넣기";
            this.btnSetCheckedListBox.UseVisualStyleBackColor = true;
            this.btnSetCheckedListBox.Click += new System.EventHandler(this.btnSetCheckedListBox_Click);
            // 
            // btnGetCheckListBox
            // 
            this.btnGetCheckListBox.Location = new System.Drawing.Point(146, 72);
            this.btnGetCheckListBox.Name = "btnGetCheckListBox";
            this.btnGetCheckListBox.Size = new System.Drawing.Size(75, 23);
            this.btnGetCheckListBox.TabIndex = 12;
            this.btnGetCheckListBox.Text = "가져오기";
            this.btnGetCheckListBox.UseVisualStyleBackColor = true;
            this.btnGetCheckListBox.Click += new System.EventHandler(this.btnGetCheckListBox_Click);
            // 
            // btnSetComboBox
            // 
            this.btnSetComboBox.Location = new System.Drawing.Point(146, 149);
            this.btnSetComboBox.Name = "btnSetComboBox";
            this.btnSetComboBox.Size = new System.Drawing.Size(75, 23);
            this.btnSetComboBox.TabIndex = 13;
            this.btnSetComboBox.Text = "값 넣기";
            this.btnSetComboBox.UseVisualStyleBackColor = true;
            this.btnSetComboBox.Click += new System.EventHandler(this.btnSetComboBox_Click);
            // 
            // btnGetComboBox
            // 
            this.btnGetComboBox.Location = new System.Drawing.Point(146, 178);
            this.btnGetComboBox.Name = "btnGetComboBox";
            this.btnGetComboBox.Size = new System.Drawing.Size(75, 23);
            this.btnGetComboBox.TabIndex = 14;
            this.btnGetComboBox.Text = "가져오기";
            this.btnGetComboBox.UseVisualStyleBackColor = true;
            this.btnGetComboBox.Click += new System.EventHandler(this.btnGetComboBox_Click);
            // 
            // btnGetListBox
            // 
            this.btnGetListBox.Location = new System.Drawing.Point(146, 237);
            this.btnGetListBox.Name = "btnGetListBox";
            this.btnGetListBox.Size = new System.Drawing.Size(75, 23);
            this.btnGetListBox.TabIndex = 16;
            this.btnGetListBox.Text = "가져오기";
            this.btnGetListBox.UseVisualStyleBackColor = true;
            this.btnGetListBox.Click += new System.EventHandler(this.btnGetListBox_Click);
            // 
            // btnSetListBox
            // 
            this.btnSetListBox.Location = new System.Drawing.Point(146, 208);
            this.btnSetListBox.Name = "btnSetListBox";
            this.btnSetListBox.Size = new System.Drawing.Size(75, 23);
            this.btnSetListBox.TabIndex = 15;
            this.btnSetListBox.Text = "값 넣기";
            this.btnSetListBox.UseVisualStyleBackColor = true;
            this.btnSetListBox.Click += new System.EventHandler(this.btnSetListBox_Click);
            // 
            // btnGetMaskedTextBox
            // 
            this.btnGetMaskedTextBox.Location = new System.Drawing.Point(146, 363);
            this.btnGetMaskedTextBox.Name = "btnGetMaskedTextBox";
            this.btnGetMaskedTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnGetMaskedTextBox.TabIndex = 18;
            this.btnGetMaskedTextBox.Text = "가져오기";
            this.btnGetMaskedTextBox.UseVisualStyleBackColor = true;
            this.btnGetMaskedTextBox.Click += new System.EventHandler(this.btnGetMaskedTextBox_Click);
            // 
            // btnSetMaskedTextBox
            // 
            this.btnSetMaskedTextBox.Location = new System.Drawing.Point(146, 334);
            this.btnSetMaskedTextBox.Name = "btnSetMaskedTextBox";
            this.btnSetMaskedTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnSetMaskedTextBox.TabIndex = 17;
            this.btnSetMaskedTextBox.Text = "값 넣기";
            this.btnSetMaskedTextBox.UseVisualStyleBackColor = true;
            this.btnSetMaskedTextBox.Click += new System.EventHandler(this.btnSetMaskedTextBox_Click);
            // 
            // btnSetImageBox
            // 
            this.btnSetImageBox.Location = new System.Drawing.Point(146, 405);
            this.btnSetImageBox.Name = "btnSetImageBox";
            this.btnSetImageBox.Size = new System.Drawing.Size(131, 23);
            this.btnSetImageBox.TabIndex = 19;
            this.btnSetImageBox.Text = "그림 넣기 1";
            this.btnSetImageBox.UseVisualStyleBackColor = true;
            this.btnSetImageBox.Click += new System.EventHandler(this.btnSetImageBox_Click);
            // 
            // btnGetRadioStatus
            // 
            this.btnGetRadioStatus.Location = new System.Drawing.Point(398, 20);
            this.btnGetRadioStatus.Name = "btnGetRadioStatus";
            this.btnGetRadioStatus.Size = new System.Drawing.Size(75, 23);
            this.btnGetRadioStatus.TabIndex = 21;
            this.btnGetRadioStatus.Text = "상태확인";
            this.btnGetRadioStatus.UseVisualStyleBackColor = true;
            this.btnGetRadioStatus.Click += new System.EventHandler(this.btnGetRadioStatus_Click);
            // 
            // btnGetRichTextBox
            // 
            this.btnGetRichTextBox.Location = new System.Drawing.Point(398, 177);
            this.btnGetRichTextBox.Name = "btnGetRichTextBox";
            this.btnGetRichTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnGetRichTextBox.TabIndex = 24;
            this.btnGetRichTextBox.Text = "가져오기";
            this.btnGetRichTextBox.UseVisualStyleBackColor = true;
            this.btnGetRichTextBox.Click += new System.EventHandler(this.btnGetRichTextBox_Click);
            // 
            // btnSetRichTextBox
            // 
            this.btnSetRichTextBox.Location = new System.Drawing.Point(398, 148);
            this.btnSetRichTextBox.Name = "btnSetRichTextBox";
            this.btnSetRichTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnSetRichTextBox.TabIndex = 23;
            this.btnSetRichTextBox.Text = "값 넣기";
            this.btnSetRichTextBox.UseVisualStyleBackColor = true;
            this.btnSetRichTextBox.Click += new System.EventHandler(this.btnSetRichTextBox_Click);
            // 
            // btnGetTextBox
            // 
            this.btnGetTextBox.Location = new System.Drawing.Point(398, 314);
            this.btnGetTextBox.Name = "btnGetTextBox";
            this.btnGetTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnGetTextBox.TabIndex = 26;
            this.btnGetTextBox.Text = "가져오기";
            this.btnGetTextBox.UseVisualStyleBackColor = true;
            this.btnGetTextBox.Click += new System.EventHandler(this.btnGetTextBox_Click);
            // 
            // btnSetTextBox
            // 
            this.btnSetTextBox.Location = new System.Drawing.Point(398, 285);
            this.btnSetTextBox.Name = "btnSetTextBox";
            this.btnSetTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnSetTextBox.TabIndex = 25;
            this.btnSetTextBox.Text = "값 넣기";
            this.btnSetTextBox.UseVisualStyleBackColor = true;
            this.btnSetTextBox.Click += new System.EventHandler(this.btnSetTextBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(275, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(2, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnChangeRadioBoxStatus
            // 
            this.btnChangeRadioBoxStatus.Location = new System.Drawing.Point(398, 65);
            this.btnChangeRadioBoxStatus.Name = "btnChangeRadioBoxStatus";
            this.btnChangeRadioBoxStatus.Size = new System.Drawing.Size(75, 23);
            this.btnChangeRadioBoxStatus.TabIndex = 28;
            this.btnChangeRadioBoxStatus.Text = "다른 항목 선택";
            this.btnChangeRadioBoxStatus.UseVisualStyleBackColor = true;
            this.btnChangeRadioBoxStatus.Click += new System.EventHandler(this.btnChangeRadioBoxStatus_Click);
            // 
            // lblSampleText
            // 
            this.lblSampleText.AutoSize = true;
            this.lblSampleText.Location = new System.Drawing.Point(327, 453);
            this.lblSampleText.Name = "lblSampleText";
            this.lblSampleText.Size = new System.Drawing.Size(132, 12);
            this.lblSampleText.TabIndex = 29;
            this.lblSampleText.Text = "Label을 활용 하는 방식";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BISTel_Logo.png");
            // 
            // btnSetImageBoxFromImageList
            // 
            this.btnSetImageBoxFromImageList.Location = new System.Drawing.Point(146, 434);
            this.btnSetImageBoxFromImageList.Name = "btnSetImageBoxFromImageList";
            this.btnSetImageBoxFromImageList.Size = new System.Drawing.Size(131, 23);
            this.btnSetImageBoxFromImageList.TabIndex = 30;
            this.btnSetImageBoxFromImageList.Text = "그림 넣기 2";
            this.btnSetImageBoxFromImageList.UseVisualStyleBackColor = true;
            this.btnSetImageBoxFromImageList.Click += new System.EventHandler(this.btnSetImageBoxFromImageList_Click);
            // 
            // btnBlink
            // 
            this.btnBlink.Location = new System.Drawing.Point(320, 374);
            this.btnBlink.Name = "btnBlink";
            this.btnBlink.Size = new System.Drawing.Size(153, 23);
            this.btnBlink.TabIndex = 31;
            this.btnBlink.Text = "깜빡이게 하기";
            this.btnBlink.UseVisualStyleBackColor = true;
            this.btnBlink.Click += new System.EventHandler(this.btnBlink_Click);
            // 
            // BoxControlSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBlink);
            this.Controls.Add(this.btnSetImageBoxFromImageList);
            this.Controls.Add(this.lblSampleText);
            this.Controls.Add(this.btnChangeRadioBoxStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetTextBox);
            this.Controls.Add(this.btnSetTextBox);
            this.Controls.Add(this.btnGetRichTextBox);
            this.Controls.Add(this.btnSetRichTextBox);
            this.Controls.Add(this.btnGetRadioStatus);
            this.Controls.Add(this.btnSetImageBox);
            this.Controls.Add(this.btnGetMaskedTextBox);
            this.Controls.Add(this.btnSetMaskedTextBox);
            this.Controls.Add(this.btnGetListBox);
            this.Controls.Add(this.btnSetListBox);
            this.Controls.Add(this.btnGetComboBox);
            this.Controls.Add(this.btnSetComboBox);
            this.Controls.Add(this.btnGetCheckListBox);
            this.Controls.Add(this.btnSetCheckedListBox);
            this.Controls.Add(this.btnGetCbxStatus);
            this.Controls.Add(this.rTbxResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkBox1);
            this.Name = "BoxControlSample";
            this.Size = new System.Drawing.Size(927, 479);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rTbxResult;
        private System.Windows.Forms.Button btnGetCbxStatus;
        private System.Windows.Forms.Button btnSetCheckedListBox;
        private System.Windows.Forms.Button btnGetCheckListBox;
        private System.Windows.Forms.Button btnSetComboBox;
        private System.Windows.Forms.Button btnGetComboBox;
        private System.Windows.Forms.Button btnGetListBox;
        private System.Windows.Forms.Button btnSetListBox;
        private System.Windows.Forms.Button btnGetMaskedTextBox;
        private System.Windows.Forms.Button btnSetMaskedTextBox;
        private System.Windows.Forms.Button btnSetImageBox;
        private System.Windows.Forms.Button btnGetRadioStatus;
        private System.Windows.Forms.Button btnGetRichTextBox;
        private System.Windows.Forms.Button btnSetRichTextBox;
        private System.Windows.Forms.Button btnGetTextBox;
        private System.Windows.Forms.Button btnSetTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnChangeRadioBoxStatus;
        private System.Windows.Forms.Label lblSampleText;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSetImageBoxFromImageList;
        private System.Windows.Forms.Button btnBlink;
    }
}
