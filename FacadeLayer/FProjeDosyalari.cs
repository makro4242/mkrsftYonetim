using System.Collections.Generic;
using EntityLayer;

namespace FacadeLayer
{
    public class FProjeDosyalari : myAbsDB
    {
        public static ProjeDosyalari select(int id)
        {
            return select<ProjeDosyalari>(id);
        }
        public static List<ProjeDosyalari> selectAll()
        {
            return selectAll<ProjeDosyalari>();
        }
        public static bool delete(int id)
        {
            return delete(id, typeof(ProjeDosyalari));
        }
    }
}
