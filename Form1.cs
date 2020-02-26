using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           String text = InputTextBox.Text;
           int k = Convert.ToInt32(Key.Text);
           
           String textencr = crypto.encrypt(text, k);
           OutputTextBox.Text = "";
           OutputTextBox.Text = textencr;

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Key_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = OutputTextBox.Text;            
            String text = InputTextBox.Text;
            int k = Convert.ToInt32(Key.Text);

            String textencr = crypto.decrypt(text, k);
            OutputTextBox.Text = "";
            OutputTextBox.Text = textencr;
        }              
    }
}
