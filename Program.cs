using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Program {
        static void Main(string[] args) {
            EconomyWagon vagonE1 = new EconomyWagon(60);
            EconomyWagon vagonE2 = new EconomyWagon(59);
            EconomyWagon vagonE3 = new EconomyWagon(58);

            BusinessWagon vagonB1 = new BusinessWagon(25, "Lenka", "Kozakova");
            Hopper vagonH1 = new Hopper(30);
            Locomotive lok1 = new Locomotive(new Person("Karel", "Novak"), new Engine("diesel"));
            Train vlak1 = new Train(lok1,new List<IWagons> { vagonE1, vagonE2, vagonB1, vagonH1 });
            Console.WriteLine(vlak1);
            vlak1.ConnectWagon(vagonE3);
            Console.WriteLine(vlak1);
            Locomotive lok2 = new Locomotive(new Person("Pepa", "Dvorak"), new Engine("parni"));
            EconomyWagon vagonE4 = new EconomyWagon(34);
            EconomyWagon vagonE5 = new EconomyWagon(34);
            EconomyWagon vagonE6 = new EconomyWagon(34);
            EconomyWagon vagonE7 = new EconomyWagon(34);
            EconomyWagon vagonE8 = new EconomyWagon(34);
            EconomyWagon vagonE9 = new EconomyWagon(34);
            Train vlakParni = new Train(lok2, new List<IWagons> { vagonE4, vagonE5, vagonE6, vagonE7, vagonE8 });
            Console.WriteLine(vlakParni);
            vlakParni.ConnectWagon(vagonE9);
            Console.WriteLine(vlakParni);
            Console.WriteLine();
            vlak1.ReserveChair(2, 6);
            vlak1.ReserveChair(2, 6);
            vlak1.ReserveChair(4, 2);
            vlak1.ReserveChair(1, 5);
            Console.WriteLine();
            vlak1.ListReservedChairs();
            Console.WriteLine();
            Console.WriteLine(vlak1);
            Console.WriteLine(vlakParni);



            Console.ReadLine();
        }
    }
}
