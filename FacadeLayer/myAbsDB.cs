using Dapper;
using EntityLayer;
using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Dynamic;
using System.Collections;
namespace FacadeLayer
{
    public abstract class myAbsDB
    {
        public static int insert(myClass obje)
        {
            var connection = DBConnection.con;
            string sorgu = "insert into tbl_" + obje.GetType().Name + " values(";
            string kolonlar = "";
            foreach (PropertyInfo propertyInfo in obje.GetType().GetProperties())
            {
                if (propertyInfo.Name != "id")
                {
                    if (kolonlar.Length > 0)
                    {
                        kolonlar += ",";
                    }
                    kolonlar += "@" + propertyInfo.Name;
                }
            }
            sorgu += kolonlar + ")";
            return connection.Execute(sorgu, obje);
        }
        public static bool update(myClass obje)
        {
            bool sonuc = false;
            try
            {
                var connection = DBConnection.con;
                string sorgu = "update tbl_" + obje.GetType().Name + " set ";
                string kolonlar = "";
                foreach (PropertyInfo propertyInfo in obje.GetType().GetProperties())
                {
                    if (propertyInfo.Name != "id")
                    {
                        if (kolonlar.Length > 0)
                        {
                            kolonlar += ",";
                        }
                        kolonlar += propertyInfo.Name + "=@" + propertyInfo.Name;
                    }
                }
                sorgu += kolonlar;
                sorgu += " where id=@id";
                sonuc = connection.Execute(sorgu, obje) > 0;
            }
            catch (Exception)
            {

                sonuc = false;
            }
            return sonuc;
        }
        public static bool delete(int id, Type t)
        {
            bool sonuc = false;
            try
            {
                var connection = DBConnection.con;
                var parameters = new DynamicParameters();
                parameters.Add("id", id);
                sonuc = connection.Execute("delete tbl_" + t.Name + " where id=@id", parameters) > 0;
            }
            catch (Exception)
            {
                sonuc = false;
            }
            return sonuc;
        }
        public static T select<T>(int id)
        {
            Type typeParameterType = typeof(T);
            var connection = DBConnection.con;
            var sonuc = connection.Query<T>("select * from tbl_" + typeParameterType.Name + " where id=@id", new { id = id }).ToList().FirstOrDefault();
            return sonuc;
        }
        public static T select<T>(string columns, IDictionary<string, string> where)
        {
            try
            {
                Type typeParameterType = typeof(T);
                var connection = DBConnection.con;
                string query = "select";
                query += " " + columns;
                query += " from tbl_" + typeParameterType.Name;
                if (where.Count > 0)
                {
                    query += " where 1=1";
                    foreach (var item in where)
                    {
                        query += " and " + item.Key + "=@" + item.Key;
                    }
                }
                DynamicParameters prm = new DynamicParameters();
                foreach (var item in where)
                {
                    prm.Add(item.Key, item.Value);
                }
                var sonuc = connection.Query<T>(query, prm).FirstOrDefault();
                return sonuc;
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public static List<T> selectAll<T>()
        {
            Type typeParameterType = typeof(T);
            var connection = DBConnection.con;
            List<T> sonuc = connection.Query<T>("select * from tbl_" + typeParameterType.Name).ToList();
            return sonuc;
        }
        public static dynamic executeQuery(string query, string[] prmValues)
        {
            try
            {
                var connection = DBConnection.con;
                DynamicParameters prms = new DynamicParameters();
                if (query.Contains("@"))
                {
                    string[] arr = query.Split('@');
                    foreach (var item in arr)
                    {

                    }
                }
                //insert into musteriler values(@adi,@soyadi) "select * from musteriler where id=@id and t=@t"
                var rst = connection.Query(query, prms);
                return rst;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static T executeQuery<T>(string query, DynamicParameters prm)
        {
            try
            {
                var connection = DBConnection.con;
                T rst = connection.Query<T>(query, prm).FirstOrDefault();
                return rst;
            }
            catch (Exception)
            {
                return default(T);
            }
        }


    }
}
