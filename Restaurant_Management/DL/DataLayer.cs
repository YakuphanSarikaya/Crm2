using BenımIsletmem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Restaurant_Management.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database = "benimisletmem",
                UserID = "root",
                Password = "159753",
            }.ConnectionString
            );

        public static int MüşteriEkle(Musteri m)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("benimisletmem_MusteriEkle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("benimisletmem_MusterilerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    
                }
                else
                {
                    komut = new MySqlCommand("benimisletmem_MusteriBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);
                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MüşteriGüncelle(Musteri m)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("benimisletmem_MusteriGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MüşteriSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("benimisletmem_MusteriSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunEkle(Urun u)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("benimisletmem_UrunEkle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@kategori", u.Katagori);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@stok", u.Stok);
                komut.Parameters.AddWithValue("@birim", u.Birim);
                komut.Parameters.AddWithValue("@detay", u.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("benimisletmem_UrunlerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("benimisletmem_UrunBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);
                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunGüncelle(Urun u)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("benimisletmem_UrunGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@kategori", u.Katagori);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@stok", u.Stok);
                komut.Parameters.AddWithValue("@birim", u.Birim);
                komut.Parameters.AddWithValue("@detay", u.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}
