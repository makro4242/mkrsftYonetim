using EntityLayer;
using FacadeLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class BLLMusteriler:BLLDB
    {
     
   
        public static bool delete(int id)
        {
            return FMusteriler.delete(id);
        }
        public static Musteriler select(int id)
        {
            return FMusteriler.select(id);
        }
        public static List<Musteriler> selectAll()
        {
            return FMusteriler.selectAll();
        }
    }
}
