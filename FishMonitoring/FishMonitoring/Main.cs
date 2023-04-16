using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishLibrary;
using ParsingLibrary;



namespace FishMonitoring
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = openFileDialog.FileName;
            string[] data = Parsing.Parse(fileName).Split(";");
            txtBoxDateBeg.Text = data[0];
            txtBoxTempEd.Text = data[1];
        }

        private void LstBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameOfFish = lstBoxMain.SelectedItem.ToString();
            string[] infoName = FishLibrary.Fishes.Info(nameOfFish).Split(" ");
            txtBoxMaxTemp.Text = infoName[0];
            txtBoxMaxTime.Text = infoName[1];
            txtBoxMin.Text = infoName[2];
            txtBoxMinTime.Text = infoName[3];
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string nameOfFish = lstBoxMain.SelectedItem.ToString();
            string informationOfDay = txtBoxDateBeg.Text.ToString();
            string informationOfTemp = txtBoxTempEd.Text.ToString();
            string str = Fishes.Fab(nameOfFish, informationOfDay, informationOfTemp);
            if (str != null)
            {
                int k = 0;
                string[] newStr = str.Split(";");
                for (int i = 0; i < newStr.Length; i++)
                {
                    lstBoxFish.Items.Add(newStr[i].ToString());
                    k = i;
                }
                txtBoxRes.Text += $"Превышен порог перевозки {nameOfFish} на {k*10} минут" + Environment.NewLine;
                MessageBox.Show("Отчет сформирован!");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = saveFileDialog.FileName;
            string str = "";
            foreach (string s in lstBoxFish.Items)
            {
                str += s + ";";
            }
            Fishes.Save(fileName, str, txtBoxRes.Text);
            MessageBox.Show("Отчет загружен");
        }
    }
}