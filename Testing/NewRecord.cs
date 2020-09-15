using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC
{
    /// <summary>
    /// The form used to get user input for adding new records.
    /// </summary>
    /// <remarks>
    /// Takes in user input and updates available choices for linked records as data fields are changed.
    /// </remarks>
    public partial class NewRecord : Form
    {
        MainWindow MainW;

        /// <summary>
        /// Intializes a New Record form and populates the initial choices.
        /// </summary>
        /// <param name="ParentW">Link this form to the main window.</param>
        public NewRecord(MainWindow ParentW)
        {
            InitializeComponent();
            MainW = ParentW;
            this.RecordDisplay.Text = (MainW.GetRecordNum()).ToString("00000");
            ResetSpouse();
            ResetParents();
            DoDEntry.Enabled = false;
        }

        private void NewRecord_Load(object sender, EventArgs e)
        {

        }


        private void IsDeceased_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDeceased.Checked == true)
            {
                DoDEntry.Enabled = true;
                if (DoBEntry.Value.Date > DoDEntry.Value.Date)
                {
                    DoDLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                DoDEntry.Enabled = false;
                DoDLabel.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void AddSubmit_Click(object sender, EventArgs e)
        {
            //Variable declarations
            string FN = "", MN = "", LN = "", MdN = "";
            bool IsMale = true, flag = false;
            List<int> FlagList = new List<int>();
            List<int> Kid = new List<int>();
            List<string> PrevNames = new List<string>();
            int SpouseNum = 0, TempKid = 0;
            Couples C = new Couples();
            FN = FirstNameEntry.Text;
            MN = MiddleNameEntry.Text;
            LN = LastNameEntry.Text;
            MdN = MaidenNameEntry.Text;
            DateTime BDay = DoBEntry.Value;
            DateTime DDay = DateTime.MinValue;

            // Validity checking on name fields
            if (FN == "")
            {
                flag = true;
                FlagList.Add(1);
                FNLabel.ForeColor = System.Drawing.Color.Red;
            }
            else if (!(FN.All(Char.IsLetter)))
            {
                flag = true;
                FNLabel.ForeColor = System.Drawing.Color.Red;
                FlagList.Add(2);
            }
            else
            {
                FNLabel.ForeColor = System.Drawing.Color.Black;
            }

            if (LN == "")
            {
                flag = true;
                FlagList.Add(3);
                LNLabel.ForeColor = System.Drawing.Color.Red;
            }
            else if (!(LN.All(Char.IsLetter)))
            {
                flag = true;
                LNLabel.ForeColor = System.Drawing.Color.Red;
                bool exists = false;
                for (int i = 0; i < FlagList.Count(); i++)
                {
                    if (FlagList[i] == 2)
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    FlagList.Add(2);
                }
            }
            else
            {
                LNLabel.ForeColor = System.Drawing.Color.Black;
            }

            if (!(MN.All(c => Char.IsLetter(c) || c == ' ')))
            {
                MNLabel.ForeColor = System.Drawing.Color.Red;
                flag = true;
                bool exists = false;
                for (int i = 0; i < FlagList.Count(); i++)
                {
                    if (FlagList[i] == 2)
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    FlagList.Add(2);
                }
            }
            else
            {
                MNLabel.ForeColor = System.Drawing.Color.Black;
            }

            if (!(MdN.All(Char.IsLetter)))
            {
                MdNLabel.ForeColor = System.Drawing.Color.Red;
                flag = true;
                bool exists = false;
                for (int i = 0; i < FlagList.Count(); i++)
                {
                    if (FlagList[i] == 2)
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    FlagList.Add(2);
                }
            }
            else
            {
                MNLabel.ForeColor = System.Drawing.Color.Black;
            }

            // Gender validity checking
            if (MaleButton.Checked)
            {
                IsMale = true;
                GenderLabel.ForeColor = System.Drawing.Color.Black;
            }
            else if (FemaleButton.Checked)
            {
                IsMale = false;
                GenderLabel.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                flag = true;
                FlagList.Add(4);
                GenderLabel.ForeColor = System.Drawing.Color.Red;
            }

            if (IsDeceased.Checked == true)
            {
                if (DoBEntry.Value.Date > DoDEntry.Value.Date)
                {
                    flag = true;
                    FlagList.Add(5);
                    DoDLabel.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    DoDLabel.ForeColor = System.Drawing.Color.Black;
                    DDay = DoDEntry.Value;
                }
            }

            // Store selected kids in temp list.
            foreach (int pers in KidsEntry.CheckedIndices)
            {
                TempKid = int.Parse(KidsEntry.Items[pers].ToString().Substring(1, 5));
                Kid.Add(TempKid);
            }

            for (int i = 0; i < SpouseKidsDisplay.Items.Count; i++)
            {
                TempKid = int.Parse(SpouseKidsDisplay.Items[i].ToString().Substring(1, 5));
                Kid.Add(TempKid);
            }

            if ((SpouseEntry.SelectedIndex == 0) && (ParentsEntry.SelectedIndex == 0) && (KidsEntry.CheckedIndices.Count == 0) && (MainW.GetRecordNum() != 1))
            {
                flag = true;
                FlagList.Add(6);
            }

            // If no error thrown, commmit changes.
            if (!flag)
            {
                for (int i = 0; i < PreviousNamesList.Items.Count; i++)
                {
                    PrevNames.Add(PreviousNamesList.Items[i].ToString());
                }
                if (ParentsEntry.SelectedIndex > 0)
                {
                    for (int i = 1; i < MainW.GetNumParents(); i++)
                    {
                        if (int.Parse(ParentsEntry.Text.Substring(1, 5)) == MainW.GetParentsFromParentList(i).GetFatherNumber() ||
                                (int.Parse(ParentsEntry.Text.Substring(1, 5)) == MainW.GetParentsFromParentList(i).GetMotherNumber()))
                        {
                            C = MainW.GetParentsFromParentList(i);
                            break;
                        }
                    }
                }
                if (SpouseEntry.SelectedIndex > 0)
                {
                    SpouseNum = int.Parse(SpouseEntry.Text.Substring(1, 5));
                    if (MainW.GetLastName(SpouseNum) != LN)
                    {
                        if (IsMale)
                        {
                            MainW.SetMaidenName(SpouseNum, MainW.GetLastName(SpouseNum));
                            MainW.SetLastName(SpouseNum, LN);
                        }
                        else
                        {
                            MdN = LN;
                            LN = MainW.GetLastName(SpouseNum);
                        }
                    }
                }
                MainW.AddNewRecord(MainW.GetRecordNum(), FN, MN, LN, MdN, PrevNames, BDay, DDay, IsMale, SpouseNum, C, Kid);
                Success Succ = new Success();
                Succ.ShowDialog();
                MainW.Enable_Menu();
                MainW.NextRec();
                this.Close();
            }

            // If any errors were thrown display them and ignore the submit request.
            else
            {
                ShowErrors(FlagList);
            }

        }


        private void AddCancel_Click(object sender, EventArgs e)
        {
            MainW.Enable_Menu();
            this.Close();
        }


        private void ParentsEntry_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ParentsEntry.Focused)
            {
                if (ParentsEntry.SelectedIndex == 0)
                {
                    ResetSpouse();
                }
                else
                {
                    RemoveSpouse();
                }
                DisplayKids();
            }
        }

        private void SpouseEntry_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SpouseEntry.Focused)
            {
                if (SpouseEntry.SelectedIndex == 0)
                {
                    ResetParents();
                }
                else
                {
                    RemoveParents();
                }
                DisplayKids();
            }

        }

        private void ResetSpouse()
        {
            SpouseEntry.Items.Clear();
            SpouseEntry.Items.Add("-Not married/Spouse not listed");

            SpouseEntry.SelectedIndex = 0;
            if (FemaleButton.Checked)
            {
                for (int i = 1; i < MainW.GetRecordNum(); i++)
                {
                    if ((MainW.GetSpouse(i) == 0) && (MainW.GetGender(i) == true))
                    {
                        if (!(DoBEntry.Value.Date > MainW.GetDateOfDeath(i).Date) || (MainW.GetDateOfDeath(i) == DateTime.MinValue))
                        {
                            if (IsDeceased.Checked == false)
                            {
                                if (Math.Abs(DoBEntry.Value.Date.Year - MainW.GetDateOfBirth(i).Year) < 100)
                                {
                                    string Entry = "[" + i.ToString("00000") + "] - " + MainW.GetLastName(i) + ", " + MainW.GetFirstName(i);
                                    SpouseEntry.Items.Add(Entry);
                                }
                            }
                            else
                            {
                                if (!(DoDEntry.Value.Date < MainW.GetDateOfBirth(i).Date))
                                {
                                    if (Math.Abs(DoBEntry.Value.Date.Year - MainW.GetDateOfBirth(i).Year) < 100)
                                    {
                                        string Entry = "[" + i.ToString("00000") + "] - " + MainW.GetLastName(i) + ", " + MainW.GetFirstName(i);
                                        SpouseEntry.Items.Add(Entry);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (MaleButton.Checked)
            {
                for (int i = 1; i < MainW.GetRecordNum(); i++)
                {
                    if ((MainW.GetSpouse(i) == 0) && (MainW.GetGender(i) == false))
                    {
                        if (!(DoBEntry.Value.Date > MainW.GetDateOfDeath(i).Date) || (MainW.GetDateOfDeath(i) == DateTime.MinValue))
                        {
                            if (IsDeceased.Checked == false)
                            {
                                if (Math.Abs(DoBEntry.Value.Date.Year - MainW.GetDateOfBirth(i).Year) < 100)
                                {
                                    string Entry = "[" + i.ToString("00000") + "] - " + MainW.GetLastName(i) + ", " + MainW.GetFirstName(i);
                                    SpouseEntry.Items.Add(Entry);
                                }
                            }
                            else
                            {
                                if (!(DoDEntry.Value.Date < MainW.GetDateOfBirth(i).Date))
                                {
                                    if (Math.Abs(DoBEntry.Value.Date.Year - MainW.GetDateOfBirth(i).Year) < 100)
                                    {
                                        string Entry = "[" + i.ToString("00000") + "] - " + MainW.GetLastName(i) + ", " + MainW.GetFirstName(i);
                                        SpouseEntry.Items.Add(Entry);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ResetParents()
        {
            ParentsEntry.Items.Clear();
            ParentsEntry.Items.Add("-Parents not listed");
            ParentsEntry.SelectedIndex = 0;
            for (int i = 1; i < MainW.GetNumParents(); i++)
            {
                Couples Current = MainW.GetParentsFromParentList(i);
                string Entry = "";
                if (LastNameEntry.Text != "")
                {
                    if ((MainW.GetLastName(Current.GetFatherNumber()) == LastNameEntry.Text) || (MainW.GetMaidenName(Current.GetMotherNumber()) == LastNameEntry.Text)
                        || (MainW.GetLastName(Current.GetMotherNumber()) == LastNameEntry.Text))
                    {
                        if (Current.GetFatherNumber() == 0)
                        {
                            Entry += "[" + Current.GetMotherNumber().ToString("00000") + "] - " + MainW.GetLastName(Current.GetMotherNumber()) + ", " + MainW.GetFirstName(Current.GetMotherNumber());
                        }
                        else if (Current.GetMotherNumber() == 0)
                        {
                            Entry += "[" + Current.GetFatherNumber().ToString("00000") + "] - " + MainW.GetLastName(Current.GetFatherNumber()) + ", " + MainW.GetFirstName(Current.GetFatherNumber());
                        }
                        else
                        {
                            Entry += "[" + Current.GetFatherNumber().ToString("00000") + ", " + Current.GetMotherNumber().ToString("00000") + "] - " + MainW.GetLastName(Current.GetFatherNumber()) + ", " + MainW.GetFirstName(Current.GetFatherNumber()) + " and "
                                + MainW.GetFirstName(Current.GetMotherNumber());
                        }
                        ParentsEntry.Items.Add(Entry);
                    }
                }
            }
        }


        private void RemoveSpouse()
        {
            int p1 = 0, p2 = 0; 
            for(int i = 1; i < SpouseEntry.Items.Count; i++)
            {
                p1 = int.Parse(ParentsEntry.Text.Substring(1, 5));
                if (ParentsEntry.Text.Substring(6, 1) != "]")
                {
                    p2 = int.Parse(ParentsEntry.Text.Substring(8, 5));
                }
                if((int.Parse(SpouseEntry.Items[i].ToString().Substring(1,5)) == p1) || (int.Parse(SpouseEntry.Items[i].ToString().Substring(1,5)) == p2))
                {
                    SpouseEntry.Items.RemoveAt(i);
                }
            }
        }

        private void RemoveParents()
        {
            int p1 = 0, p2 = 0, p3 = 0;
            for (int i = 1; i < ParentsEntry.Items.Count; i++)
            {
                p1 = MainW.GetParentsFromParentList(i).GetFatherNumber();
                p2 = MainW.GetParentsFromParentList(i).GetMotherNumber();
                p3 = int.Parse(SpouseEntry.Text.Substring(1, 5));

                if ((p3 == p1) || (p3 == p2))
                {
                    ParentsEntry.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void DisplayKids()
        {
            if (LastNameEntry.Text != "")
            {
                int p1 = 0, p2 = 0, p3 = 0;
                if (ParentsEntry.SelectedIndex > 0)
                {
                    p1 = int.Parse(ParentsEntry.SelectedItem.ToString().Substring(1, 5));
                    if (ParentsEntry.SelectedItem.ToString().Substring(6, 1) != "]")
                    {
                        p2 = int.Parse(ParentsEntry.SelectedItem.ToString().Substring(8, 5));
                    }

                }

                if (SpouseEntry.SelectedIndex > 0)
                {
                    p3 = int.Parse(SpouseEntry.SelectedItem.ToString().Substring(1, 5));
                }

                KidsEntry.Items.Clear();
                SpouseKidsDisplay.Items.Clear();
                bool PreviousMatch;
                for (int i = 1; i < MainW.GetRecordNum(); i++)
                {
                    PreviousMatch = false;
                    for (int j = 0; j < PreviousNamesList.Items.Count; j++)
                    {
                        if ((PreviousNamesList.Items[j].ToString() == MainW.GetLastName(i)) || (PreviousNamesList.Items[j].ToString() == MainW.GetMaidenName(i)))
                        {
                            PreviousMatch = true;
                        }
                    }
                    if ((LastNameEntry.Text == MainW.GetLastName(i)) || (LastNameEntry.Text == MainW.GetMaidenName(i))
                        || ((MaidenNameEntry.Text == MainW.GetLastName(i)) && (MaidenNameEntry.Text != "")) ||
                        ((MaidenNameEntry.Text == MainW.GetMaidenName(i)) && (MaidenNameEntry.Text != "")) ||
                        (PreviousMatch == true))
                    {
                        if ((i != p1) && (i != p2) && (i != p3))
                        {
                            KidsEntry.Items.Add("[" + i.ToString("00000") + "] " + MainW.GetLastName(i) + ", " + MainW.GetFirstName(i));
                        }
                    }
                }

                if((SpouseEntry.SelectedIndex != 0) && (KidsEntry.Items.Count > 0))
                {
                    int TempSpouse = int.Parse(SpouseEntry.Text.Substring(1, 5));
                    List<int> TempKids = MainW.GetChildren(TempSpouse);
                    if (TempKids.Count != 0)
                    {
                        for (int i = 0; i < KidsEntry.Items.Count; i++)
                        {
                            for (int j = 0; j < TempKids.Count; j++)
                            {
                                if (KidsEntry.Items[i].ToString().Substring(1,5) == TempKids[j].ToString("00000"))
                                {
                                    KidsEntry.Items.RemoveAt(i);
                                    SpouseKidsDisplay.Items.Add("[" + TempKids[j].ToString("00000") + "] " + MainW.GetLastName(TempKids[j]) + ", " 
                                        + MainW.GetFirstName(TempKids[j]));
                                }
                            }
                        }
                    }
                }

                if(ParentsEntry.SelectedIndex > 0)
                {
                    RemoveAllParentsFromKidsList(int.Parse(ParentsEntry.Text.Substring(1,5)));
                    if(ParentsEntry.Text[6] != ']')
                    {
                        RemoveAllParentsFromKidsList(int.Parse(ParentsEntry.Text.Substring(8, 5)));
                    }
                    for(int i = 0; i < MainW.GetChildren(int.Parse(ParentsEntry.Text.Substring(1,5))).Count; i++)
                    {
                        RemoveAllKidsFromKidsList(int.Parse(ParentsEntry.Text.Substring(1, 5)));
                        for (int j = 0; j < KidsEntry.Items.Count; j++)
                        {
                            if (MainW.GetChildren(int.Parse(ParentsEntry.Text.Substring(1, 5)))[i] == int.Parse(KidsEntry.Items[j].ToString().Substring(1, 5)))
                            {
                                KidsEntry.Items.RemoveAt(j);
                            }
                        }
                    }
                }
            }
        }

        private void RemoveAllParentsFromKidsList(int Curr)
        {
            if(MainW.GetParentsFromRecord(Curr).GetFatherNumber() != 0)
            {
                RemoveAllParentsFromKidsList(MainW.GetParentsFromRecord(Curr).GetFatherNumber());
                RemoveAllKidsFromKidsList(MainW.GetParentsFromRecord(Curr).GetFatherNumber());
                for (int i = 0; i < KidsEntry.Items.Count; i++)
                {
                    if (MainW.GetParentsFromRecord(Curr).GetFatherNumber() == int.Parse(KidsEntry.Items[i].ToString().Substring(1, 5)))
                    {
                        KidsEntry.Items.RemoveAt(i);
                    }
                }
            }
            if (MainW.GetParentsFromRecord(Curr).GetMotherNumber() != 0)
            {
                RemoveAllParentsFromKidsList(MainW.GetParentsFromRecord(Curr).GetMotherNumber());
                if(MainW.GetParentsFromRecord(Curr).GetFatherNumber() == 0)
                {
                    RemoveAllKidsFromKidsList(MainW.GetParentsFromRecord(Curr).GetMotherNumber());
                }
                for (int i = 0; i < KidsEntry.Items.Count; i++)
                {
                    if (MainW.GetParentsFromRecord(Curr).GetMotherNumber() == int.Parse(KidsEntry.Items[i].ToString().Substring(1,5)))
                    {
                        KidsEntry.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void RemoveAllKidsFromKidsList(int Curr)
        {
            for (int i = 0; i < MainW.GetChildren(Curr).Count; i++)
            {
                RemoveAllKidsFromKidsList(MainW.GetChildren(Curr)[i]);
                for(int j = 0; j < KidsEntry.Items.Count; j++)
                {
                    if(MainW.GetChildren(Curr)[i] == int.Parse(KidsEntry.Items[j].ToString().Substring(1,5)))
                    {
                        KidsEntry.Items.RemoveAt(j);
                    }
                }
            }
        }

        private void LastNameEntry_TextChanged(object sender, EventArgs e)
        {
            if (LastNameEntry.Text != "")
            {
                char[] Capitalized = LastNameEntry.Text.ToCharArray();
                Capitalized[0] = char.ToUpper(Capitalized[0]);
                LastNameEntry.Text = new string(Capitalized);
                LastNameEntry.SelectionStart = LastNameEntry.TextLength;
            }
            ResetSpouse();
            ResetParents();
            DisplayKids();
        }

        private void MaidenNameEntry_TextChanged(object sender, EventArgs e)
        {
            if (MaidenNameEntry.Text != "")
            {
                char[] Capitalized = MaidenNameEntry.Text.ToCharArray();
                Capitalized[0] = char.ToUpper(Capitalized[0]);
                MaidenNameEntry.Text = new string(Capitalized);
                MaidenNameEntry.SelectionStart = MaidenNameEntry.TextLength;
            }
            ResetSpouse();
            ResetParents();
            DisplayKids();
        }

        private void MaleButton_Click(object sender, EventArgs e)
        {
            ResetSpouse();
        }

        private void FemaleButton_Click(object sender, EventArgs e)
        {
            ResetSpouse();
        }

        // Prevent highlighting text in name fields since deleting all text at once
        // prevents updating fields from working correctly.
        private void LastNameEntry_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (LastNameEntry.SelectedText.Length > 0)
            {
                LastNameEntry.SelectionLength = 0;
            }
        }

        private void MaidenNameEntry_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (MaidenNameEntry.SelectedText.Length > 0)
            {
                MaidenNameEntry.SelectionLength = 0;
            }
        }

        private void FirstNameEntry_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (LastNameEntry.SelectedText.Length > 0)
            {
                LastNameEntry.SelectionLength = 0;
            }
        }

        private void MiddleNameEntry_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (LastNameEntry.SelectedText.Length > 0)
            {
                LastNameEntry.SelectionLength = 0;
            }
        }

        private void DoBEntry_ValueChanged(object sender, EventArgs e)
        {
            ResetSpouse();
            ResetParents();
            DisplayKids();
        }

        private void DoDEntry_ValueChanged(object sender, EventArgs e)
        {
            ResetSpouse();
            ResetParents();
            DisplayKids();
        }

        private void ShowErrors(List<int> ErrorList)
        {
            string AllErrors = "";
            for (int i = 0; i < ErrorList.Count(); i++)
                switch (ErrorList[i])
                {
                    case 1:
                        AllErrors += "First name cannot be blank\n";
                        break;
                    case 2:
                        AllErrors += "Names must only contain letters (spaces allowed in the middle name field)\n";
                        break;
                    case 3:
                        AllErrors += "Last name cannot be blank\n";
                        break;
                    case 4:
                        AllErrors += "Must select gender\n";
                        break;
                    case 5:
                        AllErrors += "Date of death cannot precede date of birth\n";
                        break;
                    case 6:
                        AllErrors += "New record must be linked to an existing record (as a spouse, parent, or kid)";
                        break;
                }
            MessageBox.Show(AllErrors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PreviousRemoveButton_Click(object sender, EventArgs e)
        {
            if(PreviousNamesList.SelectedIndex != -1)
            {
                for(int i = PreviousNamesList.SelectedItems.Count; i > 0; i--)
                {
                    PreviousNamesList.Items.RemoveAt(PreviousNamesList.SelectedIndices[i - 1]);
                }
            }
        }

        private void PreviousAddButton_Click(object sender, EventArgs e)
        {
            if (PreviousNamesEntry.Text != "")
            {
                if (!(PreviousNamesEntry.Text.All(Char.IsLetter)))
                {
                    MessageBox.Show("Only letters are allowed in the name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool found = false;
                foreach (string s in PreviousNamesList.Items)
                {
                    if (s == PreviousNamesEntry.Text)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    PreviousNamesList.Items.Add(PreviousNamesEntry.Text);
                    DisplayKids();
                }
            }
        }

        private void FirstNameEntry_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameEntry.Text != "")
            {
                char[] Capitalized = FirstNameEntry.Text.ToCharArray();
                Capitalized[0] = char.ToUpper(Capitalized[0]);
                FirstNameEntry.Text = new string(Capitalized);
                FirstNameEntry.SelectionStart = FirstNameEntry.TextLength;
            }
        }

        private void MiddleNameEntry_TextChanged(object sender, EventArgs e)
        {
            if (MiddleNameEntry.TextLength == 0)
            {
                return;
            }
            else if (((MiddleNameEntry.TextLength > 0) && (MiddleNameEntry.TextLength < 2)) || (MiddleNameEntry.Text[MiddleNameEntry.TextLength-1] == ' '))
            {
                char[] Capitalized = MiddleNameEntry.Text.ToCharArray();
                Capitalized[0] = char.ToUpper(Capitalized[0]);
                MiddleNameEntry.Text = new string(Capitalized);
                MiddleNameEntry.SelectionStart = MiddleNameEntry.TextLength;
            }
            else
            {
                if (MiddleNameEntry.Text.Contains(" "))
                {
                    string[] MidNames = MiddleNameEntry.Text.Split(' ');
                    string AllMidNames = "";
                    foreach (string n in MidNames)
                    {
                        AllMidNames += char.ToUpper(n[0]) + n.Substring(1) + ' ';
                    }
                    AllMidNames = AllMidNames.Remove(AllMidNames.Length - 1);
                    MiddleNameEntry.Text = AllMidNames;
                    MiddleNameEntry.SelectionStart = MiddleNameEntry.TextLength;
                }
                else
                {
                    char[] Capitalized = MiddleNameEntry.Text.ToCharArray();
                    Capitalized[0] = char.ToUpper(Capitalized[0]);
                    MiddleNameEntry.Text = new string(Capitalized);
                    MiddleNameEntry.SelectionStart = MiddleNameEntry.TextLength;
                }
            }
        }

        private void PreviousNamesEntry_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (PreviousNamesEntry.SelectedText.Length > 0)
            {
                PreviousNamesEntry.SelectionLength = 0;
            }
        }

        private void PreviousNamesEntry_TextChanged(object sender, EventArgs e)
        {
            if (PreviousNamesEntry.Text != "")
            {
                char[] Capitalized = PreviousNamesEntry.Text.ToCharArray();
                Capitalized[0] = char.ToUpper(Capitalized[0]);
                PreviousNamesEntry.Text = new string(Capitalized);
                PreviousNamesEntry.SelectionStart = PreviousNamesEntry.TextLength;
            }
        }
    }
}

