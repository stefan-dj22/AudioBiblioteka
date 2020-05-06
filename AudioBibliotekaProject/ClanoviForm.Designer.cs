namespace AudioBibliotekaProject
{
    partial class ClanoviForm
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
            this.tabAdminTim = new System.Windows.Forms.TabPage();
            this.tabClanovi = new System.Windows.Forms.TabPage();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.tabProfil = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxPages = new System.Windows.Forms.ComboBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.tabAdminTim.SuspendLayout();
            this.tabClanovi.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdminTim
            // 
            this.tabAdminTim.Controls.Add(this.panelAdmin);
            this.tabAdminTim.Location = new System.Drawing.Point(4, 25);
            this.tabAdminTim.Name = "tabAdminTim";
            this.tabAdminTim.Size = new System.Drawing.Size(654, 467);
            this.tabAdminTim.TabIndex = 2;
            this.tabAdminTim.Text = "Admin tim";
            this.tabAdminTim.UseVisualStyleBackColor = true;
            // 
            // tabClanovi
            // 
            this.tabClanovi.AutoScroll = true;
            this.tabClanovi.Controls.Add(this.lblPage);
            this.tabClanovi.Controls.Add(this.cbxPages);
            this.tabClanovi.Controls.Add(this.txtSearch);
            this.tabClanovi.Controls.Add(this.btnSearch);
            this.tabClanovi.Controls.Add(this.panelUsers);
            this.tabClanovi.Location = new System.Drawing.Point(4, 25);
            this.tabClanovi.Name = "tabClanovi";
            this.tabClanovi.Padding = new System.Windows.Forms.Padding(3);
            this.tabClanovi.Size = new System.Drawing.Size(654, 467);
            this.tabClanovi.TabIndex = 1;
            this.tabClanovi.Text = "Clanovi";
            this.tabClanovi.UseVisualStyleBackColor = true;
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsers.AutoScroll = true;
            this.panelUsers.Location = new System.Drawing.Point(0, 45);
            this.panelUsers.MinimumSize = new System.Drawing.Size(283, 283);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(654, 426);
            this.panelUsers.TabIndex = 0;
            // 
            // tabProfil
            // 
            this.tabProfil.Location = new System.Drawing.Point(4, 25);
            this.tabProfil.Name = "tabProfil";
            this.tabProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfil.Size = new System.Drawing.Size(654, 467);
            this.tabProfil.TabIndex = 0;
            this.tabProfil.Text = "Profil";
            this.tabProfil.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabProfil);
            this.tabControl.Controls.Add(this.tabClanovi);
            this.tabControl.Controls.Add(this.tabAdminTim);
            this.tabControl.Location = new System.Drawing.Point(1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(662, 496);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdmin.AutoScroll = true;
            this.panelAdmin.Location = new System.Drawing.Point(0, 3);
            this.panelAdmin.MinimumSize = new System.Drawing.Size(283, 283);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(654, 468);
            this.panelAdmin.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(565, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Traži";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(409, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(128, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // cbxPages
            // 
            this.cbxPages.FormattingEnabled = true;
            this.cbxPages.Location = new System.Drawing.Point(115, 9);
            this.cbxPages.Name = "cbxPages";
            this.cbxPages.Size = new System.Drawing.Size(49, 24);
            this.cbxPages.TabIndex = 3;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(49, 9);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(60, 17);
            this.lblPage.TabIndex = 4;
            this.lblPage.Text = "Stranica";
            this.lblPage.Click += new System.EventHandler(this.lblPage_Click);
            // 
            // ClanoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 500);
            this.Controls.Add(this.tabControl);
            this.Name = "ClanoviForm";
            this.Text = "ClanoviForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClanoviForm_FormClosing);
            this.Resize += new System.EventHandler(this.ClanoviForm_Resize);
            this.tabAdminTim.ResumeLayout(false);
            this.tabClanovi.ResumeLayout(false);
            this.tabClanovi.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAdminTim;
        private System.Windows.Forms.TabPage tabClanovi;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.TabPage tabProfil;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.ComboBox cbxPages;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}