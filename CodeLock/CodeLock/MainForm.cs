using CodeLock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLock
{
    public partial class MainForm : Form
    {
        string randomNumberString;
        static Random rnd = new Random();

        string inputString;
        public MainForm()
        {
            InitializeComponent();
            btnOne.Click += btnClickHandler;
            btnTwo.Click += btnClickHandler;
            btnThree.Click += btnClickHandler;
            btnFour.Click += btnClickHandler;
            btnFive.Click += btnClickHandler;
            btnSix.Click += btnClickHandler;
            btnSeven.Click += btnClickHandler;
            btnEight.Click += btnClickHandler;
            btnNine.Click += btnClickHandler;
            btnZero.Click += btnClickHandler;
            randomNumberString = "00000";
            inputString = "";
        }

        void btnClickHandler(object sender, EventArgs e)
        {
            inputString += ((Button)sender).Text;
            tbInput.Text = inputString;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                inputString = inputString.Remove(inputString.Length - 1, 1);
                tbInput.Text = inputString;
            }
        }

        private void btnEmpty1_Click(object sender, EventArgs e)
        {
            pbCongrats.Visible = false;
            tbInput.Text = inputString = string.Empty;
            lblRandomNum.Text = randomNumberString = "00000";
        }

        private void btnGenNumber_Click(object sender, EventArgs e)
        {
            randomNumberString = "";
            tbInput.Text = inputString = string.Empty;
            pbCongrats.Visible = false;

            for (int i = 0; i < 5; i++)
            {
                randomNumberString += rnd.Next(0, 10).ToString();
            }

            lblRandomNum.Text = randomNumberString;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void Compare()
        {
            if (inputString == randomNumberString)
                pbCongrats.Image = Resources.saluteImage;
            else
                pbCongrats.Image = Resources.badResultImage;

            pbCongrats.Visible = true;
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            inputString = tbInput.Text;
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Compare();
            }
        }

    }
}
