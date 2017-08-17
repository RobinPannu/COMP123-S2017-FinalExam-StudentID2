using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Robin Singh
 * Date: August 17,2017
 * StudentID: 300930741
 * Description: This is the splashForm 
 * Version:0.1 : 
 */
namespace COMP123_S2017_FinalExam_StudentID2
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickHighestCardForm = new PickHighestCardForm();
            pickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
