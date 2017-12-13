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
                TextBox[] TB_nameGens = new TextBox[] {TB_nameGen1, TB_nameGen2, TB_nameGen3, TB_nameGen4 ,TB_nameGen5 };
                TB_nameGenFull.Text = TB_nameGen1.Text;
                for (int i = 1; i < TB_nameGens.Length; i++)
                {
                    if(TB_nameGens[i].Text.Length > 0)
                    {
                        TB_nameGenFull.Text += sep + TB_nameGens[i].Text;
                    }
                }
                //TB_nameGenFull.Text = TB_nameGen1.Text + sep + TB_nameGen2.Text + sep + TB_nameGen3.Text + sep + TB_nameGen4.Text + sep + TB_nameGen5.Text;
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

            string selectFileType = CB_fileType.Items[CB_fileType.SelectedIndex].ToString();

            SearchOption recurse = CB_recurseImageList.Checked == true ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            List<string> files = new List<string>();
            List<string> searchExts = new List<string> { "jpg", "gif", "png", "bmp"};
            foreach(string extension in searchExts)
            {
                string searchPattern = "*." + extension;
                files.AddRange(Directory.GetFiles(topLevelDirectory, searchPattern, recurse));
            }

            TB_alertsBox.BackColor = DefaultBackColor;
            if (files.Count != Convert.ToInt32(TB_loadedFileCount.Text))
            {
                TB_loadedFileCount.Text = files.Count.ToString();
                TB_alertsBox.Text = ("Files found: " + files.Count.ToString()).ToString();
                TB_alertsBox.BackColor = Color.AliceBlue;
            }

            LST_loadedImages.Items.Clear();
            for (int i = 0; i < files.Count; i++)
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

        private bool ignoreTextChanged = false;
        private void MTB_loadFolder_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanged)
            {
                ImportImagesList();
            }
        }

        private void LL_selectedImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox_Options_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void CB_recurseImageList_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DD_optionEditor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B_renameImage_Click(object sender, EventArgs e)
        {
            string Imglocation = PB_loadedImage.ImageLocation;

            FileInfo currentFile = new FileInfo(Imglocation);

            string newName = currentFile.Directory.FullName + "\\" + TB_nameGenFull.Text + currentFile.Extension;
            currentFile.MoveTo(newName);

            LST_loadedImages.Items[LST_loadedImages.SelectedIndex] = newName;


            int newIndex = ((LST_loadedImages.SelectedIndex + 1) % LST_loadedImages.Items.Count);
            //ImportImagesList();
            LST_loadedImages.SelectedIndex = newIndex;

        }

        private void TB_nameGenFull_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
