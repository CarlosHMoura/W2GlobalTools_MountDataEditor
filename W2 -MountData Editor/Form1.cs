using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W2___MountData_Editor.Funções;

namespace W2___MountData_Editor
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
           
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.webcheats.com.br/members/seitbnao.4781487/";
         //   linkLabel1.Links.Add(link);
        }

        public void _Update()
        {
            MountList.Items.Clear();
            ;

            if (!Functions.ReadMountData())
                return;
 
            for (int i = 0; i < 200; i++)
            {
                External.MOUNTDATA Mount = External.g_pMountData.MountInfo[i];
                MountList.Items.Add(i + " - " + Mount.UnkValues[6]);
            }
        }
        private void Carregar_Click(object sender, EventArgs e)
        {
            _Update();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            //if (!radioButton1.Checked && !radioButton1.Checked)
            //{
            //    MessageBox.Show("Selecione a versão!", "W2 - MountData Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            //    return;
            //}
            if (MountList.Items.Count > 1 && External.Index != -1)
            {
                GetValue();
                Functions.SaveFile<Structs.STRUCT_MOUNTDATA>(External.g_pMountData);
                _Update();
                MessageBox.Show("MountData.bin salvo com sucesso", "W2 - MountData Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void MountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            External.Index = MountList.SelectedIndex;
            SetValues();
        }

        public void SetValues()
        {
            int SkillID = External.Index;
            if (SkillID == -1 || SkillID >= 200)
                return;

           External.MOUNTDATA Mount = External.g_pMountData.MountInfo[SkillID];

            box1.Text = Mount.UnkValues[0].ToString();
            box2.Text = Mount.UnkValues[1].ToString();
            box3.Text = Mount.UnkValues[2].ToString();
            box4.Text = Mount.UnkValues[3].ToString();
            box5.Text = Mount.UnkValues[4].ToString();
            box6.Text = Mount.UnkValues[5].ToString();
            box7.Text = Mount.UnkValues[6].ToString();
            box8.Text = Mount.UnkValues[7].ToString();
            box9.Text = Mount.UnkValues[8].ToString();
            box10.Text = Mount.UnkValues[9].ToString();
            box11.Text = Mount.UnkValues[10].ToString();
            box12.Text = Mount.UnkValues[11].ToString();
            box13.Text = Mount.UnkValues[12].ToString();
  

            
        }
        public void GetValue()
        {
            int SkillID = External.Index;
            if (SkillID == -1 || SkillID >= 200)
                return;

            External.MOUNTDATA Mount = External.g_pMountData.MountInfo[SkillID];

            Mount.UnkValues[0] = int.Parse(box1.Text);
            Mount.UnkValues[1] = int.Parse(box2.Text);
            Mount.UnkValues[2] = int.Parse(box3.Text);
            Mount.UnkValues[3] = int.Parse(box4.Text);
            Mount.UnkValues[4] = int.Parse(box5.Text);
            Mount.UnkValues[5] = int.Parse(box6.Text);
            Mount.UnkValues[6] = int.Parse(box7.Text);
            Mount.UnkValues[7] = int.Parse(box8.Text);
            Mount.UnkValues[8] = int.Parse(box9.Text);
            Mount.UnkValues[9] = int.Parse(box10.Text);
            Mount.UnkValues[10] = int.Parse(box11.Text);
            Mount.UnkValues[11] = int.Parse(box12.Text);
            Mount.UnkValues[12] = int.Parse(box13.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //External.Version = 7556;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //External.Version = 7559;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int SkillID = External.Index;
            if (SkillID == -1 )
                return;

            StreamWriter File = new StreamWriter("./MountData.csv");

            string TxT = "";


            File.WriteLine("#by Seitbnao\n");
            for (int i = 0; i < 200; i++)
            {
                External.MOUNTDATA Mount = External.g_pMountData.MountInfo[i];

                string Text = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",i,
                    Mount.UnkValues[0], 
                    Mount.UnkValues[1], 
                    Mount.UnkValues[2], 
                    Mount.UnkValues[3], 
                    Mount.UnkValues[4], 
                    Mount.UnkValues[5], 
                    Mount.UnkValues[6], 
                    Mount.UnkValues[7], 
                    Mount.UnkValues[8], 
                    Mount.UnkValues[9], 
                    Mount.UnkValues[10], 
                    Mount.UnkValues[11],
                     Mount.UnkValues[12]);
               
                File.WriteLine(Text);
            }
            File.Close();
            MessageBox.Show("MountData.csv gerado com sucesso", "W2 - MountData Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}