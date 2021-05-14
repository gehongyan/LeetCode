using System;
using System.Collections.Generic;
using System.Linq;

namespace toDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            UndergroundSystem system = new UndergroundSystem();
            system.CheckIn(45, "Leyton", 3);
            system.CheckIn(32, "Paradise", 8);
            system.CheckIn(27, "Leyton", 10);
            system.CheckOut(45, "Waterloo", 15);
            system.CheckOut(27, "Waterloo", 20);
            system.CheckOut(32, "Cambridge", 22);
            Console.WriteLine(system.GetAverageTime("Paradise", "Cambridge"));
        }
    }

    public class UndergroundSystem {

        public UndergroundSystem() {
            Records = new Dictionary<int, PassengerTravelRecord>();
            TravelRecords = new Dictionary<string, Dictionary<string, List<int>>>();
        }
        
        public Dictionary<int, PassengerTravelRecord> Records { get; set; }
        public Dictionary<string, Dictionary<string, List<int>>> TravelRecords { get; set; }

        public void CheckIn(int id, string stationName, int t) {
            Records.Add(id, new PassengerTravelRecord(){
                Departure = stationName,
                DepartAt = t
            });
        }
        
        public void CheckOut(int id, string stationName, int t) {
            PassengerTravelRecord record = Records[id];
            if (TravelRecords.ContainsKey(record.Departure))
            {
                if (TravelRecords[record.Departure].ContainsKey(stationName))
                {
                    TravelRecords[record.Departure][stationName].Add(t - record.DepartAt);
                }
                else
                {
                    List<int> newList = new List<int> {t - record.DepartAt};

                    var dic = new Dictionary<string, List<int>> {{stationName, newList}};

                    TravelRecords.Add(record.Departure, dic);
                }
            }
            else
            {
                TravelRecords.Add(record.Departure, new Dictionary<string, List<int>>()
                {
                    {stationName, new List<int>() {t - record.DepartAt}}
                });
            }

            Records.Remove(id);
        }
        
        public double GetAverageTime(string startStation, string endStation) {
            
            return TravelRecords[startStation][endStation].Average();
            
        }
    }




    /// <summary>
    /// 乘客记录
    /// </summary>
    public class PassengerTravelRecord {
        // public int Id { get; set; }
        public string Departure { get; set; }
        // public string Destination { get; set; }
        public int DepartAt { get; set; }
        // public int ArriveAt { get; set; } = 0;
        // public int Duration { get; set; } = 0;
        // public bool IsFinished { get; set; } = false;
    }

}
