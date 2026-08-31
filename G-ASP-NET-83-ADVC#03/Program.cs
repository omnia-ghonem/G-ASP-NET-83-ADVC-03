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
            List<double> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };
            Console.WriteLine($"Count : {grades.Count}");
            Console.WriteLine($"First : {grades.First()}");
            Console.WriteLine($"Last : {grades.Last()}");
            grades.Sort();
            PrintList<double>(grades);
            // List<double> above90 = grades.Where(x => x > 90).ToList();
            // Console.WriteLine($"First grade above 90: {above90.First()}");
            Console.WriteLine($"First grade above 90: {grades.First(x => x > 90)}");
            List<double> failed = grades.Where(x => x < 75).ToList();
            grades.RemoveAll(x => x < 75);
            PrintList<double>(grades);
            Console.WriteLine($"$\"Contains grade 100: {grades.Contains(100)}");
            List<string> gradesString = ListOperations.Transform(grades, x => $"Grade: {x}");
            PrintList<string>(gradesString);
            
            
            #endregion

            #region Ex02: Student Grade Manager

            #endregion

            #region Ex03: Student Grade Manager

            #endregion

            #region Ex04: Student Grade Manager

            #endregion

            #region Ex05: Student Grade Manager

            #endregion

            #region Ex06: Student Grade Manager

            #endregion



        }
    }
}
