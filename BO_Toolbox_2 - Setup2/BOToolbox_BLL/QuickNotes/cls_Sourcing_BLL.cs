using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using BOToolbox_DAL.QuickNotes;

namespace BOToolbox_BLL.QuickNotes
{
    public class cls_Sourcing_BLL
    {

        /// <summary>
        /// Method to generate a formatted sourcing note for GSI $ABO note
        /// </summary>
        /// <param name="Obj_Sourcing_DAL"></param>
        public void get_ABOsourcing(ref cls_Sourcing_DAL Obj_Sourcing_DAL)
        {
            //Clear error and result fields
            Obj_Sourcing_DAL.sError = "NO ERROR";
            Obj_Sourcing_DAL.sNotes = string.Empty;
            //Removes leading and trailing spaces from given string
            Obj_Sourcing_DAL.sSourc = Obj_Sourcing_DAL.sSourc.Trim();
            //Split the note into a string array
            string[] notes = Obj_Sourcing_DAL.sSourc.Split('[');
            //Prepares the string to store the ETA
            string sETA = "";
            int iCount = 0, i = 5, k=1;
            try
            {
                //Header creation process
                if (notes[1].Contains("AUTO BACKORDER RESOLUTION:") || (notes[1].Contains("AUTO BACKORDER PARTIAL RESOLUTION:") && !notes[5].Contains("INVENTORY FOUND AND RESERVED AT FINAL STORE")))
                {
                    if (notes[1].Contains("AUTO BACKORDER PARTIAL RESOLUTION:"))
                    {
                        Obj_Sourcing_DAL.sNotes = ConfigurationManager.AppSettings["Note header"] + " Partial parts sourcing||";
                    }
                    else
                    {
                        Obj_Sourcing_DAL.sNotes = ConfigurationManager.AppSettings["Note header"] + " Parts sourcing||";
                    }

                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + 
                        notes[2].Substring(0, notes[2].IndexOf(']')) + " / " + notes[3].Substring(0, notes[3].IndexOf(']')) + "|" + //Original PN
                        notes[4].Substring(0, notes[4].IndexOf(']')) + " / " + notes[5].Substring(0, notes[5].IndexOf(']')) + "|" + //Sourced PN
                        notes[7].Substring(0, notes[7].IndexOf(']')) + "|"; //Path
                    notes[7] = notes[7].Substring(0, notes[7].IndexOf(']')); //Remove "]. DETAILS:" from Path
                    iCount = notes[7].Length - 5;//Count path lenght
                }
                else if (notes[1].Contains("AUTO BACKORDER PARTIAL RESOLUTION:"))
                {
                    notes[12] = notes[12].Substring(0, notes[12].IndexOf(']')); //Remove "]. DETAILS:" from Path
                    Obj_Sourcing_DAL.sNotes = ConfigurationManager.AppSettings["Note header"] + " Parts partial sourcing||" +
                        notes[7].Substring(0, notes[7].IndexOf(']')) + " / " + notes[8].Substring(0, notes[8].IndexOf(']')) + "|" + //Original PN
                        notes[5].Substring(0, notes[5].IndexOf(']')) + " X " + (notes[4].Substring(14, notes[4].Length - 14)).Substring(0, (notes[4].Substring(14, notes[4].Length - 14)).IndexOf(']')) + " FOUND AND RESERVED IN " + notes[12].Substring(notes[12].Length - 3) + "|" +
                        notes[9].Substring(0, notes[9].IndexOf(']')) + " / " + notes[10].Substring(0, notes[10].IndexOf(']')) + "|" + //Sourced PN
                        notes[12] + "|"; //Path

                    iCount = notes[12].Length - 5;//Count path lenght
                    i = i + 5;
                }
                else if (notes[1].Contains("AUTO BACKORDER MULTI-SOURCING"))
                {
                    Obj_Sourcing_DAL.sNotes = ConfigurationManager.AppSettings["Note header"] + " Parts Multi-Sourcing||" +
                        notes[2].Substring(0, notes[2].IndexOf(']')) + " / " + notes[3].Substring(0, notes[3].IndexOf(']')) + "||";//Original PN + Orig Qty;
                    for (int j = 1; j < notes.Length; j++)
                    {
                        if (notes[j].Contains("AUTO BACKORDER MULTI-SOURCING"))
                        {
                            Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + "Multi-sourcing " + k + ":|" +
                                notes[j+3].Substring(0, notes[j+3].IndexOf(']')) + " / " + notes[j+4].Substring(0, notes[j+4].IndexOf(']')) + "|" + //Sourced PN + Sourced Qty
                                notes[j+6].Substring(0, notes[j+6].IndexOf(']')) + "|"; //Path;
                            //Remove "]. DETAILS:" from Path
                            notes[j+6] = notes[j+6].Substring(0, notes[j+6].IndexOf(']'));
                            //Count path lenght
                            iCount = notes[j+6].Length - 5;
                            switch (iCount)
                            {
                                case 10:
                                    sETA = notes[j + 5].Substring(0, 24);
                                    //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + 
                                        notes[j+9].Substring(0, notes[j+9].IndexOf(']')) + "|AWB: Not available yet|STATUS: Awaiting shipping|" +
                                        sETA + "||";//ETA
                                    break;
                                case 16:
                                    sETA = notes[j + 5].Substring(0, 24);
                                    //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes +
                                        "FINAL " + sETA + "||" +//ETA
                                        notes[j+7].Substring(0, notes[j+7].IndexOf(']')) + " / " +//HOP.1
                                        notes[j+9] + "|AWB: Not available yet|STATUS: Awaiting shipping||" +//ISO.1 & status
                                        notes[j+10].Substring(0, notes[j+10].IndexOf(']')) + " / " +//HOP.2
                                        notes[j+12].Substring(0, notes[j+12].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||";//ISO.2 & status
                                    break;
                                case 22:
                                    sETA = notes[j + 5].Substring(0, 24);
                                    //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes +
                                       "FINAL " + sETA + "||" +//ETA
                                        notes[j + 7].Substring(0, notes[j + 7].IndexOf(']')) + " / " +//HOP.1
                                        notes[j + 9] + "|AWB: Not available yet|STATUS: Awaiting shipping||" +//ISO.1 & status
                                        notes[j + 10].Substring(0, notes[j + 10].IndexOf(']')) + " / " +//HOP.2
                                        notes[j + 12] + "|AWB: N/A|STATUS: Awaiting shipping||" + //ISO.2 & status
                                        notes[j + 13].Substring(0, notes[j + 13].IndexOf(']')) + " / " +//HOP.3
                                        notes[j + 15].Substring(0, notes[j + 15].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||";//ISO.3 & status
                                    break;
                                default:
                                    break;
                            }
                            k++;
                        }
                    }
                    return; //Exit TRY block to avoid running the last code below
                }
                //Add HOP-ISO description
                switch (iCount)
                {
                    case 10:
                        sETA = notes[i + 1].Substring(0, 24);
                        //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                        Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + "|" + notes[i+5].Substring(0, notes[i + 5].IndexOf(']')) + "|AWB: Not available yet|STATUS: Awaiting shipping||" +
                            sETA;//ETA
                        break;
                    case 16:
                        sETA = notes[i + 1].Substring(0, 24);
                        //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                        Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + "FINAL " + sETA + "||" +//ETA
                            notes[i+3].Substring(0, notes[i+3].IndexOf(']')) + " / " +//HOP.1
                            notes[i+5] + "|AWB: Not available yet|STATUS: Awaiting shipping||" +//ISO.1 & status
                            notes[i+6].Substring(0, notes[i+6].IndexOf(']')) + " / " +//HOP.2
                            notes[i+8].Substring(0, notes[i+8].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||";//ISO.2 & status
                        break;
                    case 22:
                        sETA = notes[i + 1].Substring(0, 24);
                        //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                        Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + "FINAL " + sETA + "||" +//ETA
                            notes[i+3].Substring(0, notes[i+3].IndexOf(']')) + " / " +//HOP.1
                            notes[i+5] + "|AWB: Not available yet|STATUS: Awaiting shipping||" +//ISO.1 & status
                            notes[i+6].Substring(0, notes[i+6].IndexOf(']')) + " / " +//HOP.2
                            notes[i+8] + "|AWB: N/A|STATUS: Awaiting shipping||" + //ISO.2 & status
                            notes[i+9].Substring(0, notes[i+9].IndexOf(']')) + " / " +//HOP.3
                            notes[i+11].Substring(0, notes[i+11].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||";//ISO.3 & status
                        break;
                    default:
                        break;
                }

            }
            catch (Exception e)
            {
                Obj_Sourcing_DAL.sError = "There was an execution error: " + e.ToString();
            }
        }

        /// <summary>
        /// Method to generate a formatted sourcing note for GSI $MBO note
        /// </summary>
        /// <param name="Obj_Sourcing_DAL"></param>
        public void get_MBOsourcing(ref cls_Sourcing_DAL Obj_Sourcing_DAL)
        {
            //Clear error and result fields
            Obj_Sourcing_DAL.sError = "NO ERROR";
            Obj_Sourcing_DAL.sNotes = string.Empty;
            //Removes leading and trailing spaces from given string
            Obj_Sourcing_DAL.sSourc = Obj_Sourcing_DAL.sSourc.Trim();
            //Split the note into a string array
            string[] notes = Obj_Sourcing_DAL.sSourc.Split('[');
            //Prepares the string to store the ETA
            string sETA = "";
            int iCount = 0, k = 1;
            try
            {
                if (notes[1].Contains("MANUAL BACKORDER MULTI-SOURCING"))
                {
                    Obj_Sourcing_DAL.sNotes = ConfigurationManager.AppSettings["Note header"] + " Manual parts Multi-Sourcing||" +
                        notes[2].Substring(0, notes[2].IndexOf(']')) + " / " + notes[3].Substring(0, notes[3].IndexOf(']')) + "||";//PN + Qty;
                    for (int j = 1; j < notes.Length; j++)
                    {
                        if (notes[j].Contains("MANUAL BACKORDER MULTI-SOURCING"))
                        {
                            Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + "Multi-sourcing " + k + ":|" +
                                notes[j + 1].Substring(0, notes[j + 1].IndexOf(']')) + " / " + notes[j + 3].Substring(0, notes[j + 3].IndexOf(']')) + "|" + //Sourced PN + Sourced Qty
                                notes[j + 5].Substring(0, notes[j + 5].IndexOf(']')) + "|"; //Path;
                            //Remove "]. DETAILS:" from Path
                            notes[j + 5] = notes[j + 5].Substring(0, notes[j + 5].IndexOf(']'));
                            //Count path lenght
                            iCount = notes[j + 5].Length - 5;
                            switch (iCount)
                            {
                                case 7:
                                    sETA = notes[j + 4].Substring(0, 24);
                                    //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes +
                                        notes[j + 8].Substring(0, notes[j + 8].IndexOf(']')) + "|AWB: Not available yet|STATUS: Awaiting shipping|" +
                                        sETA + "||";//ETA
                                    break;
                                case 11:
                                    sETA = notes[j + 4].Substring(0, 24);
                                    //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes +
                                        "FINAL " + sETA + "||" +//ETA
                                        notes[j + 6].Substring(0, notes[j + 6].IndexOf(']')) + " / " +//HOP.1
                                        notes[j + 8].Substring(0, notes[j + 8].IndexOf(']')) + "|AWB: Not available yet|STATUS: Awaiting shipping||" +//ISO.1 & status
                                        notes[j + 9].Substring(0, notes[j + 9].IndexOf(']')) + " / " +//HOP.2
                                        notes[j + 11].Substring(0, notes[j + 11].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||";//ISO.2 & status
                                    break;
                                case 15:
                                    sETA = notes[j + 4].Substring(0, 24);
                                    //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                                    Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes +
                                       "FINAL " + sETA + "||" +//ETA
                                        notes[j + 6].Substring(0, notes[j + 6].IndexOf(']')) + " / " +//HOP.1
                                        notes[j + 8].Substring(0, notes[j + 8].IndexOf(']')) + "|AWB: Not available yet|STATUS: Awaiting shipping||" +//ISO.1 & status
                                        notes[j + 9].Substring(0, notes[j + 9].IndexOf(']')) + " / " +//HOP.2
                                        notes[j + 11].Substring(0, notes[j + 11].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||" + //ISO.2 & status
                                        notes[j + 12].Substring(0, notes[j + 12].IndexOf(']')) + " / " +//HOP.3
                                        notes[j + 14].Substring(0, notes[j + 14].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||";//ISO.3 & status
                                    break;
                                default:
                                    break;
                            }
                            k++;
                        }
                    }
                    return; //Exit TRY block to avoid running the last code below
                }
                else
                {
                    notes[5] = notes[5].Substring(0, notes[5].IndexOf(']'));//Reformat Path
                    Obj_Sourcing_DAL.sNotes = ConfigurationManager.AppSettings["Note header"] + " Manual parts sourcing||" +
                        notes[2].Substring(0, notes[2].Length - 1) + " / " + notes[3].Substring(0, notes[3].IndexOf(']')) + "|" +//PN & QTY
                        notes[5] + "|";//PATH                    
                    iCount = notes[5].Length - 5;//Count path lenght
                                                     //Add HOP-ISO description
                    switch (iCount)
                    {
                        case 7:
                            sETA = notes[4].Substring(0, 24);
                            //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                            Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + notes[8].Substring(0, notes[8].IndexOf(']')) + "|AWB: Not available yet|STATUS: Awaiting shipping||" +
                                sETA;//ETA
                            break;
                        case 11:
                            sETA = notes[4].Substring(0, 24);
                            //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                            Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + "FINAL " + sETA + "||" +//ETA
                                notes[6].Substring(0, notes[6].IndexOf(']')) + " / " +//HOP.1
                                notes[8].Substring(0, notes[8].IndexOf(']')) + "|AWB: Not available yet|STATUS: Awaiting shipping||" +//ISO.1
                                notes[9].Substring(0, notes[9].IndexOf(']')) + " / " +//HOP.2
                                notes[11].Substring(0, notes[11].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||";//ISO.2
                            break;
                        case 15:
                            sETA = notes[4].Substring(0, 24);
                            //sETA = sETA.Replace("ETA:", "ETA (at whs): ");
                            Obj_Sourcing_DAL.sNotes = Obj_Sourcing_DAL.sNotes + "FINAL " + sETA + "||" +//ETA
                                notes[6].Substring(0, notes[6].IndexOf(']')) + " / " +//HOP.1
                                notes[8].Substring(0, notes[8].IndexOf(']')) + "|AWB: Not available yet|STATUS: Awaiting shipping||" +//ISO.1
                                notes[9].Substring(0, notes[9].IndexOf(']')) + " / " +//HOP.2
                                notes[11].Substring(0, notes[11].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||" +//ISO.2
                                notes[12].Substring(0, notes[9].IndexOf(']')) + " / " +//HOP.3
                                notes[14].Substring(0, notes[11].IndexOf(']')) + "|AWB: N/A|STATUS: Awaiting shipping||";//ISO.3
                            break;
                        default:
                            break;
                    }
                }                
            }
            catch (Exception e)
            {
                Obj_Sourcing_DAL.sError = "There was an execution error: " + e.ToString();
            }
        }







    }
}
