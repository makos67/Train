using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train{
    class NightWagon : PersonalWagon {
        private Bed[] beds = new Bed[100];
        private int numberOfBeds;
        public int NumberOfBeds { get { return numberOfBeds; }set { numberOfBeds = value; } }
        public Bed[] Beds { get { return beds; }set { beds = value; } }
        public NightWagon(int numberOfChairs,int numberOfBeds) : base(numberOfChairs) {
            this.numberOfBeds = numberOfBeds;
        }
        public override string ToString() {
            return "night wagon - "+NumberOfChairs.ToString()+" sedadel a "+numberOfBeds.ToString()+"lehatek; ";
        }

    }
}
