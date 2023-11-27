using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL2_07_Ticketing.MasterForm
{
    public partial class FrmCustomerTiketSaya : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmCustomerTiketSaya()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * from tbl_transaksi_detail", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmCustomerTiketSaya_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_transaksi_detail WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
        }
    }
}
