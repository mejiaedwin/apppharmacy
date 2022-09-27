using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Pharmacy.CapaDatos
{
    internal class DALProductos
    {
        private Conexionbd conexion = new Conexionbd();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader? dataReader;
        DataTable table = new DataTable();
        public void CeateProducts(int cod_pro, string nom_prod, float pre_venta, float pre_compra,DateTime fecha_ven, int stock, int cod_cate, int cod_prov, int cod_pres)
        {
            cmd.Connection = conexion.Openconnetion();
            cmd.CommandText = "Producto";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_pro",cod_pro);
            cmd.Parameters.AddWithValue("@nom_prod", nom_prod);
            cmd.Parameters.AddWithValue("@pre_venta", pre_venta);
            cmd.Parameters.AddWithValue("@pre_compra", pre_compra);
            cmd.Parameters.AddWithValue("@fecha_ven", fecha_ven);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@cod_cate", cod_cate);
            cmd.Parameters.AddWithValue("@cod_prov", cod_prov);
            cmd.Parameters.AddWithValue("@cod_pres", cod_pres);


            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public DataTable ReadAllProducts()
        {
            cmd.Connection = conexion.Openconnetion();
            cmd.CommandText = "Producto";
            cmd.CommandType = CommandType.StoredProcedure;
            dataReader = cmd.ExecuteReader();
            table.Load(dataReader);
            conexion.CloseConnection();
            return table;
        }

        public void DeleteProducts(int cod_pro)
        {

            cmd.Connection = conexion.Openconnetion();
            cmd.CommandText = "Producto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_pro", cod_pro);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void UpdateProduct(int cod_pro, string nom_prod, float pre_venta, float pre_compra, DateTime fecha_ven, int stock, int cod_cate, int cod_prov, int cod_pres)
        {

            cmd.Connection = conexion.Openconnetion();
            cmd.CommandText = "Producto";
            cmd.Parameters.AddWithValue("@cod_pro", cod_pro);
            cmd.Parameters.AddWithValue("@nom_prod", nom_prod);
            cmd.Parameters.AddWithValue("@pre_venta", pre_venta);
            cmd.Parameters.AddWithValue("@pre_compra", pre_compra);
            cmd.Parameters.AddWithValue("@fecha_ven", fecha_ven);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@cod_cate", cod_cate);
            cmd.Parameters.AddWithValue("@cod_prov", cod_prov);
            cmd.Parameters.AddWithValue("@cod_pres", cod_pres);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        internal void CreateProducts(int cod_pro, string nom_prod, float pre_venta, float pre_compra, DateTime fecha_ven, int stock, int cod_cate, int cod_prov, int cod_pres)
        {
            throw new NotImplementedException();
        }
    }
}
