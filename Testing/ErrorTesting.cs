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
    public partial class ErrorTesting : Form
    {
        /// <summary>
        /// A form only used for debugging.
        /// </summary>
        /// <param name="num"></param>
        public ErrorTesting(int num)
        {
            InitializeComponent();
            ErrorBox.Text = num.ToString();
        }

        /// <summary>
        /// A form only used for debugging.
        /// </summary>
        /// <param name="Errr"></param>
        public ErrorTesting(string Errr)
        {
            InitializeComponent();
            ErrorBox.Text = Errr;
        }
    }
}
