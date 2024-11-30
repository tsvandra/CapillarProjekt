using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kupac.UI.Shared.BaseClasses;
using Kupac.UI.Customers;

namespace Kupac.UI.Main
{
    public partial class MainForm : BaseForm
    {
        private CustomersEditorForm customersEditorForm;
        private Button activeButton = null;
        
        //inicializacio
        public MainForm()
        {
            InitializeComponent();

            //userPictureBox.Image = Resources.Resources.kinga_200x200;
            if (Kupac.Resources.Resource.kinga_200x200 != null)
            {

                userPictureBox.Image = Kupac.Resources.Resource.kinga_200x200;
            }
            else
            {
                MessageBox.Show("Obrázok sa nenašiel");
            }


            //byte[] imageData = Resources.Resources.kinga_200x200;
            //using (MemoryStream ms = new MemoryStream(imageData))
            //{
            //    userPictureBox.Image = Image.FromStream(ms);
            //}
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach (Control control in navigationalPanel.Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += navigationButton_MouseEnter;
                    button.MouseLeave += navigationButton_MouseLeave;
                    button.MouseMove += navigationButton_MouseMove;
                    button.Click += navigationButton_Click;

                }
            }
        }

        private void SetButtonColor(Button button, bool isActive)
        {
            // Az előző gomb visszaállítása az eredeti színre
            if (isActive)
            {
                button.BackColor = Color.AntiqueWhite;  // Eredeti szín
            }
            else
            {
                button.BackColor = Color.SeaShell;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadFormIntoPanel(Form form)
        {
            // Előzőleg betöltött form bezárása, ha van
            if (this.mainInformationPanel.Controls.Count > 0)
            {
                this.mainInformationPanel.Controls[0].Hide();
                this.mainInformationPanel.Controls.Clear();
            }

            // Új form betöltése a panelbe
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Hozzáadjuk a formot a panelhez
            this.mainInformationPanel.Controls.Add(form);

            form.Show();
        }
        // just to test branches
        private void navigationButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                // Előző aktív gomb színének visszaállítása
                if (activeButton != null && activeButton != clickedButton)
                {
                    SetButtonColor(activeButton, false);
                }

                // Az új aktív gomb beállítása
                SetButtonColor(clickedButton, true);
                activeButton = clickedButton;

                // Gombhoz tartozó logika meghívása
                if (clickedButton == customersButton)
                {
                    if (customersEditorForm == null || customersEditorForm.IsDisposed)
                    {
                        customersEditorForm = new CustomersEditorForm();
                    }
                    LoadFormIntoPanel(customersEditorForm);
                }
                else if (clickedButton == dashBoardButton)
                {
                    // Dashboard betöltése (amennyiben lesz implementálva)
                    LoadFormIntoPanel(new Form()); // Csak egy példa
                }
                else if (clickedButton == ordersButton)
                {
                    // Orders betöltése (amennyiben lesz implementálva)
                    LoadFormIntoPanel(new Form()); // Csak egy példa
                }
            }
        }

        // Egér beállítása, ha fölé megyünk
        private void navigationButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button currentButton)
            {
                
                // Csak akkor változtatjuk a színt, ha nem az aktív gomb
                if (currentButton != activeButton)
                {
                    currentButton.BackColor = Color.PeachPuff; // Hover szín
                    
                }
            }
            
        }

        // Egér elhagyása esetén
        private void navigationButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button currentButton)
            {
                //MessageBox.Show($"MouseEnter: {currentButton.BackColor.Name}");
                // Csak akkor állítjuk vissza az alapértelmezett színt, ha nem az aktív gomb
                if (currentButton != activeButton)
                {
                    currentButton.BackColor = Color.SeaShell;
                    //SetButtonColor(currentButton, false);
                }
            }
        }

        private void navigationButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button currentButton && currentButton != activeButton)
            {
                // Ellenőrizzük, hogy az egér valóban a gombon belül van-e
                if (currentButton.ClientRectangle.Contains(e.Location))
                {
                    currentButton.BackColor = Color.PeachPuff;
                }
            }
        }

        //private void dashBoardButton_Click(object sender, EventArgs e)
        //{
        //    SetButtonColor(dashBoardButton, Color.AntiqueWhite);
        //}

        //private void customersButton_Click(object sender, EventArgs e)
        //{
        //    if (customersEditorForm == null || customersEditorForm.IsDisposed)
        //    { 
        //        customersEditorForm = new CustomersEditorForm();
        //    }

        //    LoadFormIntoPanel(customersEditorForm);
        //    SetButtonColor(customersButton, Color.AntiqueWhite);
        //}

        public void RefreshCustomerGrid()
        {
            if (customersEditorForm != null && !customersEditorForm.IsDisposed)
            {
                customersEditorForm.RefreshGrid();
            }
        }

        private void minimiseApp_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void closeApp_Click(object sender, EventArgs e) => Application.Exit();

        
    }
}
