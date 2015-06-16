namespace RestaurantManager
{
    partial class Login
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
            this.gebruikersnaamTextbox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.wachtwoordTextbox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.loginButton = new Telerik.WinControls.UI.RadButton();
            this.annuleerButton = new Telerik.WinControls.UI.RadButton();
            this.errorLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gebruikersnaamTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wachtwoordTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annuleerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gebruikersnaamTextbox
            // 
            this.gebruikersnaamTextbox.Location = new System.Drawing.Point(134, 12);
            this.gebruikersnaamTextbox.Name = "gebruikersnaamTextbox";
            this.gebruikersnaamTextbox.Size = new System.Drawing.Size(217, 30);
            this.gebruikersnaamTextbox.TabIndex = 0;
            this.gebruikersnaamTextbox.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(116, 23);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Gebruikersnaam";
            this.radLabel1.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 48);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(93, 23);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Wachtwoord";
            this.radLabel2.ThemeName = "TelerikMetroTouch";
            // 
            // wachtwoordTextbox
            // 
            this.wachtwoordTextbox.Location = new System.Drawing.Point(134, 48);
            this.wachtwoordTextbox.Name = "wachtwoordTextbox";
            this.wachtwoordTextbox.Size = new System.Drawing.Size(217, 30);
            this.wachtwoordTextbox.TabIndex = 3;
            this.wachtwoordTextbox.ThemeName = "TelerikMetroTouch";
            this.wachtwoordTextbox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(241, 134);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(110, 32);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.ThemeName = "TelerikMetroTouch";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // annuleerButton
            // 
            this.annuleerButton.Location = new System.Drawing.Point(12, 134);
            this.annuleerButton.Name = "annuleerButton";
            this.annuleerButton.Size = new System.Drawing.Size(110, 32);
            this.annuleerButton.TabIndex = 5;
            this.annuleerButton.Text = "Annuleer";
            this.annuleerButton.ThemeName = "TelerikMetroTouch";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = false;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 84);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(339, 44);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.ThemeName = "TelerikMetroTouch";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 178);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.annuleerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.wachtwoordTextbox);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.gebruikersnaamTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TableMe - Login";
            this.ThemeName = "TelerikMetroTouch";
            ((System.ComponentModel.ISupportInitialize)(this.gebruikersnaamTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wachtwoordTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annuleerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl gebruikersnaamTextbox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBoxControl wachtwoordTextbox;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadButton loginButton;
        private Telerik.WinControls.UI.RadButton annuleerButton;
        private Telerik.WinControls.UI.RadLabel errorLabel;
    }
}