using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.BL
{
    public class Flight
    {
        private string departCity;
        private string arrCity;
        private string tripType;
        private string departDate;
        private string departTime;
        private int seats;
        private double price;
        public Flight (string departCity , string arrCity , string tripType , string departDate , string departTime , int seats , int price)
        {
            this.DepartCity = departCity;
            this.ArrCity = arrCity;
            this.TripType = tripType;
            this.DepartDate = departDate;
            this.DepartTime = departTime;
            this.Seats = seats;
            this.Price = price;
        }
        public Flight (string departCity , string arrCity , string tripType , string departDate)
        {
            this.DepartCity = departCity;
            this.ArrCity = arrCity;
            this.TripType = tripType;
            this.DepartDate = departDate;
        }

        public string DepartCity { get => departCity; set => departCity = value; }
        public string ArrCity { get => arrCity; set => arrCity = value; }
        public string TripType { get => tripType; set => tripType = value; }
        public string DepartDate { get => departDate; set => departDate = value; }
        public string DepartTime { get => departTime; set => departTime = value; }
        public int Seats { get => seats; set => seats = value; }
        public double Price { get => price; set => price = value; }
    }
}
