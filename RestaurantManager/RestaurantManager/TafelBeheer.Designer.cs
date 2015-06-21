namespace RestaurantManager
{
    partial class TafelBeheer
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
            this.tafelsListbox = new Telerik.WinControls.UI.RadListControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tafelNummerLabel = new Telerik.WinControls.UI.RadLabel();
            this.tafelKleurLabel = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.verwijderButton = new Telerik.WinControls.UI.RadButton();
            this.tafelNummerTextbox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.aanpassenButton = new Telerik.WinControls.UI.RadButton();
            this.toevoegenButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.opslaanButton = new Telerik.WinControls.UI.RadButton();
            this.buttonPanel = new Telerik.WinControls.UI.RadPanel();
            this.kleurDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.errorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelsListbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelNummerLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelKleurLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verwijderButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelNummerTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aanpassenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toevoegenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opslaanButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kleurDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = false;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(323, 77);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(220, 44);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.ThemeName = "TelerikMetroTouch";
            // 
            // tafelsListbox
            // 
            this.tafelsListbox.ItemHeight = 36;
            this.tafelsListbox.Location = new System.Drawing.Point(12, 12);
            this.tafelsListbox.Name = "tafelsListbox";
            this.tafelsListbox.Size = new System.Drawing.Size(305, 300);
            this.tafelsListbox.TabIndex = 5;
            this.tafelsListbox.Text = "radListControl1";
            this.tafelsListbox.ThemeName = "TelerikMetroTouch";
            this.tafelsListbox.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.tafelsListbox_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(323, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(111, 23);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Tafel nummer:";
            this.radLabel1.ThemeName = "TelerikMetroTouch";
            // 
            // tafelNummerLabel
            // 
            this.tafelNummerLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tafelNummerLabel.Location = new System.Drawing.Point(440, 12);
            this.tafelNummerLabel.Name = "tafelNummerLabel";
            this.tafelNummerLabel.Size = new System.Drawing.Size(2, 2);
            this.tafelNummerLabel.TabIndex = 7;
            this.tafelNummerLabel.ThemeName = "TelerikMetroTouch";
            // 
            // tafelKleurLabel
            // 
            this.tafelKleurLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tafelKleurLabel.Location = new System.Drawing.Point(440, 48);
            this.tafelKleurLabel.Name = "tafelKleurLabel";
            this.tafelKleurLabel.Size = new System.Drawing.Size(2, 2);
            this.tafelKleurLabel.TabIndex = 9;
            this.tafelKleurLabel.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(323, 48);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(49, 23);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "Kleur:";
            this.radLabel3.ThemeName = "TelerikMetroTouch";
            // 
            // verwijderButton
            // 
            this.verwijderButton.Enabled = false;
            this.verwijderButton.Location = new System.Drawing.Point(107, 79);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(110, 32);
            this.verwijderButton.TabIndex = 0;
            this.verwijderButton.Text = "Verwijder";
            this.verwijderButton.ThemeName = "TelerikMetroTouch";
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // tafelNummerTextbox
            // 
            this.tafelNummerTextbox.Location = new System.Drawing.Point(682, 12);
            this.tafelNummerTextbox.Name = "tafelNummerTextbox";
            this.tafelNummerTextbox.Size = new System.Drawing.Size(150, 30);
            this.tafelNummerTextbox.TabIndex = 11;
            this.tafelNummerTextbox.ThemeName = "TelerikMetroTouch";
            // 
            // aanpassenButton
            // 
            this.aanpassenButton.Enabled = false;
            this.aanpassenButton.Location = new System.Drawing.Point(107, 41);
            this.aanpassenButton.Name = "aanpassenButton";
            this.aanpassenButton.Size = new System.Drawing.Size(110, 32);
            this.aanpassenButton.TabIndex = 13;
            this.aanpassenButton.Text = "Aanpassen";
            this.aanpassenButton.ThemeName = "TelerikMetroTouch";
            this.aanpassenButton.Click += new System.EventHandler(this.aanpassenButton_Click);
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(107, 3);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(110, 32);
            this.toevoegenButton.TabIndex = 14;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.ThemeName = "TelerikMetroTouch";
            this.toevoegenButton.Click += new System.EventHandler(this.toevoegenButton_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(565, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(111, 23);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Tafel nummer:";
            this.radLabel2.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(565, 48);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(49, 23);
            this.radLabel4.TabIndex = 9;
            this.radLabel4.Text = "Kleur:";
            this.radLabel4.ThemeName = "TelerikMetroTouch";
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(565, 89);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(267, 32);
            this.opslaanButton.TabIndex = 15;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.ThemeName = "TelerikMetroTouch";
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.toevoegenButton);
            this.buttonPanel.Controls.Add(this.verwijderButton);
            this.buttonPanel.Controls.Add(this.aanpassenButton);
            this.buttonPanel.Location = new System.Drawing.Point(323, 195);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(220, 119);
            this.buttonPanel.TabIndex = 16;
            this.buttonPanel.ThemeName = "TelerikMetroTouch";
            // 
            // kleurDropDownList
            // 
            this.kleurDropDownList.Location = new System.Drawing.Point(682, 48);
            this.kleurDropDownList.Name = "kleurDropDownList";
            this.kleurDropDownList.ReadOnly = true;
            this.kleurDropDownList.Size = new System.Drawing.Size(150, 30);
            this.kleurDropDownList.TabIndex = 17;
            this.kleurDropDownList.ThemeName = "TelerikMetroTouch";
            // 
            // TafelBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 326);
            this.Controls.Add(this.kleurDropDownList);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.tafelNummerTextbox);
            this.Controls.Add(this.tafelKleurLabel);
            this.Controls.Add(this.tafelNummerLabel);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.tafelsListbox);
            this.Controls.Add(this.errorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TafelBeheer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TableMe - Tafels beheren";
            this.ThemeName = "TelerikMetroTouch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TafelBeheer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelsListbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelNummerLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelKleurLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verwijderButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelNummerTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aanpassenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toevoegenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opslaanButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kleurDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadLabel errorLabel;
        private Telerik.WinControls.UI.RadListControl tafelsListbox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel tafelNummerLabel;
        private Telerik.WinControls.UI.RadLabel tafelKleurLabel;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton verwijderButton;
        private Telerik.WinControls.UI.RadTextBoxControl tafelNummerTextbox;
        private Telerik.WinControls.UI.RadButton aanpassenButton;
        private Telerik.WinControls.UI.RadButton toevoegenButton;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton opslaanButton;
        private Telerik.WinControls.UI.RadPanel buttonPanel;
        private Telerik.WinControls.UI.RadDropDownList kleurDropDownList;
    }
}