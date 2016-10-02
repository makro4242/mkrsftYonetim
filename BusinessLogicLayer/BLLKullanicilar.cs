using EntityLayer;
using System.Collections.Generic;
using FacadeLayer;


namespace BusinessLogicLayer
{
    public class BLLKullanicilar
    {
        public static int insert(Kullanicilar kullanici)
        {
            return FKullanicilar.insert(kullanici);
        }
        public static bool update(Kullanicilar kullanici)
        {
            return FKullanicilar.update(kullanici);
        }
        public static bool delete(int id)
        {
            return FKullanicilar.delete(id);
        }
        public static Kullanicilar select(int id)
        {
            return FKullanicilar.select(id);
        }
        public static Kullanicilar select(string columns, IDictionary<string, string> where)
        {
            return FKullanicilar.select(columns, where);
        }

        public static List<Kullanicilar> selectAll()
        {
            return FKullanicilar.selectAll();
        }
    }
}
