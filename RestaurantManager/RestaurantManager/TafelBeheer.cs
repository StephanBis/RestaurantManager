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

                this.Cursor = Cursors.Default;
            }
            catch
            {
                ShowError("Tafels kunnen niet opgehaald worden!", Color.Red);
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
    }
}
