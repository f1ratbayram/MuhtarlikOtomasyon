using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MuhtarlıkPerformans
{
    class askerlikKodlar
    {
        public string TcKimlik { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string AskerlikDurumu { get; set; }
        
        public string AskerlikBölgesi { get; set; }
       

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PLC6DRU\\SQLEXPRESS;Initial Catalog=Muhtarlikİslemleri;Integrated Security=True");

        public void connect()
        {

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
        }

        public List<askerlikKodlar> Getir()
        {
            connect();
            SqlCommand command = new SqlCommand("SELECT * FROM  askerlikKayitlari order by Adi ASC", baglan);
            SqlDataReader reader = command.ExecuteReader();

            List<askerlikKodlar> askerlikVeriler = new List<askerlikKodlar>();

            while (reader.Read())
            {
                askerlikKodlar askerlikVeri = new askerlikKodlar();

                askerlikVeri.TcKimlik = reader["tcKimlik"].ToString();
                askerlikVeri.Adi = reader["Adi"].ToString();
                askerlikVeri.Soyadi = reader["Soyadi"].ToString();
                askerlikVeri.AskerlikDurumu = reader["askerlikDurumu"].ToString();               
              
                askerlikVeri.AskerlikBölgesi = reader["askerlikBölgesi"].ToString();
           
               


                askerlikVeriler.Add(askerlikVeri);

            }
            reader.Close();
            baglan.Close();
            return askerlikVeriler;
        }

        public void kaydet()

        {

            connect();
            SqlCommand command = new SqlCommand("Insert into askerlikKayitlari values(@tcKimlik,@Adİ,@Soyadi,@AskerlikDurumu,@AskerlikBölgesi)", baglan);
            command.Parameters.AddWithValue("@tcKimlik", TcKimlik);
            command.Parameters.AddWithValue("@Adİ", Adi);
            command.Parameters.AddWithValue("@Soyadi", Soyadi);
            command.Parameters.AddWithValue("@askerlikDurumu", AskerlikDurumu);
          
            command.Parameters.AddWithValue("@askerlikBölgesi", AskerlikBölgesi);
           


            command.ExecuteNonQuery();
            baglan.Close();

        }
        public void sil()

        {

            connect();
            SqlCommand command = new SqlCommand(
              "Delete From askerlikKayitlari where tcKimlik='" + TcKimlik + "' ", baglan);


            command.Parameters.AddWithValue("@tcKimlik", TcKimlik);

            command.ExecuteNonQuery();

            baglan.Close();

        }
        public void guncelle()

        {

            connect();
            SqlCommand command = new SqlCommand("Update  askerlikKayitlari Set TcKimlik=@tcKimlik,Adi=@Adİ,Soyadi=@Soyadi,AskerlikDurumu=@askerlikDurumu,AskerlikBölgesi=@askerlikBölgesi  where TcKimlik=@tcKimlik", baglan);
            command.Parameters.AddWithValue("@tcKimlik", TcKimlik);
            command.Parameters.AddWithValue("@Adİ", Adi);
            command.Parameters.AddWithValue("@Soyadi", Soyadi);
            command.Parameters.AddWithValue("@askerlikDurumu", AskerlikDurumu);
           
            command.Parameters.AddWithValue("@askerlikBölgesi", AskerlikBölgesi);
          


            command.ExecuteNonQuery();
            baglan.Close();

        }


    }
}
