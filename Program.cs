namespace SimpleStudentManagementProject
{
    internal class Program
    {
        // Declear arrays to store student records
        static string[] studentName = new string[10];
        static int[] studentAge = new int[10];
        static double[] marks = new double[10];
        static DateTime[] dateTimes = new DateTime[10];
        static int count = 0;
        static string CurrentStudenName;
        static int CurrentStudenAge=0;
        static double CurrentStudenMark=0;
        static int trails = 0;
        // Main function
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please add student record.");
            addNewStudentRecord();

            bool exit = false;
            while (!exit)
            {
                
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add New Student Record");
                Console.WriteLine("2. Display Student Records");
                Console.WriteLine("3. Search Student Record");
                Console.WriteLine("4. Calculate Average Marks");
                Console.WriteLine("5. Find Student with Maximum Marks");
                Console.WriteLine("6. Sort Student Marks");
                Console.WriteLine("7. Delete Student Record");
                Console.WriteLine("8. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        addNewStudentRecord();
                        break;
                    case "2":
                        displayStudentRecord();
                        break;
                    case "3":
                        searchStudentRecord();
                        break;
                    case "4":
                        calculateAverageMarks();
                        break;
                    case "5":
                        maxMarkStudent();
                        break;
                    case "6":
                        sortStudentMarks();
                        break;
                    case "7":
                        deleteStudentRecord();
                        break;
                    case "8":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        // Add new student record function
        static void addNewStudentRecord()
        {
            //if (count == 10)
            //{
            //    Console.WriteLine("Student record is full");
                
            //}
            //else
            //{
            //    Console.WriteLine($"Enter student name {count + 1}: ");
            //    CurrentStudenName = Console.ReadLine().ToLower();
            //    Console.WriteLine("Enter student age: ");
            //    CurrentStudenAge = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter student marks: ");
            //    CurrentStudenMark = double.Parse(Console.ReadLine());
                
            //    do
            //    {
            //        Console.WriteLine("Enter student age: ");
            //        CurrentStudenAge = int.Parse(Console.ReadLine());
            //        trails++;
            //        if (trails == 3)
            //        {
            //            Console.WriteLine("You have reached the maximum number of trials");
            //            break;
            //        }
            //    }
            //    while (CurrentStudenAge < 21);

                
            //}
                // Loop through the student record array
                for (int i = count; i < studentName.Length; i++)
                {


                    Console.WriteLine($"Enter student name {count + 1}: ");
                    studentName[i] = Console.ReadLine().ToLower();
                    Console.WriteLine("Enter student age: ");
                // Handling input fromating error exceptions
                try
                {
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
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Invalide input, " + e.Message + " Please try again to enter integer input: ");
                }
                   
                    dateTimes[i] = DateTime.Now;
                    count++;

                    Console.WriteLine("Add another student record? (y/n)");
                    if (Console.ReadLine() != "y" || Console.ReadLine() != "Y")
                    {
                        break;
                    }
                }
        }
        // Display student record function
        static void displayStudentRecord()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"----------Student Record {i + 1} ------------");
                Console.WriteLine($"Student Name: {studentName[i]}");
                Console.WriteLine($"Student Age: {studentAge[i]}");
                Console.WriteLine($"Student Marks: {marks[i]}");
                Console.WriteLine($"Date and Time enrollment : {dateTimes[i]}");
            }
        }
        // Search student record function 
        static void searchStudentRecord()
        {
            Console.WriteLine("Enter student name to search: ");
            string searchName = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (studentName[i].ToLower() == searchName.ToLower())
                {
                    Console.WriteLine($"----------Student Record {i + 1} ------------");
                    Console.WriteLine($"Student Name: {studentName[i]}");
                    Console.WriteLine($"Student Age: {studentAge[i]}");
                    Console.WriteLine($"Student Marks: {marks[i]}");
                    Console.WriteLine($"Date and Time enrollment : {dateTimes[i]}");
                    break;
                }
                else
                {
                    Console.WriteLine("Student Record not found");
                }

            }
        }
        // Calculate average marks function
        static void calculateAverageMarks()
        {
            // Try to handling any error that may occur
            try
            {
                double totalMarks = 0;
                for (int i = 0; i < count; i++)
                {
                    totalMarks += marks[i];
                }
                double averageMarks = totalMarks / count;
                Console.WriteLine($"Average Marks: {Math.Round(averageMarks, 2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
           
        }
        // find student with maximum marks function
        static void maxMarkStudent()
        {
            double maxMark = marks[0];
            string name = studentName[0];
            for (int i = 0; i < count; i++)
            {
                if (marks[i] > maxMark)
                {
                    maxMark = marks[i];
                    name = studentName[i];
                }
            }
            Console.WriteLine($"Student {name} got Maximum Marks: {maxMark}");
        }
        // Sort student marks function
        static void sortStudentMarks()
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        double temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                        string tempName = studentName[i];
                        studentName[i] = studentName[j];
                        studentName[j] = tempName;
                        int tempAge = studentAge[i];
                        studentAge[i] = studentAge[j];
                        studentAge[j] = tempAge;
                        DateTime tempDate = dateTimes[i];
                        dateTimes[i] = dateTimes[j];
                        dateTimes[j] = tempDate;
                    }
                }
            }
            Console.WriteLine("Sorted Marks: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Student Name: {studentName[i]}");
                Console.WriteLine($"Student Age: {studentAge[i]}");
                Console.WriteLine($"Student Marks: {marks[i]}");
            }
        }
        // Delete student record function
        static void deleteStudentRecord()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Student Name: {studentName[i]}");
                Console.WriteLine($"Student Age: {studentAge[i]}");
                Console.WriteLine($"Student Marks: {marks[i]}");
            }
            Console.WriteLine("Enter student name to delete: ");
            string deleteName = Console.ReadLine();
            
            for (int i = 0; i < count; i++)
            {
                
                if (studentName[i] == deleteName.ToLower())
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        studentName[j] = studentName[j + 1];
                        studentAge[j] = studentAge[j + 1];
                        marks[j] = marks[j + 1];
                        dateTimes[j] = dateTimes[j + 1];
                    }
                    // Clear the last element
                    studentName[count - 1] = null;
                    studentAge[count - 1] = 0;
                    marks[count - 1] = 0;
                    dateTimes[count - 1] = DateTime.MinValue;
                    count--;
                    Console.WriteLine("Student Record Deleted Successfully");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("The Student Name Not Found");
                }
                break;
            }
            
        }
    }
}
