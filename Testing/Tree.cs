using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC
{
    /// <summary>
    /// A simple class containing two variables, a record number for both a father and mother.
    /// </summary>
    /// <remarks>
    /// Used to link couples together, especially to make setting kids for couples easier.
    /// </remarks>
    public class Couples
    {
        private int FatherNumber;
        private int MotherNumber;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Couples()
        {
            FatherNumber = 0;
            MotherNumber = 0;
        }

        /// <summary>
        /// Main constructor.  Takes in a newly created record number and gender to set either a father or mother.
        /// </summary>
        /// <remarks>
        /// Since a new couple is only created when a new record is added, only one record is sent in the constructor.
        /// The other spouse is added later when they are linked through another record.
        /// </remarks>
        /// <param name="Record"></param>
        /// <param name="Gend"></param>
        public Couples(int Record, bool Gend)
        {
            if (Gend == true)
            {
                FatherNumber = Record;
                MotherNumber = 0;
            }
            else
            {
                MotherNumber = Record;
                FatherNumber = 0;
            }
        }

        /// <summary>
        /// Get the male spouse.
        /// </summary>
        /// <returns>
        /// Male spouse's record number.
        /// </returns>
        public int GetFatherNumber()
        {
            return FatherNumber;
        }

        /// <summary>
        /// Get the female spouse.
        /// </summary>
        /// <returns>
        /// Female spouse's record number.
        /// </returns>
        public int GetMotherNumber()
        {
            return MotherNumber;
        }

        /// <summary>
        /// Sets the father's record number.
        /// </summary>
        /// <param name="F">Record number of the father.</param>
        public void SetFatherNumber(int F)
        {
            FatherNumber = F;
        }

        /// <summary>
        /// Sets the mother's record number.
        /// </summary>
        /// <param name="M">Record number of the mother.</param>
        public void SetMotherNumber(int M)
        {
            MotherNumber = M;
        }

    }

    class TreeNode
    {
        private int Record;
        private string FirstName;
        private string LastName;
        private string MiddleName;
        private string MaidenName;
        private bool IsMale;
        private DateTime Birth;
        private DateTime Death;
        private Couples Parents = null;
        private int Spouse;
        private List<int> Kids = new List<int>();
        private List<int> Siblings = new List<int>();
        private List<string> PreviousNames = new List<string>();

        public TreeNode()
        {
            Record = 0;
            SetName("", "", "", "");
            Birth = DateTime.MinValue;
            Death = DateTime.MinValue;
            IsMale = true;
        }
        public TreeNode(int R, string Fn, string Mn, string Ln, string Mdn, List<string> Prev, DateTime Bir, DateTime Dea, bool Mal, int Sp, Couples C)
        {
            Record = R;
            SetName(Fn, Mn, Ln, Mdn);
            PreviousNames = Prev;
            Birth = Bir;
            Death = Dea;
            IsMale = Mal;
            Spouse = Sp;
            Parents = C;
        }

        public void SetRecord(int R)
        {
            Record = R;
        }

        public int GetRecord()
        {
            return Record;
        }

        public void SetName(string First, string Middle, string Last, string Maid)
        {
            FirstName = First;
            MiddleName = Middle;
            LastName = Last;
            MaidenName = Maid;
        }

        public string GetFName()
        {
            return FirstName;
        }

        public string GetMName()
        {
            return MiddleName;
        }

        public string GetLName()
        {
            return LastName;
        }

        public string GetMdName()
        {
            return MaidenName;
        }

        public void SetLName(string LN)
        {
            LastName = LN;
        }

        public void SetMdName(string MDN)
        {
            MaidenName = MDN;
        }


        public void SetGender(bool Mal)
        {
            IsMale = Mal;
        }

        public bool GetGend()
        {
            return IsMale;
        }

        public DateTime GetDoB()
        {
            return Birth;
        }

        public void SetDoB(DateTime DOB)
        {
            Birth = DOB;
        }

        public void SetDoD(DateTime DOD)
        {
            Death = DOD;
        }
        public DateTime GetDoD()
        {
            return Death;
        }

        public void SetSpouse(int SpouseNum)
        {
            Spouse = SpouseNum;
        }

        public int GetSpouse()
        {
            return Spouse;
        }

        public Couples GetParents()
        {
            return Parents;
        }

        public void SetParents(Couples Par)
        {
            Parents = Par;
        }

        public void SetChildren(List<int> NewKids)
        {
            Kids = NewKids;
        }

        public List<int> GetChildren()
        {
            return Kids;

        }

        public void SetPreviousNames (List<string> PrevNames)
        {
            PreviousNames = PrevNames;
        }

        public List<string> GetPreviousNames()
        {
            return PreviousNames;
        }

        /// <summary>
        /// Stores a list of sibling numbers. 
        /// Not currently used (other than as a placeholder in save files) but left in for future implementation.
        /// </summary>
        /// <param name="NewSibs"></param>
        public void SetSiblings(List<int> NewSibs)
        {
            Siblings = NewSibs;
        }

        /// <summary>
        /// Returns a list of siblings for the current record. 
        /// Not currently used (other than as a placeholder in save files) but left in for future implementation.
        /// </summary>
        /// <returns>Sibling List</returns>
        public List<int> GetSiblings()
        {
            return Siblings;
        }
    }
}
