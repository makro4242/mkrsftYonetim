using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer;
using Dapper;

namespace FacadeLayer
{
    public class FMusteriler : myAbsDB
    {

        public static Musteriler select(int id)
        {
            return select<Musteriler>(id);
        }
        public static List<Musteriler> selectAll()
        {
            return selectAll<Musteriler>();
        }
        public static bool delete(int id)
        {
            return delete(id, typeof(Musteriler));
        }
    }
}
