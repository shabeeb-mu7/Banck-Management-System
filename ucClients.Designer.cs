namespace SystemBanckDeskTop2
{
    partial class ucClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.content = new System.Windows.Forms.Panel();
            this.pnlCenterContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.pnlBottum = new System.Windows.Forms.Panel();
            this.lbTotalClients = new System.Windows.Forms.Label();
            this.pnlHeaderContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbtnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.gbtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipsedatagridview = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPinCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbtnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.content.SuspendLayout();
            this.pnlCenterContent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            this.pnlBottum.SuspendLayout();
            this.pnlHeaderContent.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.pnlCenterContent);
            this.content.Controls.Add(this.pnlHeaderContent);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(10, 10);
            this.content.Name = "content";
            this.content.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.content.Size = new System.Drawing.Size(880, 615);
            this.content.TabIndex = 1;
            // 
            // pnlCenterContent
            // 
            this.pnlCenterContent.Controls.Add(this.panel1);
            this.pnlCenterContent.Controls.Add(this.pnlBottum);
            this.pnlCenterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterContent.Location = new System.Drawing.Point(10, 140);
            this.pnlCenterContent.Name = "pnlCenterContent";
            this.pnlCenterContent.Padding = new System.Windows.Forms.Padding(5, 10, 10, 0);
            this.pnlCenterContent.Size = new System.Drawing.Size(860, 475);
            this.pnlCenterContent.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClientList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 407);
            this.panel1.TabIndex = 13;
            // 
            // dgvClientList
            // 
            this.dgvClientList.AllowUserToAddRows = false;
            this.dgvClientList.AllowUserToDeleteRows = false;
            this.dgvClientList.AllowUserToResizeColumns = false;
            this.dgvClientList.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvClientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientList.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvClientList.ColumnHeadersHeight = 40;
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colPhone,
            this.colPinCode,
            this.colAccountNumber,
            this.ColAccountBalance});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientList.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientList.EnableHeadersVisualStyles = false;
            this.dgvClientList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvClientList.Location = new System.Drawing.Point(0, 0);
            this.dgvClientList.MultiSelect = false;
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.RowHeadersVisible = false;
            this.dgvClientList.RowHeadersWidth = 51;
            this.dgvClientList.RowTemplate.Height = 38;
            this.dgvClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientList.Size = new System.Drawing.Size(845, 407);
            this.dgvClientList.TabIndex = 11;
            this.dgvClientList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientList_CellMouseDown);
            // 
            // pnlBottum
            // 
            this.pnlBottum.BackColor = System.Drawing.Color.White;
            this.pnlBottum.Controls.Add(this.lbTotalClients);
            this.pnlBottum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottum.Location = new System.Drawing.Point(5, 417);
            this.pnlBottum.Name = "pnlBottum";
            this.pnlBottum.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottum.Size = new System.Drawing.Size(845, 58);
            this.pnlBottum.TabIndex = 12;
            // 
            // lbTotalClients
            // 
            this.lbTotalClients.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotalClients.AutoSize = true;
            this.lbTotalClients.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.lbTotalClients.Location = new System.Drawing.Point(24, 14);
            this.lbTotalClients.Name = "lbTotalClients";
            this.lbTotalClients.Size = new System.Drawing.Size(127, 28);
            this.lbTotalClients.TabIndex = 5;
            this.lbTotalClients.Text = "Total Clients:";
            // 
            // pnlHeaderContent
            // 
            this.pnlHeaderContent.Controls.Add(this.gbtnDeleteClient);
            this.pnlHeaderContent.Controls.Add(this.gtxtSearch);
            this.pnlHeaderContent.Controls.Add(this.label1);
            this.pnlHeaderContent.Controls.Add(this.gbtnAddClient);
            this.pnlHeaderContent.Controls.Add(this.gbtnSearch);
            this.pnlHeaderContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderContent.Location = new System.Drawing.Point(10, 10);
            this.pnlHeaderContent.Name = "pnlHeaderContent";
            this.pnlHeaderContent.Size = new System.Drawing.Size(860, 130);
            this.pnlHeaderContent.TabIndex = 11;
            this.pnlHeaderContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeaderContent_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client List";
            // 
            // gbtnAddClient
            // 
            this.gbtnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtnAddClient.BorderRadius = 5;
            this.gbtnAddClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnAddClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnAddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnAddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnAddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.gbtnAddClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnAddClient.ForeColor = System.Drawing.Color.White;
            this.gbtnAddClient.Location = new System.Drawing.Point(581, 72);
            this.gbtnAddClient.Name = "gbtnAddClient";
            this.gbtnAddClient.Size = new System.Drawing.Size(136, 48);
            this.gbtnAddClient.TabIndex = 7;
            this.gbtnAddClient.Text = "Add Client";
            this.gbtnAddClient.Click += new System.EventHandler(this.gbtnAddClient_Click);
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
            this.gbtnSearch.Location = new System.Drawing.Point(437, 72);
            this.gbtnSearch.Name = "gbtnSearch";
            this.gbtnSearch.Size = new System.Drawing.Size(136, 48);
            this.gbtnSearch.TabIndex = 0;
            this.gbtnSearch.Text = "Search";
            this.gbtnSearch.Click += new System.EventHandler(this.gbtnSearch_Click);
            // 
            // guna2Elipsedatagridview
            // 
            this.guna2Elipsedatagridview.BorderRadius = 15;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ContextMenuStrip1.ShowImageMargin = false;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(103, 52);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(102, 24);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(102, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // colFirstName
            // 
            this.colFirstName.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.colFirstName.FillWeight = 80F;
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.MinimumWidth = 6;
            this.colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            this.colLastName.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.colLastName.FillWeight = 80F;
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEmail.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.colEmail.FillWeight = 130F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 158;
            // 
            // colPhone
            // 
            this.colPhone.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.colPhone.FillWeight = 90F;
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            // 
            // colPinCode
            // 
            this.colPinCode.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.colPinCode.FillWeight = 80F;
            this.colPinCode.HeaderText = "PinCode";
            this.colPinCode.MinimumWidth = 6;
            this.colPinCode.Name = "colPinCode";
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.colAccountNumber.HeaderText = "Acc. Number";
            this.colAccountNumber.MinimumWidth = 6;
            this.colAccountNumber.Name = "colAccountNumber";
            // 
            // ColAccountBalance
            // 
            this.ColAccountBalance.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.ColAccountBalance.FillWeight = 110F;
            this.ColAccountBalance.HeaderText = "Acc. Balance";
            this.ColAccountBalance.MinimumWidth = 6;
            this.ColAccountBalance.Name = "ColAccountBalance";
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
            this.gtxtSearch.Location = new System.Drawing.Point(4, 72);
            this.gtxtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gtxtSearch.Name = "gtxtSearch";
            this.gtxtSearch.PlaceholderText = "";
            this.gtxtSearch.SelectedText = "";
            this.gtxtSearch.Size = new System.Drawing.Size(396, 48);
            this.gtxtSearch.TabIndex = 5;
            this.gtxtSearch.TextChanged += new System.EventHandler(this.gtxtSearch_TextChanged);
            this.gtxtSearch.Enter += new System.EventHandler(this.gtxtSearch_Enter);
            this.gtxtSearch.Leave += new System.EventHandler(this.gtxtSearch_Leave);
            // 
            // gbtnDeleteClient
            // 
            this.gbtnDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtnDeleteClient.BorderRadius = 5;
            this.gbtnDeleteClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnDeleteClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnDeleteClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnDeleteClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnDeleteClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.gbtnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.gbtnDeleteClient.Location = new System.Drawing.Point(721, 72);
            this.gbtnDeleteClient.Name = "gbtnDeleteClient";
            this.gbtnDeleteClient.Size = new System.Drawing.Size(136, 48);
            this.gbtnDeleteClient.TabIndex = 8;
            this.gbtnDeleteClient.Text = "Delete Client";
            this.gbtnDeleteClient.Click += new System.EventHandler(this.gbtnDeleteClient_Click);
            // 
            // ucClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.content);
            this.Name = "ucClients";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(900, 635);
            this.content.ResumeLayout(false);
            this.pnlCenterContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            this.pnlBottum.ResumeLayout(false);
            this.pnlBottum.PerformLayout();
            this.pnlHeaderContent.ResumeLayout(false);
            this.pnlHeaderContent.PerformLayout();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipsedatagridview;
        private System.Windows.Forms.Panel pnlCenterContent;
        private System.Windows.Forms.Panel pnlHeaderContent;
        private Guna.UI2.WinForms.Guna2TextBox gtxtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button gbtnAddClient;
        private Guna.UI2.WinForms.Guna2Button gbtnSearch;
        private System.Windows.Forms.Panel pnlBottum;
        private System.Windows.Forms.Label lbTotalClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPinCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccountBalance;
        private Guna.UI2.WinForms.Guna2Button gbtnDeleteClient;
    }
}
