using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Data;
using System.Text.RegularExpressions;

namespace SupremeGUI
{
    public partial class SettingsForm : Form
    {
        public BillingInformation billingInfo = new BillingInformation();
        public CreditcardDetails ccInfo = new CreditcardDetails();
        public Selector.Category category;

        public string[] keywords;
        public bool colorRelevant = false;
        public bool sizeRelevant = false;
        public String color;
        public String size;
        public MainForm _mFrm;

        public SettingsForm(MainForm mFrm)
        {
            _mFrm = mFrm;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstKeywords.Items.Add(txtKeyword.Text);
            txtKeyword.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtAddressOne.Text.Length > 0 && txtAddressOne.Text.Length > 0 && txtZipCode.Text.Length > 0 && txtCity.Text.Length > 0 
                && comboCountry.Text != "" && txtTelephone.Text.Length > 0 && txtEmail.Text.Length > 0 
                && comboCcType.Text != "" && comboCategory.Text != "" && txtCcNumber.Text.Length > 1 && txtMonth.Text.Length == 2 
                && txtCVV2.Text.Length > 0 && lstKeywords.Items.Count > 0) {

                billingInfo.FullName = txtFullName.Text;
                billingInfo.Address_1 = txtAddressOne.Text;
                billingInfo.Address_2 = txtAddressTwo.Text;
                billingInfo.Address_3 = txtAddressThree.Text;
                billingInfo.ZipCode = txtZipCode.Text;
                billingInfo.City = txtCity.Text;
                billingInfo.Country = new Selector.Country(new Regex("(.+) \\((.+?)\\)").Match(comboCountry.SelectedItem.ToString()).Groups[2].Value);
                billingInfo.Telephone = txtTelephone.Text;
                billingInfo.Email = txtEmail.Text;

                switch (comboCcType.Text)
                {
                    case "VISA":
                        ccInfo.Type = Selector.CreditcardType.VISA;
                        break;
                    case "MasterCard":
                        ccInfo.Type = Selector.CreditcardType.MasterCard;
                        break;
                    case "American Express":
                        ccInfo.Type = Selector.CreditcardType.American_Express;
                        break;
                }

                ccInfo.Number = txtCcNumber.Text;
                ccInfo.Month = txtMonth.Text;
                ccInfo.Year = nmrcYear.Value.ToString();
                ccInfo.CVV2 = txtCVV2.Text;

                colorRelevant = chckColor.Checked;
                color = txtColor.Text;

                category = new Selector.Category(comboCategory.Text);

                sizeRelevant = chckSize.Checked;
                size = txtSize.Text;

                keywords = new string[lstKeywords.Items.Count];

                for(int i = 0; i < keywords.Length; i++)
                {
                    keywords[i] = lstKeywords.Items[i].ToString();
                }

                _mFrm.saveCallBack();

                this.Hide();
            } else
            {
                MessageBox.Show("Some of the information you entered is not correct.", "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckColor_CheckedChanged(object sender, EventArgs e)
        {
            if(chckColor.Checked)
            {
                txtColor.Enabled = true;
            } else
            {
                txtColor.Enabled = false;
            }
        }

        private void chckSize_CheckedChanged(object sender, EventArgs e)
        {
            if(chckSize.Checked)
            {
                txtSize.Enabled = true;    
            } else
            {
                txtSize.Enabled = false;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
