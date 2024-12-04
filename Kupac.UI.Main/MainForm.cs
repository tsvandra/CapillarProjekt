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

        //inicialisation
        public MainForm()
        {
            InitializeComponent();
            if (Kupac.Resources.Resource.kinga_200x200 != null)
            {

                userPictureBox.Image = Kupac.Resources.Resource.kinga_200x200;
            }
            else
            {
                MessageBox.Show("Obrázok sa nenašiel");
            }

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
            // Reset the previous button to its original color
            if (isActive)
            {
                button.BackColor = Color.AntiqueWhite;  // original color
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
            // Close the previously loaded form, if any
            if (this.mainInformationPanel.Controls.Count > 0)
            {
                this.mainInformationPanel.Controls[0].Hide();
                this.mainInformationPanel.Controls.Clear();
            }

            // Load the new form into the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add the form to the panel
            this.mainInformationPanel.Controls.Add(form);

            form.Show();
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                // Reset the color of the previously active button
                if (activeButton != null && activeButton != clickedButton)
                {
                    SetButtonColor(activeButton, false);
                }

                // Set the new active button
                SetButtonColor(clickedButton, true);
                activeButton = clickedButton;

                // Invoke logic associated with the clicked button
                if (clickedButton == customersButton)
                {
                    //if (customersEditorForm == null || customersEditorForm.IsDisposed)
                    //{
                    //    customersEditorForm = new CustomersEditorForm();
                    //}
                        //LoadFormIntoPanel(customersEditorForm);
                }
                else if (clickedButton == dashBoardButton)
                {
                    // Load the dashboard (to be implemented)
                    LoadFormIntoPanel(new Form()); // Placeholder example
                }
                else if (clickedButton == ordersButton)
                {
                    // Load orders (to be implemented)
                    LoadFormIntoPanel(new Form()); // Placeholder example
                }
            }
        }


        // Set mouse hover behavior
        private void navigationButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button currentButton)
            {
                // Change the color only if it's not the active button
                if (currentButton != activeButton)
                {
                    currentButton.BackColor = Color.PeachPuff; // Hover color
                }
            }
        }


        // Behavior when the mouse leaves the button
        private void navigationButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button currentButton)
            {
                // Reset to the default color only if it's not the active button
                if (currentButton != activeButton)
                {
                    currentButton.BackColor = Color.SeaShell; // Default color
                }
            }
        }

        private void navigationButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button currentButton && currentButton != activeButton)
            {
                // Check if the mouse is actually within the button's boundaries
                if (currentButton.ClientRectangle.Contains(e.Location))
                {
                    currentButton.BackColor = Color.PeachPuff;
                }
            }
        }

        public void RefreshCustomerGrid()
        {
            if (customersEditorForm != null && !customersEditorForm.IsDisposed)
            {
                customersEditorForm.RefreshGrid();
            }
        }

        private void minimiseApp_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void closeApp_Click(object sender, EventArgs e) => Application.Exit();

        private void customersButton_Click(object sender, EventArgs e)
        {
            if (customersEditorForm == null || customersEditorForm.IsDisposed)
            {
                customersEditorForm = new CustomersEditorForm();
            }
            LoadFormIntoPanel(customersEditorForm);
        }
    }
}
