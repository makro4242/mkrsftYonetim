using EntityLayer;
using System.Collections.Generic;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLProjeDosyalari
    {
        public static int insert(ProjeDosyalari kullanici)
        {
            return FProjeDosyalari.insert(kullanici);
        }
        public static bool update(ProjeDosyalari kullanici)
        {
            return FProjeDosyalari.update(kullanici);
        }
        public static bool delete(int id)
        {
            return FProjeDosyalari.delete(id);
        }
        public static ProjeDosyalari select(int id)
        {
            return FProjeDosyalari.select(id);
        }
        public static List<ProjeDosyalari> selectAll()
        {
            return FProjeDosyalari.selectAll();
        }
    }
}
