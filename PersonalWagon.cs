using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    abstract class PersonalWagon : IWagons{
        private List<Door> doors = new List<Door>();
        private List<Chair> sits = new List<Chair>();

        private int numberOfChairs;
        public List<Door> Doors { get { return doors; } set { doors = value; } }
        public List<Chair> Sits { get { return sits; } set { sits = value; } }
        public int NumberOfChairs { get { return numberOfChairs; } set { numberOfChairs = value; } }
        public PersonalWagon(int numberOfChairs) {
            this.numberOfChairs = numberOfChairs;
            for (int i = 0; i < numberOfChairs; i++) {
                Sits.Add(new Chair(i + 1));
            }
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
