using System;
using System.Windows.Forms;

namespace HelloWorldForGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameText.TextLength > 0)
            {
                MessageBox.Show("Hello " + NameText.Text + "!", "Magic", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Name Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
