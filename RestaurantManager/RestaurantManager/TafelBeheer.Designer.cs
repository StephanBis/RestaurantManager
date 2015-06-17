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
            ((System.ComponentModel.ISupportInitialize)(this.errorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelsListbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelNummerLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tafelKleurLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = false;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(727, 12);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(339, 44);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.ThemeName = "TelerikMetroTouch";
            // 
            // tafelsListbox
            // 
            this.tafelsListbox.ItemHeight = 36;
            this.tafelsListbox.Location = new System.Drawing.Point(12, 12);
            this.tafelsListbox.Name = "tafelsListbox";
            this.tafelsListbox.Size = new System.Drawing.Size(305, 470);
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
            this.tafelNummerLabel.Location = new System.Drawing.Point(484, 12);
            this.tafelNummerLabel.Name = "tafelNummerLabel";
            this.tafelNummerLabel.Size = new System.Drawing.Size(103, 23);
            this.tafelNummerLabel.TabIndex = 7;
            this.tafelNummerLabel.Text = "Tafel nummer:";
            this.tafelNummerLabel.ThemeName = "TelerikMetroTouch";
            // 
            // tafelKleurLabel
            // 
            this.tafelKleurLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tafelKleurLabel.Location = new System.Drawing.Point(484, 41);
            this.tafelKleurLabel.Name = "tafelKleurLabel";
            this.tafelKleurLabel.Size = new System.Drawing.Size(103, 23);
            this.tafelKleurLabel.TabIndex = 9;
            this.tafelKleurLabel.Text = "Tafel nummer:";
            this.tafelKleurLabel.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(323, 41);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(49, 23);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "Kleur:";
            this.radLabel3.ThemeName = "TelerikMetroTouch";
            // 
            // TafelBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 494);
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
    }
}