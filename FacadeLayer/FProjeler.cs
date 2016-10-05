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
        public static List<Projeler> selectAll(string columns, IDictionary<string, string> where)
        {
            return select<Projeler>(columns, where);
        }
        public static Projeler select(string columns, IDictionary<string, string> where)
        {
            return select<Projeler>(columns, where) != null ? select<Projeler>(columns, where)[0] : null;
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
