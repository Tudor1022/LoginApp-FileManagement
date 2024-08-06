using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace lloginApp
{
    public partial class Aplicatie : Form
    {
        public Aplicatie()
        {
            InitializeComponent();
        }

        public struct globale
        {
            public string extensie;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo folder=new DirectoryInfo(txtLocatie.Text);
            if (folder.Exists)
            {
                foreach (DirectoryInfo subfolder in folder.GetDirectories())
                {
                    lstFoldere.Items.Add(subfolder.Name);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string locatie=txtLocatie.Text + @"\"+lstFoldere.SelectedItem.ToString();
            DirectoryInfo folder=new DirectoryInfo(locatie);
            lstFisiere.Items.Clear();
            if (folder.Exists)
            {
                foreach(FileInfo fisier in folder.GetFiles())
                {
                    lstFisiere.Items.Add(fisier.Name);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                btnFoldere.Visible = true;
                lstFoldere.Visible=true;
                lstFisiere.Visible=true;
                btnFisiere2.Visible=true;
                btnOpen.Visible=true;
                btnAfisareSpecifica.Visible=true;
                btnScriere.Visible=true;
                
            }
            else
            {
                btnFoldere.Visible = false;
                lstFoldere.Visible = false;
                lstFisiere.Visible = false;
                btnFisiere2.Visible = false;
                btnOpen.Visible=false;
                btnAfisareSpecifica.Visible = false;
                btnScriere.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                btnFisiere.Visible = true;
                lstFisiere.Visible=true;
                btnOpen.Visible = true;
                btnScriere.Visible = true;

            }
            else
            {
                btnFisiere.Visible = false;
                lstFisiere.Visible = false;
                btnOpen.Visible = false;
                btnScriere.Visible = false;
            }
        }

        private void btnFisiere_Click(object sender, EventArgs e)
        {
            DirectoryInfo folder = new DirectoryInfo(txtLocatie.Text);
            lstFisiere.Items.Clear();
            if (folder.Exists)
            {
                foreach(FileInfo file in folder.GetFiles())
                {
                    lstFisiere.Items.Add(file.Name);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string locatie=txtLocatie.Text + @"\" + lstFoldere.SelectedItem.ToString() + @"\" + lstFisiere.SelectedItem.ToString();
            Process.Start(locatie);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            globale global;
            global.extensie = Interaction.InputBox("Add extension (with . )");
            string locatie = txtLocatie.Text + @"\" + lstFoldere.SelectedItem.ToString();

            DirectoryInfo folder= new DirectoryInfo(locatie);
            lstFisiere.Items.Clear();
            if (folder.Exists)
            {
                foreach (FileInfo file in folder.GetFiles("*"+global.extensie))
                {
                    lstFisiere.Items.Add(file.Name);
                }
            }
        }

        private void btnScriere_Click(object sender, EventArgs e)
        {
            string locatie;
            if(radioButton1.Checked)
            {
                locatie = txtLocatie.Text + @"\" + lstFoldere.SelectedItem.ToString() + @"\" + lstFisiere.SelectedItem.ToString();
            }
            else
            {
                locatie = txtLocatie.Text + @"\" + lstFisiere.SelectedItem.ToString();
            }

            
            StreamWriter fisier = new StreamWriter(locatie,true);

            string mesaj = Interaction.InputBox("Write");
            fisier.WriteLine(mesaj);
            fisier.Close();
            MessageBox.Show("It was written successfully");
        }

        private void Aplicatie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
