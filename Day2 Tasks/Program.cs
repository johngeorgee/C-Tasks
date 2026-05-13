namespace Day2_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = Console.ReadLine();
            changString(originalString);
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

            

        }
        //Function that Takes a string as input and changing its value , displaying the original string after calling the function
        static void changString(string str)
        {
            str = "Hello John";
            Console.WriteLine($"string after change : {str}");
        }

    }
}
