using System.Collections.Generic;
using EntityLayer;
namespace FacadeLayer
{
    public class FGuncellemeler : myAbsDB
    {
        public static Guncellemeler select(int id)
        {
            return select<Guncellemeler>(id);
        }
        public static List<Guncellemeler> selectAll()
        {
            return selectAll<Guncellemeler>();
        }
        public static bool delete(int id)
        {
            return delete(id, typeof(Guncellemeler));
        }
    }
}
