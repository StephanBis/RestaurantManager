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
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        private Gebruiker gebruiker;
        private Login login;
        private bool sluit = true;

        public Main(Gebruiker gebruiker, Login login)
        {
            InitializeComponent();

            this.gebruiker = gebruiker;
            this.login = login;

            if (this.gebruiker.Rol == 0)
            {
                tafelsMenuItem.Enabled = false;
                gebruikersMenuItem.Enabled = false;
                menuMenuItem.Enabled = false;
            }

            TekenTafels();
        }

        public void TekenTafels()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                List<Tafel> tafels = Database.GetTafels();

                foreach (Tafel tafel in tafels)
                {
                    RadPanel panel = new RadPanel();
                    panel.TextAlignment = ContentAlignment.MiddleCenter;
                    panel.Text = tafel.TafelNummer;
                    panel.Size = new Size(100, 100);
                    panel.Location = new Point(tafel.X, tafel.Y + 35);
                    panel.BackColor = Color.FromName(tafel.Kleur);
                    panel.ForeColor = tafelPanel.BackColor;
                    panel.Click += tafelPanel_Click;

                    tafelPanel.Controls.Add(panel);
                }

                this.Cursor = Cursors.Default;
            }
            catch
            {
                ShowError("Tafels kunnen niet opgehaald worden!", Color.Red);
            }
        }

        private void tafelPanel_Click(object sender, EventArgs e)
        {
            RadPanel panel = (RadPanel)sender;

            MessageBox.Show(panel.Text);
        }

        private void ShowError(string message, Color color)
        {
            errorLabel.ForeColor = color;
            errorLabel.Text = message;
        }

        private void tafelsMenuItem_Click(object sender, EventArgs e)
        {
            TafelBeheer tafelBeheer = new TafelBeheer(gebruiker, this);
            tafelBeheer.Show();
            this.Hide();
        }

        private void gebruikersMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uitloggenMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            sluit = false;
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sluit == true)
            {
                Application.Exit();
            }
        }
    }
}
