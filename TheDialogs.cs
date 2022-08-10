using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDialogsApp
{
    public partial class DialogDemos : Form
    {
        public DialogDemos()
        {
            InitializeComponent();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you agree?", "DialogBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You pressed Yes");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("You pressed No");
            }
        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {


        }
    }
}
