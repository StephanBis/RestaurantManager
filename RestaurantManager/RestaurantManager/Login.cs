using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (gebruikersnaamTextbox.Text != "" && wachtwoordTextbox.Text != "")
            {
                this.Cursor = Cursors.WaitCursor;

                Gebruiker gebruiker = Database.GetUserByName(gebruikersnaamTextbox.Text);

                if (gebruiker != null)
                {
                    if (wachtwoordTextbox.Text == gebruiker.Wachtwoord)
                    {
                        Main main = new Main(gebruiker, this);
                        main.Show();

                        gebruikersnaamTextbox.Text = "";
                        wachtwoordTextbox.Text = "";
                        gebruikersnaamTextbox.Focus();

                        this.Hide();
                    }
                    else
                    {
                        ShowError("Deze combinatie is onjuist!", Color.Red);
                        wachtwoordTextbox.Focus();
                    }
                }
                else
                {
                    ShowError("Deze gebruiker bestaat niet!", Color.Red);
                    gebruikersnaamTextbox.Focus();
                }

                this.Cursor = Cursors.Default;
            }
            else
            {
                ShowError("Gebruikersnaam en wachtwoord moeten ingevuld zijn!",Color.Red);
                gebruikersnaamTextbox.Focus();
            }
        }

        private void ShowError(string message, Color color)
        {
            errorLabel.ForeColor = color;
            errorLabel.Text = message;
        }
    }
}
