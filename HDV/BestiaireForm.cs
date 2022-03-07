using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDV
{
    public partial class BestiaireForm : Form
    {
        static List<Monsters> listMonsters;


        public BestiaireForm()
        {
            InitializeComponent();
            string json = System.IO.File.ReadAllText("monsters.json");
            listMonsters = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Monsters>>(json);
        }


        public void clearStats()
        {
            tbHp.Text = "";
            tbPA.Text = "";
            tbPM.Text = "";
            tbResNeutre.Text = "";
            tbResTerre.Text = "";
            tbResFeu.Text = "";
            tbResEau.Text = "";
            tbResAir.Text = "";
        }
        public void clearForm()
        {
            tbMonsterName.Text = "";
            webBrowserMonsters.Navigate("");
            listBoxArea.Items.Clear();
            listBoxDrop.Items.Clear();
            clearStats();
        }
        public string getAverage(string statMin, string statMax)
        {
            if (string.IsNullOrEmpty(statMax))
                return statMin;
            double stat1 = Convert.ToInt32(statMin);
            double stat2 = Convert.ToInt32(statMax);
            int statAVG = (int)Math.Round((stat1 + stat2) / 2);
            return statAVG.ToString();
        }
        private void tbMonsterSearch_TextChanged(object sender, EventArgs e)
        {
            clearForm();
            bool isFind = false;
            for (int i = 0; i < listMonsters.Count; i++)
            {
                if (isFind)
                    break;
                
                if (listMonsters[i].Name.ToUpper().Contains(tbMonsterSearch.Text.ToUpper()))
                {
                    tbMonsterName.Text = listMonsters[i].Name;
                    webBrowserMonsters.Navigate(listMonsters[i].ImgUrl);
                    tbType.Text = listMonsters[i].Type;
                    tbHp.Text = getAverage(listMonsters[i].Statistics[0].Pv.Min.ToString(), listMonsters[i].Statistics[0].Pv.Max.ToString());
                    tbPA.Text = getAverage(listMonsters[i].Statistics[1].Pa.Min.ToString(), listMonsters[i].Statistics[1].Pa.Max.ToString());
                    tbPM.Text = getAverage(listMonsters[i].Statistics[2].Pm.Min.ToString(), listMonsters[i].Statistics[2].Pm.Max.ToString());
                    tbResTerre.Text = getAverage(listMonsters[i].Resistances[0].Terre.Min.ToString(), listMonsters[i].Resistances[0].Terre.Max.ToString());
                    tbResAir.Text = getAverage(listMonsters[i].Resistances[1].Air.Min.ToString(), listMonsters[i].Resistances[1].Air.Max.ToString());
                    tbResFeu.Text = getAverage(listMonsters[i].Resistances[2].Feu.Min.ToString(), listMonsters[i].Resistances[2].Feu.Max.ToString());
                    tbResEau.Text = getAverage(listMonsters[i].Resistances[3].Eau.Min.ToString(), listMonsters[i].Resistances[3].Eau.Max.ToString());
                    tbResNeutre.Text = getAverage(listMonsters[i].Resistances[4].Neutre.Min.ToString(), listMonsters[i].Resistances[4].Neutre.Max.ToString());

                    if (listMonsters[i].Areas != null)
                    {
                        foreach (var area in listMonsters[i].Areas)
                        {
                            listBoxArea.Items.Add(area);
                        }
                    }
                    if (listMonsters[i].Drops != null)
                    {
                        foreach (var drop in listMonsters[i].Drops)
                        {
                            listBoxDrop.Items.Add(drop.Name);
                        }
                    }

                    isFind = true;
  
                }
            }

        }
    }
}
