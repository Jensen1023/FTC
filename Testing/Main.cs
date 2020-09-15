using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace FTC
{
    /// <summary>
    /// Creates the main form that runs everything in the application.
    /// All other forms are displayed in a panel within this form.
    /// </summary>
    public partial class MainWindow : Form
    {
        private int RecNum = 1;
        private TreeNode CurrentFamNode;
        private List<TreeNode> FamTree;
        private List<Couples> ParentsList = new List<Couples>();
        private string CurrentFile = "";

        /// <summary>
        /// Initialize the main form.
        /// Also creates new instances for all of the declared objects of the form.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            FamTree = new List<TreeNode>();
            CurrentFamNode = new TreeNode();
            FamTree.Add(CurrentFamNode);
            Couples PlaceHolder = new Couples(0, true);
            ParentsList.Add(PlaceHolder);
        }

        /// <summary>
        /// Resets all objects in the main form.
        /// </summary>
        /// <remarks>
        /// Used when the New or Open options of the menu strip are selected.
        /// </remarks>
        public void Reset()
        {
            RecNum = 1;
            FamTree.Clear();
            CurrentFamNode = new TreeNode();
            FamTree.Add(CurrentFamNode);
            ParentsList.Clear();
            Couples PlaceHolder = new Couples(0, true);
            ParentsList.Add(PlaceHolder);
            CurrentFile = "";
        }

        /// <summary>
        /// Disables side buttons when a form is loaded in the main form's panel.
        /// </summary>
        public void Disable_Menu()
        {
            AddR.Enabled = false;
            RetR.Enabled = false;
            SumView.Enabled = false;
        }

        /// <summary>
        /// Reenable side buttons once a panel form is closed.
        /// </summary>
        public void Enable_Menu()
        {
            AddR.Enabled = true;
            RetR.Enabled = true;
            SumView.Enabled = true;
        }

        /// <summary>
        /// Gets the current record number.
        /// </summary>
        /// <remarks>
        /// Used to determine how many records are currently stored.
        /// Note: A dummy record is added initially to match up a record's
        /// number with its index in the list.
        /// </remarks>
        /// <returns>
        /// The current number of records stored.
        /// </returns>
        public int GetRecordNum()
        {
            return RecNum;
        }

        /// <summary>
        /// Increases the current record number.
        /// </summary>
        /// <remarks>
        /// Increases when a new record is added.
        /// </remarks>
        public void NextRec()
        {
            RecNum++;
        }   

        /// <summary>
        /// Adds a new record to the record list.
        /// </summary>
        /// <remarks>
        /// Called upon successful completion of a <c>NewRecord</c> form.
        /// </remarks>
        /// <param name="R">The current record number.</param>
        /// <param name="Fn">String containing first name.</param>
        /// <param name="Mn">String containing middle name.</param>
        /// <param name="Ln">String containing last name.</param>
        /// <param name="Mdn">String containing maiden name.</param>
        /// <param name="Prev">List of strings containing any previous last names used.</param>
        /// <param name="Bir">Datetimne containing the date of birth.</param>
        /// <param name="Dea">Datetime containing the date of death.</param>
        /// <param name="Mal">Bool representing gender (true for male).</param>
        /// <param name="Sp">The listed spouse's record number.</param>
        /// <param name="C">A <c>Couples</c> containing the listed parents.</param>
        /// <param name="K">A list of the record numbers of the listed children.</param>
        public void AddNewRecord (int R, string Fn, string Mn, string Ln, string Mdn, List<string> Prev, DateTime Bir, DateTime Dea, bool Mal, int Sp, Couples C, List<int> K)
        {
            // Add the results from the NewRecord form to the list of records.
            CurrentFamNode = new TreeNode(R, Fn, Mn, Ln, Mdn, Prev, Bir, Dea, Mal, Sp, C);
            FamTree.Add(CurrentFamNode);

            // Add this record to the list of couples.
            LogParent(R, Sp, Mal);

            // Add this record as a kid to the parent's kid list if parents are listed.
            if ((C.GetFatherNumber() != 0) || (C.GetMotherNumber() != 0))
            {

                // Add to father.
                if (C.GetFatherNumber() != 0)
                {
                    List<int> TempChildren = FamTree[C.GetFatherNumber()].GetChildren();
                    bool found = false;
                    for (int i = 0; i < TempChildren.Count; i++)
                    {
                        if (TempChildren[i] == R)
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        TempChildren.Add(R);
                    }
                }

                // Add to mother.
                if (C.GetMotherNumber() != 0)
                {
                    List<int> TempChildren = FamTree[C.GetMotherNumber()].GetChildren();
                    bool found = false;
                    for (int i = 0; i < TempChildren.Count; i++)
                    {
                        if (TempChildren[i] == R)
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        TempChildren.Add(R);
                    }
                }
            }

            // If kids were listed add them to this record then set this record as a parent for each kid.
            if (K.Count != 0)
            {
                SetChildren(K, R);
                Couples TempPar = new Couples();
                for (int j = 1; j < ParentsList.Count; j++)
                {
                    if (Mal)
                    {
                        if (ParentsList[j].GetFatherNumber() == R)
                            TempPar = ParentsList[j];
                    }
                    else
                    {
                        if (ParentsList[j].GetMotherNumber() == R)
                            TempPar = ParentsList[j];
                    }
                }
                for (int i = 0; i < K.Count; i++)
                {
                    FamTree[K[i]].SetParents(TempPar);
                }
            }

            // If spouse was listed set this record as the spouse's spouse then share both spouse's listed kids.
            // (May need to verify that both spouses end up with the same kids list).
            if (Sp != 0)
            {
                FamTree[Sp].SetSpouse(R);
                if(K.Count != 0)
                {
                    List<int> TempChildren = FamTree[Sp].GetChildren();
                    foreach (int i in K)
                    {
                        bool found = false;
                        foreach (int j in FamTree[Sp].GetChildren())
                        {
                            if (j == i)
                            {
                                found = true;
                            }
                        }
                        if (found == false)
                        {
                            TempChildren.Add(i);
                        }
                    }
                    FamTree[Sp].SetChildren(TempChildren);
                }
            }
        }

     // ***Get (from TreeNode) Methods***

        /// <summary>
        /// Get a record's full name (excluding any previously used last names).
        /// </summary>
        /// <param name="index">The record number that corresponds to the needed name.</param>
        /// <returns>
        /// A string containing a full name.
        /// </returns>
        public string GetFullName(int index)
        {
            string Full = FamTree[index].GetFName();
            if (FamTree[index].GetMName() != "")
            {
                Full += " " + FamTree[index].GetMName();
            }
            if (FamTree[index].GetMdName() != "")
            {
                Full += " (" + FamTree[index].GetMdName() + ")";
            }
            Full += " " + FamTree[index].GetLName();
            return Full;
        }

        /// <summary>
        /// Get a record's last name.
        /// </summary>
        /// <param name="index">The record number that corresponds to the needed name.</param>
        /// <returns>
        /// A string containing the last name.
        /// </returns>
        public string GetLastName(int index)
        {
            return FamTree[index].GetLName();
        }

        /// <summary>
        /// Get a record's first name.
        /// </summary>
        /// <param name="index">The record number that corresponds to the needed name.</param>
        /// <returns>
        /// A string containing the first name.
        /// </returns>
        public string GetFirstName(int index)
        {
            return FamTree[index].GetFName();
        }

        /// <summary>
        /// Get a record's maiden name.
        /// </summary>
        /// <param name="index">The record number that corresponds to the needed name.</param>
        /// <returns>
        /// A string containing the maiden name.
        /// </returns>
        public string GetMaidenName(int index)
        {
            return FamTree[index].GetMdName();
        }

        /// <summary>
        /// Get a record's gender.
        /// </summary>
        /// <param name="index">The record number that corresponds to the needed gender.</param>
        /// <returns>
        /// A bool containing the gender (true is male).
        /// </returns>
        public bool GetGender(int index)
        {
            return FamTree[index].GetGend();
        }

        /// <summary>
        /// Get a record's date of birth.
        /// </summary>
        /// <param name="index">The record number that corresponds to the needed date.</param>
        /// <returns>
        /// A DateTime containing the date of birth.
        /// </returns>
        public DateTime GetDateOfBirth(int index)
        {
            return FamTree[index].GetDoB();
        }

        /// <summary>
        /// Get a record's date of death.
        /// </summary>
        /// <param name="index">The record number that corresponds to the needed date.</param>
        /// <returns>
        /// A DateTime containing the date of death.
        /// </returns>
        public DateTime GetDateOfDeath(int index)
        {
            return FamTree[index].GetDoD();
        }

        /// <summary>
        /// Get a record's spouse number.
        /// </summary>
        /// <param name="index">The record number whose spouse is needed.</param>
        /// <returns>
        /// The spouse's record number.
        /// </returns>
        public int GetSpouse(int index)
        {
            return FamTree[index].GetSpouse();
        }

        /// <summary>
        /// Get a record's children.
        /// </summary>
        /// <param name="index">The record number to get children from.</param>
        /// <returns>
        /// A list containing the record numbers of the children.
        /// </returns>
        public List<int> GetChildren(int index)
        {
            return FamTree[index].GetChildren();
        }

        /// <summary>
        /// Get the parent record numbers of a target record.
        /// </summary>
        /// <param name="index">The record number to get parents of.</param>
        /// <returns>A Couples object containing both parents' record numbers.</returns>
        public Couples GetParentsFromRecord(int index)
        {
            return FamTree[index].GetParents();
        }

    // ***Set (to TreeNode) Methods***

        /// <summary>
        /// Set the target record's last name.
        /// </summary>
        /// <param name="index">Target record number.</param>
        /// <param name="LName">Target's last name</param>
        public void SetLastName(int index, string LName)
        {
            FamTree[index].SetLName(LName);
        }

        /// <summary>
        /// Set the target record's maiden name.
        /// </summary>
        /// <param name="index">Target record number.</param>
        /// <param name="MDName">Target's maiden name.</param>
        public void SetMaidenName(int index, string MDName)
        {
            FamTree[index].SetMdName(MDName);
        }

        /// <summary>
        /// Set the list of children for the target record.
        /// </summary>
        /// <param name="K">List of children record numbers.</param>
        /// <param name="index">Target record's number.</param>
        public void SetChildren(List<int> K, int index)
        {
            FamTree[index].SetChildren(K);
        }

        /*
        public void SetSpouse(int index, int Spou)
        {
            FamTree[index].SetSpouse(Spou);
        }
        */

        /// <summary>
        /// Adds the currently created record number into the parents list.
        /// </summary>
        /// <remarks>
        /// Creates a new Couples object if no spouse was selected for this record,
        /// otherwise links this record to its spouse's Couples object.
        /// </remarks>
        /// <param name="RecordNum">The number of the record being added.</param>
        /// <param name="Spouse">The spouse number of the current record.</param>
        /// <param name="Gend">The gender of the current record.</param>
        public void LogParent(int RecordNum, int Spouse, bool Gend)
        {
            if (Spouse == 0)
            {
                ParentsList.Add(new Couples(RecordNum, Gend));
            }
            else
            {
                for (int i = 0; i < ParentsList.Count; i++)
                {

                    if (Gend == true)
                    {
                        if (ParentsList[i].GetMotherNumber() == Spouse)
                        {
                            ParentsList[i].SetFatherNumber(RecordNum);
                            break;
                        }
                    }
                    else
                    {
                        if (ParentsList[i].GetFatherNumber() == Spouse)
                        {
                            ParentsList[i].SetMotherNumber(RecordNum);
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets the number of Couples objects in the parents list.
        /// </summary>
        /// <returns>
        /// The number of items in the list.
        /// </returns>
        public int GetNumParents()
        {
            return ParentsList.Count();
        }

        /// <summary>
        /// Gets a target Couples object from the parents list.
        /// </summary>
        /// <param name="index">The index of the couple to get.</param>
        /// <returns>
        /// The Couples object (male and/or female record numbers) at the specified index.
        /// </returns>
        public Couples GetParentsFromParentList(int index)
        {
            return ParentsList[index];
        }

        /*
        
        Possible future use.

        public List<int> GetSibs(int index)
        {
            return FamTree[index].GetSiblings();
        }
        */

        /// <summary>
        /// Saves all current record information to a .gen file
        /// </summary>
        /// <remarks>
        /// Uses AES encryption to store the information to file so that users can't
        /// modify it without using this program.
        /// </remarks>
        /// <param name="SaveAs">A bool to determine if this was called from Save or Save As.</param>
        private void SaveData(bool SaveAs)
        {
            if (FamTree.Count > 1)
            {
                // If Save option was chosen and a file name has already been used this session.
                if (!SaveAs && (CurrentFile != ""))
                {

                    // Create a string and write all current information to it.
                    string SaveData = "";
                    for (int i = 1; i < FamTree.Count; i++)
                    {
                        SaveData += i.ToString("00000") + FamTree[i].GetFName() + "|" + FamTree[i].GetMName() + "|" + FamTree[i].GetMdName()
                            + "|" + FamTree[i].GetLName() + "|";

                        if (FamTree[i].GetGend() == true)
                        {
                            SaveData += "M";
                        }
                        else
                        {
                            SaveData += "F";
                        }

                        SaveData += FamTree[i].GetDoB().Month.ToString("00") + FamTree[i].GetDoB().Day.ToString("00") + FamTree[i].GetDoB().Year.ToString("0000");
                        SaveData += FamTree[i].GetDoD().Month.ToString("00") + FamTree[i].GetDoD().Day.ToString("00") + FamTree[i].GetDoD().Year.ToString("0000");
                        SaveData += FamTree[i].GetSpouse().ToString("00000");

                        if (FamTree[i].GetParents() == null)
                        {
                            SaveData += "0000000000";
                        }
                        else
                        {
                            SaveData += FamTree[i].GetParents().GetFatherNumber().ToString("00000") + FamTree[i].GetParents().GetMotherNumber().ToString("00000");
                        }

                        if (FamTree[i].GetChildren().Count == 0)
                        {
                            SaveData += "N";
                        }
                        else
                        {
                            SaveData += "Y" + FamTree[i].GetChildren().Count + "|";
                            for (int j = 0; j < FamTree[i].GetChildren().Count; j++)
                            {
                                SaveData += FamTree[i].GetChildren()[j].ToString("00000");
                            }
                        }

                        if (FamTree[i].GetSiblings().Count == 0)
                        {
                            SaveData += "N";
                        }
                        else
                        {
                            SaveData += "Y" + FamTree[i].GetSiblings().Count + "|";
                            foreach (int val in FamTree[i].GetSiblings())
                            {
                                SaveData += FamTree[i].GetSiblings()[val].ToString("00000");
                            }
                        }
                    }

                    // Encryption process.
                    byte[] ToEncrypted = System.Text.ASCIIEncoding.ASCII.GetBytes(SaveData);

                    AesCryptoServiceProvider Crypto = new AesCryptoServiceProvider
                    {
                        BlockSize = 128,
                        KeySize = 256,
                        Key = System.Text.Encoding.ASCII.GetBytes("abcdefghijklmnop"),
                        IV = System.Text.Encoding.ASCII.GetBytes("zyxwvutsrqponmlk"),
                        Padding = PaddingMode.PKCS7,
                        Mode = CipherMode.CBC
                    };
                    ICryptoTransform CryptoTrans = Crypto.CreateEncryptor(Crypto.Key, Crypto.IV);
                    byte[] Crypted = CryptoTrans.TransformFinalBlock(ToEncrypted, 0, ToEncrypted.Length);
                    System.IO.File.WriteAllBytes(CurrentFile, Crypted);
                    MessageBox.Show("Successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    // Save As option.
                    SaveFileDialog Saved = new SaveFileDialog
                    {
                        AddExtension = true,
                        DefaultExt = "gen",
                        Filter = "Genealogy Document (*.gen)|*.gen"
                    };
                    if (Saved.ShowDialog() == DialogResult.OK)
                    {
                        // Create a string and write all current information to it.
                        string SaveData = "";
                        for (int i = 1; i < FamTree.Count; i++)
                        {
                            SaveData += i.ToString("00000") + FamTree[i].GetFName() + "|" + FamTree[i].GetMName() + "|" + FamTree[i].GetMdName()
                                + "|" + FamTree[i].GetLName() + "|";

                            if (FamTree[i].GetGend() == true)
                            {
                                SaveData += "M";
                            }
                            else
                            {
                                SaveData += "F";
                            }

                            SaveData += FamTree[i].GetDoB().Month.ToString("00") + FamTree[i].GetDoB().Day.ToString("00") + FamTree[i].GetDoB().Year.ToString("0000");
                            SaveData += FamTree[i].GetDoD().Month.ToString("00") + FamTree[i].GetDoD().Day.ToString("00") + FamTree[i].GetDoD().Year.ToString("0000");
                            SaveData += FamTree[i].GetSpouse().ToString("00000");

                            if (FamTree[i].GetParents() == null)
                            {
                                SaveData += "0000000000";
                            }
                            else
                            {
                                SaveData += FamTree[i].GetParents().GetFatherNumber().ToString("00000") + FamTree[i].GetParents().GetMotherNumber().ToString("00000");
                            }

                            if (FamTree[i].GetChildren().Count == 0)
                            {
                                SaveData += "N";
                            }
                            else
                            {
                                SaveData += "Y" + FamTree[i].GetChildren().Count + "|";
                                for (int j = 0; j < FamTree[i].GetChildren().Count; j++)
                                {
                                    SaveData += FamTree[i].GetChildren()[j].ToString("00000");
                                }
                            }

                            if (FamTree[i].GetSiblings().Count == 0)
                            {
                                SaveData += "N";
                            }
                            else
                            {
                                SaveData += "Y" + FamTree[i].GetSiblings().Count + "|";
                                foreach (int val in FamTree[i].GetSiblings())
                                {
                                    SaveData += FamTree[i].GetSiblings()[val].ToString("00000");
                                }
                            }
                        }

                        // Encryption process.
                        byte[] ToEncrypted = System.Text.ASCIIEncoding.ASCII.GetBytes(SaveData);

                        AesCryptoServiceProvider Crypto = new AesCryptoServiceProvider
                        {
                            BlockSize = 128,
                            KeySize = 256,
                            Key = System.Text.Encoding.ASCII.GetBytes("abcdefghijklmnop"),
                            IV = System.Text.Encoding.ASCII.GetBytes("zyxwvutsrqponmlk"),
                            Padding = PaddingMode.PKCS7,
                            Mode = CipherMode.CBC
                        };
                        ICryptoTransform CryptoTrans = Crypto.CreateEncryptor(Crypto.Key, Crypto.IV);
                        byte[] Crypted = CryptoTrans.TransformFinalBlock(ToEncrypted, 0, ToEncrypted.Length);
                        System.IO.File.WriteAllBytes(Saved.FileName, Crypted);
                        MessageBox.Show("Successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            else
            {
                // Save failed if there is nothing to save.
                MessageBox.Show("No records to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    // Form events.

        private void AddRecord_Click(object sender, EventArgs e)
        {
            CurrentFamNode = new TreeNode();
            NewRecord AddRecord = new NewRecord(this)
            {
                TopLevel = false
            };
            panel1.Controls.Add(AddRecord);
            this.Disable_Menu();
            AddRecord.Show();
        }

        private void RetrieveRecord_Click(object sender, EventArgs e)
        {
            DisplayRecord DispRecord = new DisplayRecord(this)
            {
                TopLevel = false
            };
            panel1.Controls.Add(DispRecord);
            this.Disable_Menu();
            DispRecord.Show();
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SumView_Click(object sender, EventArgs e)
        {
            SummaryView SumView = new SummaryView(this)
            {
                TopLevel = false
            };
            
            panel1.Controls.Add(SumView);
            this.Disable_Menu();
            SumView.Show();
        }

        private void TipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. This family tree creator is designed around a traditional family unit.\n" +
                "2. Couples can only be a man and woman.\n" +
                "3. Wives take the husband's last name. If not set by user the creator will do it automatically.\n" +
                "4. Whenever last or maiden names, gender, spouse, or parent fields are changed other fields may be reset to reflect those changes.\n" +
                "5. Only letters are allowed in name fields, except for middle name which allows spaces.\n" +
                "6. After the initial record all records must be linked to an existing record (via spouse, parents or kids).",
                "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(true);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.Count > 1)
            {
                Application.OpenForms[1].Close();
                Enable_Menu();
            }
            if (RecNum > 1)
            {
                if (MessageBox.Show("Doing this will erase all current data", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Reset();
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Accept = true;
            if(RecNum > 1)
            {
                if(MessageBox.Show("Doing this will erase all current data", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                {
                    Accept = false;
                }
            }
            if (Accept)
            {
                if (Application.OpenForms.Count > 1)
                {
                    Application.OpenForms[1].Close();
                    Enable_Menu();
                }
                Reset();
                string FamData;
                byte[] ToDecrypt;
                OpenFileDialog Opened = new OpenFileDialog
                {
                    AddExtension = true,
                    DefaultExt = "gen",
                    Filter = "Genealogy Document (*.gen)|*.gen"
                };
                if (Opened.ShowDialog() == DialogResult.OK)
                {
                    CurrentFile = Opened.FileName;
                    ToDecrypt = System.IO.File.ReadAllBytes(Opened.FileName);
                    AesCryptoServiceProvider Crypto = new AesCryptoServiceProvider
                    {
                        BlockSize = 128,
                        KeySize = 256,
                        Key = System.Text.Encoding.ASCII.GetBytes("abcdefghijklmnop"),
                        IV = System.Text.Encoding.ASCII.GetBytes("zyxwvutsrqponmlk"),
                        Padding = PaddingMode.PKCS7,
                        Mode = CipherMode.CBC
                    };
                    ICryptoTransform CryptoTrans = Crypto.CreateDecryptor(Crypto.Key, Crypto.IV);
                    byte[] DeCrypted = CryptoTrans.TransformFinalBlock(ToDecrypt, 0, ToDecrypt.Length);
                    FamData = System.Text.Encoding.ASCII.GetString(DeCrypted);
                    int i = 0, NextStop = 0, Count = 0;
                    string FirstN, MiddleN, LastN, MaidenN, ParentsParse;
                    DateTime TempBDay = DateTime.MinValue, TempDDay = DateTime.MinValue;
                    CultureInfo ThisCulture = CultureInfo.InvariantCulture;
                    Couples TempParents;
                    List<int> TempKids, TempSibs;
                    do
                    {
                        TempParents = new Couples();
                        FirstN = MiddleN = LastN = MaidenN = "";
                        TreeNode LoadNode = new TreeNode();
                        TempKids = new List<int>();
                        TempSibs = new List<int>();
                        LoadNode.SetRecord(int.Parse(FamData.Substring(i, 5)));
                        i += 5;
                        NextStop = FamData.IndexOf('|', NextStop + 1);
                        FirstN = FamData.Substring(i, NextStop - i);
                        i = NextStop + 1;
                        NextStop = FamData.IndexOf('|', NextStop + 1);
                        if(i != NextStop)
                        {
                            MiddleN = FamData.Substring(i, NextStop - i);
                        }
                        i = NextStop + 1;
                        NextStop = FamData.IndexOf('|', NextStop + 1);
                        if (i != NextStop)
                        {
                            MaidenN = FamData.Substring(i, NextStop - i);
                        }
                        i = NextStop + 1;
                        NextStop = FamData.IndexOf('|', NextStop + 1);
                        LastN = FamData.Substring(i, NextStop - i);
                        i = NextStop + 1;
                        LoadNode.SetName(FirstN, MiddleN, LastN, MaidenN);
                        if (FamData[i] == 'F')
                        {
                            LoadNode.SetGender(false);
                        }
                        else
                        {
                            LoadNode.SetGender(true);
                        }
                        i++;

                        LoadNode.SetDoB(DateTime.ParseExact(FamData.Substring(i, 8), "MMddyyyy", ThisCulture));
                        i += 8;
                        LoadNode.SetDoD(DateTime.ParseExact(FamData.Substring(i, 8), "MMddyyyy", ThisCulture));
                        i += 8;
                        LoadNode.SetSpouse(int.Parse(FamData.Substring(i, 5)));
                        i += 5;
                        ParentsParse = FamData.Substring(i, 10);
                        i += 10;
                        if (ParentsParse == "0000000000")
                        {
                            LoadNode.SetParents(TempParents);
                        }
                        else
                        {
                            TempParents.SetFatherNumber(int.Parse(ParentsParse.Substring(0, 5)));
                            TempParents.SetMotherNumber(int.Parse(ParentsParse.Substring(5, 5)));
                            LoadNode.SetParents(TempParents);
                        }
                        if (FamData[i] == 'N')
                        {
                            i++;
                        }
                        else
                        {
                            i++;
                            NextStop = FamData.IndexOf('|', NextStop + 1);
                            Count = int.Parse(FamData.Substring(i, NextStop - i));
                            i = NextStop + 1;
                            for(int j = 1; j <= Count; j++)
                            {
                                TempKids.Add(int.Parse(FamData.Substring(i, 5)));
                                i += 5;
                            }
                        }
                        if (FamData[i] == 'N')
                        {
                            i++;
                        }
                        else
                        {
                            i++;
                            NextStop = FamData.IndexOf('|', NextStop + 1);
                            Count = int.Parse(FamData.Substring(i, NextStop - i));
                            for (int j = 1; j <= Count; j++)
                            {
                                TempSibs.Add(int.Parse(FamData.Substring(i, 5)));
                                i += 5;
                            }
                        }
                        LoadNode.SetChildren(TempKids);
                        LoadNode.SetSiblings(TempSibs);
                        FamTree.Add(LoadNode);
                        RecNum++;
                    }
                    while (FamData.Length != i);
                    Couples TempCoup;
                    foreach (TreeNode j in FamTree)
                    {
                        if(j.GetGend())
                        {
                            TempCoup = new Couples();
                            TempCoup.SetFatherNumber(j.GetRecord());
                            TempCoup.SetMotherNumber(j.GetSpouse());
                            ParentsList.Add(TempCoup);
                        }
                        else if (j.GetSpouse() == 0)
                        {
                            TempCoup = new Couples();
                            TempCoup.SetMotherNumber(j.GetRecord());
                            TempCoup.SetFatherNumber(0);
                            ParentsList.Add(TempCoup);
                        }
                    }
                    MessageBox.Show("Successfully loaded!", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            this.Refresh();
        }

    
            

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 2.0.2\nVersion Date: 9/14/2020\nCreator: Lynn Jensen", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(false);
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
