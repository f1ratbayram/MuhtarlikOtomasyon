using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MuhtarlıkPerformans
{
   public class ikametgahKodlar
    {



        public string TcKimlik { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }       
        public string İl { get; set; }
        public string İlce { get; set; }
        public string Mahalle { get; set; }
        public string CaddeSokak { get; set; }
        public string DaireNo { get; set; }
        

       


        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PLC6DRU\\SQLEXPRESS;Initial Catalog=Muhtarlikİslemleri;Integrated Security=True");

        public void connect()
        {
       
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
        }

        public List<ikametgahKodlar> Getir()
        {
            connect();
            SqlCommand command = new SqlCommand("SELECT * FROM  ikametgahKayitlari order by Adi ASC", baglan);
            SqlDataReader reader = command.ExecuteReader();

            List<ikametgahKodlar> ikametgahVeriler = new List<ikametgahKodlar>();

            while (reader.Read())
            {
                ikametgahKodlar ikametgahVeri = new ikametgahKodlar();

                ikametgahVeri.TcKimlik = reader["tcKimlik"].ToString();
                ikametgahVeri.Adi = reader["Adi"].ToString();
                ikametgahVeri.Soyadi = reader["Soyadi"].ToString();
                ikametgahVeri.İl = reader["İl"].ToString();
                ikametgahVeri.İlce = reader["İlce"].ToString();
                ikametgahVeri.Mahalle = reader["Mahalle"].ToString();
                ikametgahVeri.CaddeSokak = reader["CaddeSokak"].ToString();
                ikametgahVeri.DaireNo = reader["DaireNo"].ToString();
                

                ikametgahVeriler.Add(ikametgahVeri);

            }
            reader.Close();
            baglan.Close();
            return ikametgahVeriler;
        }

        public void kaydet()
       
        {
            
            connect();
            SqlCommand command = new SqlCommand("Insert into ikametgahKayitlari values(@tcKimlik,@Adİ,@Soyadi,@İl,@İlce,@Mahalle,@CaddeSokak,@DaireNo)", baglan);
            command.Parameters.AddWithValue("@tcKimlik",TcKimlik);
            command.Parameters.AddWithValue("@Adİ", Adi);
            command.Parameters.AddWithValue("@Soyadi", Soyadi);
            command.Parameters.AddWithValue("@İl", İl);
            command.Parameters.AddWithValue("@İlce", İlce);
            command.Parameters.AddWithValue("@Mahalle", Mahalle);
            command.Parameters.AddWithValue("@CaddeSokak", CaddeSokak);
            command.Parameters.AddWithValue("@DaireNo", DaireNo);
            command.ExecuteNonQuery();           
            baglan.Close();

        }
        public void sil()

        {

            connect();
            SqlCommand command = new SqlCommand(
              "Delete From ikametgahKayitlari where tcKimlik='" + TcKimlik + "' ", baglan);


            command.Parameters.AddWithValue("@tcKimlik", TcKimlik);

            command.ExecuteNonQuery();
          
            baglan.Close();

        }
        public void guncelle()

        { 

            connect();
            SqlCommand command = new SqlCommand("Update  ikametgahKayitlari Set TcKimlik=@tcKimlik,Adi=@Adİ,Soyadi=@Soyadi,İl=@İl,İlce=@İlce,Mahalle=@Mahalle,CaddeSokak=@CaddeSokak,DaireNo=@DaireNo  where TcKimlik=@tcKimlik", baglan);
            command.Parameters.AddWithValue("@tcKimlik", TcKimlik);
            command.Parameters.AddWithValue("@Adİ", Adi);
            command.Parameters.AddWithValue("@Soyadi", Soyadi);
            command.Parameters.AddWithValue("@İl", İl);
            command.Parameters.AddWithValue("@İlce", İlce);
            command.Parameters.AddWithValue("@Mahalle", Mahalle);
            command.Parameters.AddWithValue("@CaddeSokak", CaddeSokak);
            command.Parameters.AddWithValue("@DaireNo", DaireNo);
            command.ExecuteNonQuery();
            baglan.Close();

        }


    }
   
      
    
}
