using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class BusinessWagon : PersonalWagon{
        private Person steward;
        public Person Steward { get { return steward; } set { steward = value; } }
        public BusinessWagon(int numberOfChairs,string firstName,string lastName) : base(numberOfChairs) {
            this.steward = new Person(firstName, lastName);
        }
        public override string ToString() {
            return "business wagon -  "+NumberOfChairs+" sedadel, steward - "+steward.ToString()+"; ";
        }
    }
}
