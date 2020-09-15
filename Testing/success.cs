using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC
{
    public partial class Success : Form
    {
        /// <summary>
        /// A simple form to show a successful record add attempt.
        /// </summary>
        public Success()
        {
            InitializeComponent();
        }

        private void AcceptSuccess_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
