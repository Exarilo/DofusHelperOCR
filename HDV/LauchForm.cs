using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace HDV
{
    public partial class LauchForm : Form
    {
        public LauchForm()
        {
            InitializeComponent();
        }

        private void pbHDV_Click(object sender, EventArgs e)
        {
            Hide();
            using (HDVForm hDVForm = new HDVForm())
                hDVForm.ShowDialog();
            Show();

        }

        private void pbDirection_Click(object sender, EventArgs e)
        {
            Hide();
            using (DirectionForm directionForm = new DirectionForm())
                directionForm.ShowDialog();
            Show();
        }

        private void pbScript_Click(object sender, EventArgs e)
        {
            Hide();
            using (ScriptForm scriptForm = new ScriptForm())
                scriptForm.ShowDialog();
            Show();
        }

        private void pbTreasureHunt_Click(object sender, EventArgs e)
        {
            Hide();
            using (FMForm fMForm= new FMForm())
                fMForm.ShowDialog();
            Show();
        }

        private void pbBestiaire_Click(object sender, EventArgs e)
        {
            Hide();
            using (BestiaireForm bestiaireForm= new BestiaireForm())
                bestiaireForm.ShowDialog();
            Show();
        }
    }

}
