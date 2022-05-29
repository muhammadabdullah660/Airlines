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
        private string travelClass;
        private int adult;
        private int child;
        private int infant;
        private List<Flight> myFlights;
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
        public string TravelClass { get => travelClass; set => travelClass = value; }
        public int Adult { get => adult; set => adult = value; }
        public int Child { get => child; set => child = value; }
        public int Infant { get => infant; set => infant = value; }
        internal List<Flight> MyFlights { get => myFlights; set => myFlights = value; }


        public void cancelBookedFlight (Flight myFlight)
        {
            int index = MyFlights.FindIndex(item => item == myFlight);
            MyFlights.RemoveAt(index);
        }
    }
}
