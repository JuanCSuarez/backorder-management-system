using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOToolbox_DAL.QuickNotes
{
    public class cls_Sourcing_DAL
    {
        #region Variables declaration
        private string _sSourc;
        private string _sNotes;
        private string _sError;
        #endregion

        #region Setters & Getters
        /// <summary>
        /// String to insert the sourcing note from GSI
        /// </summary>
        public string sSourc { get => _sSourc; set => _sSourc = value; }

        /// <summary>
        /// String to return a formated sourcing Note
        /// </summary>
        public string sNotes { get => _sNotes; set => _sNotes = value; }

        /// <summary>
        /// String to catch error messages
        /// </summary>
        public string sError { get => _sError; set => _sError = value; }
        #endregion

    }
}
