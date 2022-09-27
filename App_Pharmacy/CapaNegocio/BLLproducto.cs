using App_Pharmacy.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Pharmacy.CapaNegocio
{
    public class BLLproducto
    {
        private DALProductos objetoCD = new DALProductos();

        public void Create(int cod_pro, string nom_prod, float pre_venta, float pre_compra, DateTime fecha_ven, int stock, int cod_cate, int cod_prov, int cod_pres)
        {

            objetoCD.CreateProducts(cod_pro, nom_prod, pre_venta, pre_compra, fecha_ven, stock, cod_cate, cod_prov, cod_pres);
        }
        public DataTable View()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ReadAllProducts();
            return tabla;

        }

        public void Delete(int cod_pro)
        {

            objetoCD.DeleteProducts(cod_pro);
        }

        public void Update(int cod_pro, string nom_prod, float pre_venta, float pre_compra, DateTime fecha_ven, int stock, int cod_cate, int cod_prov, int cod_pres)
        {

            objetoCD.UpdateProduct(cod_pro, nom_prod, pre_venta, pre_compra, fecha_ven, stock, cod_cate, cod_prov, cod_pres);
        }

    }
}
