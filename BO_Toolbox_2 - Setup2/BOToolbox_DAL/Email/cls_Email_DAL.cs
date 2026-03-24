using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOToolbox_DAL.Email
{
    public class cls_Email_DAL
    {
        #region Variables
        private string _sPth;
        private string _sSht;
        private int _iCol;
        private int _iRow;
        private string _sVal;
        private string _sError;
        private string _sSub;
        private string _sBod;
        private string[] _sarrLin;
        private string[] _sarrBod;
        private List<string> _lstMen = new List<string>();
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Path in the HDD were the Excel file is stored
        /// </summary>
        public string sPth { get => _sPth; set => _sPth = value; }

        /// <summary>
        /// Excel target sheet´s name
        /// </summary>
        public string sSht { get => _sSht; set => _sSht = value; }

        /// <summary>
        /// Cell column number
        /// </summary>
        public int iCol { get => _iCol; set => _iCol = value; }

        /// <summary>
        /// Cell row number
        /// </summary>
        public int iRow { get => _iRow; set => _iRow = value; }

        /// <summary>
        /// Cell content value
        /// </summary>
        public string sVal { get => _sVal; set => _sVal = value; }

        /// <summary>
        /// Errors generated during the process
        /// </summary>
        public string sError { get => _sError; set => _sError = value; }

        /// <summary>
        /// Mail´s subject
        /// </summary>
        public string sSub { get => _sSub; set => _sSub = value; }

        /// <summary>
        /// Mail´s body
        /// </summary>
        public string sBod { get => _sBod; set => _sBod = value; }

        /// <summary>
        /// Array of String to store the Mail templates text file lines 
        /// </summary>
        public string[] sarrLin { get => _sarrLin; set => _sarrLin = value; }

        /// <summary>
        /// List of items for the Menu of mail templates
        /// </summary>
        public List<string> lstMen { get => _lstMen; set => _lstMen = value; }

        /// <summary>
        /// Array of string to store the mail body lines
        /// </summary>
        public string[] sarrBod { get => _sarrBod; set => _sarrBod = value; }

        #endregion
    }
}
