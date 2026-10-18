namespace SystemBanckDeskTop2
{
    partial class ucTransaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTransaction));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpnlSubHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbtnSenderSearch = new Guna.UI2.WinForms.Guna2Button();
            this.gtxtSenderAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtRecipientAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbtnRecipient = new Guna.UI2.WinForms.Guna2Button();
            this.gbtnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.gbtnWithdrawlas = new Guna.UI2.WinForms.Guna2Button();
            this.gbtnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDepositHeader = new System.Windows.Forms.Panel();
            this.gbtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.gtxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gtxtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gtxtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbtnProcess = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gpnlcontent = new Guna.UI2.WinForms.Guna2Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.timerFadeOut = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.gpnlSubHeader.SuspendLayout();
            this.pnlTransfer.SuspendLayout();
            this.pnlDepositHeader.SuspendLayout();
            this.gpnlcontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 101);
            this.pnlHeader.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(-7, 40);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(167, 58);
            this.label1.TabIndex = 10;
            this.label1.Text = "Transaction";
            // 
            // gpnlSubHeader
            // 
            this.gpnlSubHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.gpnlSubHeader.BorderRadius = 5;
            this.gpnlSubHeader.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gpnlSubHeader.Controls.Add(this.pnlTransfer);
            this.gpnlSubHeader.Controls.Add(this.gbtnTransfer);
            this.gpnlSubHeader.Controls.Add(this.gbtnWithdrawlas);
            this.gpnlSubHeader.Controls.Add(this.gbtnDeposit);
            this.gpnlSubHeader.Controls.Add(this.pnlDepositHeader);
            this.gpnlSubHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gpnlSubHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnlSubHeader.Location = new System.Drawing.Point(20, 5);
            this.gpnlSubHeader.Name = "gpnlSubHeader";
            this.gpnlSubHeader.Size = new System.Drawing.Size(840, 167);
            this.gpnlSubHeader.TabIndex = 65;
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.Controls.Add(this.label6);
            this.pnlTransfer.Controls.Add(this.label4);
            this.pnlTransfer.Controls.Add(this.gbtnSenderSearch);
            this.pnlTransfer.Controls.Add(this.gtxtSenderAccountNumber);
            this.pnlTransfer.Controls.Add(this.gtxtRecipientAccountNumber);
            this.pnlTransfer.Controls.Add(this.gbtnRecipient);
            this.pnlTransfer.Location = new System.Drawing.Point(0, 73);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(0, 94);
            this.pnlTransfer.TabIndex = 70;
            this.pnlTransfer.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(-5, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 28);
            this.label6.TabIndex = 71;
            this.label6.Text = "Sender Acc.Number:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(484, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 28);
            this.label4.TabIndex = 69;
            this.label4.Text = "Recipient Acc.Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbtnSenderSearch
            // 
            this.gbtnSenderSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbtnSenderSearch.BorderRadius = 5;
            this.gbtnSenderSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnSenderSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnSenderSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnSenderSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnSenderSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gbtnSenderSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnSenderSearch.ForeColor = System.Drawing.Color.White;
            this.gbtnSenderSearch.Image = global::SystemBanckDeskTop2.Properties.Resources.search;
            this.gbtnSenderSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnSenderSearch.Location = new System.Drawing.Point(374, 44);
            this.gbtnSenderSearch.Name = "gbtnSenderSearch";
            this.gbtnSenderSearch.Size = new System.Drawing.Size(53, 48);
            this.gbtnSenderSearch.TabIndex = 70;
            // 
            // gtxtSenderAccountNumber
            // 
            this.gtxtSenderAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gtxtSenderAccountNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gtxtSenderAccountNumber.BorderRadius = 5;
            this.gtxtSenderAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtSenderAccountNumber.DefaultText = "Search by Account number...";
            this.gtxtSenderAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtSenderAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtSenderAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtSenderAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtSenderAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtSenderAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtSenderAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtSenderAccountNumber.IconRightOffset = new System.Drawing.Point(5, 0);
            this.gtxtSenderAccountNumber.IconRightSize = new System.Drawing.Size(30, 30);
            this.gtxtSenderAccountNumber.Location = new System.Drawing.Point(0, 44);
            this.gtxtSenderAccountNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gtxtSenderAccountNumber.Name = "gtxtSenderAccountNumber";
            this.gtxtSenderAccountNumber.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.gtxtSenderAccountNumber.PlaceholderText = "";
            this.gtxtSenderAccountNumber.SelectedText = "";
            this.gtxtSenderAccountNumber.Size = new System.Drawing.Size(367, 48);
            this.gtxtSenderAccountNumber.TabIndex = 69;
            this.gtxtSenderAccountNumber.TextChanged += new System.EventHandler(this.gtxtSenderAccountNumber_TextChanged);
            this.gtxtSenderAccountNumber.Enter += new System.EventHandler(this.gtxtSearch_Enter);
            this.gtxtSenderAccountNumber.Leave += new System.EventHandler(this.gtxtSearch_Leave);
            // 
            // gtxtRecipientAccountNumber
            // 
            this.gtxtRecipientAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gtxtRecipientAccountNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gtxtRecipientAccountNumber.BorderRadius = 5;
            this.gtxtRecipientAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtRecipientAccountNumber.DefaultText = "Search by Account number...";
            this.gtxtRecipientAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtRecipientAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtRecipientAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtRecipientAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtRecipientAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtRecipientAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtRecipientAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtRecipientAccountNumber.IconRightOffset = new System.Drawing.Point(5, 0);
            this.gtxtRecipientAccountNumber.IconRightSize = new System.Drawing.Size(30, 30);
            this.gtxtRecipientAccountNumber.Location = new System.Drawing.Point(489, 43);
            this.gtxtRecipientAccountNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gtxtRecipientAccountNumber.Name = "gtxtRecipientAccountNumber";
            this.gtxtRecipientAccountNumber.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.gtxtRecipientAccountNumber.PlaceholderText = "";
            this.gtxtRecipientAccountNumber.SelectedText = "";
            this.gtxtRecipientAccountNumber.Size = new System.Drawing.Size(280, 48);
            this.gtxtRecipientAccountNumber.TabIndex = 67;
            this.gtxtRecipientAccountNumber.Enter += new System.EventHandler(this.gtxtSearch_Enter);
            this.gtxtRecipientAccountNumber.Leave += new System.EventHandler(this.gtxtSearch_Leave);
            // 
            // gbtnRecipient
            // 
            this.gbtnRecipient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbtnRecipient.BorderRadius = 5;
            this.gbtnRecipient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnRecipient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnRecipient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnRecipient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnRecipient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gbtnRecipient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnRecipient.ForeColor = System.Drawing.Color.White;
            this.gbtnRecipient.Image = global::SystemBanckDeskTop2.Properties.Resources.search;
            this.gbtnRecipient.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnRecipient.Location = new System.Drawing.Point(776, 43);
            this.gbtnRecipient.Name = "gbtnRecipient";
            this.gbtnRecipient.Size = new System.Drawing.Size(53, 48);
            this.gbtnRecipient.TabIndex = 68;
            // 
            // gbtnTransfer
            // 
            this.gbtnTransfer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbtnTransfer.BorderRadius = 5;
            this.gbtnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnTransfer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.gbtnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.gbtnTransfer.Location = new System.Drawing.Point(612, 4);
            this.gbtnTransfer.Name = "gbtnTransfer";
            this.gbtnTransfer.Size = new System.Drawing.Size(225, 59);
            this.gbtnTransfer.TabIndex = 63;
            this.gbtnTransfer.Text = "Transfer";
            this.gbtnTransfer.Click += new System.EventHandler(this.gbtnTransfer_Click);
            // 
            // gbtnWithdrawlas
            // 
            this.gbtnWithdrawlas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbtnWithdrawlas.BorderRadius = 5;
            this.gbtnWithdrawlas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnWithdrawlas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnWithdrawlas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnWithdrawlas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnWithdrawlas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.gbtnWithdrawlas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnWithdrawlas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.gbtnWithdrawlas.Location = new System.Drawing.Point(309, 4);
            this.gbtnWithdrawlas.Name = "gbtnWithdrawlas";
            this.gbtnWithdrawlas.Size = new System.Drawing.Size(225, 59);
            this.gbtnWithdrawlas.TabIndex = 62;
            this.gbtnWithdrawlas.Text = "Withdraw";
            this.gbtnWithdrawlas.Click += new System.EventHandler(this.gbtnDeposit_Withdraw_Click);
            // 
            // gbtnDeposit
            // 
            this.gbtnDeposit.BorderRadius = 5;
            this.gbtnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnDeposit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.gbtnDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.gbtnDeposit.Location = new System.Drawing.Point(3, 3);
            this.gbtnDeposit.Name = "gbtnDeposit";
            this.gbtnDeposit.Size = new System.Drawing.Size(225, 59);
            this.gbtnDeposit.TabIndex = 61;
            this.gbtnDeposit.Text = "Deposit";
            this.gbtnDeposit.Click += new System.EventHandler(this.gbtnDeposit_Withdraw_Click);
            // 
            // pnlDepositHeader
            // 
            this.pnlDepositHeader.Controls.Add(this.gbtnSearch);
            this.pnlDepositHeader.Controls.Add(this.gtxtSearch);
            this.pnlDepositHeader.Controls.Add(this.lbAccountNumber);
            this.pnlDepositHeader.Location = new System.Drawing.Point(0, 73);
            this.pnlDepositHeader.Name = "pnlDepositHeader";
            this.pnlDepositHeader.Size = new System.Drawing.Size(0, 94);
            this.pnlDepositHeader.TabIndex = 11;
            // 
            // gbtnSearch
            // 
            this.gbtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbtnSearch.BorderRadius = 5;
            this.gbtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gbtnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnSearch.ForeColor = System.Drawing.Color.White;
            this.gbtnSearch.Location = new System.Drawing.Point(479, 43);
            this.gbtnSearch.Name = "gbtnSearch";
            this.gbtnSearch.Size = new System.Drawing.Size(99, 48);
            this.gbtnSearch.TabIndex = 66;
            this.gbtnSearch.Text = "Search";
            this.gbtnSearch.Click += new System.EventHandler(this.gbtnSearch_Click_1);
            // 
            // gtxtSearch
            // 
            this.gtxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gtxtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gtxtSearch.BorderRadius = 5;
            this.gtxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtSearch.DefaultText = "Search by Account number...";
            this.gtxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtSearch.IconRight = global::SystemBanckDeskTop2.Properties.Resources.search;
            this.gtxtSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.gtxtSearch.IconRightSize = new System.Drawing.Size(30, 30);
            this.gtxtSearch.Location = new System.Drawing.Point(0, 43);
            this.gtxtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gtxtSearch.Name = "gtxtSearch";
            this.gtxtSearch.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.gtxtSearch.PlaceholderText = "";
            this.gtxtSearch.SelectedText = "";
            this.gtxtSearch.Size = new System.Drawing.Size(456, 48);
            this.gtxtSearch.TabIndex = 60;
            this.gtxtSearch.Enter += new System.EventHandler(this.gtxtSearch_Enter);
            this.gtxtSearch.Leave += new System.EventHandler(this.gtxtSearch_Leave);
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.lbAccountNumber.Location = new System.Drawing.Point(-5, 9);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(179, 28);
            this.lbAccountNumber.TabIndex = 63;
            this.lbAccountNumber.Text = "Account Number:";
            this.lbAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label3.Size = new System.Drawing.Size(93, 43);
            this.label3.TabIndex = 61;
            this.label3.Text = "Amount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gtxtBalance
            // 
            this.gtxtBalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gtxtBalance.BorderRadius = 5;
            this.gtxtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtBalance.DefaultText = "";
            this.gtxtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.gtxtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtBalance.Location = new System.Drawing.Point(20, 215);
            this.gtxtBalance.Margin = new System.Windows.Forms.Padding(10, 4, 3, 4);
            this.gtxtBalance.Name = "gtxtBalance";
            this.gtxtBalance.PlaceholderText = "";
            this.gtxtBalance.SelectedText = "";
            this.gtxtBalance.Size = new System.Drawing.Size(840, 42);
            this.gtxtBalance.TabIndex = 58;
            this.gtxtBalance.Validating += new System.ComponentModel.CancelEventHandler(this.gtxtBalance_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(20, 257);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label2.Size = new System.Drawing.Size(126, 43);
            this.label2.TabIndex = 62;
            this.label2.Text = "Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gtxtLastName
            // 
            this.gtxtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gtxtLastName.BorderRadius = 5;
            this.gtxtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtLastName.DefaultText = "";
            this.gtxtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gtxtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtLastName.Location = new System.Drawing.Point(20, 300);
            this.gtxtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtLastName.Name = "gtxtLastName";
            this.gtxtLastName.PlaceholderText = "";
            this.gtxtLastName.SelectedText = "";
            this.gtxtLastName.Size = new System.Drawing.Size(840, 42);
            this.gtxtLastName.TabIndex = 59;
            // 
            // gbtnProcess
            // 
            this.gbtnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtnProcess.BorderRadius = 5;
            this.gbtnProcess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnProcess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnProcess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.gbtnProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnProcess.ForeColor = System.Drawing.Color.White;
            this.gbtnProcess.Location = new System.Drawing.Point(10, 391);
            this.gbtnProcess.Name = "gbtnProcess";
            this.gbtnProcess.Size = new System.Drawing.Size(421, 48);
            this.gbtnProcess.TabIndex = 57;
            this.gbtnProcess.Text = "Process";
            this.gbtnProcess.Click += new System.EventHandler(this.gbtnProcess_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.guna2Button1.Location = new System.Drawing.Point(451, 391);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(406, 48);
            this.guna2Button1.TabIndex = 64;
            this.guna2Button1.Text = "Reset";
            // 
            // gpnlcontent
            // 
            this.gpnlcontent.BackColor = System.Drawing.Color.Transparent;
            this.gpnlcontent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.gpnlcontent.BorderRadius = 5;
            this.gpnlcontent.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gpnlcontent.BorderThickness = 1;
            this.gpnlcontent.Controls.Add(this.guna2Button1);
            this.gpnlcontent.Controls.Add(this.gbtnProcess);
            this.gpnlcontent.Controls.Add(this.gtxtLastName);
            this.gpnlcontent.Controls.Add(this.label2);
            this.gpnlcontent.Controls.Add(this.gtxtBalance);
            this.gpnlcontent.Controls.Add(this.label3);
            this.gpnlcontent.Controls.Add(this.gpnlSubHeader);
            this.gpnlcontent.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gpnlcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpnlcontent.FillColor = System.Drawing.Color.White;
            this.gpnlcontent.Location = new System.Drawing.Point(10, 111);
            this.gpnlcontent.Name = "gpnlcontent";
            this.gpnlcontent.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.gpnlcontent.Size = new System.Drawing.Size(880, 474);
            this.gpnlcontent.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Interval = 1;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // timerFadeOut
            // 
            this.timerFadeOut.Interval = 1;
            this.timerFadeOut.Tick += new System.EventHandler(this.timerFadeOut_Tick);
            // 
            // ucTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpnlcontent);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucTransaction";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.Size = new System.Drawing.Size(900, 635);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gpnlSubHeader.ResumeLayout(false);
            this.pnlTransfer.ResumeLayout(false);
            this.pnlTransfer.PerformLayout();
            this.pnlDepositHeader.ResumeLayout(false);
            this.pnlDepositHeader.PerformLayout();
            this.gpnlcontent.ResumeLayout(false);
            this.gpnlcontent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel gpnlSubHeader;
        private Guna.UI2.WinForms.Guna2TextBox gtxtSearch;
        private Guna.UI2.WinForms.Guna2Button gbtnTransfer;
        private Guna.UI2.WinForms.Guna2Button gbtnWithdrawlas;
        private Guna.UI2.WinForms.Guna2Button gbtnDeposit;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox gtxtBalance;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox gtxtLastName;
        private Guna.UI2.WinForms.Guna2Button gbtnProcess;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel gpnlcontent;
        private Guna.UI2.WinForms.Guna2Button gbtnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button gbtnSenderSearch;
        private Guna.UI2.WinForms.Guna2TextBox gtxtSenderAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox gtxtRecipientAccountNumber;
        private Guna.UI2.WinForms.Guna2Button gbtnRecipient;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Timer timerFadeOut;
        private System.Windows.Forms.Panel pnlDepositHeader;
    }
}
