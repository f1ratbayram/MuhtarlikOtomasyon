using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MuhtarlıkPerformans
{
    class medeniKodlar
    { 

        public string TcKimlik { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string MedeniDurum { get; set; }
        public string CocukSayisi { get; set; }
       
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PLC6DRU\\SQLEXPRESS;Initial Catalog=Muhtarlikİslemleri;Integrated Security=True");

        public void connect()
        {

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
        }

        public List<medeniKodlar> Getir()
        {
            connect();
            SqlCommand command = new SqlCommand("SELECT * FROM  medeniKayitlari order by Adi ASC", baglan);
            SqlDataReader reader = command.ExecuteReader();

            List<medeniKodlar> medeniVeriler = new List<medeniKodlar>();

            while (reader.Read())
            {
                medeniKodlar medeniVeri = new medeniKodlar();

                medeniVeri.TcKimlik = reader["tcKimlik"].ToString();
                medeniVeri.Adi = reader["Adi"].ToString();
                medeniVeri.Soyadi = reader["Soyadi"].ToString();
                medeniVeri.MedeniDurum = reader["medeniDurum"].ToString();  
                medeniVeri.CocukSayisi = reader["cocukSayisi"].ToString();




                medeniVeriler.Add(medeniVeri);

            }
            reader.Close();
            baglan.Close();
            return medeniVeriler;
        }

        public void kaydet()

        {

            connect();
            SqlCommand command = new SqlCommand("Insert into medeniKayitlari values(@tcKimlik,@Adİ,@Soyadi,@medeniDurum,@cocukSayisi)", baglan);
            command.Parameters.AddWithValue("@tcKimlik", TcKimlik);
            command.Parameters.AddWithValue("@Adİ", Adi);
            command.Parameters.AddWithValue("@Soyadi", Soyadi);
            command.Parameters.AddWithValue("@medeniDurum", MedeniDurum);
            command.Parameters.AddWithValue("@cocukSayisi", CocukSayisi);



            command.ExecuteNonQuery();
            baglan.Close();

        }
        public void sil()

        {

            connect();
            SqlCommand command = new SqlCommand(
              "Delete From medeniKayitlari where tcKimlik='" + TcKimlik + "' ", baglan);


            command.Parameters.AddWithValue("@tcKimlik", TcKimlik);

            command.ExecuteNonQuery();

            baglan.Close();

        }
        public void guncelle()

        {

            connect();
            SqlCommand command = new SqlCommand("Update  medeniKayitlari Set TcKimlik=@tcKimlik,Adi=@Adi,Soyadi=@Soyadi,MedeniDurum=@medeniDurum,CocukSayisi=cocukSayisi  where TcKimlik=@tcKimlik", baglan);
            command.Parameters.AddWithValue("@tcKimlik", TcKimlik);
            command.Parameters.AddWithValue("@Adİ", Adi);
            command.Parameters.AddWithValue("@Soyadi", Soyadi);
            command.Parameters.AddWithValue("@medeniDurum", MedeniDurum);
            command.Parameters.AddWithValue("@cocukSayisi", CocukSayisi); ;



            command.ExecuteNonQuery();
            baglan.Close();

        }
    }
}
