using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_ASP.NET
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
