using System.Collections.Generic;
using EntityLayer;

namespace FacadeLayer
{
    public class FProjeler : myAbsDB
    {
        public static Projeler select(int id)
        {
            return select<Projeler>(id);
        }
        public static List<Projeler> selectAll()
        {
            return selectAll<Projeler>();
        }
        public static bool delete(int id)
        {
            return delete(id, typeof(Projeler));
        }
    }
}
