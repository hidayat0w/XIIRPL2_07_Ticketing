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
    public partial class FrmMasterJadwalPenerbangan : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * from tbl_jadwal_penerbangan", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    String sql = "DELETE FROM tbl_jadwal_penerbangan WHERE id=@id";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO tbl_jadwal_penerbangan" + "(kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_waktu_keberangkatan,durasi_penerbangan,harga_per_tiket)" + "VALUES" + "('" + txtKodePenerbangan.Text + "','" + txtDari.Text + "'," + "'" + txtKe.Text + "','" + txtMaskapai.Text + "'," + "'" + txtTanggal.Text + "','" + txtDurasiPenerbangan.Text + "'," + "'" + txtHarga.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Jadwal Penerbangan");
                koneksi.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
