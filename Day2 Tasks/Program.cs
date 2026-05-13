namespace Day2_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = Console.ReadLine();
            changeString(originalString);
            Console.WriteLine(originalString); //The value of the original string will not Change because strings are imutable in C#
            _3DPoint p1 = new _3DPoint
            {
                X = 10,
                Y = 20,
                Z = 15
            }; //object initializer
            _3DPoint p2 = new _3DPoint
            {
                X = 10,
                Y = 20,
                Z = 15
            }; //two points have same coordinates

            if (p1 == p2)
            {
                Console.WriteLine("p1 and p2 are equal.");
            }
            else
            {
                Console.WriteLine("p1 and p2 are not equal.");
            }
            p1.DisplayCoordinates();

            //Day 3 Task
            var points = new _3DPoint[]
            {
               new _3DPoint { X=1, Y=5.3, Z=2.3},
                new _3DPoint { X=2, Y=3.4, Z=4.5},
                new _3DPoint { X=3, Y=1.2, Z=6.7},
                new _3DPoint {X =4.3, Y=2.1, Z=8.9},
            };
            _3DPoint p = new _3DPoint();
            p.Display(points);

            var persons = new Person[]
            {
                new Person { NationalID = 123456789, Age = 30, Name = "John Doe" },
                new Employee { NationalID = 111111111, Age = 35, Name = "Bob Brown", Salary = 50000 },
                new Person { NationalID = 987654321, Age = 25, Name = "Jane Smith" },
                new Trainee { NationalID = 222222222, Age = 28, Name = "Alice White", IntakeNumber = 101 },
                new Person { NationalID = 555555555, Age = 40, Name = "Alice Johnson" },
                new Employee { NationalID = 333333333, Age = 45, Name = "Charlie Green", Salary = 60000 },
                new Person { NationalID = 444444444, Age = 22, Name = "Eve Black" },
                new Trainee { NationalID = 666666666, Age = 27, Name = "David Blue", IntakeNumber = 102 },
            };

            displayPeople(persons);
            GetType(persons[2]);
        }
        //Function that Takes a string as input and changing its value , displaying the original string after calling the function
        static void changeString(string str)
        {
            str = "Hello John";
            Console.WriteLine($"string after change : {str}");
        }
        static void displayPeople(Person[] people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
        // GetType function that returns the object type as string
        static string GetType(Person p)
        {
            // Get the actual type of the object (not reference type)
            return p.GetType().Name;
        }
    }
}
