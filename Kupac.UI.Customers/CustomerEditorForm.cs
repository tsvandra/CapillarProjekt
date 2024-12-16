using Kupac.Data.Entities;
using Kupac.Data.DbContexts;
using Kupac.UI.Shared;
using Kupac.UI.Shared.BaseClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kupac.UI.Customers
{
    public partial class CustomerEditorForm : BaseForm
    {
        private bool _isEditMode;

        private const string defaultName = "Keresztnév";
        private const string defaultLastName = "Vezetéknév";
        private const string defaultMail = "@";
        private const string defaultText = "Addj meg egy értéket";
        private const string defaultCity = "Horná Potôň";
        private const string defaultPostalCode = "930 36";
        private const string defaultPhone = "+421";
        private const string defaultState = "SK";
        private const string defaultAddress = "utca";

        private bool isEditMode => editingCustomer != null;
        private Customer editingCustomer;

        public CustomerEditorForm(Customer customer = null)
        {
            InitializeComponent();
            this.editingCustomer = customer;

            if (isEditMode)
            {
                // Load existing customer data
                nameTextbox.Text = customer.FirstName;
                priezviskoTextBox.Text = customer.LastName;
                emailTextBox.Text = customer.Email;
                mobilPhoneTextBox.Text = customer.MobilPhone;
                addressTextBox.Text = customer.Address;
                cityTextBox.Text = customer.City;
                postalCodeTextBox.Text = customer.PostalCode;
                stateTextBox.Text = customer.Country;
                phoneTextBox.Text = customer.Phone;
                commentTextBox.Text = customer.Comment;

                addCustomer.Text = "Mentés";
            }
            else
            {
                addCustomer.Text = "Hozzáadás";
            }
        }

        //public Customer NewCustomer { get; private set; } = new Customer();

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                nameTextbox.Text = defaultName;
                nameTextbox.ForeColor = Color.Gray;
                priezviskoTextBox.Text = defaultLastName;
                priezviskoTextBox.ForeColor = Color.Gray;
                emailTextBox.Text = defaultMail;
                emailTextBox.ForeColor = Color.Gray;
                mobilPhoneTextBox.Text = defaultPhone;
                mobilPhoneTextBox.ForeColor = Color.Gray;
                addressTextBox.Text = defaultAddress;
                addressTextBox.ForeColor = Color.Gray;
                cityTextBox.Text = defaultCity;
                cityTextBox.ForeColor = Color.Gray;
                postalCodeTextBox.Text = defaultPostalCode;
                postalCodeTextBox.ForeColor = Color.Gray;
                phoneTextBox.Text = defaultPhone;
                phoneTextBox.ForeColor = Color.Gray;
                stateTextBox.Text = defaultState;
                stateTextBox.ForeColor = Color.Gray;
            }
        }


        private void nameTextbox_Enter(object sender, EventArgs e)
        {
            if (nameTextbox.Text == defaultName)
            {
                nameTextbox.ForeColor = Color.Black;
                nameTextbox.Text = "";

            }
        }

        private void nameTextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                nameTextbox.Text = defaultName;
                nameTextbox.ForeColor = Color.Gray;
            }

        }

        private void priezviskoTextBox_Enter(object sender, EventArgs e)
        {
            if (priezviskoTextBox.Text == defaultLastName)
            {
                priezviskoTextBox.ForeColor = Color.Black;
                priezviskoTextBox.Text = "";

            }
        }

        private void priezviskoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priezviskoTextBox.Text))
            {
                priezviskoTextBox.Text = defaultLastName;
                priezviskoTextBox.ForeColor = Color.Gray;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == defaultMail)
            {
                emailTextBox.ForeColor = Color.Black;
                emailTextBox.Text = "@";

            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text) || emailTextBox.Text == "@")
            {
                emailTextBox.Text = defaultMail;
                emailTextBox.ForeColor = Color.Gray;
            }
        }

        private void mobilPhoneTextBox_Enter(object sender, EventArgs e)
        {
            if (mobilPhoneTextBox.Text == defaultPhone)
            {
                mobilPhoneTextBox.ForeColor = Color.Black;
                mobilPhoneTextBox.Text = defaultPhone;

            }
        }

        private void mobilPhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mobilPhoneTextBox.Text) || mobilPhoneTextBox.Text == defaultPhone)
            {
                mobilPhoneTextBox.Text = defaultPhone;
                mobilPhoneTextBox.ForeColor = Color.Gray;
            }
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            if (addressTextBox.Text == defaultAddress)
            {
                addressTextBox.ForeColor = Color.Black;
                addressTextBox.Text = "";

            }
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                addressTextBox.Text = defaultAddress;
                addressTextBox.ForeColor = Color.Gray;
            }
        }

        private void CityTextBox_Enter(object sender, EventArgs e)
        {
            if (cityTextBox.Text == defaultCity)
            {
                cityTextBox.ForeColor = Color.Black;
                cityTextBox.Text = "";
            }
        }

        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityTextBox.Text = defaultCity;
                cityTextBox.ForeColor = Color.Gray;
            }

            if (cityTextBox.Text != defaultCity)
            {
                postalCodeTextBox.Text = "";
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            if (!ValidateFields())
            {
                return;
            }
            var factory = new CapillarContextFactory();
            using var context = factory.CreateDbContext(null);

            string phoneNumber = mobilPhoneTextBox.Text;

            if (IsPhoneNumberDuplicated(phoneNumber, context))
            {
                MessageBox.Show("Az adott mobiltelefonszám már létezik az adatbázisban.");
                return;
            }

            if (isEditMode)
            {
                var customer = context.Customers.Find(editingCustomer.Id);
                if (customer != null)
                {
                    customer.FirstName = nameTextbox.Text;
                    customer.LastName = priezviskoTextBox.Text;
                    customer.Email = emailTextBox.Text;
                    customer.MobilPhone = mobilPhoneTextBox.Text;
                    customer.Address = addressTextBox.Text;
                    customer.City = cityTextBox.Text;
                    customer.PostalCode = postalCodeTextBox.Text;
                    customer.Country = stateTextBox.Text;
                    customer.Phone = phoneTextBox.Text;
                    customer.Comment = commentTextBox.Text;

                    context.SaveChanges();
                    MessageBox.Show("Az ügyfél sikeresen frissítve.");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var customer = new Customer
                {
                    FirstName = nameTextbox.Text,
                    LastName = priezviskoTextBox.Text,
                    Email = emailTextBox.Text,
                    MobilPhone = mobilPhoneTextBox.Text,
                    Address = addressTextBox.Text,
                    City = cityTextBox.Text,
                    PostalCode = postalCodeTextBox.Text,
                    Country = stateTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Comment = commentTextBox.Text,
                };
                context.Customers.Add(customer);
                context.SaveChanges();

                MessageBox.Show($"Az új ügyfél {customer.LastName} {customer.FirstName} sikeresen hozzáadva");
                DialogResult = DialogResult.OK;
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void postalCodeTextBox_Enter(object sender, EventArgs e)
        {
            if (postalCodeTextBox.Text == defaultPostalCode)
            {
                postalCodeTextBox.ForeColor = Color.Black;
                postalCodeTextBox.Text = string.Empty;

            }
        }

        private void postalCodeTextBox_Leave(object sender, EventArgs e)
        {
            string cityText = cityTextBox.Text;
            if (string.IsNullOrWhiteSpace(postalCodeTextBox.Text))
            {
                postalCodeTextBox.Text = defaultPostalCode;
                postalCodeTextBox.ForeColor = Color.Gray;
            }

            if (cityText == defaultCity)
            {
                postalCodeTextBox.Text = defaultPostalCode;
                postalCodeTextBox.ForeColor = Color.Black;
            }
        }


        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text) || nameTextbox.Text == defaultName)
            {
                MessageBox.Show("A keresztnevet meg kell adni!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(priezviskoTextBox.Text) || priezviskoTextBox.Text == defaultLastName)
            {
                MessageBox.Show("A vezetéknevet meg kell adni!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(mobilPhoneTextBox.Text) || mobilPhoneTextBox.Text == defaultPhone)
            {
                MessageBox.Show("A telefonszámot meg kell adni!");
                return false;
            }

            return true;
        }

        private bool IsPhoneNumberDuplicated(string phoneNumber, CapillarContext context)
        {
            if (phoneNumber == defaultPhone)
                return false;

            return context.Customers.Any(c => c.MobilPhone == phoneNumber && (isEditMode == false || c.Id != editingCustomer.Id));
        }
    }
}
