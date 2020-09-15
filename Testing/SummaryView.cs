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
    public partial class SummaryView : Form
    {
        MainWindow MainW;

        /// <summary>
        /// Shows a brief summary of all currently stored records.
        /// </summary>
        /// <param name="ParentW">Links this form to the main window.</param>
        public SummaryView(MainWindow ParentW)
        {
            InitializeComponent();
            MainW = ParentW;
            string Gend, Birth;
            SummaryViewGrid.Rows.Clear();
            SummaryViewGrid.TopLeftHeaderCell.Value = "Record";
            for (int i = 1; i < MainW.GetRecordNum(); i++)
            {
                if (MainW.GetGender(i))
                {
                    Gend = "Male";
                }
                else
                {
                    Gend = "Female";
                }
                Birth = MainW.GetDateOfBirth(i).Month.ToString() + "/" + MainW.GetDateOfBirth(i).Day.ToString() + "/" + MainW.GetDateOfBirth(i).Year.ToString();
                SummaryViewGrid.Rows.Add(MainW.GetFullName(i), Gend, Birth);
                SummaryViewGrid.Rows[i - 1].HeaderCell.Value = i.ToString("00000");
            }




            /*for (int i = 1; i < MainW.GetRecordNum(); i++)
            {
                Rec += (i).ToString("00000") + ": ";
                Rec += MainW.GetFullName(i) + ", ";
                if (MainW.GetGender(i) == true)
                    Rec += "Male, ";
                else
                    Rec += "Female, ";
                Rec += MainW.GetDateOfBirth(i).Month.ToString() + "/" + MainW.GetDateOfBirth(i).Day.ToString() + "/" + MainW.GetDateOfBirth(i).Year.ToString() + "\n";
            }
            SummaryBox.Text = Rec;*/
        }
        
        private void SumClose_Click(object sender, EventArgs e)
        {
            MainW.Enable_Menu();
            this.Close();
        }
    }
}
