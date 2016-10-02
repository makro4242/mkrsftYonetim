using System.Collections.Generic;
using EntityLayer;

namespace FacadeLayer
{
    public class FLisanslar : myAbsDB
    {
        public static Lisanslar select(int id)
        {
            return select<Lisanslar>(id);
        }
        public static List<Lisanslar> selectAll()
        {
            return selectAll<Lisanslar>();
        }
        public static bool delete(int id)
        {
            return delete(id, typeof(Lisanslar));
        }
    }
}
