using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using Data;

namespace SupremeGUI
{
    public partial class MainForm : Form
    {
        private SettingsForm settings;
        private CookieContainer masterContainer;

        private BillingInformation billing;
        private Selector.Category category;
        private CreditcardDetails credit;
        private String color;
        private String size;
        private String[] keywords;

        private bool colorRelevant;
        private bool sizeRelevant;

        public MainForm()
        {
            InitializeComponent();
        }

        public void saveCallBack()
        {
            billing = settings.billingInfo;
            credit = settings.ccInfo;
            colorRelevant = settings.colorRelevant;
            sizeRelevant = settings.sizeRelevant;
            color = settings.color;
            size = settings.size;
            keywords = settings.keywords;
            category = settings.category;

            btnOrder.Enabled = true;
        }

        private void lnkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settings = new SettingsForm(this);
            settings.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Product grail = new Product(category, keywords, ref masterContainer, sizeRelevant, size, colorRelevant, color);
            grail.initialize();

            OrderResult result = Supreme.Order(grail, billing, credit);
            
            if(result.success)
            {
                // Order successful
                MessageBox.Show("Order successful.");
            } else
            {
                // Order unsuccessful
                // result.rawResult contains Page Source
                MessageBox.Show("Order unsuccessful.");
                MessageBox.Show(result.rawResult);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/MalcolmA");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
