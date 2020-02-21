using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.UserControls
{
    public partial class BoxControlSample : UserControl
    {
        public BoxControlSample()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetCbxStatus_Click(object sender, EventArgs e)
        {
            this.rTbxResult.Text += String.Format("{0} : {1}\r\n", sender.ToString(), this.checkBox1.CheckState);
        }

        private void btnSetCheckedListBox_Click(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Add("Checked 1", true);
            this.checkedListBox1.Items.Add("Un Checked 1", false);
            this.checkedListBox1.Items.Add("Un Checked 2", false);
            this.checkedListBox1.Items.Add("Checked 2", true);
        }

        private void btnGetCheckListBox_Click(object sender, EventArgs e)
        {
            System.Collections.IEnumerator inum = this.checkedListBox1.CheckedItems.GetEnumerator();
            while(inum.MoveNext())
            {
                this.rTbxResult.Text += String.Format("{0} : {1}\r\n", "Checked lists : ", inum.Current.ToString());
            }
        }

        private void btnSetComboBox_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();

            this.comboBox1.Items.Add("BISTel");
            this.comboBox1.Items.Add("Oracle");
            this.comboBox1.Items.Add("IBM");

            this.comboBox1.SelectedIndex = 0;
        }

        private void btnGetComboBox_Click(object sender, EventArgs e)
        {
            this.rTbxResult.Text += String.Format("Selected [text/index/value] is : [{0} / {1} / {2}] \r\n", 
                this.comboBox1.Text, 
                this.comboBox1.SelectedIndex, 
                this.comboBox1.SelectedValue == null ? "Value is empty" : this.comboBox1.SelectedValue);
            
        }

        private void btnSetListBox_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("TEST1");
            this.listBox1.Items.Add("TEST2");
            this.listBox1.Items.Add("TEST3");
        }

        private void btnGetListBox_Click(object sender, EventArgs e)
        {
            //this.rTbxResult.Text += String.Format("Selected [text/index/value] is : [{0} / {1} / {2}] \r\n", 
            //    this.listBox1.Text, this.listBox1.SelectedIndex, this.listBox1.SelectedValue == null ? "Value is empty" : this.listBox1.SelectedValue);

            //https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/operators/null-coalescing-operator
            this.rTbxResult.Text += String.Format("Selected [text/index/value] is : [{0} / {1} / {2}] \r\n",
                this.listBox1.Text, this.listBox1.SelectedIndex, this.listBox1.SelectedValue ?? "Value is empty");
        }


        private void btnSetMaskedTextBox_Click(object sender, EventArgs e)
        {
            this.maskedTextBox1.Text = this.lblSampleText.Text;
        }

        private void btnGetMaskedTextBox_Click(object sender, EventArgs e)
        {
            this.rTbxResult.Text += String.Format("MaskedTextBox is : [{0}] \r\n", this.maskedTextBox1.Text);
        }

        private void btnSetImageBox_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Load("https://www.bistel.com/wp-content/uploads/2019/08/BISTel_Logo.png");
        }

        private void btnSetImageBoxFromImageList_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.imageList1.Images[0];
        }

        private void btnGetRadioStatus_Click(object sender, EventArgs e)
        {
            foreach(Control grpBox in this.groupBox1.Controls)
            {
                RadioButton radioButtonTemp = ((RadioButton)grpBox);
                if (radioButtonTemp.Checked == true)
                {
                    this.rTbxResult.Text += String.Format("Selected radio is : [{0}] \r\n", radioButtonTemp.Text);
                }
            }
        }

        private void btnChangeRadioBoxStatus_Click(object sender, EventArgs e)
        {
            this.radioButton2.Checked = true;
        }

        private void btnSetRichTextBox_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.lblSampleText.Text;
            this.richTextBox1.Select(0, 3);
            this.richTextBox1.SelectionColor = Color.Red;
        }

        private void btnGetRichTextBox_Click(object sender, EventArgs e)
        {
            this.rTbxResult.Text += String.Format("Selected is : [{0}] \r\n", this.richTextBox1.SelectedRtf);
            
        }

        private void btnSetTextBox_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.lblSampleText.Text;
        }

        private void btnGetTextBox_Click(object sender, EventArgs e)
        {
            this.rTbxResult.Text += String.Format("TextBox is : [{0}] \r\n", this.textBox1.Text);
        }

        #region 무한 루프 샘플
        /* 무한 루프 샘플 입니다. */
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == false)
            {
                this.radioButton1.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == false)
            {
                this.radioButton2.Checked = true;
            }
        }

        /* 무한 루프 샘플 입니다. */
        #endregion

        private void btnBlink_Click(object sender, EventArgs e)
        {
            this.btnBlink.BackColor = Color.LightSteelBlue;
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            this.btnBlink.BackColor = Color.Gray;
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            this.btnBlink.BackColor = Color.LightSteelBlue;
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            Application.DoEvents();
            this.btnBlink.BackColor = Color.Gray;
            
        }
    }
}
