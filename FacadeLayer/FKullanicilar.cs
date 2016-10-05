using System.Collections.Generic;
using EntityLayer;

namespace FacadeLayer
{
    public class FKullanicilar : myAbsDB
    {
        public static Kullanicilar select(int id)
        {
            return select<Kullanicilar>(id);
        }

        public static List<Kullanicilar> selectAll(string columns, IDictionary<string, string> where)
        {
            return select<Kullanicilar>(columns, where);
        }
        public static Kullanicilar select(string columns, IDictionary<string, string> where)
        {
            List<Kullanicilar> lstKullanicilar = select<Kullanicilar>(columns, where);
            return lstKullanicilar != null && lstKullanicilar.Count > 0 ? lstKullanicilar[0] : null;
        }
        public static List<Kullanicilar> selectAll()
        {
            return selectAll<Kullanicilar>();
        }
        public static bool delete(int id)
        {
            return delete(id, typeof(Kullanicilar));
        }

    }
}
