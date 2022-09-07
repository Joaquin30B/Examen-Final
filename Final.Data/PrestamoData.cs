using Final.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;

namespace Final.Data
{
    public class PrestamoData
    {
        string cadenaConexion = "server=localhost\\SQLEXPRESS; database=Final; integrated security=true";
        public List<Prestamo> Listar()
        {
            var listado = new List<Prestamo>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Prestamo", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Prestamo prestamo;
                            while (lector.Read())
                            {
                                prestamo = new Prestamo();
                                prestamo.Numero = lector[1].ToString();
                                prestamo.Importe = int.Parse(lector[0].ToString());
                                prestamo.Tasa = int.Parse(lector[0].ToString());


                                listado.Add(prestamo);
                            }
                        }
                    }
                }
            }
            return listado;
        }
        public Prestamo BuscarPorId(int id)
        {
            var prestamo = new Prestamo();
            return prestamo;
        }
    }
}
