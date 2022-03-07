using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDV
{
    public partial class FMForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        static List<Items> listItems;
        static List<Runes> listRunes;

        public FMForm()
        {
            InitializeComponent();
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            gridStatistics.Columns.Add("Min", "Min");
            gridStatistics.Columns.Add("Max", "Max");
            gridStatistics.Columns.Add("Current", "Current");
            gridStatistics.Columns.Add("Excpeted", "Excpeted");

            //gridStatistics.Rows.Add("Current", "Current");

            string jsonItems = System.IO.File.ReadAllText("items.json");
            listItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Items>>(jsonItems);
            string jsonRunes = System.IO.File.ReadAllText("runes.json");
            listRunes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Runes>>(jsonRunes);
        }



        public bool checkGoodRows()
        {
            int cpt = 0;
            foreach (DataGridViewRow row in gridStatistics.Rows)
            {
                if (row.Index == gridStatistics.Rows.Count-1|| row.Cells[2].Value.ToString() == "")
                    continue;
                
                if (Convert.ToInt32(row.Cells[2].Value.ToString()) >= Convert.ToInt32(row.Cells[3].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#9BFF00");
                    cpt++;
                }
                else
                    row.DefaultCellStyle.BackColor = Color.Empty;
            }
            if (cpt == gridStatistics.Rows.Count - 1)
                return true;
            else
                return false;
           
        }
        public int getRowIndexWithTheLessWeight()
        {
            int index=-1;
            List<double> listWeight = new List<double>();
            listWeight.Clear();
            for (int i = 0; i< gridStatistics.Rows.Count-1; i++)
            {
                int nbStats;
                bool success = int.TryParse(gridStatistics.Rows[i].Cells[2].Value.ToString(), out nbStats);
                if (success)
                {
                    for (int j = 0; j < listRunes.Count; j++)
                    {
                        if (listRunes[j].StatisticName.ToLower().Contains(gridStatistics.Rows[i].HeaderCell.Value.ToString().ToLower()))
                        {
                            if (Convert.ToInt32(gridStatistics.Rows[i].Cells[3].Value.ToString()) <= nbStats )
                                listWeight.Add(0);
                            else
                                listWeight.Add(((Convert.ToInt32(gridStatistics.Rows[i].Cells[3].Value.ToString()) * listRunes[j].UnitWeight))- (nbStats * listRunes[j].UnitWeight));
                        }
                    }          
                }
                   
                else
                    listWeight.Add(-1);
            }
            for(int i = 0; i < listWeight.Count; i++)
            {
                if (i == 0)
                    continue;
                if (listWeight[i] > listWeight[i - 1] && listWeight[i] != -1)
                    index = i-1;
            }

            return index;
        }
        public void clearForm()
        {
            gridStatistics.Rows.Clear();
            gridStatistics.Refresh();
            tbItemName.Text = "";
            webBrowserItems.Navigate("");
            tbNiveau.Text = "";
            tbDescription.Text = "";
            tbCategorie.Text = "";
        }
        private void tbItemName_TextChanged(object sender, EventArgs e)
        {
            clearForm();
            bool dataGridFill = false;
            for (int i=0;i<listItems.Count;i++)
            {
                if (dataGridFill)
                    break;
                if (listItems[i].Name.ToUpper().Contains(tbItemSearch.Text.ToUpper()))
                {
                    tbItemName.Text = listItems[i].Name;
                    tbNiveau.Text = listItems[i].Level.ToString();
                    webBrowserItems.Navigate(listItems[i].ImgUrl);
                    tbDescription.Text = listItems[i].Description;
                    tbCategorie.Text = listItems[i].Type.ToString();

                    if (listItems[i].Statistics==null)
                        break;
                    for (int j = 0; j < listItems[i].Statistics.Count; j++)
                    {
                        foreach (KeyValuePair<string, StatisticClass> kvp in listItems[i].Statistics[j])
                        {
                            gridStatistics.Rows.Add(kvp.Value.Min, kvp.Value.Max, "","");
                            gridStatistics.Rows[j].HeaderCell.Value = kvp.Key.ToString();
                        }
         
                        dataGridFill = true;



                    }
                    break;
                }
            }

        }


        public string correctStatName(string statToCorrect)
        {
            statToCorrect = statToCorrect.TrimStart(' ') ;
            statToCorrect = statToCorrect.TrimEnd(' ');
            for (int i = 0; i < listRunes.Count; i++)
            {
                if (listRunes[i].StatisticName.ToLower().Contains(statToCorrect.ToLower()))
                {
                    statToCorrect = listRunes[i].StatisticName;
                    return statToCorrect;
                }
            }
            int indexOfLevenshteinSmallestValue=0;
            int lastLevenshteinSmallestValue = 1000;
            for (int i = 0; i < listRunes.Count; i++)
            {
                if (i==0)
                    continue;
                else
                {
                    int levenshteinDistanceCurrentValue = Fastenshtein.Levenshtein.Distance(statToCorrect, listRunes[i].StatisticName);
                    int levenshteinDistancePreviousValue = Fastenshtein.Levenshtein.Distance(statToCorrect, listRunes[i-1].StatisticName);
                    if (levenshteinDistanceCurrentValue < levenshteinDistancePreviousValue && levenshteinDistanceCurrentValue< lastLevenshteinSmallestValue )
                    {
                        indexOfLevenshteinSmallestValue = i;
                        lastLevenshteinSmallestValue = levenshteinDistanceCurrentValue;
                    }  
                }
            }  
            return listRunes[indexOfLevenshteinSmallestValue].StatisticName;
        }
        public void fillGridWithCurrentStats()
        {
            int yInterval = 39;
            for(int i = 0; i < gridStatistics.Rows.Count-1; i++)
            {
                Tools.captureScreen("fm.jpg", 800, 334 + i * yInterval, 256, 40);
                Tools.binarizeimg("fm.jpg", 55);
                string stats = Tools.getTextFromImg("fm.jpg");
                stats = correctStatName(stats);
                gridStatistics.Rows[i].HeaderCell.Value = stats;

                Tools.captureScreen("fm.jpg", 800, 334+i* yInterval, 127, 40);
                Tools.binarizeimg("fm.jpg", 70);

                stats = Tools.getNumberFromImg("fm.jpg");
                gridStatistics.Rows[i].Cells[2].Value = stats;
            }
           
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            if (gridStatistics.Rows.Count <= 1)
                return;
            for(int i = 0; i < gridStatistics.Rows.Count-1; i++)
            {
                if(String.IsNullOrEmpty(gridStatistics.Rows[i].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("Les valeurs de la colonne \"Expected\"ne doivent pas être vides");
                    return;
                }
            }

            bool isJobDone = false;
            do
            {

                fillGridWithCurrentStats();
                isJobDone = checkGoodRows();
                gridStatistics.Refresh();

                if (isJobDone)
                {
                    MessageBox.Show("Yeahhhh c'est tout bon ! ");
                    return;
                }
                else
                {

                    int priorityIndex = getRowIndexWithTheLessWeight() + 1;
                    int runePositionX = getRunePositionX(priorityIndex);
                    int runePositionY;
                    if (priorityIndex == 0)
                        runePositionY = 339;
                    else
                        runePositionY = 339 + (39 * priorityIndex + 1);
                    Tools.moveCursorThanClick(runePositionX, runePositionY, 500);
                    //Tools.moveCursor(runePositionX, runePositionY);
                }
            } while (!isJobDone);

        }
        public int getRunePositionX(int index)
        {
            int currentStat;
            int position1 = 1112;
            int position2 = 1160;
            int position3 = 1215;
            bool success = int.TryParse(gridStatistics.Rows[index].Cells[2].Value.ToString(), out currentStat); ;
            if (success)
            {
                for (int i = 0; i < listRunes.Count; i++)
                {
                    if (listRunes[i].StatisticName.ToLower().Contains(gridStatistics.Rows[index].HeaderCell.Value.ToString().ToLower()))
                    {
                        double weightRange = 20 * listRunes[i].UnitWeight;
                        if (currentStat < weightRange)
                            return position1;
                        else if (currentStat < weightRange * 3)
                            return position2;
                        else if (currentStat < weightRange * 3)
                            return position3;
                    }
                }
            }
            return 0;
        }
        /*
        public string getRuneName(int index)
        {
            int currentStat;
            bool success = int.TryParse(gridStatistics.Rows[index].Cells[2].Value.ToString(), out currentStat); ;
            if (success)
            {
                for (int i = 0; i < listRunes.Count; i++)
                {
                    if (listRunes[i].StatisticName.ToLower().Contains(gridStatistics.Rows[index].HeaderCell.Value.ToString().ToLower()))
                    {
                        double weightRange = 20 * listRunes[i].UnitWeight;
                        if (currentStat < weightRange)
                            return listRunes[i].Type[0].RuneName;
                        else if (currentStat < weightRange *3)
                            return listRunes[i].Type[1].RuneName;
                        else if (currentStat < weightRange * 3)
                            return listRunes[i].Type[2].RuneName;
                        break;
                    }
                }
            }
            return "";
        }*/


        private void tbItemName_MouseEnter(object sender, EventArgs e)
        {
            tbItemName.Enabled = false;
        }

        private void tbItemName_MouseLeave(object sender, EventArgs e)
        {
            tbItemName.Enabled = true;
        }

        private void tbNiveau_MouseEnter(object sender, EventArgs e)
        {
            tbNiveau.Enabled = false;
        }

        private void tbNiveau_MouseLeave(object sender, EventArgs e)
        {
            tbNiveau.Enabled = true;
        }

        private void tbCategorie_MouseEnter(object sender, EventArgs e)
        {
            tbCategorie.Enabled = false;
        }

        private void tbCategorie_MouseLeave(object sender, EventArgs e)
        {
            tbCategorie.Enabled = true;
        }


    }
}
