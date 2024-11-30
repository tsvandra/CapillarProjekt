namespace Kupac.UI.Customers
{
    partial class CustomerAddForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTextbox = new TextBox();
            menoLabel = new Label();
            phoneTextBox = new TextBox();
            stateTextBox = new TextBox();
            postalCodeTextBox = new TextBox();
            phoneLabel = new Label();
            stateLabel = new Label();
            postalCodeLabel = new Label();
            cityTextBox = new TextBox();
            addressTextBox = new TextBox();
            mobilPhoneTextBox = new TextBox();
            cityLabel = new Label();
            addressLabel = new Label();
            mobilPhoneLabel = new Label();
            emailTextBox = new TextBox();
            priezviskoTextBox = new TextBox();
            EmailLabel = new Label();
            priezviskoLabel = new Label();
            addCustomer = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(121, 44);
            nameTextbox.Margin = new Padding(2, 1, 2, 1);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(135, 23);
            nameTextbox.TabIndex = 7;
            nameTextbox.Enter += nameTextbox_Enter;
            nameTextbox.Leave += nameTextbox_Leave;
            // 
            // menoLabel
            // 
            menoLabel.AutoSize = true;
            menoLabel.Location = new Point(47, 44);
            menoLabel.Margin = new Padding(2, 0, 2, 0);
            menoLabel.Name = "menoLabel";
            menoLabel.Size = new Size(63, 15);
            menoLabel.TabIndex = 6;
            menoLabel.Text = "Keresztnév";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(121, 237);
            phoneTextBox.Margin = new Padding(2, 1, 2, 1);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(135, 23);
            phoneTextBox.TabIndex = 35;
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(121, 204);
            stateTextBox.Margin = new Padding(2, 1, 2, 1);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(135, 23);
            stateTextBox.TabIndex = 34;
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(121, 171);
            postalCodeTextBox.Margin = new Padding(2, 1, 2, 1);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(135, 23);
            postalCodeTextBox.TabIndex = 33;
            postalCodeTextBox.Enter += postalCodeTextBox_Enter;
            postalCodeTextBox.Leave += postalCodeTextBox_Leave;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(46, 237);
            phoneLabel.Margin = new Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(44, 15);
            phoneLabel.TabIndex = 32;
            phoneLabel.Text = "Mobil2";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(46, 204);
            stateLabel.Margin = new Padding(2, 0, 2, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(43, 15);
            stateLabel.TabIndex = 31;
            stateLabel.Text = "Ország";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(46, 171);
            postalCodeLabel.Margin = new Padding(2, 0, 2, 0);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(74, 15);
            postalCodeLabel.TabIndex = 30;
            postalCodeLabel.Text = "Irányítószám";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(362, 110);
            cityTextBox.Margin = new Padding(2, 1, 2, 1);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(135, 23);
            cityTextBox.TabIndex = 29;
            cityTextBox.Enter += CityTextBox_Enter;
            cityTextBox.Leave += CityTextBox_Leave;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(362, 77);
            addressTextBox.Margin = new Padding(2, 1, 2, 1);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(135, 23);
            addressTextBox.TabIndex = 28;
            addressTextBox.Enter += addressTextBox_Enter;
            addressTextBox.Leave += addressTextBox_Leave;
            // 
            // mobilPhoneTextBox
            // 
            mobilPhoneTextBox.Location = new Point(362, 44);
            mobilPhoneTextBox.Margin = new Padding(2, 1, 2, 1);
            mobilPhoneTextBox.Name = "mobilPhoneTextBox";
            mobilPhoneTextBox.Size = new Size(135, 23);
            mobilPhoneTextBox.TabIndex = 27;
            mobilPhoneTextBox.Enter += mobilPhoneTextBox_Enter;
            mobilPhoneTextBox.Leave += mobilPhoneTextBox_Leave;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(294, 110);
            cityLabel.Margin = new Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(44, 15);
            cityLabel.TabIndex = 26;
            cityLabel.Text = "Község";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(294, 77);
            addressLabel.Margin = new Padding(2, 0, 2, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(60, 15);
            addressLabel.TabIndex = 25;
            addressLabel.Text = "Utca, h.sz.";
            // 
            // mobilPhoneLabel
            // 
            mobilPhoneLabel.AutoSize = true;
            mobilPhoneLabel.Location = new Point(294, 44);
            mobilPhoneLabel.Margin = new Padding(2, 0, 2, 0);
            mobilPhoneLabel.Name = "mobilPhoneLabel";
            mobilPhoneLabel.Size = new Size(24, 15);
            mobilPhoneLabel.TabIndex = 24;
            mobilPhoneLabel.Text = "Tel.";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(120, 110);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(135, 23);
            emailTextBox.TabIndex = 23;
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // priezviskoTextBox
            // 
            priezviskoTextBox.Location = new Point(120, 77);
            priezviskoTextBox.Margin = new Padding(2, 1, 2, 1);
            priezviskoTextBox.Name = "priezviskoTextBox";
            priezviskoTextBox.Size = new Size(135, 23);
            priezviskoTextBox.TabIndex = 22;
            priezviskoTextBox.Enter += priezviskoTextBox_Enter;
            priezviskoTextBox.Leave += priezviskoTextBox_Leave;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(46, 110);
            EmailLabel.Margin = new Padding(2, 0, 2, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 21;
            EmailLabel.Text = "Email";
            // 
            // priezviskoLabel
            // 
            priezviskoLabel.AutoSize = true;
            priezviskoLabel.Location = new Point(46, 77);
            priezviskoLabel.Margin = new Padding(2, 0, 2, 0);
            priezviskoLabel.Name = "priezviskoLabel";
            priezviskoLabel.Size = new Size(65, 15);
            priezviskoLabel.TabIndex = 20;
            priezviskoLabel.Text = "Vezetéknév";
            // 
            // addCustomer
            // 
            addCustomer.BackColor = Color.Plum;
            addCustomer.Cursor = Cursors.Hand;
            addCustomer.FlatAppearance.BorderSize = 0;
            addCustomer.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            addCustomer.ForeColor = Color.White;
            addCustomer.Location = new Point(319, 204);
            addCustomer.Margin = new Padding(2, 1, 2, 1);
            addCustomer.Name = "addCustomer";
            addCustomer.Size = new Size(178, 56);
            addCustomer.TabIndex = 36;
            addCustomer.Text = "Hozzáadás";
            addCustomer.UseVisualStyleBackColor = false;
            addCustomer.Click += addCustomer_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top;
            closeButton.BackColor = Color.Thistle;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            closeButton.Location = new Point(538, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(18, 23);
            closeButton.TabIndex = 38;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // CustomerAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 309);
            Controls.Add(closeButton);
            Controls.Add(addCustomer);
            Controls.Add(phoneTextBox);
            Controls.Add(stateTextBox);
            Controls.Add(postalCodeTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(stateLabel);
            Controls.Add(postalCodeLabel);
            Controls.Add(cityTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(mobilPhoneTextBox);
            Controls.Add(cityLabel);
            Controls.Add(addressLabel);
            Controls.Add(mobilPhoneLabel);
            Controls.Add(emailTextBox);
            Controls.Add(priezviskoTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(priezviskoLabel);
            Controls.Add(nameTextbox);
            Controls.Add(menoLabel);
            Name = "CustomerAddForm";
            Text = "Új ügyfél";
            Load += CustomerAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextbox;
        private Label menoLabel;
        private TextBox phoneTextBox;
        private TextBox stateTextBox;
        private TextBox postalCodeTextBox;
        private Label phoneLabel;
        private Label stateLabel;
        private Label postalCodeLabel;
        private TextBox cityTextBox;
        private TextBox addressTextBox;
        private TextBox mobilPhoneTextBox;
        private Label cityLabel;
        private Label addressLabel;
        private Label mobilPhoneLabel;
        private TextBox emailTextBox;
        private TextBox priezviskoTextBox;
        private Label EmailLabel;
        private Label priezviskoLabel;
        private Button addCustomer;
        private Button closeButton;
    }
}
