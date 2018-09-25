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
            this.matchesFoundDisplayTxt = new System.Windows.Forms.TextBox();
            this.resultListDisplay = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dirSearchBtn = new System.Windows.Forms.Button();
            this.dirPathTxt = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dirSearcChkBox = new System.Windows.Forms.CheckBox();
            this.favChkBox = new System.Windows.Forms.CheckBox();
            this.addToFavBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Search";
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
            this.searchBtn.Location = new System.Drawing.Point(309, 398);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(129, 37);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // matchesFoundDisplayTxt
            // 
            this.matchesFoundDisplayTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.matchesFoundDisplayTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matchesFoundDisplayTxt.ForeColor = System.Drawing.Color.OliveDrab;
            this.matchesFoundDisplayTxt.Location = new System.Drawing.Point(13, 132);
            this.matchesFoundDisplayTxt.Name = "matchesFoundDisplayTxt";
            this.matchesFoundDisplayTxt.Size = new System.Drawing.Size(726, 13);
            this.matchesFoundDisplayTxt.TabIndex = 4;
            // 
            // resultListDisplay
            // 
            this.resultListDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultListDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultListDisplay.ForeColor = System.Drawing.Color.White;
            this.resultListDisplay.FormattingEnabled = true;
            this.resultListDisplay.HorizontalScrollbar = true;
            this.resultListDisplay.Location = new System.Drawing.Point(13, 151);
            this.resultListDisplay.Name = "resultListDisplay";
            this.resultListDisplay.Size = new System.Drawing.Size(726, 234);
            this.resultListDisplay.TabIndex = 5;
            // 
            // dirSearchBtn
            // 
            this.dirSearchBtn.BackColor = System.Drawing.Color.DimGray;
            this.dirSearchBtn.FlatAppearance.BorderSize = 0;
            this.dirSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dirSearchBtn.ForeColor = System.Drawing.Color.White;
            this.dirSearchBtn.Location = new System.Drawing.Point(641, 429);
            this.dirSearchBtn.Name = "dirSearchBtn";
            this.dirSearchBtn.Size = new System.Drawing.Size(97, 25);
            this.dirSearchBtn.TabIndex = 6;
            this.dirSearchBtn.Text = "Select Directory";
            this.dirSearchBtn.UseVisualStyleBackColor = false;
            this.dirSearchBtn.Click += new System.EventHandler(this.dirSearchBtn_Click);
            // 
            // dirPathTxt
            // 
            this.dirPathTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dirPathTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dirPathTxt.ForeColor = System.Drawing.Color.OliveDrab;
            this.dirPathTxt.Location = new System.Drawing.Point(12, 113);
            this.dirPathTxt.Name = "dirPathTxt";
            this.dirPathTxt.Size = new System.Drawing.Size(726, 13);
            this.dirPathTxt.TabIndex = 7;
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.DimGray;
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Location = new System.Drawing.Point(641, 398);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(97, 25);
            this.openFileBtn.TabIndex = 8;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTxt.ForeColor = System.Drawing.Color.IndianRed;
            this.statusTxt.Location = new System.Drawing.Point(13, 460);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(726, 13);
            this.statusTxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Aleksandar Zoric 2018 ©";
            // 
            // dirSearcChkBox
            // 
            this.dirSearcChkBox.AutoSize = true;
            this.dirSearcChkBox.ForeColor = System.Drawing.Color.White;
            this.dirSearcChkBox.Location = new System.Drawing.Point(191, 90);
            this.dirSearcChkBox.Name = "dirSearcChkBox";
            this.dirSearcChkBox.Size = new System.Drawing.Size(105, 17);
            this.dirSearcChkBox.TabIndex = 11;
            this.dirSearcChkBox.Text = "Search Directory";
            this.dirSearcChkBox.UseVisualStyleBackColor = true;
            // 
            // favChkBox
            // 
            this.favChkBox.AutoSize = true;
            this.favChkBox.ForeColor = System.Drawing.Color.White;
            this.favChkBox.Location = new System.Drawing.Point(456, 90);
            this.favChkBox.Name = "favChkBox";
            this.favChkBox.Size = new System.Drawing.Size(95, 17);
            this.favChkBox.TabIndex = 12;
            this.favChkBox.Text = "View Favorites";
            this.favChkBox.UseVisualStyleBackColor = true;
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
            // DirectorySearchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(751, 479);
            this.Controls.Add(this.addToFavBtn);
            this.Controls.Add(this.favChkBox);
            this.Controls.Add(this.dirSearcChkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.dirPathTxt);
            this.Controls.Add(this.dirSearchBtn);
            this.Controls.Add(this.resultListDisplay);
            this.Controls.Add(this.matchesFoundDisplayTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.fileSearchTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectorySearchMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zor Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileSearchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox matchesFoundDisplayTxt;
        private System.Windows.Forms.ListBox resultListDisplay;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button dirSearchBtn;
        private System.Windows.Forms.TextBox dirPathTxt;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox dirSearcChkBox;
        private System.Windows.Forms.CheckBox favChkBox;
        private System.Windows.Forms.Button addToFavBtn;
    }
}

