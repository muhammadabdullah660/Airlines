using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BL;
using System.IO;

namespace Airlines.DL
{
    public class FlightDL
    {
        static private List<Flight> flightsList = new List<Flight>();
        static private List<Flight> requestedFlightsList = new List<Flight>();

        internal static List<Flight> FlightsList { get => flightsList; set => flightsList = value; }
        internal static List<Flight> RequestedFlightsList { get => requestedFlightsList; set => requestedFlightsList = value; }

        public static void addFlightIntoList (Flight newFlight)
        {
            FlightsList.Add(newFlight);
        }
        public static void addReqFlightIntoList (Flight reqFlight)
        {
            RequestedFlightsList.Add(reqFlight);
        }
        public static Flight checkFlight (Flight newFlight)
        {
            foreach (Flight item in FlightsList)
            {
                if (item.DepartCity == newFlight.DepartCity && item.ArrCity == newFlight.ArrCity && item.TripType == newFlight.TripType && item.DepartDate == newFlight.DepartDate)
                {
                    return item;
                }
            }
            return null;
        }
        public static void cancelFlight (Flight newFlight)
        {

            int index = FlightsList.FindIndex(item => item == newFlight);
            FlightsList.RemoveAt(index);
        }
        public static void deleteRequestedFlight (Flight newFlight)
        {

            int index = RequestedFlightsList.FindIndex(item => item == newFlight);
            RequestedFlightsList.RemoveAt(index);
        }

        public static void editFlightFromList (Flight previous , Flight updated)
        {
            foreach (Flight item in FlightsList)
            {
                if (item == previous)
                {
                    item.ArrCity = updated.ArrCity;
                    item.DepartCity = updated.DepartCity;
                    item.DepartTime = updated.DepartTime;
                    item.DepartDate = updated.DepartDate;
                    item.Seats = updated.Seats;
                    item.Price = updated.Price;
                    item.TripType = updated.TripType;
                    item.FlightClass = updated.FlightClass;
                }
            }
        }
        public static bool loadFromFile (string path , string pathF)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path) && File.Exists(pathF))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string departCity = splittedRecord[0];
                    string arrCity = (splittedRecord[1]);
                    string tripType = (splittedRecord[2]);
                    string departDate = splittedRecord[3];
                    string departTime = (splittedRecord[4]);
                    int seats = int.Parse(splittedRecord[5]);
                    int price = int.Parse(splittedRecord[6]);
                    string flightClass = (splittedRecord[7]);
                    Flight newFlight = new Flight(departCity , arrCity , tripType , departDate , departTime , seats , price , flightClass);
                    addFlightIntoList(newFlight);

                }
                f.Close();
                f = new StreamReader(pathF);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string departCity = splittedRecord[0];
                    string arrCity = (splittedRecord[1]);
                    string tripType = (splittedRecord[2]);
                    string departDate = splittedRecord[3];
                    string departTime = (splittedRecord[4]);
                    int seats = int.Parse(splittedRecord[5]);
                    int price = int.Parse(splittedRecord[6]);
                    string flightClass = (splittedRecord[7]);
                    Flight newFlight = new Flight(departCity , arrCity , tripType , departDate , departTime , seats , price , flightClass);
                    addReqFlightIntoList(newFlight);

                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeIntoFile (string path , Flight newFlight)
        {

            StreamWriter f = new StreamWriter(path , true);
            f.WriteLine(newFlight.DepartCity + "," + newFlight.ArrCity + "," + newFlight.TripType + "," + newFlight.DepartDate + "," + newFlight.DepartTime + "," + newFlight.Seats + "," + newFlight.Price + "," + newFlight.FlightClass);
            f.Flush();
            f.Close();
        }
        public static void storeAllFlightsIntoFile (string path , string pathF)
        {

            StreamWriter f = new StreamWriter(path);
            foreach (var newFlight in FlightsList)
            {
                f.WriteLine(newFlight.DepartCity + "," + newFlight.ArrCity + "," + newFlight.TripType + "," + newFlight.DepartDate + "," + newFlight.DepartTime + "," + newFlight.Seats + "," + newFlight.Price + "," + newFlight.FlightClass);
            }
            f.Flush();
            f.Close();
            f = new StreamWriter(pathF);
            foreach (var newFlight in RequestedFlightsList)
            {
                f.WriteLine(newFlight.DepartCity + "," + newFlight.ArrCity + "," + newFlight.TripType + "," + newFlight.DepartDate + "," + newFlight.DepartTime + "," + newFlight.Seats + "," + newFlight.Price + "," + newFlight.FlightClass);
            }
            f.Flush();
            f.Close();
        }
    }

}
