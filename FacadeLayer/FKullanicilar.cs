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

        public static Kullanicilar select(string columns, IDictionary<string, string> where)
        {
            return select<Kullanicilar>(columns, where);
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
