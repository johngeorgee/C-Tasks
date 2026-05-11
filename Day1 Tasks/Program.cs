namespace C__Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator();
            CompleteNumbers();

        }
        // Task 1: Simple Calculator
        public static void SimpleCalculator()
        {
             Console.WriteLine("Please Enter the first operand : ");
            int operand1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second operand : ");
            int operand2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the type of operation (+, -, *, /) : ");
            char operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"The Result of {operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case '-':
                    Console.WriteLine($"The Result of {operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case '*':
                    Console.WriteLine($"The Result of {operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case '/':
                    if (operand2 == 0)
                        //{
                        //    Console.WriteLine("Error: Division by zero is not allowed.");
                        //}
                        Console.WriteLine($"The Result of {operand1} / {operand2} = {(operand2 != 0 ? (operand1 / operand2).ToString() : "undefined")}");
                    break;
                default:
                    break;



            }
        }

        //Task 2 : Show the Complete  numbers from 1 to 1000
        public static void CompleteNumbers()
        {
            
            for (int i = 1; i < 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j < i-1; j++)
                {
                    if(i%j == 0)
                    {
                        sum += j;
                    }

                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
