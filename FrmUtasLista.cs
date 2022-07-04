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
    public partial class FrmUtasLista : Form
    {
        private FrmUtas FrmUtas { get; set; } = null;
        public FrmUtasLista(FrmUtas frmUtas)
        {
            FrmUtas = frmUtas;
            InitializeComponent();
            Icon = Properties.Resources.utas;
        }

        private void TbNevSzures_TextChanged(object sender, EventArgs e)
            => Lekerdezes();
        private void TbUticelSzures_TextChanged(object sender, EventArgs e)
            => Lekerdezes();
        private void FrmUtasLista_Load(object sender, EventArgs e)
            => Lekerdezes();
        private void Lekerdezes()
        {
            dgvUtas.Rows.Clear();

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

                var r = new SqlCommand(
                    "SELECT u_kod, nev, cim, t_kod, kezdet, hova " +
                    "FROM utas " +
                    "INNER JOIN tura ON jelentkezik = t_kod " +
                    "INNER JOIN utvonal ON utvonal = ut_kod " +
                    $"WHERE nev LIKE '{tbNevSzures.Text}%' AND hova LIKE '{tbUticelSzures.Text}%' " +
                    "ORDER BY nev, hova ASC;",
                    conn).ExecuteReader();

                while (r.Read())
                {
                    dgvUtas.Rows.Add(
                        r[0], r[1], r[2], r[3],
                        r.GetDateTime(4).ToString("yyyy.MM.dd."),
                        r[5]);
                }
            }
        }

        private void DgvUtas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FrmUtas != null)
            {
                FrmUtas.tbUtasKod.Text = dgvUtas[0, e.RowIndex].Value.ToString();
                FrmUtas.tbNev.Text = dgvUtas[1, e.RowIndex].Value.ToString();
                FrmUtas.rtbCim.Text = dgvUtas[2, e.RowIndex].Value.ToString();
                FrmUtas.cbJelentkezes.Text = dgvUtas[3, e.RowIndex].Value.ToString();

                this.Close();
            }
        }
    }
}
