using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallmentPlan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectionPlan collectionPlan = new CollectionPlan();
            collectionPlan.Cost = costNumericTextBox.DecimalValue;
            collectionPlan.ProfitRate = profitRateNumericTextBox.DecimalValue;
            collectionPlan.BsmvRate = 0;
            collectionPlan.KkdfRate = 0;
            collectionPlan.FirstInstalmentDate = DateTime.Now.Date.AddDays(30);
            collectionPlan.ProjectStartDate = DateTime.Now.Date;
            collectionPlan.InstalmentCount = Convert.ToInt16(installmentCountNumericUpDown.Value);
            collectionPlan.InstalmentPeriod = Convert.ToInt16(installmentPeriodNumericUpDown.Value);

            collectionPlan = CollectionPlan.SetCollectionPlanSchedule(collectionPlan);
            collectionPlan = CollectionPlan.SetCoefList(collectionPlan);
            collectionPlan = CollectionPlan.CreateCollectionPlan(collectionPlan);
            dataGridView1.DataSource = collectionPlan.CollectionPlanInstalmentArray;
        }


    }
}
