using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tugas_pbo_toko_buku_API
{
    public partial class Class2 : Form
    {
        public Class2()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO detail_transaksi(id_transaksi, id_laptop, stok_dibeli) VALUES ({tb_idtransaksi.Text},{tb_IDLaptop.Text},{tb_jumlah.Text})";
            new DBHelpers().Execute(sql);
            new DBHelpers().Execute($"UPDATE laptop SET stok = stok - ({tb_jumlah.Text}) WHERE id_laptop = {tb_IDLaptop.Text}");
            InputBarang form = new InputBarang();
            form.ShowDialog();
            this.Close();
        }
    }
}
