using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220117
{
    public partial class FrmUtas : Form
    {
        public FrmUtas()
        {
            InitializeComponent();
            Icon = Properties.Resources.utas;
        }

        private void FrmUtas_Load(object sender, EventArgs e)
        {
            string kDatum = Program.MaiDatum.ToString("yyyy-MM-01");
            string vDatum = Program.MaiDatum.AddMonths(2).ToString("yyyy-MM-01");

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

                var r = new SqlCommand(
                    "SELECT t_kod FROM tura " +
                    $"WHERE kezdet >= '{kDatum}' AND kezdet < '{vDatum}';",
                    conn).ExecuteReader();

                while (r.Read())
                {
                    cbJelentkezes.Items.Add(r[0]);
                }
            }
        }

        private void TsmiKereses_Click(object sender, EventArgs e)
            => new FrmUtasLista(this).ShowDialog();

        private void TsmiMentes_Click(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(tbNev.Text))
                errorMessage += "a 'név' mező kitöltése kötelező!\n";
            if (string.IsNullOrWhiteSpace(rtbCim.Text))
                errorMessage += "a 'cím' mező kitöltése kötelező!\n";

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    caption: "HIBA",
                    text: $"{errorMessage}",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(tbUtasKod.Text))
                {
                    //TODO::: INSERT
                    //TODO::: => tnUtasKod => id
                }
                else
                {
                    //TODO::: UPDATE
                }
            }
        }

        private void TsmiTorles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                caption: "FIGYELMEZTETÉS",
                text: "Biztosan törölni akarja a kijelölt rekordot?",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                //TODO::: DELETE
                UresUrlap();
            }
        }

        private void TsmiUresUrlap_Click(object sender, EventArgs e)
            => UresUrlap();

        private void UresUrlap()
        {
            tbUtasKod.Text = null;
            tbNev.Text = null;
            rtbCim.Text = null;
            cbJelentkezes.Text = null;
            cbJelentkezes.SelectedIndex = -1;
        }

        private void TbUtasKod_TextChanged(object sender, EventArgs e)
            => tsmiTorles.Enabled = !string.IsNullOrEmpty(tbUtasKod.Text);
    }
}
