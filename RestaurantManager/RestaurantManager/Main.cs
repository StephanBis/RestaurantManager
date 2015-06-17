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
        private bool drag = false;
        private bool verplaatsMode = false;
        private int y, x, prevY, prevX;

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

                foreach (Control control in tafelPanel.Controls)
                {
                    if (control is RadPanel)
                    {
                        control.Dispose();
                    }
                }

                foreach (Tafel tafel in tafels)
                {
                    RadPanel panel = new RadPanel();
                    panel.TextAlignment = ContentAlignment.MiddleCenter;
                    panel.Text = tafel.TafelNummer;
                    panel.Name = tafel.TafelId.ToString();
                    panel.Size = new Size(100, 100);
                    panel.Location = new Point(tafel.X, tafel.Y + 35);
                    panel.BackColor = Color.FromName(tafel.Kleur);
                    panel.ForeColor = tafelPanel.BackColor;

                    panel.Click += tafelPanel_Click;
                    panel.MouseDown += new MouseEventHandler(c_MouseDown);
                    panel.MouseMove += new MouseEventHandler(c_MouseMove);
                    panel.MouseUp += new MouseEventHandler(c_MouseUp);

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
            if (!drag)
            {
                RadPanel panel = (RadPanel)sender;

                MessageBox.Show(panel.Text);
            }
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
            GebruikerBeheer gebruikerBeheer = new GebruikerBeheer(gebruiker, this);
            gebruikerBeheer.Show();
            this.Hide();
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

        private void c_MouseDown(object sender, MouseEventArgs e)
        {
            if (verplaatsMode == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    drag = true;
                    x = e.X;
                    y = e.Y;
                }
            }
        }

        private void c_MouseMove(object sender, MouseEventArgs e)
        {
            if (verplaatsMode == true)
            {
                if (drag)
                {
                    RadPanel panel = (RadPanel)sender;

                    panel.Location = new Point(e.X + panel.Left - x, e.Y + panel.Top - y);

                    if (!(IsTouching(panel, tafelPanel)) && !(IsTouching(panel, verplaatsLabel)))
                    {
                        prevX = e.X + panel.Left - x;
                        prevY = e.Y + panel.Top - y;
                    }
                }
            }
        }

        private void c_MouseUp(object sender, MouseEventArgs e)
        {
            if (verplaatsMode == true)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    RadPanel panel = (RadPanel)sender;

                    if (IsTouching(panel, radApplicationMenu) || IsTouching(panel, verplaatsLabel))
                    {
                        panel.Location = new Point(prevX + 1, prevY - 1);
                    }
                    
                    Tafel tafel = Database.GetTafelById(Convert.ToInt32(panel.Name));

                    tafel.X = e.X + panel.Left - x;
                    tafel.Y = e.Y + panel.Top - y;

                    Database.EditTafel(tafel);

                    drag = false;
                }
                catch
                {
                    ShowError("De tafel kon niet opgeslagen worden!", Color.Red);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }  
            }
        }

        private bool IsTouching(Control p1, Control p2)
        {
            if (p1.Location.X + p1.Width < p2.Location.X)
                return false;
            if (p2.Location.X + p2.Width < p1.Location.X)
                return false;
            if (p1.Location.Y + p1.Height < p2.Location.Y)
                return false;
            if (p2.Location.Y + p2.Height < p1.Location.Y)
                return false;
            return true;
        }

        private void verplaatsMenuItem_Click(object sender, EventArgs e)
        {
            if (verplaatsMode == false)
            {
                verplaatsMode = true;
                verplaatsLabel.Visible = true;
            }
            else
            {
                verplaatsMode = false;
                verplaatsLabel.Visible = false;
                drag = false;
            }
        }
    }
}
