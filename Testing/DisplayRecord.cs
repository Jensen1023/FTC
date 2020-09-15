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

    public partial class DisplayRecord : Form
    {
        MainWindow MainW;

        /// <summary>
        /// Initialize a DisplayRecord form.
        /// </summary>
        /// <remarks>
        /// This form displays detailed information on the record chosen from the combobox.
        /// </remarks>
        /// <param name="ParentW">Links this form to the main window.</param>
        public DisplayRecord(MainWindow ParentW)
        {
            InitializeComponent();
            MainW = ParentW;
            for (int i = 1; i < MainW.GetRecordNum(); i++)
            {
                string Record = i.ToString("00000") + " - " + MainW.GetLastName(i) + ", " + MainW.GetFirstName(i);
                ChooseDisplay.Items.Add(Record);
            }
        }

        private void ChooseDisplay_DropDownClosed(object sender, EventArgs e)
        {
            if(ChooseDisplay.SelectedIndex == -1)
            {
                return;
            }
            int Selection = ChooseDisplay.SelectedIndex + 1;
            DateTime DateOfBir;
            DateTime DateOfDea;
            string Birthday = "", Deathday = "";
            RetName.Text = MainW.GetFullName(Selection);

            if (MainW.GetGender(Selection) == true)
            {
                RetGender.Text = "Male";
            }
            else
            {
                RetGender.Text = "Female";
            }

            if (MainW.GetSpouse(Selection) == 0)
            {
                RetSpouse.Text = "N/A";
                RetSpouseNum.Text = "";
            }
            else
            {
                RetSpouse.Text = MainW.GetFullName(MainW.GetSpouse(Selection));
                RetSpouseNum.Text = MainW.GetSpouse(Selection).ToString("00000");
            }

            if ((MainW.GetParentsFromRecord(Selection) == null) || ((MainW.GetParentsFromRecord(Selection).GetFatherNumber() == 0) && (MainW.GetParentsFromRecord(Selection).GetMotherNumber() == 0)))
            {
                RetFather.Text = "N/A";
                RetMother.Text = "N/A";
                RetMotherNum.Text = "";
                RetFatherNum.Text = "";
            }
            else
            {
                if (MainW.GetParentsFromRecord(Selection).GetFatherNumber() == 0)
                {
                    RetFather.Text = "N/A";
                    RetFatherNum.Text = "";
                    RetMother.Text = MainW.GetFullName(MainW.GetParentsFromRecord(Selection).GetMotherNumber());
                    RetMotherNum.Text = MainW.GetParentsFromRecord(Selection).GetMotherNumber().ToString("00000");
                }
                else if (MainW.GetParentsFromRecord(Selection).GetMotherNumber() == 0)
                {
                    RetMother.Text = "N/A";
                    RetMotherNum.Text = "";
                    RetFather.Text = MainW.GetFullName(MainW.GetParentsFromRecord(Selection).GetFatherNumber());
                    RetFatherNum.Text = MainW.GetParentsFromRecord(Selection).GetFatherNumber().ToString("00000");
                }
                else
                {
                    RetMother.Text = MainW.GetFullName(MainW.GetParentsFromRecord(Selection).GetMotherNumber());
                    RetMotherNum.Text = MainW.GetParentsFromRecord(Selection).GetMotherNumber().ToString("00000");
                    RetFather.Text = MainW.GetFullName(MainW.GetParentsFromRecord(Selection).GetFatherNumber());
                    RetFatherNum.Text = MainW.GetParentsFromRecord(Selection).GetFatherNumber().ToString("00000");
                }
            }

            if(MainW.GetChildren(Selection).Count() != 0)
            {
                List<int> Kids = MainW.GetChildren(Selection);
                string KidsNames = "", KidsNumbers = "";
                foreach (int i in Kids)
                {
                    KidsNames += MainW.GetFullName(i) + "\r\n";
                    KidsNumbers += i.ToString("00000") + "\r\n";
                }
                ChildrenNamesBox.Text = KidsNames;
                ChildrenNumberBox.Text = KidsNumbers;
            }
            else
            {
                ChildrenNamesBox.Text = "";
                ChildrenNumberBox.Text = "";
            }

            string SibNames = "", SibNumbers = "";

            if(MainW.GetParentsFromRecord(Selection).GetFatherNumber() != 0)
            {
                List<int> TempSibs = MainW.GetChildren(MainW.GetParentsFromRecord(Selection).GetFatherNumber());
                if (TempSibs.Count > 1)
                {
                    foreach(int s in TempSibs)
                    {
                        if (s != Selection)
                        {
                            SibNames += MainW.GetFullName(s) + "\r\n";
                            SibNumbers += s.ToString("00000") + "\r\n";
                        }
                    }
                }
            }
            else if (MainW.GetParentsFromRecord(Selection).GetMotherNumber() != 0)
            {
                List<int> TempSibs = MainW.GetChildren(MainW.GetParentsFromRecord(Selection).GetMotherNumber());
                if (TempSibs.Count > 1)
                {
                    foreach (int s in TempSibs)
                    {
                        if (s != Selection)
                        {
                            SibNames += MainW.GetFullName(s) + "\r\n";
                            SibNumbers += s.ToString("00000") + "\r\n";
                        }
                    }
                }
            }

            SiblingsNamesBox.Text = SibNames;
            SiblingsNumberBox.Text = SibNumbers;

            DateOfBir = MainW.GetDateOfBirth(Selection);
            switch (DateOfBir.Month)
            {
                case 1:
                    Birthday = "January ";
                    break;
                case 2:
                    Birthday = "February ";
                    break;
                case 3:
                    Birthday = "March ";
                    break;
                case 4:
                    Birthday = "April ";
                    break;
                case 5:
                    Birthday = "May ";
                    break;
                case 6:
                    Birthday = "June ";
                    break;
                case 7:
                    Birthday = "July ";
                    break;
                case 8:
                    Birthday = "August ";
                    break;
                case 9:
                    Birthday = "September ";
                    break;
                case 10:
                    Birthday = "October ";
                    break;
                case 11:
                    Birthday = "November ";
                    break;
                case 12:
                    Birthday = "December ";
                    break;
            }
            Birthday += DateOfBir.Day + ", " + DateOfBir.Year;
            RetDoB.Text = Birthday;
            DateOfDea = MainW.GetDateOfDeath(Selection);

            if (DateOfDea.Year == 1)
            {
                RetDoD.Text = "N/A";
            }
            else
            {
                switch (DateOfDea.Month)
                {
                    case 1:
                        Deathday = "January ";
                        break;
                    case 2:
                        Deathday = "February ";
                        break;
                    case 3:
                        Deathday = "March ";
                        break;
                    case 4:
                        Deathday = "April ";
                        break;
                    case 5:
                        Deathday = "May ";
                        break;
                    case 6:
                        Deathday = "June ";
                        break;
                    case 7:
                        Deathday = "July ";
                        break;
                    case 8:
                        Deathday = "August ";
                        break;
                    case 9:
                        Deathday = "September ";
                        break;
                    case 10:
                        Deathday = "October ";
                        break;
                    case 11:
                        Deathday = "November ";
                        break;
                    case 12:
                        Deathday = "December ";
                        break;
                }
                Deathday += DateOfDea.Day + ", " + DateOfDea.Year;
                RetDoD.Text = Deathday;
            }
        }

        private void RetClose_Click(object sender, EventArgs e)
        {
            MainW.Enable_Menu();
            this.Close();
        }
    }
}
