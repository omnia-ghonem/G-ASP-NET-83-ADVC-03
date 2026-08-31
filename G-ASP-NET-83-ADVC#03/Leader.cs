using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_ADVC_03
{
    public class Leader 
    {

        public static void PrintLeaderboard(SortedDictionary<int, string> leaderboard) {
            // Why KeyValuePair<int,string> not SortedDictionary<int,string> as The type after foreach must be the type of one element, not the type of the entire collection.
            foreach (KeyValuePair<int,string> s in leaderboard) { 
              Console.WriteLine($"{s.Key} = {s.Value}");
            
            }
        
        }
        //public string Name { get;
        //    set {
        //        if (!string.IsNullOrEmpty(value))
        //            field = value;

        //    }

        // }
        //public int Score { get;
        //    set
        //    { 
        //      if (value >= 0)
        //         field = value;
        //    }

        //  }

        //public Leader(string name, int score) {
        //    Name = !string.IsNullOrEmpty(name)? name : "unkown";
        //    Score = score >= 0? score : 0;
        //}

        //public int CompareTo(Leader other) {
        //    if (this.Score > other.Score)
        //         return 1;
        //    if (this.Score < other.Score)
        //        return -1;
        //    if (this.Score == other.Score)
        //        return 0;
        //    return -1;
        //}

    }
}
