using EntityLayer;
using System.Collections.Generic;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLGuncellemeler   
    {
        public static int insert(Guncellemeler kullanici)
        {
            return FGuncellemeler.insert(kullanici);
        }
        public static bool update(Guncellemeler kullanici)
        {
            return FGuncellemeler.update(kullanici);
        }
        public static bool delete(int id)
        {
            return FGuncellemeler.delete(id);
        }
        public static Guncellemeler select(int id)
        {
            return FGuncellemeler.select(id);
        }
        public static List<Guncellemeler> selectAll()
        {
            return FGuncellemeler.selectAll();
        }
    }
}
