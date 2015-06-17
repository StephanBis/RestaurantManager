using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RestaurantManager
{
    public partial class GebruikerBeheer : Telerik.WinControls.UI.RadForm
    {
        private Gebruiker gebruiker;
        private Main main;
        private bool toevoegen;

        public GebruikerBeheer(Gebruiker gebruiker, Main main)
        {
            InitializeComponent();

            this.Size = new Size(565, this.Height);

            this.gebruiker = gebruiker;
            this.main = main;
            this.toevoegen = false;

            GetGebruikers();
        }

        public void GetGebruikers()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                gebruikersnaamLabel.Text = "";
                rolLabel.Text = "";

                List<Gebruiker> gebruikers = Database.GetGebruikers();

                gebruikersListbox.DataSource = gebruikers;
                gebruikersListbox.DisplayMember = "Gebruikersnaam";
                gebruikersListbox.ValueMember = "GebruikerId";

                gebruikersListbox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowError("Gebruikers kunnen niet opgehaald worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ShowError(string message, Color color)
        {
            errorLabel.ForeColor = color;
            errorLabel.Text = message;
        }

        private void GebruikerBeheer_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.TekenTafels();
            main.Show();
        }

        private void gebruikersListbox_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ShowError("", Color.Red);

            if (gebruikersListbox.SelectedIndex > -1)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    aanpassenButton.Enabled = true;
                    verwijderButton.Enabled = true;

                    Gebruiker gebruiker = Database.GetGebruikerById((int)gebruikersListbox.SelectedValue);

                    gebruikersnaamLabel.Text = gebruiker.Gebruikersnaam;

                    if (gebruiker.Rol == 0)
                    {
                        rolLabel.Text = "Medewerker";
                    }
                    else
                    {
                        rolLabel.Text = "Administrator";
                    }
                }
                catch
                {
                    ShowError("De gebruiker data kon niet opgehaald worden!", Color.Red);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                aanpassenButton.Enabled = false;
                verwijderButton.Enabled = false;
            }
        }

        private void toevoegenButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Enabled = false;
            gebruikersListbox.Enabled = false;

            this.Size = new Size(870, this.Height);
            toevoegen = true;
        }

        private void aanpassenButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                buttonPanel.Enabled = false;
                gebruikersListbox.Enabled = false;

                Gebruiker gebruiker = Database.GetGebruikerById((int)gebruikersListbox.SelectedValue);

                gebruikersnaamTextbox.Text = gebruiker.Gebruikersnaam;
                rolDropDownList.SelectedIndex = gebruiker.Rol;
                wachtwoordTextbox.Text = gebruiker.Wachtwoord;

                this.Size = new Size(870, this.Height);
                toevoegen = false;
            }
            catch
            {
                ShowError("De gebruiker kon niet geladen worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gebruikersnaamTextbox.Text != "" && wachtwoordTextbox.Text != "")
                {
                    this.Cursor = Cursors.WaitCursor;

                    if (toevoegen == true)
                    {
                        Gebruiker gebruiker = new Gebruiker();

                        gebruiker.Gebruikersnaam = gebruikersnaamTextbox.Text;
                        gebruiker.Wachtwoord = wachtwoordTextbox.Text;
                        gebruiker.Rol = rolDropDownList.SelectedIndex;

                        Database.InsertGebruiker(gebruiker);
                    }
                    else
                    {
                        Gebruiker gebruiker = Database.GetGebruikerById((int)gebruikersListbox.SelectedValue);

                        gebruiker.Gebruikersnaam = gebruikersnaamTextbox.Text;
                        gebruiker.Wachtwoord = wachtwoordTextbox.Text;
                        gebruiker.Rol = rolDropDownList.SelectedIndex;

                        Database.EditGebruiker(gebruiker);
                    }

                    GetGebruikers();

                    buttonPanel.Enabled = true;
                    gebruikersListbox.Enabled = true;

                    this.Size = new Size(565, this.Height);
                }
                else
                {
                    ShowError("Alle velden moeten ingevuld zijn!", Color.Red);
                }
            }
            catch
            {
                ShowError("De gebruiker kon niet opgeslaan worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Gebruiker gebruiker = Database.GetGebruikerById((int)gebruikersListbox.SelectedValue);

                Database.DeleteGebruiker(gebruiker);

                GetGebruikers();
            }
            catch
            {
                ShowError("De gebruiker kon niet verwijderd worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
