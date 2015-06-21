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
    public partial class MenuBeheer : Telerik.WinControls.UI.RadForm
    {
        private Gebruiker gebruiker;
        private Main main;
        private bool productToevoegen, categorieToevoegen;

        public MenuBeheer(Gebruiker gebruiker, Main main)
        {
            InitializeComponent();

            this.Size = new Size(865, this.Height);

            this.gebruiker = gebruiker;
            this.main = main;
            this.categorieToevoegen = false;
            this.productToevoegen = false;

            GetCategorien();
        }

        public void GetCategorien()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                categorieNaamLabel.Text = "";
                productNaamLabel.Text = "";
                productPrijsLabel.Text = "";
                categorieNaamLabel.Text = "";

                List<Categorie> categorien = Database.GetCategorien();

                categorienListbox.DataSource = categorien;
                categorienListbox.DisplayMember = "Naam";
                categorienListbox.ValueMember = "CategorieId";

                productCategorienDropDownList.DataSource = categorien;
                productCategorienDropDownList.DisplayMember = "Naam";
                productCategorienDropDownList.ValueMember = "CategorieId";

                categorienListbox.SelectedIndex = -1;
            }
            catch
            {
                ShowError("Categorien kunnen niet opgehaald worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public void GetProducten()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                categorieNaamLabel.Text = "";
                productNaamLabel.Text = "";
                productPrijsLabel.Text = "";
                categorieNaamLabel.Text = "";

                List<Product> producten = Database.GetProductenByCategorie((int)categorienListbox.SelectedValue);

                productenListbox.DataSource = producten;
                productenListbox.DisplayMember = "Naam";
                productenListbox.ValueMember = "ProductId";

                productenListbox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowError("Producten kunnen niet opgehaald worden!", Color.Red);
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

        private void MenuBeheer_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.TekenTafels();
            main.Show();
        }

        private void categorienListbox_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ShowError("", Color.Red);

            if (categorienListbox.SelectedIndex > -1)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    categorieAanpassenButton.Enabled = true;
                    categorieVerwijderButton.Enabled = true;

                    Categorie categorie = Database.GetCategorieById((int)categorienListbox.SelectedValue);

                    categorieNaamLabel.Text = categorie.Naam;

                    GetProducten();

                    categorienPanel.Visible = true;
                    productenPanel.Visible = false;
                }
                catch
                {
                    ShowError("De categorie data kon niet opgehaald worden!", Color.Red);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                categorieAanpassenButton.Enabled = false;
                categorieVerwijderButton.Enabled = false;
            }
        }

        private void categorieToevoegenButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Enabled = false;
            button2Panel.Enabled = false;
            categorienListbox.Enabled = false;
            productenListbox.Enabled = false;

            categorienPanel.Visible = true;
            productenPanel.Visible = false;

            this.Size = new Size(1185, this.Height);
            categorieToevoegen = true;
        }

        private void categorieAanpassenButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                buttonPanel.Enabled = false;
                button2Panel.Enabled = false;
                categorienListbox.Enabled = false;
                productenListbox.Enabled = false;

                categorienPanel.Visible = true;
                productenPanel.Visible = false;

                Categorie categorie = Database.GetCategorieById((int)categorienListbox.SelectedValue);

                categorieNaamTextbox.Text = categorie.Naam;

                this.Size = new Size(1185, this.Height);
                categorieToevoegen = false;
            }
            catch
            {
                ShowError("De categorie kon niet geladen worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void categorieOpslaanButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categorieNaamTextbox.Text != "")
                {
                    this.Cursor = Cursors.WaitCursor;

                    if (categorieToevoegen == true)
                    {
                        Categorie categorie = new Categorie();

                        categorie.Naam = categorieNaamTextbox.Text;

                        Database.InsertCategorie(categorie);
                    }
                    else
                    {
                        Categorie categorie = Database.GetCategorieById((int)categorienListbox.SelectedValue);

                        categorie.Naam = categorieNaamTextbox.Text;

                        Database.EditCategorie(categorie);
                    }

                    categorieNaamTextbox.Text = "";

                    GetCategorien();

                    buttonPanel.Enabled = true;
                    button2Panel.Enabled = true;
                    categorienListbox.Enabled = true;
                    productenListbox.Enabled = true;

                    this.Size = new Size(865, this.Height);
                }
                else
                {
                    ShowError("Alle velden moeten ingevuld zijn!", Color.Red);
                }
            }
            catch
            {
                ShowError("De categorie kon niet opgeslaan worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void categorieVerwijderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Categorie categorie = Database.GetCategorieById((int)categorienListbox.SelectedValue);

                Database.DeleteCategorie(categorie);

                GetCategorien();
            }
            catch
            {
                ShowError("De categorie kon niet verwijderd worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void productOpslaanButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (productNaamTextbox.Text != "" && productPrijsTextbox.Text != "")
                {
                    this.Cursor = Cursors.WaitCursor;

                    if (productToevoegen == true)
                    {
                        Product product = new Product();

                        product.Naam = productNaamTextbox.Text;
                        product.CategorieId = (int)productCategorienDropDownList.SelectedValue;
                        product.Prijs = Convert.ToDecimal(productPrijsTextbox.Text);

                        Database.InsertProduct(product);
                    }
                    else
                    {
                        Product product = Database.GetProductById((int)productenListbox.SelectedValue);

                        product.Naam = productNaamTextbox.Text;
                        product.CategorieId = (int)productCategorienDropDownList.SelectedValue;
                        product.Prijs = Convert.ToDecimal(productPrijsTextbox.Text);

                        Database.EditProduct(product);
                    }

                    productPrijsTextbox.Text = "";
                    productNaamTextbox.Text = "";

                    GetProducten();

                    buttonPanel.Enabled = true;
                    button2Panel.Enabled = true;
                    categorienListbox.Enabled = true;
                    productenListbox.Enabled = true;

                    this.Size = new Size(865, this.Height);
                }
                else
                {
                    ShowError("Alle velden moeten ingevuld zijn!", Color.Red);
                }
            }
            catch
            {
                ShowError("Het product kon niet opgeslaan worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void productToevoegenButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Enabled = false;
            button2Panel.Enabled = false;
            categorienListbox.Enabled = false;
            productenListbox.Enabled = false;

            categorienPanel.Visible = false;
            productenPanel.Visible = true;

            this.Size = new Size(1185, this.Height);
            productToevoegen = true;
        }

        private void productAanpassenButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                buttonPanel.Enabled = false;
                button2Panel.Enabled = false;
                categorienListbox.Enabled = false;
                productenListbox.Enabled = false;

                categorienPanel.Visible = false;
                productenPanel.Visible = true;

                Product product = Database.GetProductById((int)productenListbox.SelectedValue);

                productNaamTextbox.Text = product.Naam;
                productPrijsLabel.Text = product.Prijs.ToString();
                productCategorienDropDownList.SelectedValue = product.CategorieId;

                this.Size = new Size(1185, this.Height);
                productToevoegen = false;
            }
            catch
            {
                ShowError("De categorie kon niet geladen worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void productVerwijderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = Database.GetProductById((int)productenListbox.SelectedValue);

                Database.DeleteProduct(product);

                GetProducten();
            }
            catch
            {
                ShowError("De categorie kon niet verwijderd worden!", Color.Red);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void productenListbox_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ShowError("", Color.Red);

            if (productenListbox.SelectedIndex > -1)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    productAanpassenButton.Enabled = true;
                    productVerwijderButton.Enabled = true;

                    Product product = Database.GetProductById((int)productenListbox.SelectedValue);

                    productNaamLabel.Text = product.Naam;
                    productPrijsLabel.Text = product.Prijs.ToString();

                    Categorie categorie = Database.GetCategorieById(product.CategorieId);

                    productCategorieLabel.Text = categorie.Naam;

                    categorienPanel.Visible = false;
                    productenPanel.Visible = true;
                }
                catch (Exception ex)
                {
                    ShowError("De product data kon niet opgehaald worden!", Color.Red);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                productAanpassenButton.Enabled = false;
                productVerwijderButton.Enabled = false;
            }
        }
    }
}
