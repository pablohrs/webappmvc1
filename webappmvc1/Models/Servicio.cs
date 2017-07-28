using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webappmvc1.DAL;

namespace webappmvc1.Models
{
    public class Servicio
    {
        public List<clientes> lista_clientes { get; set; }

        public Servicio()
        {
            //int[] valores = {10,20,30,40,50 };
            //cantidad = valores.Count(x => x >= 30);

            using (var context = new PruebaEntities())
            {
                lista_clientes = (from cli in context.clientes
                             //  where st.StudentName == "Bill"
                               select cli).ToList();           
            }

        }

    }
}