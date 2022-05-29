using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BL;
namespace Airlines.DL
{
    public class PassengerDL
    {
        static private List<Passenger> passengersList = new List<Passenger>();
        static private List<Passenger> sortedPassengersList = new List<Passenger>();
        public static void sortPassengersByTotal ()
        {
            foreach (Passenger p in passengersList)
            {
                p.calculateTotal();
            }
            SortedPassengersList = passengersList.OrderByDescending(p => p.Total).ToList();
        }
        public static List<Passenger> PassengersList { get => passengersList; set => passengersList = value; }
        public static List<Passenger> SortedPassengersList { get => sortedPassengersList; set => sortedPassengersList = value; }
    }
}
