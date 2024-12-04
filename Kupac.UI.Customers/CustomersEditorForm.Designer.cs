using Kupac.UI.Shared;
using Kupac.UI.Shared.BaseClasses;
using Kupac.Resources;

namespace Kupac
{
    partial class CustomersEditorForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersEditorForm));
            customerDataGridView = new CustomDataGridView();
            customerManagerBindingSource1 = new BindingSource(components);
            customerManagerBindingSource = new BindingSource(components);
            addNewCustomerButton = new CustomButton();
            loadingPictureBox = new PictureBox();
            deleteCustomerButton = new CustomButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadingPictureBox).BeginInit();
            SuspendLayout();
            // 
            // customerDataGridView
            // 
            customerDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            customerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            customerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerDataGridView.BorderStyle = BorderStyle.None;
            customerDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            customerDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 68, 90);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.EnableHeadersVisualStyles = false;
            customerDataGridView.GridColor = Color.LightGray;
            customerDataGridView.Location = new Point(49, 53);
            customerDataGridView.MultiSelect = false;
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.ReadOnly = true;
            customerDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            customerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDataGridView.Size = new Size(1179, 493);
            customerDataGridView.TabIndex = 21;
            customerDataGridView.CellDoubleClick += customerDataGridView_CellDoubleClick;
            // 
            // customerManagerBindingSource1
            // 
            customerManagerBindingSource1.DataSource = typeof(AdatbazisTablak.CustomerManager);
            // 
            // customerManagerBindingSource
            // 
            customerManagerBindingSource.DataSource = typeof(AdatbazisTablak.CustomerManager);
            // 
            // addNewCustomerButton
            // 
            addNewCustomerButton.AutoSize = true;
            addNewCustomerButton.BackColor = Color.Transparent;
            addNewCustomerButton.BackgroundImage = (Image)resources.GetObject("addNewCustomerButton.BackgroundImage");
            addNewCustomerButton.BackgroundImageLayout = ImageLayout.Center;
            addNewCustomerButton.FlatStyle = FlatStyle.Flat;
            addNewCustomerButton.ForeColor = Color.Transparent;
            addNewCustomerButton.Location = new Point(49, 14);
            addNewCustomerButton.Name = "addNewCustomerButton";
            addNewCustomerButton.Size = new Size(24, 24);
            addNewCustomerButton.TabIndex = 22;
            addNewCustomerButton.UseVisualStyleBackColor = false;
            addNewCustomerButton.Click += addNewCustomerButton_Click;
            // 
            // loadingPictureBox
            // 
            loadingPictureBox.Location = new Point(543, 238);
            loadingPictureBox.Name = "loadingPictureBox";
            loadingPictureBox.Size = new Size(140, 21);
            loadingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loadingPictureBox.TabIndex = 23;
            loadingPictureBox.TabStop = false;
            loadingPictureBox.Visible = false;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.AutoSize = true;
            deleteCustomerButton.BackColor = Color.Transparent;
            deleteCustomerButton.BackgroundImage = (Image)resources.GetObject("deleteCustomerButton.BackgroundImage");
            deleteCustomerButton.BackgroundImageLayout = ImageLayout.Center;
            deleteCustomerButton.FlatStyle = FlatStyle.Flat;
            deleteCustomerButton.ForeColor = Color.Transparent;
            deleteCustomerButton.Location = new Point(88, 14);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(24, 24);
            deleteCustomerButton.TabIndex = 24;
            toolTip1.SetToolTip(deleteCustomerButton, "Ügyfél törlése");
            deleteCustomerButton.UseVisualStyleBackColor = false;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // CustomersEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1240, 584);
            Controls.Add(deleteCustomerButton);
            Controls.Add(loadingPictureBox);
            Controls.Add(addNewCustomerButton);
            Controls.Add(customerDataGridView);
            DoubleBuffered = true;
            Margin = new Padding(2, 1, 2, 1);
            Name = "CustomersEditorForm";
            Text = "Form1";
            Load += CustomerEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadingPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource customerManagerBindingSource1;
        private BindingSource customerManagerBindingSource;
        private CustomButton addNewCustomerButton;
        private PictureBox loadingPictureBox;
        private CustomButton deleteCustomerButton;
        private CustomDataGridView customerDataGridView;
        private ToolTip toolTip1;
        //private CustomDataGridView customerDataGridView;
    }
}
