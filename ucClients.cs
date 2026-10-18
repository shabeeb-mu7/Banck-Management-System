using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BanckSystemDesktop;

namespace SystemBanckDeskTop2
{
    public partial class ucClients : UserControl
    {

        public ucClients()
        {
            InitializeComponent();
            _ShowClientListInDataGridView();
            lbTotalClients.Text+= clsBanckClient.ClientCount.ToString();
            CurrentAccountNumber = "";
        }
        public static string CurrentAccountNumber;

        private static void _FillDataGridViewRow(clsBanckClient Client, DataGridViewRow Row)
        {
            Row.Cells["colFirstName"].Value = Client.FirstName;
            Row.Cells["colLastName"].Value=Client.LastName;
            Row.Cells["colEmail"].Value= Client.Email;
            Row.Cells["colPhone"].Value = Client.Phone;
            Row.Cells["colPinCode"].Value = Client.PinCode;
            Row.Cells["colAccountNumber"].Value = Client.AccountNumber;
            Row.Cells["colAccountBalance"].Value = Client.AccountBalance;

        }
        private void _ShowClientListInDataGridView()
        {
            List<clsBanckClient> lClients = clsBanckClient.GetBanckClientsList();
            foreach (clsBanckClient client in lClients)
            {
                dgvClientList.Rows.Add();
                _FillDataGridViewRow(client, dgvClientList.Rows[dgvClientList.Rows.Count - 1]);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                gbtnSearch.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.A))
            {
                gbtnAddClient.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private bool _IsClientExist(string accNumber)
        {
            
            for (int i = 0; i < dgvClientList.Rows.Count; i++)
            {
                if (dgvClientList.Rows[i].Cells["colAccountNumber"].Value.ToString() == accNumber)
                {
                    dgvClientList.Rows[i].Selected = true;
                    return true;
                }
            }
            return false;
        }
        private void _SelectUserSearchClient()
        {
            if(string.IsNullOrEmpty(gtxtSearch.Text)|| gtxtSearch.Text== "Search by Account number...")
                return;
            if (!_IsClientExist(gtxtSearch.Text))
                MessageBox.Show("Client dose not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        
        private void gbtnSearch_Click(object sender, EventArgs e)
        {
            _SelectUserSearchClient();
            gbtnSearch.FillColor = Color.FromArgb(23, 37, 84);
        }

        private void gtxtSearch_Enter(object sender, EventArgs e)
        {
            if (gtxtSearch.Text == "Search by Account number...")
                gtxtSearch.Text = string.Empty;
        }

        private void gtxtSearch_Leave(object sender, EventArgs e)
        {
            if (gtxtSearch.Text == string.Empty)
                gtxtSearch.Text = "Search by Account number...";
        }
        ucAddClient AddClient = null;
        private void gbtnAddClient_Click(object sender, EventArgs e)
        {
            if(AddClient==null)
                AddClient = new ucAddClient();

            frmMain frmMain = this.FindForm() as frmMain;
            frmMain.ShowpanelContentControls(AddClient);
            gbtnAddClient.FillColor = Color.FromArgb(23, 37, 84);
        }
        private void gtxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvClientList.ClearSelection();
            for (int i = 0; i < dgvClientList.Rows.Count; i++)
            {
                if (dgvClientList.Rows[i].Cells["colAccountNumber"].Value.ToString().Contains(gtxtSearch.Text))
                {
                    dgvClientList.Rows[i].Selected= true;
                    dgvClientList.FirstDisplayedScrollingRowIndex = i;
                    break;
                }

            }
            
        }
        private void pnlHeaderContent_Paint(object sender, PaintEventArgs e)
        {

        }
        ucDelete ucDelete = null;
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gbtnDeleteClient.PerformClick();
        }
        private void dgvClientList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                CurrentAccountNumber = dgvClientList.Rows[e.RowIndex].Cells["colAccountNumber"].Value.ToString();
            }
        }
        private void gbtnDeleteClient_Click(object sender, EventArgs e)
        {
            frmMain frmMain = this.FindForm() as frmMain;
            ucDelete = new ucDelete();
            frmMain.ShowpanelContentControls(ucDelete);
        }
    }
}
