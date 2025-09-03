using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void ExibirDados()
          {
            Console.WriteLine($"Numero: {Numero}, Modelo: {Modelo}");
        }

        public override void InstalarApp(string nome)
        {

           Console.WriteLine($"Intalando {nome} no Nokia");
        }
    }
}