using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            KrediKartiBuilder gercekKart = new AmericanExpressConcreteBuilder();
            KrediKartiKullan kullan = new KrediKartiKullan();
            kullan.KartKullan(gercekKart);

            Console.WriteLine(gercekKart.Kart.ToString());
            Console.Read();
        }
    }
}
