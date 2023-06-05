using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tugas_pbo_toko_buku_API
{
    public partial class Form1 : Form
    {
        DBHelpers db;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }
        string APIKey = "0b95dcefe169678651da68af551448fd";
        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lab_Condition.Text = Info.weather[0].main;
                lab_detail.Text = Info.weather[0].description;
                lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lab_wind.Text = Info.wind.speed.ToString();
                lab_pressue.Text = Info.main.pressure.ToString();
            }
        }
        DateTime convertDateTime(long millisec)

        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            var db = new DBHelpers();
            new DBHelpers().Execute($"INSERT INTO laptop(id_laptop, nama_laptop, harga_laptop, stok) VALUES ({tb_IDlaptop.Text}, '{tb_namalaptop.Text}',{tb_harga.Text},{tb_stok.Text} )");
            showdataLaptop();

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            var db = new DBHelpers();
            new DBHelpers().Execute($"Update laptop SET nama_laptop = '{tb_namalaptop.Text}', harga_laptop = {tb_harga.Text}, stok = {tb_stok.Text} where id_laptop = {tb_IDlaptop.Text}");
            showdataLaptop();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showdataLaptop();
            showdataTransaksi();
            showdataDetailTransaksi();
        }
        private void showdataLaptop()
        {
            var reader = new DBHelpers().Select("SELECT * FROM laptop order by id_laptop ASC;");
            dataGridView1.Rows.Clear();


                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id_laptop"], reader["nama_laptop"], reader["harga_laptop"], reader["stok"]);
                }
            reader.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"Delete from laptop where id_laptop = '{tb_IDlaptop.Text}'");
            showdataLaptop();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var Reader = new DBHelpers().Select($"select * from laptop where nama_laptop ilike '%{tb_search.Text}%'");

            dataGridView1.Rows.Clear();
            while (Reader.Read())
            {
                dataGridView1.Rows.Add((int)Reader["id_laptop"], (string)Reader["nama_laptop"], (int)Reader["harga_laptop"], (int)Reader["stok"]);
            }

            Reader.Close();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO transaksi(id_transaksi) VALUES ({tb_idtransaksi.Text})";
            MessageBox.Show(sql);
            new DBHelpers().Execute(sql);
            Class2 form = new Class2();
            form.ShowDialog();
            showdataTransaksi();
            showdataDetailTransaksi();
            showdataLaptop();
        }
        private void showdataDetailTransaksi()
        {
            var reader3 = new DBHelpers().Select("SELECT * from detail_transaksi order by id_detail_transaksi ASC");
            dataGridView3.Rows.Clear();
            while (reader3.Read())
            {
                dataGridView3.Rows.Add(reader3["id_detail_transaksi"], reader3["id_transaksi"], reader3["id_laptop"], reader3["stok_dibeli"]);
            }
        }
        private void showdataTransaksi()
        {
            var reader2 = new DBHelpers().Select("SELECT * from transaksi order by id_transaksi ASC");
            dataGridView2.Rows.Clear();
            while (reader2.Read())
            {
                dataGridView2.Rows.Add(reader2["id_transaksi"], reader2["tanggal_transaksi"]);
            }
        }

        private void lab_pembeli_Click(object sender, EventArgs e)
        {

        }

        private void tb_pembeli_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
