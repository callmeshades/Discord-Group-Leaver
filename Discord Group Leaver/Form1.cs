using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Group_Leaver
{
    public partial class Form1 : Form
    {
        private int totalChatsInput;
        private AutoIt driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            driver = new AutoIt();
            driver.CreateAutoIt();
            driver.FocusOnDiscord();
            System.Threading.Thread.Sleep(2000);
            DeleteChats();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Make sure Discord is started and open to start.");
            totalChatsInput = 20;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            totalChatsInput = Convert.ToInt32(numericUpDown1.Value);
        }

        private void DeleteChats()
        {
            while(totalChatsInput > 0)
            {
                driver.LeaveChatOrGroup();
                totalChatsInput -= 1;
            }
            MessageBox.Show("Done leaving groups.");
            numericUpDown1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalChatsInput = 0;
            numericUpDown1.Enabled = true;
        }
    }
}
