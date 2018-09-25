namespace OwlFileSearch
{
    partial class Eula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eula));
            this.eulaAgreementTxt = new System.Windows.Forms.TextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.declineBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eulaAgreementTxt
            // 
            this.eulaAgreementTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eulaAgreementTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eulaAgreementTxt.ForeColor = System.Drawing.Color.White;
            this.eulaAgreementTxt.HideSelection = false;
            this.eulaAgreementTxt.Location = new System.Drawing.Point(24, 12);
            this.eulaAgreementTxt.Multiline = true;
            this.eulaAgreementTxt.Name = "eulaAgreementTxt";
            this.eulaAgreementTxt.ReadOnly = true;
            this.eulaAgreementTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eulaAgreementTxt.Size = new System.Drawing.Size(719, 435);
            this.eulaAgreementTxt.TabIndex = 0;
            this.eulaAgreementTxt.TabStop = false;
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.acceptBtn.FlatAppearance.BorderSize = 0;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.ForeColor = System.Drawing.Color.White;
            this.acceptBtn.Location = new System.Drawing.Point(233, 462);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(97, 20);
            this.acceptBtn.TabIndex = 26;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // declineBtn
            // 
            this.declineBtn.BackColor = System.Drawing.Color.IndianRed;
            this.declineBtn.FlatAppearance.BorderSize = 0;
            this.declineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declineBtn.ForeColor = System.Drawing.Color.White;
            this.declineBtn.Location = new System.Drawing.Point(380, 462);
            this.declineBtn.Name = "declineBtn";
            this.declineBtn.Size = new System.Drawing.Size(97, 20);
            this.declineBtn.TabIndex = 29;
            this.declineBtn.Text = "Decline";
            this.declineBtn.UseVisualStyleBackColor = false;
            this.declineBtn.Click += new System.EventHandler(this.declineBtn_Click);
            // 
            // Eula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(755, 504);
            this.Controls.Add(this.declineBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.eulaAgreementTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eulaAgreementTxt;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button declineBtn;
    }
}