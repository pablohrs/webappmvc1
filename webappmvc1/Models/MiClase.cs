using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webappmvc1.Models
{
    public class MiClase
    {
        public int cantidad { get; set; }
        public MiClase()
        {
            int[] valores = {10,20,30,40,50 };
            cantidad = valores.Count(x => x >= 30);

        }

    }
}