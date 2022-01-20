using static ClockApp.ClockCalculator;

namespace ClockApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool stop = false;

            while (stop == false)
            {
                Console.WriteLine("Hi, please enter the hours (1-12 range): ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) throw new ArgumentNullException("input", "Please enter a value ");

                var inputHours = int.Parse(input);

                if (inputHours < 1 || inputHours > 12) throw new ArgumentOutOfRangeException("input", "Please enter a valid number of hours, range: 1 - 12");


                Console.WriteLine("Now please enter the minutes (0-59 range): ");
                var input2 = Console.ReadLine();

                if (string.IsNullOrEmpty(input2)) throw new ArgumentNullException("input", "Please enter a value ");

                var inputMinutes = int.Parse(input2);

                if (inputMinutes < 0 || inputMinutes > 59) throw new ArgumentOutOfRangeException("input", "Please enter a valid number of hours, range: 0 - 59");


                var result = CalculateAngle(inputHours, inputMinutes);

                Console.WriteLine();
                Console.WriteLine($"The angle between hour arrow, that is pointing at {inputHours}, and minute arrow, that indicates {inputMinutes}, is: {result} degrees");

                Console.WriteLine("If you wish to start over once again, enter 'Y' or 'y' ");
                Console.WriteLine("If you wish to end, enter 'N' ");

                var input3 = Console.ReadLine();

                Console.WriteLine();

                if (input3.Equals("Y") || input3.Equals("y"))
                {
                    stop = false;
                }

                else stop = true;
            }
        }
    }
}
