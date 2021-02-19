using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Train {
        private Locomotive locomotive;
        private List<IWagons> wagons = new List<IWagons>();
        public Locomotive Locomotive { get { return locomotive; } set { locomotive = value; } }
        public List<IWagons> Wagons { get { return wagons; } set { wagons = value; } }
        public Train() { }
        public Train(Locomotive locomotive) {
            this.locomotive = locomotive;
        }
        public Train(Locomotive locomotive, List<IWagons> wagons) {
            this.locomotive = locomotive;
            this.wagons = wagons;
        }
        public void ConnectWagon(IWagons wagon) {
            wagon.ConnectWagon(this);
        }
        public void DisconnetWagon(IWagons wagon) {
            wagon.DisconnectWagon(this);
        }
        public override string ToString() {
            string text = Locomotive.ToString() + "\n";
            foreach (var w in Wagons) {
                text += w.ToString() + "\n";
            }
            text += "\n";
            return text;
        }

        public void ReserveChair(int cisloWagonu, int cisloSedacky) {
            if ((cisloWagonu - 1) <= Wagons.Count) {                
                if (Wagons[(cisloWagonu - 1)] is PersonalWagon) {
                    PersonalWagon tmp = (PersonalWagon)wagons[(cisloWagonu - 1)];                    
                    if ((tmp.Sits.Count <= (cisloSedacky - 1)) || (tmp.Sits[(cisloSedacky - 1)].Reserved)) {
                        Console.WriteLine("Sedadlo je již rezervováno nebo neexistuje");
                    }
                    else {
                        tmp.Sits[(cisloSedacky - 1)].Reserved = true;
                        Console.WriteLine("Rezervace provedena");
                    }
                }
                else {
                    Console.WriteLine("Nakladni vagon");
                }
            }
            else {
                Console.WriteLine("Vlak je kratsi");
            }
        }
        public void ListReservedChairs() {
            int k = 1;
            foreach (var w in wagons) {
                if (w is PersonalWagon) {
                    PersonalWagon tmp = (PersonalWagon)w;
                    Console.WriteLine("vagon: " + k+" - rezervace:");
                    foreach (var ch in tmp.Sits) {
                        if (ch.Reserved) {
                            Console.WriteLine("sedacka: " + ch.Number);
                        }
                    }
                }
                k++;
            }
        }


    }


}
