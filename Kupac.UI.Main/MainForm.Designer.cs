namespace Kupac.UI.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new TableLayoutPanel();
            userPictureBox = new PictureBox();
            navigationTablePanel = new TableLayoutPanel();
            navigationalPanel = new Panel();
            customersButton = new Button();
            dashBoardButton = new Button();
            ordersButton = new Button();
            mainFunctionPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            minimiseApp = new Button();
            closeApp = new Button();
            mainInformationPanel = new Panel();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            navigationTablePanel.SuspendLayout();
            navigationalPanel.SuspendLayout();
            mainFunctionPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.ColumnCount = 2;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainPanel.Controls.Add(userPictureBox, 0, 0);
            mainPanel.Controls.Add(navigationTablePanel, 0, 1);
            mainPanel.Controls.Add(mainFunctionPanel, 1, 0);
            mainPanel.Controls.Add(mainInformationPanel, 1, 1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(10, 15);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.RowCount = 3;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            mainPanel.Size = new Size(1480, 736);
            mainPanel.TabIndex = 1;
            // 
            // userPictureBox
            // 
            userPictureBox.Dock = DockStyle.Fill;
            userPictureBox.Location = new Point(0, 0);
            userPictureBox.Margin = new Padding(0);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(200, 150);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 2;
            userPictureBox.TabStop = false;
            // 
            // navigationTablePanel
            // 
            navigationTablePanel.ColumnCount = 1;
            navigationTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            navigationTablePanel.Controls.Add(navigationalPanel, 0, 0);
            navigationTablePanel.Dock = DockStyle.Fill;
            navigationTablePanel.Location = new Point(0, 153);
            navigationTablePanel.Margin = new Padding(0, 3, 0, 0);
            navigationTablePanel.Name = "navigationTablePanel";
            navigationTablePanel.RowCount = 3;
            navigationTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            navigationTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            navigationTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            navigationTablePanel.Size = new Size(200, 465);
            navigationTablePanel.TabIndex = 0;
            // 
            // navigationalPanel
            // 
            navigationalPanel.Controls.Add(customersButton);
            navigationalPanel.Controls.Add(dashBoardButton);
            navigationalPanel.Controls.Add(ordersButton);
            navigationalPanel.Dock = DockStyle.Fill;
            navigationalPanel.Location = new Point(0, 0);
            navigationalPanel.Margin = new Padding(0);
            navigationalPanel.Name = "navigationalPanel";
            navigationalPanel.Size = new Size(200, 300);
            navigationalPanel.TabIndex = 0;
            // 
            // customersButton
            // 
            customersButton.BackColor = Color.SeaShell;
            customersButton.Cursor = Cursors.Hand;
            customersButton.FlatAppearance.BorderSize = 0;
            customersButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            customersButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            customersButton.FlatStyle = FlatStyle.Flat;
            customersButton.Location = new Point(0, 54);
            customersButton.Margin = new Padding(0);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(200, 27);
            customersButton.TabIndex = 8;
            customersButton.Text = "Zákazníci";
            customersButton.UseVisualStyleBackColor = false;
            customersButton.Click += customersButton_Click;
            customersButton.MouseEnter += navigationButton_MouseEnter;
            customersButton.MouseLeave += navigationButton_MouseLeave;
            customersButton.MouseMove += navigationButton_MouseMove;
            // 
            // dashBoardButton
            // 
            dashBoardButton.BackColor = Color.SeaShell;
            dashBoardButton.Cursor = Cursors.Hand;
            dashBoardButton.FlatAppearance.BorderSize = 0;
            dashBoardButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            dashBoardButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            dashBoardButton.FlatStyle = FlatStyle.Flat;
            dashBoardButton.Location = new Point(0, 0);
            dashBoardButton.Margin = new Padding(0);
            dashBoardButton.Name = "dashBoardButton";
            dashBoardButton.Size = new Size(200, 27);
            dashBoardButton.TabIndex = 7;
            dashBoardButton.Text = "Dashboard";
            dashBoardButton.UseVisualStyleBackColor = false;
            dashBoardButton.MouseEnter += navigationButton_MouseEnter;
            dashBoardButton.MouseLeave += navigationButton_MouseLeave;
            dashBoardButton.MouseMove += navigationButton_MouseMove;
            // 
            // ordersButton
            // 
            ordersButton.BackColor = Color.SeaShell;
            ordersButton.Cursor = Cursors.Hand;
            ordersButton.FlatAppearance.BorderSize = 0;
            ordersButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            ordersButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.Location = new Point(0, 27);
            ordersButton.Margin = new Padding(0);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(200, 27);
            ordersButton.TabIndex = 6;
            ordersButton.Text = "Objednávky";
            ordersButton.UseVisualStyleBackColor = false;
            ordersButton.MouseEnter += navigationButton_MouseEnter;
            ordersButton.MouseLeave += navigationButton_MouseLeave;
            ordersButton.MouseMove += navigationButton_MouseMove;
            // 
            // mainFunctionPanel
            // 
            mainFunctionPanel.BackColor = Color.Thistle;
            mainFunctionPanel.ColumnCount = 2;
            mainFunctionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainFunctionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            mainFunctionPanel.Controls.Add(tableLayoutPanel1, 1, 0);
            mainFunctionPanel.Dock = DockStyle.Fill;
            mainFunctionPanel.Location = new Point(203, 3);
            mainFunctionPanel.Name = "mainFunctionPanel";
            mainFunctionPanel.RowCount = 2;
            mainFunctionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 22.9355927F));
            mainFunctionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 77.06441F));
            mainFunctionPanel.Size = new Size(1274, 144);
            mainFunctionPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(minimiseApp, 0, 0);
            tableLayoutPanel1.Controls.Add(closeApp, 1, 0);
            tableLayoutPanel1.Location = new Point(1217, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(54, 27);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // minimiseApp
            // 
            minimiseApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            minimiseApp.BackColor = Color.Thistle;
            minimiseApp.FlatAppearance.BorderSize = 0;
            minimiseApp.FlatStyle = FlatStyle.Flat;
            minimiseApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            minimiseApp.ForeColor = SystemColors.ControlText;
            minimiseApp.Location = new Point(0, 0);
            minimiseApp.Margin = new Padding(0);
            minimiseApp.Name = "minimiseApp";
            minimiseApp.Size = new Size(27, 27);
            minimiseApp.TabIndex = 3;
            minimiseApp.Text = "_";
            minimiseApp.UseVisualStyleBackColor = false;
            minimiseApp.Click += minimiseApp_Click;
            // 
            // closeApp
            // 
            closeApp.BackColor = Color.Thistle;
            closeApp.Dock = DockStyle.Top;
            closeApp.FlatAppearance.BorderSize = 0;
            closeApp.FlatStyle = FlatStyle.Flat;
            closeApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            closeApp.Location = new Point(30, 3);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(21, 19);
            closeApp.TabIndex = 2;
            closeApp.Text = "X";
            closeApp.UseVisualStyleBackColor = false;
            closeApp.Click += closeApp_Click;
            // 
            // mainInformationPanel
            // 
            mainInformationPanel.Dock = DockStyle.Fill;
            mainInformationPanel.Location = new Point(200, 153);
            mainInformationPanel.Margin = new Padding(0, 3, 0, 0);
            mainInformationPanel.Name = "mainInformationPanel";
            mainInformationPanel.Size = new Size(1280, 465);
            mainInformationPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 761);
            Controls.Add(mainPanel);
            Name = "MainForm";
            Padding = new Padding(10, 15, 10, 10);
            Text = "MainForm";
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            navigationTablePanel.ResumeLayout(false);
            navigationalPanel.ResumeLayout(false);
            mainFunctionPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainPanel;
        private TableLayoutPanel navigationTablePanel;
        private PictureBox userPictureBox;
        private TableLayoutPanel mainFunctionPanel;
        private Panel mainInformationPanel;
        private Panel navigationalPanel;
        private Button customersButton;
        private Button dashBoardButton;
        private Button ordersButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button closeApp;
        private Button minimiseApp;
    }
}