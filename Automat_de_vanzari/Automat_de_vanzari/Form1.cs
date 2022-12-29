using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat_de_vanzari
{
    public partial class Form1 : Form
    {
        /*
             * A=1
             * B=2
             * C=3
             * D=4
             */
        int stare = 1;
        bool dispense = false, nickel = false, dime = false;


        public Form1()
        {
            InitializeComponent();
            button1.Parent = this;
            button2.Parent = this;
            button3.Parent = this;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //nickle
            switch(stare)
            {
                case 1: stare = 2; dispense = false; nickel = false; dime = false; break;
                case 2: stare = 3; dispense = false; nickel = false; dime = false; break;
                case 3: stare = 4; dispense = false; nickel = false; dime = false; break;
                case 4: stare = 1; dispense = true; nickel = false; dime = false; break;
            }
            rezultat();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //dime
            switch (stare)
            {
                case 1: stare = 3; dispense = false; nickel = false; dime = false; break;
                case 2: stare = 4; dispense = false; nickel = false; dime = false; break;
                case 3: stare = 1; dispense = true; nickel = false; dime = false; break;
                case 4: stare = 1; dispense = true; nickel = true; dime = false; break;
            }
            rezultat();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //quarter
            switch (stare)
            {
                case 1: stare = 1; dispense = true; nickel = true; dime = false; break;
                case 2: stare = 1; dispense = true; nickel = false; dime = true; break;
                case 3: stare = 1; dispense = true; nickel = true; dime = true; break;
                case 4: stare = 2; dispense = true; nickel = true; dime = true; break;
            }
            rezultat();
        }
        private void rezultat()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            switch (stare)
            {
                case 1: label2.Text = "0"; break;
                case 2: label2.Text = "5"; break;
                case 3: label2.Text = "10"; break;
                case 4: label2.Text = "15"; break;
            }
            if(nickel == true && dime==true)
            {
                MessageBox.Show("Ai obținut un *produs* și ai primit rest un nickel și un dime!", "Felicitări!");

            }
            else
            {
                if (nickel == true)
                {
                    MessageBox.Show("Ai obținut un *produs* și ai primit rest un nickel!", "Felicitări!");
                }
                else
                {
                    if (dime == true)
                    {
                        MessageBox.Show("Ai obținut un *produs* și ai primit rest un dime!", "Felicitări!");
                    }
                    else
                    {
                        if(dispense==true)
                        {
                            MessageBox.Show("Ai obținut un *produs* !", "Felicitări!");
                        }
                    }
                }
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
    }
}
