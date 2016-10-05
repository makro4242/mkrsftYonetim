using EntityLayer;
using FacadeLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class BLLMusteriler : BLLDB
    {


        public static bool delete(int id)
        {
            return FMusteriler.delete(id);
        }
        public static Musteriler select(int id)
        {
            return FMusteriler.select(id);
        }
        public static Musteriler select(string columns, IDictionary<string, string> where)
        {
            return FMusteriler.select(columns, where);
        }
        public static List<Musteriler> selectAll(string columns, IDictionary<string, string> where)
        {
            return FMusteriler.selectAll(columns, where);
        }
        public static List<Musteriler> selectAll()
        {
            return FMusteriler.selectAll();
        }
    }
}
