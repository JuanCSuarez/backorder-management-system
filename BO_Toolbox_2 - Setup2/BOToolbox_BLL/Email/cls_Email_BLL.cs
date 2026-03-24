using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOToolbox_DAL.Email;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Configuration;
using System.IO;

namespace BOToolbox_BLL.Email
{
    public class cls_Email_BLL
    {

        /// <summary>
        /// Method to load the dropdown list with the mail templates
        /// </summary>
        public void load_MailList(ref cls_Email_DAL Obj_Email_DAL)
        {
            //Reset error
            Obj_Email_DAL.sError = "";
            //Load the rest of item from the local TXT file 
            try
            {
                //Get the list of mail templates from the local text file
                Obj_Email_DAL.sarrLin = File.ReadAllLines("C:\\Program Files\\Oracle Corporation\\BO Toolbox\\Mail templates.txt");
                for (int i = 0; i < Obj_Email_DAL.sarrLin.Length; i++)
                {
                    if (Obj_Email_DAL.sarrLin[i].StartsWith("**MAIL"))
                    {
                        Obj_Email_DAL.lstMen.Add(Obj_Email_DAL.sarrLin[i+1]);
                    }
                }
                //Sort the items into the obtained Array
                Obj_Email_DAL.lstMen.Sort();
            }
            catch (Exception ex)
            {
                Obj_Email_DAL.sError = ex.ToString();
            }
        }

        /// <summary>
        /// Method to get the mail subject depending on the selected template
        /// </summary>
        /// <param name="Obj_Email_DAL"></param>
        public void get_mailSubect(ref cls_Email_DAL Obj_Email_DAL)
        {
            //Reset error message
            Obj_Email_DAL.sError = "";
            //Reset subject
            Obj_Email_DAL.sSub = "";
            try
            {
                //Get the list of mail templates from the local text file
                Obj_Email_DAL.sarrLin = File.ReadAllLines("C:\\Program Files\\Oracle Corporation\\BO Toolbox\\Mail templates.txt");
                //Look for the corresponding subject into de array of TEXT lines
                for (int i = 0; i < Obj_Email_DAL.sarrLin.Length; i++)
                {
                    if (Obj_Email_DAL.sarrLin[i].Equals(Obj_Email_DAL.sVal))
                    {
                        Obj_Email_DAL.sSub = Obj_Email_DAL.sarrLin[i+1];
                        break;
                    }
                }                
            }
            catch (Exception ex)
            {
                Obj_Email_DAL.sError = ex.ToString();
            }
        }

        /// <summary>
        /// Method to get the mail body depending on the selected template
        /// </summary>
        /// <param name="Obj_Email_DAL"></param>
        public void get_mailBody(ref cls_Email_DAL Obj_Email_DAL)
        {
            List<string> tmpList = new List<string>();
            //Reset the array of strign for the mail body
            Obj_Email_DAL.sarrBod = null;
            //Reset error msg
            Obj_Email_DAL.sError = "";
            try
            {
                //Get the list of mail templates from the local text file
                Obj_Email_DAL.sarrLin = File.ReadAllLines("C:\\Program Files\\Oracle Corporation\\BO Toolbox\\Mail templates.txt");
                //Look for the corresponding subject into de array of TEXT lines
                for (int i = 0; i < Obj_Email_DAL.sarrLin.Length; i++)
                {
                    if (Obj_Email_DAL.sarrLin[i].Equals(Obj_Email_DAL.sVal))
                    {
                        int j = i + 2;
                        do
                        {
                            tmpList.Add(Obj_Email_DAL.sarrLin[j]);
                            j++;
                        } while (j < Obj_Email_DAL.sarrLin.Length && !Obj_Email_DAL.sarrLin[j].Equals("**MAIL"));
                        Obj_Email_DAL.sarrBod = tmpList.ToArray();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Obj_Email_DAL.sError = ex.ToString();
            }
        }


        public void import_ExcelCell(ref cls_Email_DAL Obj_Email_DAL)
        {
            Obj_Email_DAL.sError = "No error";

            try
            {
                //Loads the Excel given Book and Sheet
                Application appExcel = new Application();
                Workbook wbExcel = appExcel.Workbooks.Open(@"G:\OneDrive\Docs de Juan K\Escritorio\Test1.xlsx");
                Worksheet wsExcel = wbExcel.Worksheets[ConfigurationManager.AppSettings["Excel_Sheet"]];
                if (wsExcel.Cells[Obj_Email_DAL.iRow, Obj_Email_DAL.iCol] != null)
                {
                    Obj_Email_DAL.sVal = wsExcel.Cells[Obj_Email_DAL.iRow, Obj_Email_DAL.iCol].Value;
                    wbExcel.Close();
                }
                else
                {
                    Obj_Email_DAL.sVal = "";
                }
            }
            catch (Exception ex)
            {
                Obj_Email_DAL.sError = "There was en error during the process: " + ex.ToString();
            }
        }


    }
}
