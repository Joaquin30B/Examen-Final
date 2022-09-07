using System;

namespace Final.Dominio
{
    public class Prestamo
    {
        public int ID { get; set; }
        public string Numero { get; set; }
        public int IdCliente { get; set; }
        public decimal Importe { get; set; }
        public decimal Tasa { get; set; }
        public int Plazo { get; set; }

    }
}
