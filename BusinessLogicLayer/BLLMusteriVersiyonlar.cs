using EntityLayer;
using System.Collections.Generic;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLMusteriVersiyonlar
    {
        public static int insert(MusteriVersiyonlar kullanici)
        {
            return FMusteriVersiyonlar.insert(kullanici);
        }
        public static bool update(MusteriVersiyonlar kullanici)
        {
            return FMusteriVersiyonlar.update(kullanici);
        }
        public static bool delete(int id)
        {
            return FMusteriVersiyonlar.delete(id);
        }
        public static MusteriVersiyonlar select(int id)
        {
            return FMusteriVersiyonlar.select(id);
        }
        public static List<MusteriVersiyonlar> selectAll()
        {
            return FMusteriVersiyonlar.selectAll();
        }
    }
}
