namespace SimpleStudentManagementProject
{
    internal class Program
    {
        static string[] studentName = new string[10];
        static int[] studentAge = new int[10];
        static double[] marks = new double[10];
        static DateTime[] dateTimes = new DateTime[10];
        static int count = 0;
        static void Main(string[] args)
        {

            addNewStudentRecord();
        }
        static void addNewStudentRecord()
        {
           
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine($"Enter student name {count +1}: ");
                studentName[i] = Console.ReadLine();
                Console.WriteLine("Enter student age: ");
                studentAge[i] = int.Parse(Console.ReadLine());
                if (studentAge[i] < 21)
                {
                    Console.WriteLine("Student age must be greater than 21");
                    break;
                }
                Console.WriteLine("Enter student marks: ");
                marks[i] = double.Parse(Console.ReadLine());
                if (marks[i] < 0 || marks[i] > 100)
                {
                    Console.WriteLine("Student marks must be between 0 and 100");
                    break;
                }
                dateTimes[i] = DateTime.Now;
                count++;
                Console.WriteLine("add another student record");
                if (i > count)
                {
                    break;
                }
                
               
            }
            
            
           
            Console.WriteLine( string.Join(",",studentName));
            Console.WriteLine(string.Join(",",studentAge));
            Console.WriteLine(string.Join(",", marks));
            Console.WriteLine(string.Join(",", dateTimes));
        }
    }
}
