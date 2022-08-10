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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        // return the input from the textname box
        public string UserName
        {
            get { return TxtName.Text; }
        }

        // return the input from the textage box
        public string UserAge
        {
            get { return TxtAge.Text; }
        }


 
        
    }
}
