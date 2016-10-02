using System.Collections.Generic;
using EntityLayer;

namespace FacadeLayer
{
    public class FMusteriVersiyonlar:myAbsDB
    {
        public static MusteriVersiyonlar select(int id)
        {
            return select<MusteriVersiyonlar>(id);
        }
        public static List<MusteriVersiyonlar> selectAll()
        {
            return selectAll<MusteriVersiyonlar>();
        }
        public static bool delete(int id)
        {
            return delete(id, typeof(MusteriVersiyonlar));
        }
    }
}
