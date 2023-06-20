using BenımIsletmem;
using Restaurant_Management.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriEkle(m);
                return (res > 0);
            }
            catch(Exception ex)
            { 
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MüşteriGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriGüncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool MüşteriSil(string id)
        {
            try
            {
                int res = DataLayer.MüşteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool UrunEkle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunEkle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                DataSet ds2 = DataLayer.UrunGetir(filtre);
                return ds2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool UrunGüncelle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunGüncelle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
