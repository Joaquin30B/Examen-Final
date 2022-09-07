using Final.Data;
using Final.Dominio;
using System.Collections.Generic;
using System;

namespace Final.Logic
{
    public class PrestamoBL
    {
      
        public static List<Prestamo> Listar()
        {
            var prestamoData = new PrestamoData();
            return prestamoData.Listar();
        }
    }
}
