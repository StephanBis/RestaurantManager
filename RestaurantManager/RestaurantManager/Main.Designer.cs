namespace RestaurantManager
{
    partial class Main
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
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.errorLabel = new Telerik.WinControls.UI.RadLabel();
            this.radApplicationMenu = new Telerik.WinControls.UI.RadApplicationMenu();
            this.uitloggenMenuItem = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.tafelsMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.gebruikersMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.menuMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.tafelPanel = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radApplicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelPanel)).BeginInit();
            this.tafelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = false;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(736, 12);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(339, 44);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.ThemeName = "TelerikMetroTouch";
            // 
            // radApplicationMenu
            // 
            this.radApplicationMenu.ButtonItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.uitloggenMenuItem});
            this.radApplicationMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tafelsMenuItem,
            this.gebruikersMenuItem,
            this.menuMenuItem});
            this.radApplicationMenu.Location = new System.Drawing.Point(3, 3);
            this.radApplicationMenu.Name = "radApplicationMenu";
            this.radApplicationMenu.RightColumnWidth = 0;
            this.radApplicationMenu.ShowTwoColumnDropDownMenu = false;
            this.radApplicationMenu.Size = new System.Drawing.Size(100, 48);
            this.radApplicationMenu.TabIndex = 5;
            this.radApplicationMenu.Text = "radApplicationMenu1";
            this.radApplicationMenu.ThemeName = "TelerikMetroTouch";
            // 
            // uitloggenMenuItem
            // 
            this.uitloggenMenuItem.AccessibleDescription = "Uitloggen";
            this.uitloggenMenuItem.AccessibleName = "Uitloggen";
            // 
            // 
            // 
            this.uitloggenMenuItem.ButtonElement.AccessibleDescription = "Uitloggen";
            this.uitloggenMenuItem.ButtonElement.AccessibleName = "Uitloggen";
            this.uitloggenMenuItem.Name = "uitloggenMenuItem";
            this.uitloggenMenuItem.Text = "Uitloggen";
            this.uitloggenMenuItem.Click += new System.EventHandler(this.uitloggenMenuItem_Click);
            // 
            // tafelsMenuItem
            // 
            this.tafelsMenuItem.AccessibleDescription = "Tafels beheren";
            this.tafelsMenuItem.AccessibleName = "Tafels beheren";
            this.tafelsMenuItem.Name = "tafelsMenuItem";
            this.tafelsMenuItem.Text = "Tafels beheren";
            this.tafelsMenuItem.Click += new System.EventHandler(this.tafelsMenuItem_Click);
            // 
            // gebruikersMenuItem
            // 
            this.gebruikersMenuItem.AccessibleDescription = "Gebruikers beheren";
            this.gebruikersMenuItem.AccessibleName = "Gebruikers beheren";
            this.gebruikersMenuItem.Name = "gebruikersMenuItem";
            this.gebruikersMenuItem.Text = "Gebruikers beheren";
            this.gebruikersMenuItem.Click += new System.EventHandler(this.gebruikersMenuItem_Click);
            // 
            // menuMenuItem
            // 
            this.menuMenuItem.AccessibleDescription = "Menu beheren";
            this.menuMenuItem.AccessibleName = "Menu beheren";
            this.menuMenuItem.Name = "menuMenuItem";
            this.menuMenuItem.Text = "Menu beheren";
            this.menuMenuItem.Click += new System.EventHandler(this.menuMenuItem_Click);
            // 
            // tafelPanel
            // 
            this.tafelPanel.Controls.Add(this.radApplicationMenu);
            this.tafelPanel.Controls.Add(this.errorLabel);
            this.tafelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tafelPanel.Location = new System.Drawing.Point(0, 0);
            this.tafelPanel.Name = "tafelPanel";
            this.tafelPanel.Size = new System.Drawing.Size(1078, 494);
            this.tafelPanel.TabIndex = 6;
            this.tafelPanel.ThemeName = "TelerikMetroTouch";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 494);
            this.Controls.Add(this.tafelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TableMe - Hoofdscherm";
            this.ThemeName = "TelerikMetroTouch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radApplicationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelPanel)).EndInit();
            this.tafelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadLabel errorLabel;
        private Telerik.WinControls.UI.RadApplicationMenu radApplicationMenu;
        private Telerik.WinControls.UI.RadMenuItem tafelsMenuItem;
        private Telerik.WinControls.UI.RadMenuItem gebruikersMenuItem;
        private Telerik.WinControls.UI.RadPanel tafelPanel;
        private Telerik.WinControls.UI.RadMenuItem menuMenuItem;
        private Telerik.WinControls.UI.RadMenuButtonItem uitloggenMenuItem;
    }
}