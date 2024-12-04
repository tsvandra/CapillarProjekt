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
            userPictureBox = new PictureBox();
            navigationalPanel = new Panel();
            customersButton = new Button();
            dashBoardButton = new Button();
            ordersButton = new Button();
            minimiseApp = new Button();
            closeApp = new Button();
            mainInformationPanel = new Panel();
            mainPanel = new Panel();
            rightPanel = new Panel();
            extraDetailPanel = new Panel();
            miniDashboardPanel = new Panel();
            leftPanel = new Panel();
            warningsPanel = new Panel();
            leftTopPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            navigationalPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            miniDashboardPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            leftTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userPictureBox
            // 
            userPictureBox.Dock = DockStyle.Fill;
            userPictureBox.Location = new Point(0, 0);
            userPictureBox.Margin = new Padding(0);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(224, 219);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 2;
            userPictureBox.TabStop = false;
            // 
            // navigationalPanel
            // 
            navigationalPanel.Controls.Add(customersButton);
            navigationalPanel.Controls.Add(dashBoardButton);
            navigationalPanel.Controls.Add(ordersButton);
            navigationalPanel.Dock = DockStyle.Top;
            navigationalPanel.Location = new Point(0, 219);
            navigationalPanel.Margin = new Padding(0);
            navigationalPanel.Name = "navigationalPanel";
            navigationalPanel.Size = new Size(224, 337);
            navigationalPanel.TabIndex = 0;
            // 
            // customersButton
            // 
            customersButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customersButton.BackColor = Color.SeaShell;
            customersButton.Cursor = Cursors.Hand;
            customersButton.FlatAppearance.BorderSize = 0;
            customersButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            customersButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            customersButton.FlatStyle = FlatStyle.Flat;
            customersButton.Location = new Point(0, 54);
            customersButton.Margin = new Padding(0);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(224, 27);
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
            dashBoardButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dashBoardButton.BackColor = Color.SeaShell;
            dashBoardButton.Cursor = Cursors.Hand;
            dashBoardButton.FlatAppearance.BorderSize = 0;
            dashBoardButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            dashBoardButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            dashBoardButton.FlatStyle = FlatStyle.Flat;
            dashBoardButton.Location = new Point(0, 0);
            dashBoardButton.Margin = new Padding(0);
            dashBoardButton.Name = "dashBoardButton";
            dashBoardButton.Size = new Size(224, 27);
            dashBoardButton.TabIndex = 7;
            dashBoardButton.Text = "Dashboard";
            dashBoardButton.UseVisualStyleBackColor = false;
            dashBoardButton.MouseEnter += navigationButton_MouseEnter;
            dashBoardButton.MouseLeave += navigationButton_MouseLeave;
            dashBoardButton.MouseMove += navigationButton_MouseMove;
            // 
            // ordersButton
            // 
            ordersButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ordersButton.BackColor = Color.SeaShell;
            ordersButton.Cursor = Cursors.Hand;
            ordersButton.FlatAppearance.BorderSize = 0;
            ordersButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            ordersButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.Location = new Point(0, 27);
            ordersButton.Margin = new Padding(0);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(224, 27);
            ordersButton.TabIndex = 6;
            ordersButton.Text = "Objednávky";
            ordersButton.UseVisualStyleBackColor = false;
            ordersButton.MouseEnter += navigationButton_MouseEnter;
            ordersButton.MouseLeave += navigationButton_MouseLeave;
            ordersButton.MouseMove += navigationButton_MouseMove;
            // 
            // minimiseApp
            // 
            minimiseApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimiseApp.FlatAppearance.BorderSize = 0;
            minimiseApp.FlatStyle = FlatStyle.Flat;
            minimiseApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            minimiseApp.ForeColor = SystemColors.ControlText;
            minimiseApp.Location = new Point(1023, 2);
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
            closeApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeApp.FlatAppearance.BorderSize = 0;
            closeApp.FlatStyle = FlatStyle.Flat;
            closeApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            closeApp.Location = new Point(1054, 2);
            closeApp.Margin = new Padding(0);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(27, 27);
            closeApp.TabIndex = 2;
            closeApp.Text = "X";
            closeApp.UseVisualStyleBackColor = false;
            closeApp.Click += closeApp_Click;
            // 
            // mainInformationPanel
            // 
            mainInformationPanel.Dock = DockStyle.Fill;
            mainInformationPanel.Location = new Point(0, 100);
            mainInformationPanel.Margin = new Padding(0, 3, 0, 0);
            mainInformationPanel.Name = "mainInformationPanel";
            mainInformationPanel.Size = new Size(1084, 536);
            mainInformationPanel.TabIndex = 3;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(rightPanel);
            mainPanel.Controls.Add(leftPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(10, 15);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1308, 736);
            mainPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(mainInformationPanel);
            rightPanel.Controls.Add(extraDetailPanel);
            rightPanel.Controls.Add(miniDashboardPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(224, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1084, 736);
            rightPanel.TabIndex = 4;
            // 
            // extraDetailPanel
            // 
            extraDetailPanel.Dock = DockStyle.Bottom;
            extraDetailPanel.Location = new Point(0, 636);
            extraDetailPanel.Name = "extraDetailPanel";
            extraDetailPanel.Size = new Size(1084, 100);
            extraDetailPanel.TabIndex = 2;
            // 
            // miniDashboardPanel
            // 
            miniDashboardPanel.Controls.Add(minimiseApp);
            miniDashboardPanel.Controls.Add(closeApp);
            miniDashboardPanel.Dock = DockStyle.Top;
            miniDashboardPanel.Location = new Point(0, 0);
            miniDashboardPanel.Name = "miniDashboardPanel";
            miniDashboardPanel.Size = new Size(1084, 100);
            miniDashboardPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(navigationalPanel);
            leftPanel.Controls.Add(warningsPanel);
            leftPanel.Controls.Add(leftTopPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(224, 736);
            leftPanel.TabIndex = 3;
            // 
            // warningsPanel
            // 
            warningsPanel.Dock = DockStyle.Bottom;
            warningsPanel.Location = new Point(0, 556);
            warningsPanel.Name = "warningsPanel";
            warningsPanel.Size = new Size(224, 180);
            warningsPanel.TabIndex = 2;
            // 
            // leftTopPanel
            // 
            leftTopPanel.Controls.Add(userPictureBox);
            leftTopPanel.Dock = DockStyle.Top;
            leftTopPanel.Location = new Point(0, 0);
            leftTopPanel.Name = "leftTopPanel";
            leftTopPanel.Size = new Size(224, 219);
            leftTopPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 761);
            Controls.Add(mainPanel);
            Name = "MainForm";
            Padding = new Padding(10, 15, 10, 10);
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            navigationalPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            miniDashboardPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftTopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox userPictureBox;
        private Panel mainInformationPanel;
        private Panel navigationalPanel;
        private Button customersButton;
        private Button dashBoardButton;
        private Button ordersButton;
        private Button closeApp;
        private Button minimiseApp;
        private Panel mainPanel;
        private Panel leftPanel;
        private Panel leftTopPanel;
        private Panel warningsPanel;
        private Panel rightPanel;
        private Panel miniDashboardPanel;
        private Panel extraDetailPanel;
    }
}