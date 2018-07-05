namespace ImageRenamerTool
{
    partial class OptionsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_openImage = new System.Windows.Forms.Button();
            this.PB_loadedImage = new System.Windows.Forms.PictureBox();
            this.MTB_loadFolder = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Options = new System.Windows.Forms.GroupBox();
            this.B_renameImage = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DD_optionEditor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_loadImagePrevious = new System.Windows.Forms.Button();
            this.B_loadImageNext = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_separators = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_useSeparator = new System.Windows.Forms.CheckBox();
            this.TB_nameGen5 = new System.Windows.Forms.TextBox();
            this.TB_nameGen4 = new System.Windows.Forms.TextBox();
            this.TB_nameGen3 = new System.Windows.Forms.TextBox();
            this.TB_nameGenFull = new System.Windows.Forms.TextBox();
            this.TB_nameGen2 = new System.Windows.Forms.TextBox();
            this.TB_nameGen1 = new System.Windows.Forms.TextBox();
            this.groupBox_Image = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_loadedFileCount = new System.Windows.Forms.TextBox();
            this.CB_fileType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LL_selectedImage = new System.Windows.Forms.LinkLabel();
            this.B_importImagesList = new System.Windows.Forms.Button();
            this.B_chooseImgFolder = new System.Windows.Forms.Button();
            this.LST_loadedImages = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_imageRecurseDepth = new System.Windows.Forms.TextBox();
            this.CB_recurseImageList = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_alertsBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_loadedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Options.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_openImage
            // 
            this.B_openImage.Location = new System.Drawing.Point(190, 340);
            this.B_openImage.Name = "B_openImage";
            this.B_openImage.Size = new System.Drawing.Size(78, 23);
            this.B_openImage.TabIndex = 0;
            this.B_openImage.Text = "Load Image";
            this.B_openImage.UseVisualStyleBackColor = true;
            this.B_openImage.Click += new System.EventHandler(this.B_openImage_Click);
            // 
            // PB_loadedImage
            // 
            this.PB_loadedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PB_loadedImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_loadedImage.Location = new System.Drawing.Point(6, 34);
            this.PB_loadedImage.Name = "PB_loadedImage";
            this.PB_loadedImage.Size = new System.Drawing.Size(445, 329);
            this.PB_loadedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_loadedImage.TabIndex = 1;
            this.PB_loadedImage.TabStop = false;
            // 
            // MTB_loadFolder
            // 
            this.MTB_loadFolder.Location = new System.Drawing.Point(11, 407);
            this.MTB_loadFolder.Name = "MTB_loadFolder";
            this.MTB_loadFolder.Size = new System.Drawing.Size(661, 20);
            this.MTB_loadFolder.TabIndex = 2;
            this.MTB_loadFolder.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTB_loadFolder_MaskInputRejected);
            this.MTB_loadFolder.TextChanged += new System.EventHandler(this.MTB_loadFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Folder (Containing images to rename)";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 3);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_Options
            // 
            this.groupBox_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Options.AutoSize = true;
            this.groupBox_Options.Controls.Add(this.label8);
            this.groupBox_Options.Controls.Add(this.label13);
            this.groupBox_Options.Controls.Add(this.DD_optionEditor);
            this.groupBox_Options.Controls.Add(this.groupBox2);
            this.groupBox_Options.Controls.Add(this.label7);
            this.groupBox_Options.Controls.Add(this.label6);
            this.groupBox_Options.Controls.Add(this.label5);
            this.groupBox_Options.Controls.Add(this.label4);
            this.groupBox_Options.Controls.Add(this.label2);
            this.groupBox_Options.Controls.Add(this.B_openImage);
            this.groupBox_Options.Controls.Add(this.groupBox1);
            this.groupBox_Options.Controls.Add(this.TB_nameGen5);
            this.groupBox_Options.Controls.Add(this.TB_nameGen4);
            this.groupBox_Options.Controls.Add(this.TB_nameGen3);
            this.groupBox_Options.Controls.Add(this.TB_nameGenFull);
            this.groupBox_Options.Controls.Add(this.TB_nameGen2);
            this.groupBox_Options.Controls.Add(this.TB_nameGen1);
            this.groupBox_Options.Location = new System.Drawing.Point(701, 12);
            this.groupBox_Options.Name = "groupBox_Options";
            this.groupBox_Options.Size = new System.Drawing.Size(282, 483);
            this.groupBox_Options.TabIndex = 4;
            this.groupBox_Options.TabStop = false;
            this.groupBox_Options.Text = "Naming Options";
            this.groupBox_Options.Enter += new System.EventHandler(this.groupBox_Options_Enter);
            // 
            // B_renameImage
            // 
            this.B_renameImage.Location = new System.Drawing.Point(6, 53);
            this.B_renameImage.Name = "B_renameImage";
            this.B_renameImage.Size = new System.Drawing.Size(249, 33);
            this.B_renameImage.TabIndex = 14;
            this.B_renameImage.Text = "Rename Image";
            this.B_renameImage.UseVisualStyleBackColor = true;
            this.B_renameImage.Click += new System.EventHandler(this.B_renameImage_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Quick Edit (Select option to edit):";
            // 
            // DD_optionEditor
            // 
            this.DD_optionEditor.FormattingEnabled = true;
            this.DD_optionEditor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.DD_optionEditor.Location = new System.Drawing.Point(190, 313);
            this.DD_optionEditor.Name = "DD_optionEditor";
            this.DD_optionEditor.Size = new System.Drawing.Size(78, 21);
            this.DD_optionEditor.TabIndex = 12;
            this.DD_optionEditor.Text = "Edit";
            this.DD_optionEditor.SelectedIndexChanged += new System.EventHandler(this.DD_optionEditor_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.B_renameImage);
            this.groupBox2.Controls.Add(this.B_loadImagePrevious);
            this.groupBox2.Controls.Add(this.B_loadImageNext);
            this.groupBox2.Location = new System.Drawing.Point(9, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loaded Image Control";
            // 
            // B_loadImagePrevious
            // 
            this.B_loadImagePrevious.Location = new System.Drawing.Point(6, 19);
            this.B_loadImagePrevious.Name = "B_loadImagePrevious";
            this.B_loadImagePrevious.Size = new System.Drawing.Size(120, 23);
            this.B_loadImagePrevious.TabIndex = 1;
            this.B_loadImagePrevious.Text = "<< Previous Image";
            this.B_loadImagePrevious.UseVisualStyleBackColor = true;
            this.B_loadImagePrevious.Click += new System.EventHandler(this.B_loadImagePrevious_Click);
            // 
            // B_loadImageNext
            // 
            this.B_loadImageNext.Location = new System.Drawing.Point(136, 19);
            this.B_loadImageNext.Name = "B_loadImageNext";
            this.B_loadImageNext.Size = new System.Drawing.Size(119, 23);
            this.B_loadImageNext.TabIndex = 0;
            this.B_loadImageNext.Text = "Next Image >>";
            this.B_loadImageNext.UseVisualStyleBackColor = true;
            this.B_loadImageNext.Click += new System.EventHandler(this.B_loadImageNext_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_separators);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_useSeparator);
            this.groupBox1.Location = new System.Drawing.Point(15, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separator Options";
            // 
            // TB_separators
            // 
            this.TB_separators.Location = new System.Drawing.Point(9, 75);
            this.TB_separators.Name = "TB_separators";
            this.TB_separators.Size = new System.Drawing.Size(81, 20);
            this.TB_separators.TabIndex = 8;
            this.TB_separators.Text = "-";
            this.TB_separators.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_separators.TextChanged += new System.EventHandler(this.TB_separators_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Separator Char(s):";
            // 
            // CB_useSeparator
            // 
            this.CB_useSeparator.AutoSize = true;
            this.CB_useSeparator.Checked = true;
            this.CB_useSeparator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_useSeparator.Location = new System.Drawing.Point(12, 33);
            this.CB_useSeparator.Name = "CB_useSeparator";
            this.CB_useSeparator.Size = new System.Drawing.Size(78, 17);
            this.CB_useSeparator.TabIndex = 7;
            this.CB_useSeparator.Text = "Separator?";
            this.CB_useSeparator.UseVisualStyleBackColor = true;
            this.CB_useSeparator.CheckedChanged += new System.EventHandler(this.CB_useSeparator_CheckedChanged);
            // 
            // TB_nameGen5
            // 
            this.TB_nameGen5.Location = new System.Drawing.Point(27, 173);
            this.TB_nameGen5.Name = "TB_nameGen5";
            this.TB_nameGen5.Size = new System.Drawing.Size(248, 20);
            this.TB_nameGen5.TabIndex = 5;
            this.TB_nameGen5.Text = "Option5";
            this.TB_nameGen5.TextChanged += new System.EventHandler(this.TB_nameGen5_TextChanged);
            // 
            // TB_nameGen4
            // 
            this.TB_nameGen4.Location = new System.Drawing.Point(27, 147);
            this.TB_nameGen4.Name = "TB_nameGen4";
            this.TB_nameGen4.Size = new System.Drawing.Size(249, 20);
            this.TB_nameGen4.TabIndex = 4;
            this.TB_nameGen4.Text = "Option4";
            this.TB_nameGen4.TextChanged += new System.EventHandler(this.TB_nameGen4_TextChanged);
            // 
            // TB_nameGen3
            // 
            this.TB_nameGen3.Location = new System.Drawing.Point(27, 121);
            this.TB_nameGen3.Name = "TB_nameGen3";
            this.TB_nameGen3.Size = new System.Drawing.Size(249, 20);
            this.TB_nameGen3.TabIndex = 3;
            this.TB_nameGen3.Text = "Option3";
            this.TB_nameGen3.TextChanged += new System.EventHandler(this.TB_nameGen3_TextChanged);
            // 
            // TB_nameGenFull
            // 
            this.TB_nameGenFull.Location = new System.Drawing.Point(15, 35);
            this.TB_nameGenFull.Name = "TB_nameGenFull";
            this.TB_nameGenFull.Size = new System.Drawing.Size(261, 20);
            this.TB_nameGenFull.TabIndex = 2;
            this.TB_nameGenFull.TextChanged += new System.EventHandler(this.TB_nameGenFull_TextChanged);
            // 
            // TB_nameGen2
            // 
            this.TB_nameGen2.Location = new System.Drawing.Point(27, 95);
            this.TB_nameGen2.Name = "TB_nameGen2";
            this.TB_nameGen2.Size = new System.Drawing.Size(249, 20);
            this.TB_nameGen2.TabIndex = 1;
            this.TB_nameGen2.Text = "Option2";
            this.TB_nameGen2.TextChanged += new System.EventHandler(this.TB_nameGen2_TextChanged);
            // 
            // TB_nameGen1
            // 
            this.TB_nameGen1.Location = new System.Drawing.Point(27, 66);
            this.TB_nameGen1.Name = "TB_nameGen1";
            this.TB_nameGen1.Size = new System.Drawing.Size(249, 20);
            this.TB_nameGen1.TabIndex = 0;
            this.TB_nameGen1.Text = "Option1";
            this.TB_nameGen1.TextChanged += new System.EventHandler(this.TB_nameGen5_TextChanged);
            // 
            // groupBox_Image
            // 
            this.groupBox_Image.AutoSize = true;
            this.groupBox_Image.Controls.Add(this.label9);
            this.groupBox_Image.Controls.Add(this.TB_loadedFileCount);
            this.groupBox_Image.Controls.Add(this.CB_fileType);
            this.groupBox_Image.Controls.Add(this.label15);
            this.groupBox_Image.Controls.Add(this.label14);
            this.groupBox_Image.Controls.Add(this.LL_selectedImage);
            this.groupBox_Image.Controls.Add(this.B_importImagesList);
            this.groupBox_Image.Controls.Add(this.B_chooseImgFolder);
            this.groupBox_Image.Controls.Add(this.LST_loadedImages);
            this.groupBox_Image.Controls.Add(this.label12);
            this.groupBox_Image.Controls.Add(this.TB_imageRecurseDepth);
            this.groupBox_Image.Controls.Add(this.CB_recurseImageList);
            this.groupBox_Image.Controls.Add(this.PB_loadedImage);
            this.groupBox_Image.Controls.Add(this.label1);
            this.groupBox_Image.Controls.Add(this.MTB_loadFolder);
            this.groupBox_Image.Location = new System.Drawing.Point(15, 12);
            this.groupBox_Image.Name = "groupBox_Image";
            this.groupBox_Image.Size = new System.Drawing.Size(689, 483);
            this.groupBox_Image.TabIndex = 5;
            this.groupBox_Image.TabStop = false;
            this.groupBox_Image.Text = "Image + Saving / Loading";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "- Recursion Depth (\'0\' for all Subfolders)";
            // 
            // TB_loadedFileCount
            // 
            this.TB_loadedFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_loadedFileCount.Enabled = false;
            this.TB_loadedFileCount.Location = new System.Drawing.Point(620, 13);
            this.TB_loadedFileCount.Name = "TB_loadedFileCount";
            this.TB_loadedFileCount.Size = new System.Drawing.Size(52, 20);
            this.TB_loadedFileCount.TabIndex = 18;
            this.TB_loadedFileCount.Text = "0";
            // 
            // CB_fileType
            // 
            this.CB_fileType.FormattingEnabled = true;
            this.CB_fileType.Items.AddRange(new object[] {
            "All (.*.)",
            "Images",
            "JPG",
            "BMP",
            "GIF",
            "EXE"});
            this.CB_fileType.Location = new System.Drawing.Point(513, 374);
            this.CB_fileType.Name = "CB_fileType";
            this.CB_fileType.Size = new System.Drawing.Size(65, 21);
            this.CB_fileType.TabIndex = 14;
            this.CB_fileType.Text = "All (.*.)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(454, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "File Type:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Image Preview";
            // 
            // LL_selectedImage
            // 
            this.LL_selectedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LL_selectedImage.AutoSize = true;
            this.LL_selectedImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LL_selectedImage.Location = new System.Drawing.Point(25, 337);
            this.LL_selectedImage.Name = "LL_selectedImage";
            this.LL_selectedImage.Size = new System.Drawing.Size(73, 13);
            this.LL_selectedImage.TabIndex = 15;
            this.LL_selectedImage.TabStop = true;
            this.LL_selectedImage.Text = "[Image Name]";
            this.LL_selectedImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LL_selectedImage.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LL_selectedImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_selectedImage_LinkClicked);
            // 
            // B_importImagesList
            // 
            this.B_importImagesList.Location = new System.Drawing.Point(584, 373);
            this.B_importImagesList.Name = "B_importImagesList";
            this.B_importImagesList.Size = new System.Drawing.Size(88, 23);
            this.B_importImagesList.TabIndex = 14;
            this.B_importImagesList.Text = "Reload";
            this.B_importImagesList.UseVisualStyleBackColor = true;
            this.B_importImagesList.Click += new System.EventHandler(this.B_importImagesList_Click);
            // 
            // B_chooseImgFolder
            // 
            this.B_chooseImgFolder.Location = new System.Drawing.Point(10, 435);
            this.B_chooseImgFolder.Name = "B_chooseImgFolder";
            this.B_chooseImgFolder.Size = new System.Drawing.Size(99, 29);
            this.B_chooseImgFolder.TabIndex = 10;
            this.B_chooseImgFolder.Text = "Choose Folder";
            this.B_chooseImgFolder.UseVisualStyleBackColor = true;
            this.B_chooseImgFolder.Click += new System.EventHandler(this.B_chooseImgFolder_Click);
            // 
            // LST_loadedImages
            // 
            this.LST_loadedImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LST_loadedImages.FormattingEnabled = true;
            this.LST_loadedImages.HorizontalScrollbar = true;
            this.LST_loadedImages.Location = new System.Drawing.Point(457, 34);
            this.LST_loadedImages.Name = "LST_loadedImages";
            this.LST_loadedImages.Size = new System.Drawing.Size(215, 329);
            this.LST_loadedImages.TabIndex = 9;
            this.LST_loadedImages.SelectedIndexChanged += new System.EventHandler(this.LST_loadedImages_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Loaded images:";
            // 
            // TB_imageRecurseDepth
            // 
            this.TB_imageRecurseDepth.Location = new System.Drawing.Point(441, 440);
            this.TB_imageRecurseDepth.Name = "TB_imageRecurseDepth";
            this.TB_imageRecurseDepth.Size = new System.Drawing.Size(32, 20);
            this.TB_imageRecurseDepth.TabIndex = 6;
            this.TB_imageRecurseDepth.Text = "0";
            // 
            // CB_recurseImageList
            // 
            this.CB_recurseImageList.AutoSize = true;
            this.CB_recurseImageList.Location = new System.Drawing.Point(288, 444);
            this.CB_recurseImageList.Name = "CB_recurseImageList";
            this.CB_recurseImageList.Size = new System.Drawing.Size(131, 17);
            this.CB_recurseImageList.TabIndex = 4;
            this.CB_recurseImageList.Text = "- Recurse Subfolders?";
            this.CB_recurseImageList.UseVisualStyleBackColor = true;
            this.CB_recurseImageList.CheckedChanged += new System.EventHandler(this.CB_recurseImageList_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(877, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "© Fin Warman, 2018";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Version 0.1.2";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TB_alertsBox
            // 
            this.TB_alertsBox.Enabled = false;
            this.TB_alertsBox.Location = new System.Drawing.Point(303, 503);
            this.TB_alertsBox.Name = "TB_alertsBox";
            this.TB_alertsBox.Size = new System.Drawing.Size(401, 20);
            this.TB_alertsBox.TabIndex = 13;
            this.TB_alertsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(261, 506);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Alerts:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "New Name:";
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 534);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TB_alertsBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox_Image);
            this.Controls.Add(this.groupBox_Options);
            this.Name = "OptionsWindow";
            this.Text = "ImageRenamer - Options";
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_loadedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Options.ResumeLayout(false);
            this.groupBox_Options.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Image.ResumeLayout(false);
            this.groupBox_Image.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_openImage;
        private System.Windows.Forms.PictureBox PB_loadedImage;
        private System.Windows.Forms.MaskedTextBox MTB_loadFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_Options;
        private System.Windows.Forms.GroupBox groupBox_Image;
        private System.Windows.Forms.TextBox TB_nameGenFull;
        private System.Windows.Forms.TextBox TB_nameGen2;
        private System.Windows.Forms.TextBox TB_nameGen1;
        private System.Windows.Forms.TextBox TB_nameGen5;
        private System.Windows.Forms.TextBox TB_nameGen4;
        private System.Windows.Forms.TextBox TB_nameGen3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_separators;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_useSeparator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CB_recurseImageList;
        private System.Windows.Forms.TextBox TB_imageRecurseDepth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox LST_loadedImages;
        private System.Windows.Forms.Button B_chooseImgFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_loadImagePrevious;
        private System.Windows.Forms.Button B_loadImageNext;
        private System.Windows.Forms.ComboBox DD_optionEditor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button B_importImagesList;
        private System.Windows.Forms.LinkLabel LL_selectedImage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CB_fileType;
        private System.Windows.Forms.TextBox TB_alertsBox;
        private System.Windows.Forms.TextBox TB_loadedFileCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button B_renameImage;
        private System.Windows.Forms.Label label8;
    }
}

