using EntityLayer;
using System.Collections.Generic;
using FacadeLayer;


namespace BusinessLogicLayer
{
    public class BLLProjeler
    {
        public static int insert(Projeler kullanici)
        {
            return FProjeler.insert(kullanici);
        }
        public static bool update(Projeler kullanici)
        {
            return FProjeler.update(kullanici);
        }
        public static bool delete(int id)
        {
            return FProjeler.delete(id);
        }
        public static Projeler select(int id)
        {
            return FProjeler.select(id);
        }
        public static List<Projeler> selectAll()
        {
            return FProjeler.selectAll();
        }

        public static List<Projeler> selectAll(string columns, IDictionary<string, string> where)
        {
            return FProjeler.selectAll(columns, where);
        }
        public static Projeler select(string columns, IDictionary<string, string> where)
        {
            return FProjeler.select(columns, where);
        }
    }
}
