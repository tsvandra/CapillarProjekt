using Kupac.Entities;
using Kupac.DbContexts;
using Kupac.UI.Customers;
using Kupac.UI.Shared;
using Kupac.UI.Shared.BaseClasses;
using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using Kupac.Resources;

namespace Kupac
{
    public partial class CustomersEditorForm : BaseForm
    {
        public CustomerManager _customerManager;
        private const string defaultText = "Zadat hodnotu";
        private CustomersEditorForm customersEditorForm;

        public CustomersEditorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _customerManager = new CustomerManager();
        }

        private void CustomerDataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.BeginInvoke(new Action(() => SetLastColumnFillColumnWidthChanged()));
        }

        private void SetLastColumnFillColumnWidthChanged()
        {
            if (customerDataGridView.Columns.Count > 0)
            {
                foreach (DataGridViewColumn column in customerDataGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }

                // Fill in the last column
                var lastColumn = customerDataGridView.Columns[customerDataGridView.Columns.Count - 1];
                lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetLastColumnFill()
        {
            if (customerDataGridView.Columns.Count > 0)
            {
                // Enable editing for the last column
                var lastColumn = customerDataGridView.Columns[customerDataGridView.Columns.Count - 1];
                lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // The other columns have fixed sizes
                foreach (DataGridViewColumn column in customerDataGridView.Columns)
                {
                    if (column != lastColumn)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    }
                }
            }
        }

        private void CustomersEditorForm_Resize(object sender, EventArgs e)
        {
            SetLastColumnFill();
        }

        private void CustomizeColumns()
        {
            if (customerDataGridView.Columns["ID"] != null)
            {
                var idColumn = customerDataGridView.Columns["ID"];
#if DEBUG
                idColumn.Visible = true;
#else
                idColumn.Visible = false; // Elrejti az ID-t
#endif
                idColumn.Width = 50;

            }

            if (customerDataGridView.Columns["FirstName"] != null)
            {
                var firstNameColumn = customerDataGridView.Columns["FirstName"];
                firstNameColumn.HeaderText = "Keresztnév";
                firstNameColumn.MinimumWidth = GetHeaderTextWidth(firstNameColumn);
                firstNameColumn.Width = GetOptimalColumnWidth(firstNameColumn);
                firstNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            if (customerDataGridView.Columns["LastName"] != null)
            {
                var lastNameColumn = customerDataGridView.Columns["LastName"];
                lastNameColumn.HeaderText = "Vezetéknév";
                lastNameColumn.MinimumWidth = GetHeaderTextWidth(lastNameColumn);
                lastNameColumn.Width = GetOptimalColumnWidth(lastNameColumn);
                lastNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            }

            if (customerDataGridView.Columns["Email"] != null)
            {
                customerDataGridView.Columns["Email"].HeaderText = "Email cím";
            }

            if (customerDataGridView.Columns["MobilPhone"] != null)
            {
                customerDataGridView.Columns["MobilPhone"].HeaderText = "Mobiltelefon";
            }

            if (customerDataGridView.Columns["Address"] != null)
            {
                customerDataGridView.Columns["Address"].HeaderText = "Utca, házszám";
            }

            if (customerDataGridView.Columns["City"] != null)
            {
                customerDataGridView.Columns["City"].HeaderText = "Város";
            }

            if (customerDataGridView.Columns["PostalCode"] != null)
            {
                var postalCodeColumn = customerDataGridView.Columns["PostalCode"];
                postalCodeColumn.HeaderText = "Irányítószám";
                postalCodeColumn.Width = GetHeaderTextWidth(postalCodeColumn);
                postalCodeColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (customerDataGridView.Columns["Country"] != null)
            {
                var countryColumn = customerDataGridView.Columns["Country"];
                countryColumn.HeaderText = "Ország";
                countryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                countryColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (customerDataGridView.Columns["Phone"] != null)
            {
                var phoneColumn = customerDataGridView.Columns["Phone"];
                phoneColumn.HeaderText = "Telefon2";
                phoneColumn.Visible = false;
            }
        }

        private int GetHeaderTextWidth(DataGridViewColumn column)
        {
            using (Graphics g = customerDataGridView.CreateGraphics())
            {
                // lower, "* 1.5" is for differences between in calculations - not the best way, but some workaruond
                SizeF textSize = g.MeasureString(column.HeaderText, customerDataGridView.Font);
                return (int)(textSize.Width * 1.5) + 10;
            }
        }

        private int GetOptimalColumnWidth(DataGridViewColumn column)
        {
            // Calculates the optimal width based on the header and the first few rows of data
            using (Graphics g = customerDataGridView.CreateGraphics())
            {
                // Measure the width of the header
                SizeF headerSize = g.MeasureString(column.HeaderText, customerDataGridView.Font);

                // Also consider the width of the first few cells
                float maxWidth = headerSize.Width;

                foreach (DataGridViewRow row in customerDataGridView.Rows)
                {
                    if (row.Cells[column.Index].Value != null)
                    {
                        SizeF cellSize = g.MeasureString(row.Cells[column.Index].Value.ToString(), customerDataGridView.Font);
                        maxWidth = Math.Max(maxWidth, cellSize.Width);
                    }
                }

                var headerWidth = GetHeaderTextWidth(column);
                if (headerWidth > ((int)maxWidth + 20))
                {
                    return headerWidth;
                }
                // Add a safety margin and round to the nearest integer
                else
                {
                    return (int)maxWidth + 20;
                }
            }
        }


        private void addNewCustomerButton_Click(object sender, EventArgs e)
        {
            AddOrEditCustomer();
        }

        public async Task RefreshGrid()
        {
            try
            {
                // Display loading animation
                loadingPictureBox.Visible = true;
                customerDataGridView.DataSource = null;
                customerDataGridView.DataSource = await _customerManager.GetCustomers();

                // Update data

                CustomizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az adatok betöltésekor: {ex.Message}");
            }
            finally
            {
                // Hide loading animation
                loadingPictureBox.Visible = false;
            }
        }

        private void customerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Retrieve the customer ID
                    int customerId = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["ID"].Value);

                    // Use CapillarContextFactory to instantiate a CapillarContext
                    var factory = new CapillarContextFactory();
                    using var context = factory.CreateDbContext(null);

                    var customer = context.Customers.Find(customerId);
                    if (customer != null)
                    {
                        AddOrEditCustomer(customer);
                    }
                    else
                    {
                        MessageBox.Show("Az ügyfél nem található az adatbázisban.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddOrEditCustomer(Customer customer = null)
        {
            using (var editForm = new CustomerAddForm(customer))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Kérlek, válassz ki egy ügyfelet a törléshez.");
                return;
            }

            var result = MessageBox.Show("Biztosan törölni szeretnéd ezt az ügyfelet?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int customerId = Convert.ToInt32(customerDataGridView.SelectedRows[0].Cells["ID"].Value);

                    // Using CapillarContextFactory to instantiate CapillarContext
                    var factory = new CapillarContextFactory();
                    using var context = factory.CreateDbContext(null);

                    var customer = context.Customers.Find(customerId);
                    if (customer != null)
                    {
                        context.Customers.Remove(customer);
                        context.SaveChanges();
                        MessageBox.Show("Az ügyfél sikeresen törölve.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid(); // Update table
                    }
                    else
                    {
                        MessageBox.Show("Az ügyfél nem található az adatbázisban.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt a törlés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CustomerEditorForm_Load(object sender, EventArgs e)
        {
            loadingPictureBox.Image = Kupac.Resources.Resource.Fountain2;
            try
            {
                // Using CapillarContextFactory to instantiate CapillarContext
                var factory = new CapillarContextFactory();
                using var context = factory.CreateDbContext(null);

                RefreshGrid(); // Refresh the grid with data from the database
                CustomizeColumns(); // Customize the columns
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a betöltés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetLastColumnFill(); // Fill the last column

            customerDataGridView.ColumnWidthChanged += CustomerDataGridView_ColumnWidthChanged;
            this.Resize += CustomersEditorForm_Resize;

            toolTip1.SetToolTip(addNewCustomerButton, "Új ügyfél hozzáadása");
        }


    }


}
