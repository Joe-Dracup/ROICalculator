using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal cost = 0;
        decimal benefit = 0;
        DateTime startDate = DateTime.Now;
        private void cost_num_ValueChanged(object sender, EventArgs e)
        {
            cost = cost_num.Value;
        }

        private void benefit_num_ValueChanged(object sender, EventArgs e)
        {
            benefit = benefit_num.Value;
        }
        private void startDate_dat_ValueChanged(object sender, EventArgs e)
        {
            startDate = startDate_dat.Value;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            endDate_txt.Text = BenefitDate(cost, benefit, startDate);
            ROI_txt.Text = CalcROI(cost, benefit);
        }
        private static string BenefitDate(decimal cost, decimal payback, DateTime startDate)
        {
            decimal monthlyPayback = payback / 365;
            decimal payedBack = 0;
            while (payedBack < cost)
            {
                payedBack += monthlyPayback;
                startDate = startDate.AddDays(1);
            }
            return startDate.ToString("dd/MM/yyyy");
        }
        private static string CalcROI(decimal cost, decimal payback)
        {
            if (cost > 0 && payback > 0)
            {
                decimal ROI = (((payback - cost) / cost) * 100);

                return ROI.ToString() + "%";
            } 
            return "Please enter a number that is greater than zero";
            
        }


    }
}
