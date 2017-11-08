using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRenamerTool
{
    public partial class OptionsWindow : Form
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            //PB_loadedImage.ImageLocation = @"C:\Users\Fin\Pictures\demo.bmp";

            string currentDir = Directory.GetCurrentDirectory();
            MTB_loadFolder.Text = currentDir;

            UpdateNameGen();

        }

        private void B_openImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Debugger.Log(1, "General", dlg.FileName);
                PB_loadedImage.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
        }

        private void CB_useSeparator_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNameGen();
        }

        public void UpdateNameGen()
        {
            if (CB_useSeparator.Checked)
            {
                string sep = TB_separators.Text;
                TB_nameGenFull.Text = TB_nameGen1.Text + sep + TB_nameGen2.Text + sep + TB_nameGen3.Text + sep + TB_nameGen4.Text + sep + TB_nameGen5.Text;
            }
            else
            {
                TB_nameGenFull.Text = TB_nameGen1.Text + TB_nameGen2.Text + TB_nameGen3.Text + TB_nameGen4.Text + TB_nameGen5.Text;
            }
        }

        private void TB_nameGen1_TextChanged(object sender, EventArgs e)
        {
            UpdateNameGen();
        }
        private void TB_nameGen2_TextChanged(object sender, EventArgs e)
        {
            UpdateNameGen();
        }
        private void TB_nameGen3_TextChanged(object sender, EventArgs e)
        {
            UpdateNameGen();
        }
        private void TB_nameGen4_TextChanged(object sender, EventArgs e)
        {
            UpdateNameGen();
        }
        private void TB_nameGen5_TextChanged(object sender, EventArgs e)
        {
            UpdateNameGen();
        }

        private void TB_separators_TextChanged(object sender, EventArgs e)
        {
            UpdateNameGen();
        }

        private void B_chooseImgFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                MTB_loadFolder.Text = fbd.SelectedPath;
            }
            fbd.Dispose();
            //ImportImagesList();
        }

        private void B_loadImageNext_Click(object sender, EventArgs e)
        {
            LST_loadedImages.SelectedIndex = ((LST_loadedImages.SelectedIndex + 1) % LST_loadedImages.Items.Count);
        }

        private void B_loadImagePrevious_Click(object sender, EventArgs e)
        {
            LST_loadedImages.SelectedIndex = (((LST_loadedImages.SelectedIndex - 1) % LST_loadedImages.Items.Count) + LST_loadedImages.Items.Count) % LST_loadedImages.Items.Count;
        }

        private void B_importImagesList_Click(object sender, EventArgs e)
        {
            ImportImagesList();
        }

        public void ImportImagesList()
        {
            string topLevelDirectory = MTB_loadFolder.Text;

            string[] files = new string[0];
            if (CB_recurseImageList.Checked)
            {

            }
            else
            {
                files = Directory.GetFiles(topLevelDirectory);
            }

            MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            for (int i = 0; i < files.Length; i++)
            {
                if (i < LST_loadedImages.Items.Count)
                {
                    LST_loadedImages.Items[i] = files[i];
                }
                else
                {
                    LST_loadedImages.Items.Add(files[i]);
                }
            }
        }

        private void LST_loadedImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LST_loadedImages.SelectedIndex >= 0 && LST_loadedImages.SelectedIndex < LST_loadedImages.Items.Count)
            {
                PB_loadedImage.ImageLocation = LST_loadedImages.Items[LST_loadedImages.SelectedIndex].ToString();

                //LL_selectedImage.Text = "[" + LST_loadedImages.Items[LST_loadedImages.SelectedIndex].ToString() + "]";
                //LL_selectedImage.Text = "[" + Path.GetFileName(LST_loadedImages.Items[LST_loadedImages.SelectedIndex].ToString()).ToString() + "]";

                string path = LST_loadedImages.Items[LST_loadedImages.SelectedIndex].ToString();
                //var match = Regex.Match(path, @"\.[^\.]*\.", RegexOptions.RightToLeft);
                var match = Regex.Match(path, @"\\[^\\]*\\", RegexOptions.RightToLeft);
                //Debugger.Log(1, "K", match.ToString());
                //int ix = match.Success ? match.Index : -1;
                LL_selectedImage.Text = (match.Index > -1) ? "[..." + match.ToString() + Path.GetFileName(path) + "]" : "[...\\" + Path.GetFileName(path) + "]";
            }
            else
            {
                LL_selectedImage.Text = "[Image Name]";
            }
        }

        private void MTB_loadFolder_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MTB_loadFolder_TextChanged(object sender, EventArgs e)
        {
            ImportImagesList();
        }

        private void LL_selectedImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox_Options_Enter(object sender, EventArgs e)
        {

        }
    }
}
