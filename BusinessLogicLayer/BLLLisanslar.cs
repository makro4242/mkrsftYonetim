using EntityLayer;
using System.Collections.Generic;
using FacadeLayer;


namespace BusinessLogicLayer
{
    public class BLLLisanslar
    {
        public static int insert(Lisanslar kullanici)
        {
            return FLisanslar.insert(kullanici);
        }
        public static bool update(Lisanslar kullanici)
        {
            return FLisanslar.update(kullanici);
        }
        public static bool delete(int id)
        {
            return FLisanslar.delete(id);
        }
        public static Lisanslar select(int id)
        {
            return FLisanslar.select(id);
        }
        public static Lisanslar select(string columns, IDictionary<string, string> where)
        {
            return FLisanslar.select(columns, where);
        }
        public static List<Lisanslar> selectAll(string columns, IDictionary<string, string> where)
        {
            return FLisanslar.selectAll(columns, where);
        }
        public static List<Lisanslar> selectAll()
        {
            return FLisanslar.selectAll();
        }
    }
}
