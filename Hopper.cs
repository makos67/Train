using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Hopper : IWagons {
        private double loadingCapacity;
        public double LoadingCapacity { get { return loadingCapacity; } set { loadingCapacity = value; } }
        public Hopper(double loadingCapacity) { this.loadingCapacity = loadingCapacity; }
        public override string ToString() {
            return "hopper wagon - kapacita: " + loadingCapacity + "tun; ";
        }
        public void ConnectWagon(Train train) {
            if ((train.Locomotive.Engine.Type == "parni") && (train.Wagons.Count >= 5)) {
                Console.WriteLine("Nelze pripojit\n");
            }
            else {
                train.Wagons.Add(this);
            }
        }
        public void DisconnectWagon(Train train) {
            if (train.Wagons.Contains(this)) {
                train.Wagons.Remove(this);
            }
            else {
                Console.WriteLine("Tenhle vagon v tomhle vlaku neni, nelze odpojit");
            }
            
        }
    }
}
