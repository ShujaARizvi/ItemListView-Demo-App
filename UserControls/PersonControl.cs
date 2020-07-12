using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsListViewTestApp.UserControls
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        public string PName
        {
            set 
            {
                PersonName.Text = value;
            }
        }

        public string Cnic
        {
            set 
            {
                CNIC.Text = value;
            }
        }

        public bool Active 
        {
            set 
            {
                SelectionIndicator.Visible = value;
            }
        }
    }
}
