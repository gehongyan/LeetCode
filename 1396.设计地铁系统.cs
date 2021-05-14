/*
 * @lc app=leetcode.cn id=1396 lang=csharp
 *
 * [1396] 设计地铁系统
 */

// @lc code=start
public class UndergroundSystem {

    public UndergroundSystem() {
        Records = new Dictionary<int, PassengerTravelRecord>();
        TravelRecords = new Dictionary<string, List<int>>();
    }
    
    public Dictionary<int, PassengerTravelRecord> Records { get; set; }
    public Dictionary<string, List<int>> TravelRecords { get; set; }

    public void CheckIn(int id, string stationName, int t) {
        Records.Add(id, new PassengerTravelRecord(){
            Departure = stationName,
            DepartAt = t
        });
    }
    
    public void CheckOut(int id, string stationName, int t) {
        PassengerTravelRecord record = Records[id];

        string path = $"{record.Departure}-{stationName}";

        if (TravelRecords.ContainsKey(path))
        {
            TravelRecords[path].Add(t - record.DepartAt);
        }
        else
        {
            TravelRecords.Add(path, new List<int>(){t - record.DepartAt});
        }

        Records.Remove(id);
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        
        return TravelRecords[$"{startStation}-{endStation}"].Average();

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

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */
// @lc code=end

