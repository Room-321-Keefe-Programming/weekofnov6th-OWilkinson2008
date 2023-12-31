﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void rdoTempConverter1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdoTempConverter2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btn_Temp_Click(object sender, EventArgs e)
        {
            if (txtInput1.Text == "")
            {
                txtInput1.Text = "0";
            }
            //Makes the Input 0 if nothing is entered
            string temperature = txtInput1.Text;
            int temperInt = int.Parse(temperature);
            //Sets the Text to an Integer
            if (rdoTempConverter1.Checked == true)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{txtInput1.Text} Celsius is {(temperInt * 9 / 5) + 32} Celsius";
            }
            else
            if (rdoTempConverter2.Checked == true)
            {
                rtbOutput.Text += $"{txtInput1.Text} Celsius is {(temperInt - 32) * 5 / 9} Fahrenheit";
            }
            else
            {
                rtbOutput.Text += "Select a Temperature";
            }
        }

        private void btn_Money_Click(object sender, EventArgs e)
        {
            if (txtMoneyInput.Text == "")
            {
                txtMoneyInput.Text = "0";
            }
            //Makes the Input 0 if nothing is entered
            string money = txtMoneyInput.Text;
            int moneyInt = int.Parse(money);
            //Sets the Text to an Integer
            if (cmbMoneyConverter.SelectedIndex == 0)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} USD in Yen is {moneyInt * 149.75}";
            }
            if (cmbMoneyConverter.SelectedIndex == 1)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} Yen in USD is {moneyInt * 0.0067}";
            }
            if (cmbMoneyConverter.SelectedIndex == 2)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} Zimbabwean Dollars in USD is {moneyInt * 0.003106}";
            }
            if (cmbMoneyConverter.SelectedIndex == 3)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} USD in Zimbabwean Dollars is {moneyInt * 322}";
            }
            if (cmbMoneyConverter.SelectedIndex == 4)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} Euros in USD is {moneyInt * 1.07}";
            }
            if (cmbMoneyConverter.SelectedIndex == 5)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} USD in Euros is {moneyInt * 0.93}";
            }
            if (cmbMoneyConverter.SelectedIndex == 6)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} Canadian Dollars in USD is {moneyInt * 0.73}";
            }
            if (cmbMoneyConverter.SelectedIndex == 7)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} USD in Canadian Dollars is {moneyInt * 1.37}";
            }
            if (cmbMoneyConverter.SelectedIndex == 8)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} Guinean Francs in USD is {moneyInt * 0.00012}";
            }
            if (cmbMoneyConverter.SelectedIndex == 9)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{moneyInt} USD in Guinean Francs is {moneyInt * 83650}";
            }

        }

        private void cmbMoneyConverter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Distance_Click(object sender, EventArgs e)
        {
            if (tbDistance.Text == "")
            {
                tbDistance.Text = "0";
            }
            //Makes the Input 0 if nothing is entered
            string distance = tbDistance.Text;
            int distanceInt = int.Parse(distance);
            //Sets the Text to an Integer
            if (chkMileToKilo.Checked == true)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{distanceInt} Miles is {distanceInt * 1.608344} Kilometers.";
            }
            if (chkKiloToMiles.Checked == true)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{distanceInt} Kilometers is {distanceInt * 0.621371} Miles.";
            }
        }

        private void btn_Distance2_Click(object sender, EventArgs e)
        {
            if (tbDistance.Text == "")
            {
                tbDistance.Text = "0";
            }
            //Makes the Input 0 if nothing is entered
            string distance = tbDistance.Text;
            int distanceInt = int.Parse(distance);
            //Sets the Text to an Integer
            if (chkInchToMeter.Checked == true)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{distanceInt} Inches is {distanceInt * 0.0254} Meters.";
            }
            if (chkMeterToInch.Checked == true)
            {
                if (rtbOutput.Text != "")
                {
                    rtbOutput.Text += "\n";
                }
                rtbOutput.Text += $"{distanceInt} Meters is {distanceInt * 39.3701} Inches.";
            }
        }

        private void chkMileToKilo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            string lines = @"C:\\Users\\ollie\\source\\repos\\weekofnov6th-OWilkinson2008\\WeekOfNov6th\\bin\\test.txt";
            string[] contents = File.ReadAllLines(lines);
            for (var i = 0; i < contents.Length; i++)
            {
                rtbOutput.Text += contents[i];
            }
        }

        private void btnPrintFile_Click(object sender, EventArgs e)
        {
            if (txtInput1.Text == "")
            {
                txtInput1.Text = "1";
            }
            //Makes the Input 0 if nothing is entered
            string length = txtInput1.Text;
            int lengthInt = int.Parse(length);

            string lines = @"C:\\Users\\ollie\\source\\repos\\weekofnov6th-OWilkinson2008\\WeekOfNov6th\\bin\\test.txt";
            string contents = File.ReadAllText(lines);
            string[] dog = contents.Split(' ');

            for (var i = 0; i <= dog.Length; i += lengthInt)
            {
                rtbOutput.Text += "" + dog[i] + " ";
            }
        }

        private void txtInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlphabits_Click(object sender, EventArgs e)
        {
            int counter = 26;
            int caseCounter = 0;
            bool caseFlip = false;
            char[] LowerCaseAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] UpperCaseAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i <= LowerCaseAlphabet.Length-1; i++)
            {
                if (LowerCaseAlphabet[i] == 'a'|| LowerCaseAlphabet[i] == 'e' || LowerCaseAlphabet[i] == 'i' || LowerCaseAlphabet[i] == 'o' || LowerCaseAlphabet[i] == 'u')
                {
                    rtbOutput.Text += UpperCaseAlphabet[i];
                }
                else
                {
                    rtbOutput.Text += LowerCaseAlphabet[i];
                }

            }
            rtbOutput.Text += "\n \n";
            while(counter != 0)
            {
                counter--;
                if (caseCounter == 5)
                {
                    rtbOutput.Text += ", ";
                    caseFlip = !caseFlip;
                    caseCounter = 0;
                    if (caseFlip == true) {
                        rtbOutput.Text += UpperCaseAlphabet[counter];
                    }
                    else
                    {
                        rtbOutput.Text += LowerCaseAlphabet[counter];
                    }
                }
                else
                {
                    caseCounter += 1;
                    if (caseFlip == true)
                    {
                        rtbOutput.Text += UpperCaseAlphabet[counter];
                    }
                    else
                    {
                        rtbOutput.Text += LowerCaseAlphabet[counter];
                    }
                }
                
            }
        }
    }
}
