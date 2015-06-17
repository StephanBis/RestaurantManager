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
    public partial class TafelBeheer : Telerik.WinControls.UI.RadForm
    {
        private Gebruiker gebruiker;
        private Main main;
        private bool toevoegen;
        List<string> engelseKleuren = new List<string>();
        List<string> nederlandseKleuren = new List<string>();

        public TafelBeheer(Gebruiker gebruiker, Main main)
        {
            InitializeComponent();

            this.Size = new Size(565, this.Height);

            //engelse namen voor kleuren
            engelseKleuren.Add("Red");
            engelseKleuren.Add("Orange");
            engelseKleuren.Add("Green");
            engelseKleuren.Add("Blue");
            engelseKleuren.Add("Purple");
            engelseKleuren.Add("Brown");
            engelseKleuren.Add("Black");
            
            //nederlandse namen voor kleuren
            nederlandseKleuren.Add("Rood");
            nederlandseKleuren.Add("Oranje");
            nederlandseKleuren.Add("Groen");
            nederlandseKleuren.Add("Blauw");
            nederlandseKleuren.Add("Paars");
            nederlandseKleuren.Add("Bruin");
            nederlandseKleuren.Add("Zwart");

            for (int i = 0; i <= nederlandseKleuren.Count - 1; i++)
            {
                RadListDataItem item = new RadListDataItem();
                item.ForeColor = Color.FromName(engelseKleuren[i]);
                item.Text = nederlandseKleuren[i];
                kleurDropDownList.Items.Add(item);
            }

            kleurDropDownList.SelectedIndex = 0;

            this.gebruiker = gebruiker;
            this.main = main;
            this.toevoegen = false;

            GetTafels();
        }

        private void GetTafels()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                tafelNummerLabel.Text = "";
                tafelKleurLabel.Text = "";

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
            main.TekenTafels();
            main.Show();
        }

        private void tafelsListbox_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                ShowError("", Color.Red);

                if (tafelsListbox.SelectedIndex > -1)
                {
                    this.Cursor = Cursors.WaitCursor;

                    aanpassenButton.Enabled = true;
                    verwijderButton.Enabled = true;

                    Tafel tafel = Database.GetTafelById((int)tafelsListbox.SelectedValue);

                    tafelNummerLabel.Text = tafel.TafelNummer;
                    tafelKleurLabel.Text = nederlandseKleuren[engelseKleuren.IndexOf(tafel.Kleur)];
                    tafelKleurLabel.ForeColor = Color.FromName(engelseKleuren[engelseKleuren.IndexOf(tafel.Kleur)]);
                }
                else
                {
                    aanpassenButton.Enabled = false;
                    verwijderButton.Enabled = false;
                }
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

        private void toevoegenButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Enabled = false;
            tafelsListbox.Enabled = false;

            this.Size = new Size(850, this.Height);
            toevoegen = true;
        }

        private void aanpassenButton_Click(object sender, EventArgs e)
        {
            try
            {
                buttonPanel.Enabled = false;
                tafelsListbox.Enabled = false;

                Tafel tafel = Database.GetTafelById((int)tafelsListbox.SelectedValue);

                tafelNummerTextbox.Text = tafel.TafelNummer;
                kleurDropDownList.SelectedValue = tafel.Kleur;

                this.Size = new Size(850, this.Height);
                toevoegen = false;
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

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tafelNummerLabel.Text != "")
                {
                    if (toevoegen == true)
                    {
                        Tafel tafel = new Tafel();

                        tafel.TafelNummer = tafelNummerTextbox.Text;
                        tafel.Kleur = engelseKleuren[kleurDropDownList.SelectedIndex];

                        Database.InsertTafel(tafel);
                    }
                    else
                    {
                        Tafel tafel = Database.GetTafelById((int)tafelsListbox.SelectedValue);

                        tafel.TafelNummer = tafelNummerTextbox.Text;
                        tafel.Kleur = engelseKleuren[kleurDropDownList.SelectedIndex];

                        Database.EditTafel(tafel);
                    }

                    GetTafels();

                    buttonPanel.Enabled = true;
                    tafelsListbox.Enabled = true;

                    this.Size = new Size(565, this.Height);
                }
                else
                {
                    ShowError("Alle velden moeten ingevuld zijn!", Color.Red);
                }
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

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tafel tafel = Database.GetTafelById((int)tafelsListbox.SelectedValue);

                Database.DeleteTafel(tafel);

                GetTafels();
            }
            catch
            {
                ShowError("De tafel kon niet verwijderd worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
