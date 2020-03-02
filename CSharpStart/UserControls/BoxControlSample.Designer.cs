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
            this.btnWebServiceCall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 35);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 25);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(27, 75);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(186, 120);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 264);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(27, 364);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 151);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(27, 546);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(318, 32);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(27, 709);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 72);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 47);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(140, 25);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(432, 259);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(155, 165);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 457);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 32);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rTbxResult
            // 
            this.rTbxResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.rTbxResult.Location = new System.Drawing.Point(835, 0);
            this.rTbxResult.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rTbxResult.Name = "rTbxResult";
            this.rTbxResult.Size = new System.Drawing.Size(622, 838);
            this.rTbxResult.TabIndex = 9;
            this.rTbxResult.Text = "";
            // 
            // btnGetCbxStatus
            // 
            this.btnGetCbxStatus.Location = new System.Drawing.Point(229, 23);
            this.btnGetCbxStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetCbxStatus.Name = "btnGetCbxStatus";
            this.btnGetCbxStatus.Size = new System.Drawing.Size(118, 40);
            this.btnGetCbxStatus.TabIndex = 10;
            this.btnGetCbxStatus.Text = "상태확인";
            this.btnGetCbxStatus.UseVisualStyleBackColor = true;
            this.btnGetCbxStatus.Click += new System.EventHandler(this.btnGetCbxStatus_Click);
            // 
            // btnSetCheckedListBox
            // 
            this.btnSetCheckedListBox.Location = new System.Drawing.Point(229, 75);
            this.btnSetCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetCheckedListBox.Name = "btnSetCheckedListBox";
            this.btnSetCheckedListBox.Size = new System.Drawing.Size(118, 40);
            this.btnSetCheckedListBox.TabIndex = 11;
            this.btnSetCheckedListBox.Text = "값 넣기";
            this.btnSetCheckedListBox.UseVisualStyleBackColor = true;
            this.btnSetCheckedListBox.Click += new System.EventHandler(this.btnSetCheckedListBox_Click);
            // 
            // btnGetCheckListBox
            // 
            this.btnGetCheckListBox.Location = new System.Drawing.Point(229, 126);
            this.btnGetCheckListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetCheckListBox.Name = "btnGetCheckListBox";
            this.btnGetCheckListBox.Size = new System.Drawing.Size(118, 40);
            this.btnGetCheckListBox.TabIndex = 12;
            this.btnGetCheckListBox.Text = "가져오기";
            this.btnGetCheckListBox.UseVisualStyleBackColor = true;
            this.btnGetCheckListBox.Click += new System.EventHandler(this.btnGetCheckListBox_Click);
            // 
            // btnSetComboBox
            // 
            this.btnSetComboBox.Location = new System.Drawing.Point(229, 261);
            this.btnSetComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetComboBox.Name = "btnSetComboBox";
            this.btnSetComboBox.Size = new System.Drawing.Size(118, 40);
            this.btnSetComboBox.TabIndex = 13;
            this.btnSetComboBox.Text = "값 넣기";
            this.btnSetComboBox.UseVisualStyleBackColor = true;
            this.btnSetComboBox.Click += new System.EventHandler(this.btnSetComboBox_Click);
            // 
            // btnGetComboBox
            // 
            this.btnGetComboBox.Location = new System.Drawing.Point(229, 312);
            this.btnGetComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetComboBox.Name = "btnGetComboBox";
            this.btnGetComboBox.Size = new System.Drawing.Size(118, 40);
            this.btnGetComboBox.TabIndex = 14;
            this.btnGetComboBox.Text = "가져오기";
            this.btnGetComboBox.UseVisualStyleBackColor = true;
            this.btnGetComboBox.Click += new System.EventHandler(this.btnGetComboBox_Click);
            // 
            // btnGetListBox
            // 
            this.btnGetListBox.Location = new System.Drawing.Point(229, 415);
            this.btnGetListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetListBox.Name = "btnGetListBox";
            this.btnGetListBox.Size = new System.Drawing.Size(118, 40);
            this.btnGetListBox.TabIndex = 16;
            this.btnGetListBox.Text = "가져오기";
            this.btnGetListBox.UseVisualStyleBackColor = true;
            this.btnGetListBox.Click += new System.EventHandler(this.btnGetListBox_Click);
            // 
            // btnSetListBox
            // 
            this.btnSetListBox.Location = new System.Drawing.Point(229, 364);
            this.btnSetListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetListBox.Name = "btnSetListBox";
            this.btnSetListBox.Size = new System.Drawing.Size(118, 40);
            this.btnSetListBox.TabIndex = 15;
            this.btnSetListBox.Text = "값 넣기";
            this.btnSetListBox.UseVisualStyleBackColor = true;
            this.btnSetListBox.Click += new System.EventHandler(this.btnSetListBox_Click);
            // 
            // btnGetMaskedTextBox
            // 
            this.btnGetMaskedTextBox.Location = new System.Drawing.Point(229, 635);
            this.btnGetMaskedTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetMaskedTextBox.Name = "btnGetMaskedTextBox";
            this.btnGetMaskedTextBox.Size = new System.Drawing.Size(118, 40);
            this.btnGetMaskedTextBox.TabIndex = 18;
            this.btnGetMaskedTextBox.Text = "가져오기";
            this.btnGetMaskedTextBox.UseVisualStyleBackColor = true;
            this.btnGetMaskedTextBox.Click += new System.EventHandler(this.btnGetMaskedTextBox_Click);
            // 
            // btnSetMaskedTextBox
            // 
            this.btnSetMaskedTextBox.Location = new System.Drawing.Point(229, 584);
            this.btnSetMaskedTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetMaskedTextBox.Name = "btnSetMaskedTextBox";
            this.btnSetMaskedTextBox.Size = new System.Drawing.Size(118, 40);
            this.btnSetMaskedTextBox.TabIndex = 17;
            this.btnSetMaskedTextBox.Text = "값 넣기";
            this.btnSetMaskedTextBox.UseVisualStyleBackColor = true;
            this.btnSetMaskedTextBox.Click += new System.EventHandler(this.btnSetMaskedTextBox_Click);
            // 
            // btnSetImageBox
            // 
            this.btnSetImageBox.Location = new System.Drawing.Point(229, 709);
            this.btnSetImageBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetImageBox.Name = "btnSetImageBox";
            this.btnSetImageBox.Size = new System.Drawing.Size(206, 40);
            this.btnSetImageBox.TabIndex = 19;
            this.btnSetImageBox.Text = "그림 넣기 1";
            this.btnSetImageBox.UseVisualStyleBackColor = true;
            this.btnSetImageBox.Click += new System.EventHandler(this.btnSetImageBox_Click);
            // 
            // btnGetRadioStatus
            // 
            this.btnGetRadioStatus.Location = new System.Drawing.Point(625, 35);
            this.btnGetRadioStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetRadioStatus.Name = "btnGetRadioStatus";
            this.btnGetRadioStatus.Size = new System.Drawing.Size(118, 40);
            this.btnGetRadioStatus.TabIndex = 21;
            this.btnGetRadioStatus.Text = "상태확인";
            this.btnGetRadioStatus.UseVisualStyleBackColor = true;
            this.btnGetRadioStatus.Click += new System.EventHandler(this.btnGetRadioStatus_Click);
            // 
            // btnGetRichTextBox
            // 
            this.btnGetRichTextBox.Location = new System.Drawing.Point(625, 310);
            this.btnGetRichTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetRichTextBox.Name = "btnGetRichTextBox";
            this.btnGetRichTextBox.Size = new System.Drawing.Size(118, 40);
            this.btnGetRichTextBox.TabIndex = 24;
            this.btnGetRichTextBox.Text = "가져오기";
            this.btnGetRichTextBox.UseVisualStyleBackColor = true;
            this.btnGetRichTextBox.Click += new System.EventHandler(this.btnGetRichTextBox_Click);
            // 
            // btnSetRichTextBox
            // 
            this.btnSetRichTextBox.Location = new System.Drawing.Point(625, 259);
            this.btnSetRichTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetRichTextBox.Name = "btnSetRichTextBox";
            this.btnSetRichTextBox.Size = new System.Drawing.Size(118, 40);
            this.btnSetRichTextBox.TabIndex = 23;
            this.btnSetRichTextBox.Text = "값 넣기";
            this.btnSetRichTextBox.UseVisualStyleBackColor = true;
            this.btnSetRichTextBox.Click += new System.EventHandler(this.btnSetRichTextBox_Click);
            // 
            // btnGetTextBox
            // 
            this.btnGetTextBox.Location = new System.Drawing.Point(625, 550);
            this.btnGetTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetTextBox.Name = "btnGetTextBox";
            this.btnGetTextBox.Size = new System.Drawing.Size(118, 40);
            this.btnGetTextBox.TabIndex = 26;
            this.btnGetTextBox.Text = "가져오기";
            this.btnGetTextBox.UseVisualStyleBackColor = true;
            this.btnGetTextBox.Click += new System.EventHandler(this.btnGetTextBox_Click);
            // 
            // btnSetTextBox
            // 
            this.btnSetTextBox.Location = new System.Drawing.Point(625, 499);
            this.btnSetTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetTextBox.Name = "btnSetTextBox";
            this.btnSetTextBox.Size = new System.Drawing.Size(118, 40);
            this.btnSetTextBox.TabIndex = 25;
            this.btnSetTextBox.Text = "값 넣기";
            this.btnSetTextBox.UseVisualStyleBackColor = true;
            this.btnSetTextBox.Click += new System.EventHandler(this.btnSetTextBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(432, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(157, 175);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 103);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 25);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnChangeRadioBoxStatus
            // 
            this.btnChangeRadioBoxStatus.Location = new System.Drawing.Point(625, 114);
            this.btnChangeRadioBoxStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnChangeRadioBoxStatus.Name = "btnChangeRadioBoxStatus";
            this.btnChangeRadioBoxStatus.Size = new System.Drawing.Size(118, 40);
            this.btnChangeRadioBoxStatus.TabIndex = 28;
            this.btnChangeRadioBoxStatus.Text = "다른 항목 선택";
            this.btnChangeRadioBoxStatus.UseVisualStyleBackColor = true;
            this.btnChangeRadioBoxStatus.Click += new System.EventHandler(this.btnChangeRadioBoxStatus_Click);
            // 
            // lblSampleText
            // 
            this.lblSampleText.AutoSize = true;
            this.lblSampleText.Location = new System.Drawing.Point(514, 793);
            this.lblSampleText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSampleText.Name = "lblSampleText";
            this.lblSampleText.Size = new System.Drawing.Size(223, 21);
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
            this.btnSetImageBoxFromImageList.Location = new System.Drawing.Point(229, 760);
            this.btnSetImageBoxFromImageList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetImageBoxFromImageList.Name = "btnSetImageBoxFromImageList";
            this.btnSetImageBoxFromImageList.Size = new System.Drawing.Size(206, 40);
            this.btnSetImageBoxFromImageList.TabIndex = 30;
            this.btnSetImageBoxFromImageList.Text = "그림 넣기 2";
            this.btnSetImageBoxFromImageList.UseVisualStyleBackColor = true;
            this.btnSetImageBoxFromImageList.Click += new System.EventHandler(this.btnSetImageBoxFromImageList_Click);
            // 
            // btnBlink
            // 
            this.btnBlink.Location = new System.Drawing.Point(503, 654);
            this.btnBlink.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBlink.Name = "btnBlink";
            this.btnBlink.Size = new System.Drawing.Size(240, 40);
            this.btnBlink.TabIndex = 31;
            this.btnBlink.Text = "깜빡이게 하기";
            this.btnBlink.UseVisualStyleBackColor = true;
            this.btnBlink.Click += new System.EventHandler(this.btnBlink_Click);
            // 
            // btnWebServiceCall
            // 
            this.btnWebServiceCall.Location = new System.Drawing.Point(497, 704);
            this.btnWebServiceCall.Margin = new System.Windows.Forms.Padding(5);
            this.btnWebServiceCall.Name = "btnWebServiceCall";
            this.btnWebServiceCall.Size = new System.Drawing.Size(240, 40);
            this.btnWebServiceCall.TabIndex = 32;
            this.btnWebServiceCall.Text = "WebService Call";
            this.btnWebServiceCall.UseVisualStyleBackColor = true;
            this.btnWebServiceCall.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxControlSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnWebServiceCall);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "BoxControlSample";
            this.Size = new System.Drawing.Size(1457, 838);
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
        private System.Windows.Forms.Button btnWebServiceCall;
    }
}
