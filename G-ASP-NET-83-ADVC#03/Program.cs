namespace G_ASP_NET_83_ADVC_03
{
    internal class Program
    {
        public static void PrintList<T>(List<T> list) {

            //foreach (T item in list) {
            //    Console.Write(item+ " ");
            //}
            Console.Write(string.Join(" ", list));
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
        }
        static void Main(string[] args)
        {

            #region Ex01: Student Grade Manager
            //// 1.	Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<double> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //// 2.	Print the collection, Count, first and last grade
            //Console.WriteLine($"Count : {grades.Count}");
            //Console.WriteLine($"First : {grades.First()}");
            //Console.WriteLine($"Last : {grades.Last()}");
            //// 3.	Sort the grades ascending, then print
            //grades.Sort();
            //PrintList<double>(grades);
            //// List<double> above90 = grades.Where(x => x > 90).ToList();
            //// Console.WriteLine($"First grade above 90: {above90.First()}");

            //// 4.	Get the first grade above 90
            //Console.WriteLine($"First grade above 90: {grades.First(x => x > 90)}");
            //// 5.	Get all grades below 75 (failing grades)
            //List<double> failed = grades.Where(x => x < 75).ToList();
            //// 6.	Remove all failing grades (below 75)
            //grades.RemoveAll(x => x < 75);
            //PrintList<double>(grades);
            //// 7.	Check if any grade equals 100
            //Console.WriteLine($"$\"Contains grade 100: {grades.Contains(100)}");
            //// 8.	Create a List<string> where each grade becomes "Grade: X"
            //List<string> gradesString = ListOperations.Transform(grades, x => $"Grade: {x}");
            //PrintList<string>(gradesString);


            #endregion

            #region Ex02: Leaderboard
            //// Create a leaderboard that automatically sorts players by score.
            //SortedDictionary<int, string> leaderboard = new();
            //// 1.	Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //leaderboard[500] = "Ahmed";
            //leaderboard[200] = "Sara";
            //leaderboard[800] = "Ali";
            //leaderboard[350] = "Mona";
            //// 2.	Print all entries (they should be sorted by score automatically)
            //Console.WriteLine("Leaderboard:");
            //Leader.PrintLeaderboard(leaderboard);
            //// 3.	Access the first key and first value 
            //Console.WriteLine($"First key: {leaderboard.First().Key}");
            //Console.WriteLine($"First value: {leaderboard.First().Value}");
            //// 4.	Check if score 500 exists
            //Console.WriteLine($"Score 500 exists: {leaderboard.ContainsKey(500)}");

            //// 5.	Safely get the player with score 999

            //// The conditional expression must be enclosed in parentheses inside an interpolated string.
            //// Because the colon : has two possible meanings inside an interpolated string:
            //// belong to the conditional operator: condition ? True : False
            //// a formatting instruction: $"{value:F2}"
            //Console.WriteLine($"Player with score 999 : {(leaderboard.TryGetValue(999, out string? player)? player: "Not found")}");

            //// 6.	Remove the player with score 200 and print the updated list
            //leaderboard.Remove(200);
            //Console.WriteLine($"Leaderboard after player with score 200: ");
            //Leader.PrintLeaderboard(leaderboard);




            #endregion

            #region Ex03: Phone Book
            // 1.	Create a Collection  with 4 contacts (name → phone number)
            Dictionary<string,string> phoneBook = new Dictionary<string, string>();
            
            // 2.	Add a new contact using [] syntax (add or update)
            phoneBook["Ahmed"] = "01011105555";
            phoneBook["Sara"] = "01011105557";
            phoneBook["Omnia"] = "01011105355";

            // 3.	Try adding a duplicate using .Add() — catch the exception and print the error
            try
            {
                phoneBook.Add("Ahmed", "01011105558");
            } catch(ArgumentException ex)
            {
               Console.WriteLine($"Adding duplicate: {ex.Message}");  
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(", " , phoneBook));
            Console.WriteLine("-------------------------------");
            // 4.	Try adding a duplicate using .TryAdd() — print whether it succeeded
            Console.WriteLine(phoneBook.TryAdd("Ahmed", "01011105559"));

            // 5.	Search for a contact that doesn’t exist
            Console.WriteLine(phoneBook.ContainsKey("Mohamed"));
            // or 
            //phoneBook.TryGetValue("Mohamed", out string val);
            //Console.WriteLine(val);

            // 6.	Get a contact with a fallback of "Not Found"
            DictionaryTools.PrintKVDifferLine(phoneBook);

            #endregion

            #region Ex04: Unique Email Validator

            #endregion

            #region Ex05: Print Queue Simulator

            #endregion

            #region Ex06: Browser History (Undo)    

            #endregion



        }
    }
}
