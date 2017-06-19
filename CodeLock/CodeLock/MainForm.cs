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
        string randomPukString;

        byte tries = 3, pukTries = 3;

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
            btnCompare.Enabled = false;
            inputString = "";
            pbCongrats.Image = Resources.NavesnojZamok1;
            pbCongrats.Visible = true;
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

        private void btnGenNumber_Click(object sender, EventArgs e)
        {
            btnCompare.Enabled = true;
            lblPass.Visible = true;
            tbInput.Visible = true;
            randomNumberString = "";
            randomPukString = "";
            tbInput.Text = inputString = string.Empty;
            
            for (int i = 0; i < 5; i++)
                randomNumberString += rnd.Next(0, 10).ToString();

            for (int i = 0; i < 3; i++)
                randomPukString += rnd.Next(0, 10).ToString();

            lblRandomNum.Text = randomNumberString;
            lblRandomPuk.Text = randomPukString;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void Compare()
        {
            if (inputString == randomNumberString)
            {
                pbCongrats.Image = Resources.saluteImage;
                tries = 3;
                lblTries.Visible = !true;
                lblTriesLeft.Visible = !true;
            }
            else
            {
                lblTries.Visible = true;
                lblTriesLeft.Visible = true;
                lblTries.Text = tries.ToString();
                pbCongrats.Image = Resources.KnDq;

                if (tries == 0)
                {
                    lblPass.Visible = !true;
                    lblRandomNum.Visible = !true;
                    PukCode();
                    tries = 1;
                }
                tries -= 1;
            }
            pbCongrats.Visible = true;
        }

        private void PukCode()
        {
            lblRandomPuk.Visible = true; 
            lblPuk.Visible = true;       
            btnGenNumber.Enabled = false;
            lblTries.Visible = false;    
            lblTriesLeft.Visible = false;

            if (inputString == randomPukString)
            {
                pbCongrats.Image = Resources.saluteImage;
                btnGenNumber.Enabled = true;
            }
            else
            {
                lblPukTries.Visible = true;
                lblPukTriesLeft.Visible = true;
                lblPukTries.Text = pukTries.ToString();
                pbCongrats.Image = Resources.KnDq;

                if (pukTries == 0)
                {
                    pbCongrats.Image = Resources.badResultImage;
                    pukTries = 1;
                    btnGenNumber.Enabled = true;
                }
                pukTries -= 1;
            }
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
