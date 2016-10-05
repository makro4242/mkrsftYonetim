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
        public static List<Musteriler> selectAll(string columns, IDictionary<string, string> where)
        {
            return select<Musteriler>(columns, where);
        }
        public static Musteriler select(string columns, IDictionary<string, string> where)
        {
            return select<Musteriler>(columns, where) != null ? select<Musteriler>(columns, where)[0] : null;
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
