using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DirectoryFind
{
    public partial class Form1 : Form
    {
        bool isPanelClosed = true;
        string choisedPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string filter = "";
            listBox1.Items.Clear();

            if (radioButton1.Checked)
            {
                filter = Mask_search.Text;
            }
            else if (radioButton2.Checked)
            {
                filter = "*" + Mask_search.Text + "*";
            }
            else if  (radioButton3.Checked)
            {
                filter = "*.*" + Mask_search.Text;
            }
            else if (radioButton4.Checked)
            {
                filter = "*" + Mask_search.Text + "*";
            }

            try
            {
                string[] patchs = Directory.GetFiles(choisedPath, filter, SearchOption.AllDirectories);
                listBox1.Items.AddRange(patchs);
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("По вашему запросу ничего не найдено","Предупреждение");
                }
                
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }

        }

        private void setting_Click(object sender, EventArgs e)
        {
            if (isPanelClosed)
            {
                //Storyboard sb = this.FindResource("OpenMenu") as Storyboard;
                //sb.Begin();
                panelMenuSettings.Visible = true;
                //MessageBox.Show("Opening", "Move");
                
            }
            else
            {
                //Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
                //sb.Begin();
                panelMenuSettings.Visible = false;
                //MessageBox.Show("Closeng", "Move");
                
            }

            isPanelClosed = !isPanelClosed;
        }

        private void pM_ok_Click(object sender, EventArgs e)
        {

            panelMenuSettings.Visible = false;
            isPanelClosed = !isPanelClosed;
        }

        private void pM_cancle_Click(object sender, EventArgs e)
        {
            panelMenuSettings.Visible = false;
            isPanelClosed = !isPanelClosed;
        }

        private void choisePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog obj = new FolderBrowserDialog();

            obj.ShowNewFolderButton = false;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                choisedPath = folderBrowserDialog1.SelectedPath;
                textBoxChoisedFolder.Text = choisedPath;
                folderName.Text = Path.GetFileName(choisedPath);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo();
            //string G1;
            //G1 = Convert.ToString(sender);
            //MessageBox.Show(  G1, "Try");
            process.FileName = listBox1.SelectedItem.ToString();
            Process.Start(process);
        }

        private void Mask_search_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if (e.KeyChar == (char)13)
            {
                search_Click(sender, e);
            }
        }
    }
}
