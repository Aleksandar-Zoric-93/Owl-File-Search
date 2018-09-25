namespace DirectorySearch
{
    partial class DirectorySearchMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorySearchMain));
            this.label1 = new System.Windows.Forms.Label();
            this.fileSearchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resultListDisplay = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dirSearchBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addToFavBtn = new System.Windows.Forms.Button();
            this.addToWorksBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.fileInfoLbl = new System.Windows.Forms.Label();
            this.infoBtn = new System.Windows.Forms.PictureBox();
            this.owlImage = new System.Windows.Forms.PictureBox();
            this.overallStatusTxt = new System.Windows.Forms.Label();
            this.dirPathTxt = new System.Windows.Forms.Label();
            this.matchesFoundDisplayTxt = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.dirSearcChkBox = new System.Windows.Forms.RadioButton();
            this.workOnChkBox = new System.Windows.Forms.RadioButton();
            this.favChkBox = new System.Windows.Forms.RadioButton();
            this.addToDirListBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.recentFileSrc = new System.Windows.Forms.RadioButton();
            this.selectDirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.owlImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owl File Search";
            // 
            // fileSearchTxt
            // 
            this.fileSearchTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fileSearchTxt.Location = new System.Drawing.Point(191, 66);
            this.fileSearchTxt.Name = "fileSearchTxt";
            this.fileSearchTxt.Size = new System.Drawing.Size(360, 20);
            this.fileSearchTxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DarkGray;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(309, 419);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(129, 37);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resultListDisplay
            // 
            this.resultListDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultListDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultListDisplay.ForeColor = System.Drawing.Color.White;
            this.resultListDisplay.FormattingEnabled = true;
            this.resultListDisplay.HorizontalScrollbar = true;
            this.resultListDisplay.Location = new System.Drawing.Point(13, 172);
            this.resultListDisplay.Name = "resultListDisplay";
            this.resultListDisplay.Size = new System.Drawing.Size(725, 234);
            this.resultListDisplay.TabIndex = 5;
            this.resultListDisplay.SelectedIndexChanged += new System.EventHandler(this.resultListDisplay_SelectedIndexChanged);
            // 
            // dirSearchBtn
            // 
            this.dirSearchBtn.BackColor = System.Drawing.Color.DimGray;
            this.dirSearchBtn.FlatAppearance.BorderSize = 0;
            this.dirSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dirSearchBtn.ForeColor = System.Drawing.Color.White;
            this.dirSearchBtn.Location = new System.Drawing.Point(641, 450);
            this.dirSearchBtn.Name = "dirSearchBtn";
            this.dirSearchBtn.Size = new System.Drawing.Size(97, 25);
            this.dirSearchBtn.TabIndex = 6;
            this.dirSearchBtn.Text = "Select Directory";
            this.dirSearchBtn.UseVisualStyleBackColor = false;
            this.dirSearchBtn.Click += new System.EventHandler(this.dirSearchBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.DimGray;
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Location = new System.Drawing.Point(641, 419);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(97, 25);
            this.openFileBtn.TabIndex = 8;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "© Copyright Aleksandar Zoric 2018";
            // 
            // addToFavBtn
            // 
            this.addToFavBtn.BackColor = System.Drawing.Color.DimGray;
            this.addToFavBtn.FlatAppearance.BorderSize = 0;
            this.addToFavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToFavBtn.ForeColor = System.Drawing.Color.White;
            this.addToFavBtn.Location = new System.Drawing.Point(642, 66);
            this.addToFavBtn.Name = "addToFavBtn";
            this.addToFavBtn.Size = new System.Drawing.Size(97, 20);
            this.addToFavBtn.TabIndex = 13;
            this.addToFavBtn.Text = "Add to Favorites";
            this.addToFavBtn.UseVisualStyleBackColor = false;
            this.addToFavBtn.Click += new System.EventHandler(this.addToFavBtn_Click);
            // 
            // addToWorksBtn
            // 
            this.addToWorksBtn.BackColor = System.Drawing.Color.DimGray;
            this.addToWorksBtn.FlatAppearance.BorderSize = 0;
            this.addToWorksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToWorksBtn.ForeColor = System.Drawing.Color.White;
            this.addToWorksBtn.Location = new System.Drawing.Point(641, 40);
            this.addToWorksBtn.Name = "addToWorksBtn";
            this.addToWorksBtn.Size = new System.Drawing.Size(97, 20);
            this.addToWorksBtn.TabIndex = 15;
            this.addToWorksBtn.Text = "Add to Works";
            this.addToWorksBtn.UseVisualStyleBackColor = false;
            this.addToWorksBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(321, 419);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(97, 25);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // fileInfoLbl
            // 
            this.fileInfoLbl.AutoEllipsis = true;
            this.fileInfoLbl.AutoSize = true;
            this.fileInfoLbl.CausesValidation = false;
            this.fileInfoLbl.ForeColor = System.Drawing.Color.White;
            this.fileInfoLbl.Location = new System.Drawing.Point(65, 441);
            this.fileInfoLbl.MaximumSize = new System.Drawing.Size(245, 0);
            this.fileInfoLbl.Name = "fileInfoLbl";
            this.fileInfoLbl.Size = new System.Drawing.Size(0, 13);
            this.fileInfoLbl.TabIndex = 21;
            // 
            // infoBtn
            // 
            this.infoBtn.BackgroundImage = global::OwlFileSearch.Properties.Resources.setting;
            this.infoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.infoBtn.Location = new System.Drawing.Point(12, 447);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(47, 34);
            this.infoBtn.TabIndex = 19;
            this.infoBtn.TabStop = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // owlImage
            // 
            this.owlImage.BackgroundImage = global::OwlFileSearch.Properties.Resources.owl2;
            this.owlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.owlImage.Location = new System.Drawing.Point(119, 40);
            this.owlImage.Name = "owlImage";
            this.owlImage.Size = new System.Drawing.Size(66, 67);
            this.owlImage.TabIndex = 18;
            this.owlImage.TabStop = false;
            // 
            // overallStatusTxt
            // 
            this.overallStatusTxt.AutoSize = true;
            this.overallStatusTxt.ForeColor = System.Drawing.Color.OliveDrab;
            this.overallStatusTxt.Location = new System.Drawing.Point(6, 4);
            this.overallStatusTxt.Name = "overallStatusTxt";
            this.overallStatusTxt.Size = new System.Drawing.Size(0, 13);
            this.overallStatusTxt.TabIndex = 22;
            // 
            // dirPathTxt
            // 
            this.dirPathTxt.AutoSize = true;
            this.dirPathTxt.ForeColor = System.Drawing.Color.OliveDrab;
            this.dirPathTxt.Location = new System.Drawing.Point(12, 116);
            this.dirPathTxt.Name = "dirPathTxt";
            this.dirPathTxt.Size = new System.Drawing.Size(0, 13);
            this.dirPathTxt.TabIndex = 23;
            // 
            // matchesFoundDisplayTxt
            // 
            this.matchesFoundDisplayTxt.AutoSize = true;
            this.matchesFoundDisplayTxt.ForeColor = System.Drawing.Color.OliveDrab;
            this.matchesFoundDisplayTxt.Location = new System.Drawing.Point(11, 132);
            this.matchesFoundDisplayTxt.Name = "matchesFoundDisplayTxt";
            this.matchesFoundDisplayTxt.Size = new System.Drawing.Size(0, 13);
            this.matchesFoundDisplayTxt.TabIndex = 24;
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.ForeColor = System.Drawing.Color.Salmon;
            this.statusTxt.Location = new System.Drawing.Point(9, 484);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(0, 13);
            this.statusTxt.TabIndex = 25;
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.ForeColor = System.Drawing.Color.White;
            this.fileNameLbl.Location = new System.Drawing.Point(12, 149);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(0, 13);
            this.fileNameLbl.TabIndex = 26;
            // 
            // dirSearcChkBox
            // 
            this.dirSearcChkBox.AutoSize = true;
            this.dirSearcChkBox.ForeColor = System.Drawing.Color.White;
            this.dirSearcChkBox.Location = new System.Drawing.Point(191, 89);
            this.dirSearcChkBox.Name = "dirSearcChkBox";
            this.dirSearcChkBox.Size = new System.Drawing.Size(104, 17);
            this.dirSearcChkBox.TabIndex = 27;
            this.dirSearcChkBox.TabStop = true;
            this.dirSearcChkBox.Text = "Directory Search";
            this.dirSearcChkBox.UseVisualStyleBackColor = true;
            this.dirSearcChkBox.CheckedChanged += new System.EventHandler(this.dirSearcChkBox_CheckedChanged);
            // 
            // workOnChkBox
            // 
            this.workOnChkBox.AutoSize = true;
            this.workOnChkBox.ForeColor = System.Drawing.Color.White;
            this.workOnChkBox.Location = new System.Drawing.Point(332, 89);
            this.workOnChkBox.Name = "workOnChkBox";
            this.workOnChkBox.Size = new System.Drawing.Size(82, 17);
            this.workOnChkBox.TabIndex = 28;
            this.workOnChkBox.TabStop = true;
            this.workOnChkBox.Text = "View Works";
            this.workOnChkBox.UseVisualStyleBackColor = true;
            this.workOnChkBox.CheckedChanged += new System.EventHandler(this.workOnChkBox_CheckedChanged);
            // 
            // favChkBox
            // 
            this.favChkBox.AutoSize = true;
            this.favChkBox.ForeColor = System.Drawing.Color.White;
            this.favChkBox.Location = new System.Drawing.Point(457, 89);
            this.favChkBox.Name = "favChkBox";
            this.favChkBox.Size = new System.Drawing.Size(94, 17);
            this.favChkBox.TabIndex = 29;
            this.favChkBox.TabStop = true;
            this.favChkBox.Text = "View Favorites";
            this.favChkBox.UseVisualStyleBackColor = true;
            this.favChkBox.CheckedChanged += new System.EventHandler(this.favChkBox_CheckedChanged);
            // 
            // addToDirListBtn
            // 
            this.addToDirListBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.addToDirListBtn.FlatAppearance.BorderSize = 0;
            this.addToDirListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToDirListBtn.ForeColor = System.Drawing.Color.White;
            this.addToDirListBtn.Location = new System.Drawing.Point(538, 450);
            this.addToDirListBtn.Name = "addToDirListBtn";
            this.addToDirListBtn.Size = new System.Drawing.Size(97, 25);
            this.addToDirListBtn.TabIndex = 30;
            this.addToDirListBtn.Text = "Add to Search";
            this.addToDirListBtn.UseVisualStyleBackColor = false;
            this.addToDirListBtn.Visible = false;
            this.addToDirListBtn.Click += new System.EventHandler(this.addToDirListBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.Peru;
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Location = new System.Drawing.Point(538, 419);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(97, 25);
            this.exportBtn.TabIndex = 31;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Visible = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // recentFileSrc
            // 
            this.recentFileSrc.AutoSize = true;
            this.recentFileSrc.ForeColor = System.Drawing.Color.White;
            this.recentFileSrc.Location = new System.Drawing.Point(673, 480);
            this.recentFileSrc.Name = "recentFileSrc";
            this.recentFileSrc.Size = new System.Drawing.Size(65, 17);
            this.recentFileSrc.TabIndex = 32;
            this.recentFileSrc.TabStop = true;
            this.recentFileSrc.Text = "Recents";
            this.recentFileSrc.UseVisualStyleBackColor = true;
            this.recentFileSrc.CheckedChanged += new System.EventHandler(this.recentFileSrc_CheckedChanged);
            // 
            // selectDirBtn
            // 
            this.selectDirBtn.BackColor = System.Drawing.Color.DarkGray;
            this.selectDirBtn.FlatAppearance.BorderSize = 0;
            this.selectDirBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectDirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDirBtn.Location = new System.Drawing.Point(309, 419);
            this.selectDirBtn.Name = "selectDirBtn";
            this.selectDirBtn.Size = new System.Drawing.Size(129, 37);
            this.selectDirBtn.TabIndex = 33;
            this.selectDirBtn.Text = "Select";
            this.selectDirBtn.UseVisualStyleBackColor = false;
            this.selectDirBtn.Visible = false;
            this.selectDirBtn.Click += new System.EventHandler(this.selectDirBtn_Click);
            // 
            // DirectorySearchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(751, 500);
            this.Controls.Add(this.recentFileSrc);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.addToDirListBtn);
            this.Controls.Add(this.favChkBox);
            this.Controls.Add(this.workOnChkBox);
            this.Controls.Add(this.dirSearcChkBox);
            this.Controls.Add(this.fileNameLbl);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.matchesFoundDisplayTxt);
            this.Controls.Add(this.dirPathTxt);
            this.Controls.Add(this.overallStatusTxt);
            this.Controls.Add(this.fileInfoLbl);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.owlImage);
            this.Controls.Add(this.addToWorksBtn);
            this.Controls.Add(this.addToFavBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.dirSearchBtn);
            this.Controls.Add(this.resultListDisplay);
            this.Controls.Add(this.fileSearchTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.selectDirBtn);
            this.Controls.Add(this.searchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DirectorySearchMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owl File Search";
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.owlImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileSearchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox resultListDisplay;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button dirSearchBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToFavBtn;
        private System.Windows.Forms.Button addToWorksBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.PictureBox owlImage;
        private System.Windows.Forms.PictureBox infoBtn;
        private System.Windows.Forms.Label fileInfoLbl;
        private System.Windows.Forms.Label overallStatusTxt;
        private System.Windows.Forms.Label dirPathTxt;
        private System.Windows.Forms.Label matchesFoundDisplayTxt;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.RadioButton dirSearcChkBox;
        private System.Windows.Forms.RadioButton workOnChkBox;
        private System.Windows.Forms.RadioButton favChkBox;
        public System.Windows.Forms.Button addToDirListBtn;
        public System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.RadioButton recentFileSrc;
        private System.Windows.Forms.Button selectDirBtn;
    }
}

