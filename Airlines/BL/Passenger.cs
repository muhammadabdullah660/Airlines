using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.BL
{
    public class Passenger : MUser
    {
        private string name;
        private string passportNo;
        private string cnic;
        private string eMail;
        private string gender;
        private string contactNum;
        private List<Flight> myFlights = new List<Flight>();
        private double total;
        public Passenger (string userName , string userPassword , string userRole , string name , string passportNo , string cnic , string eMail , string gender , string contactNum) : base(userName , userPassword , userRole)
        {
            this.Name = name;
            this.PassportNo = passportNo;
            this.Cnic = cnic;
            this.EMail = eMail;
            this.Gender = gender;
            this.ContactNum = contactNum;
        }
        public Passenger (string userName , string userPassword , string userRole) : base(userName , userPassword , userRole)
        {

        }
        public Passenger ()
        {

        }

        public string Name { get => name; set => name = value; }
        public string PassportNo { get => passportNo; set => passportNo = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string Gender { get => gender; set => gender = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }
        internal List<Flight> MyFlights { get => myFlights; set => myFlights = value; }
        public double Total { get => total; set => total = value; }

        public void cancelBookedFlight (Flight myFlight)
        {
            int index = MyFlights.FindIndex(item => item == myFlight);
            MyFlights.RemoveAt(index);
        }
        public double calculatePrice (Flight item , Flight myFlight , int Adult , int Child , int Infant)
        {
            double x = ((Adult * item.Price) + (Child * (item.Price)) / 2 + (Infant * (item.Price) / 4));
            x += myFlight.Seats * checkClass(myFlight);
            return x;
        }
        public double checkClass (Flight myFlight)
        {
            if (myFlight.FlightClass == "Business")
            {
                return myFlight.Price * 10;
            }
            return 1;
        }
        public void calculateTotal ()
        {
            this.total = 0;
            foreach (var item in MyFlights)
            {
                this.total += item.Price;
            }
        }
        public void bookFlight (Flight myFlight)
        {
            MyFlights.Add(myFlight);
        }
    }
}
