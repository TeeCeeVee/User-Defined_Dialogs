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
            // when click the button, FormUser displays

            // how to make the FormUser show up when clicked?
            // first create an instance of FormUser - how to connect the main form and the second form

           FormUser formUser = new FormUser();
            // second - use ShowDialog to display the FormUser
            // in order to show the results from the FormUser, use DialogResult
            //formUser.ShowDialog();
            DialogResult result = formUser.ShowDialog(); // feeding the data into the result box

         
            if (result == DialogResult.OK)
            {
                // formUser.UserName and formUser.UserAge from FormUser
                MessageBox.Show("Your name is " + formUser.UserName + ". You are " + formUser.UserAge + " years old.");

            }

            else
            {
                MessageBox.Show("You pressed Cancel");
            }




        }
    }
}
