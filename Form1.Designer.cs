namespace DirectoryFind
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.Mask_search = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.panelMenuSettings = new System.Windows.Forms.Panel();
            this.pM_cancle = new System.Windows.Forms.Button();
            this.pM_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.folderName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choiseFolder = new System.Windows.Forms.Button();
            this.textBoxChoisedFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.setting = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.panelMenuSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mask_search
            // 
            this.Mask_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mask_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mask_search.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mask_search.Location = new System.Drawing.Point(4, 7);
            this.Mask_search.Name = "Mask_search";
            this.Mask_search.Size = new System.Drawing.Size(720, 20);
            this.Mask_search.TabIndex = 1;
            this.Mask_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_search_KeyPress);
            // 
            // Author
            // 
            this.Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(655, 444);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(143, 15);
            this.Author.TabIndex = 4;
            this.Author.Text = "Автор: Волошенко В. А";
            // 
            // panelMenuSettings
            // 
            this.panelMenuSettings.AllowDrop = true;
            this.panelMenuSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuSettings.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenuSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuSettings.Controls.Add(this.pM_cancle);
            this.panelMenuSettings.Controls.Add(this.pM_ok);
            this.panelMenuSettings.Controls.Add(this.groupBox1);
            this.panelMenuSettings.Controls.Add(this.folderName);
            this.panelMenuSettings.Controls.Add(this.label1);
            this.panelMenuSettings.Controls.Add(this.choiseFolder);
            this.panelMenuSettings.Controls.Add(this.textBoxChoisedFolder);
            this.panelMenuSettings.Location = new System.Drawing.Point(478, 31);
            this.panelMenuSettings.Name = "panelMenuSettings";
            this.panelMenuSettings.Size = new System.Drawing.Size(320, 188);
            this.panelMenuSettings.TabIndex = 101;
            this.panelMenuSettings.TabStop = true;
            this.panelMenuSettings.Visible = false;
            // 
            // pM_cancle
            // 
            this.pM_cancle.Location = new System.Drawing.Point(235, 160);
            this.pM_cancle.Name = "pM_cancle";
            this.pM_cancle.Size = new System.Drawing.Size(75, 23);
            this.pM_cancle.TabIndex = 102;
            this.pM_cancle.Text = "Отмена";
            this.pM_cancle.UseVisualStyleBackColor = true;
            this.pM_cancle.Click += new System.EventHandler(this.pM_cancle_Click);
            // 
            // pM_ok
            // 
            this.pM_ok.Location = new System.Drawing.Point(154, 160);
            this.pM_ok.Name = "pM_ok";
            this.pM_ok.Size = new System.Drawing.Size(75, 23);
            this.pM_ok.TabIndex = 103;
            this.pM_ok.Text = "Ок";
            this.pM_ok.UseVisualStyleBackColor = true;
            this.pM_ok.Click += new System.EventHandler(this.pM_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(7, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 108);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 85);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(163, 17);
            this.radioButton4.TabIndex = 112;
            this.radioButton4.Text = "Содержащее данное слово";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 17);
            this.radioButton1.TabIndex = 105;
            this.radioButton1.Text = "Точное совпадение";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(139, 17);
            this.radioButton3.TabIndex = 107;
            this.radioButton3.Text = "Поиск по расширению";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 17);
            this.radioButton2.TabIndex = 106;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Неточное совпадение";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // folderName
            // 
            this.folderName.AutoSize = true;
            this.folderName.Location = new System.Drawing.Point(105, 4);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(56, 13);
            this.folderName.TabIndex = 108;
            this.folderName.Text = "NotChoise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Выбранная папка: ";
            // 
            // choiseFolder
            // 
            this.choiseFolder.Location = new System.Drawing.Point(235, 17);
            this.choiseFolder.Name = "choiseFolder";
            this.choiseFolder.Size = new System.Drawing.Size(75, 23);
            this.choiseFolder.TabIndex = 110;
            this.choiseFolder.Text = "Выбрать";
            this.choiseFolder.UseVisualStyleBackColor = true;
            this.choiseFolder.Click += new System.EventHandler(this.choisePath_Click);
            // 
            // textBoxChoisedFolder
            // 
            this.textBoxChoisedFolder.Enabled = false;
            this.textBoxChoisedFolder.Location = new System.Drawing.Point(3, 20);
            this.textBoxChoisedFolder.Name = "textBoxChoisedFolder";
            this.textBoxChoisedFolder.Size = new System.Drawing.Size(226, 20);
            this.textBoxChoisedFolder.TabIndex = 111;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(4, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(794, 407);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // setting
            // 
            this.setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setting.BackgroundImage = global::DirectoryFind.Properties.Resources.settings;
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.setting.Font = new System.Drawing.Font("Arial", 9F);
            this.setting.Location = new System.Drawing.Point(764, 5);
            this.setting.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(34, 24);
            this.setting.TabIndex = 3;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search.BackgroundImage = global::DirectoryFind.Properties.Resources.transparency;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search.Font = new System.Drawing.Font("Arial", 9F);
            this.search.Location = new System.Drawing.Point(730, 5);
            this.search.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(34, 24);
            this.search.TabIndex = 0;
            this.search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.panelMenuSettings);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.Mask_search);
            this.Controls.Add(this.search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(666, 444);
            this.Name = "Form1";
            this.Text = "Файловый поиск";
            this.panelMenuSettings.ResumeLayout(false);
            this.panelMenuSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox Mask_search;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Panel panelMenuSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label folderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choiseFolder;
        private System.Windows.Forms.TextBox textBoxChoisedFolder;
        private System.Windows.Forms.Button pM_cancle;
        private System.Windows.Forms.Button pM_ok;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

