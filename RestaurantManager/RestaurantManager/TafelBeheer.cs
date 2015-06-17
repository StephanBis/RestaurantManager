using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RestaurantManager
{
    public partial class TafelBeheer : Telerik.WinControls.UI.RadForm
    {
        private Gebruiker gebruiker;
        private Main main;

        public TafelBeheer(Gebruiker gebruiker, Main main)
        {
            InitializeComponent();

            this.gebruiker = gebruiker;
            this.main = main;

            GetTafels();
        }

        public void GetTafels()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                List<Tafel> tafels = Database.GetTafels();

                tafelsListbox.DataSource = tafels;
                tafelsListbox.DisplayMember = "TafelNummer";
                tafelsListbox.ValueMember = "TafelId";

                tafelsListbox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowError("Tafels kunnen niet opgehaald worden!", Color.Red);
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

        private void TafelBeheer_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }

        private void tafelsListbox_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ShowError("", Color.Red);

            if (tafelsListbox.SelectedIndex > -1)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    Tafel tafel = Database.GetTafelById((int)tafelsListbox.SelectedValue);

                    tafelNummerLabel.Text = tafel.TafelNummer;
                    tafelKleurLabel.Text = tafel.Kleur;
                }
                catch
                {
                    ShowError("De tafel data kon niet opgehaald worden!", Color.Red);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }
    }
}
