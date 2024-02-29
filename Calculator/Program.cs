namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double sum = 0;
            string quit = "";
            bool isCalculatorOn = true;

            while (isCalculatorOn)
            {
                Console.Write("Would you like to Add(+), Subtract(-), Divide(/) or Multiply(*)? ");
                string tegn = Console.ReadLine();
                
                if ((tegn == "+") || (tegn == "-") || (tegn == "/") || (tegn == "*"))
                {
                    try
                    {

                        Console.Write("Enter the first number: ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter the secound number: ");
                        int num2 = int.Parse(Console.ReadLine());

                        switch (tegn)
                        {
                            case "+":
                                sum = calculator.Add(num1, num2);
                                break;
                            case "-":
                                sum = calculator.Subtract(num1, num2);
                                break;
                            case "*":
                                sum = calculator.Multiply(num1, num2);
                                break;
                            case "/":
                                sum = calculator.Divide(num1, num2);
                                break;
                        }

                        Console.WriteLine($"{num1} {tegn} {num2} = {sum}");

                        Console.Write("Press enter to calculate again or X to quit ");
                        quit = Console.ReadLine();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter only whole numbers.");

                        Console.Write("Press enter to calculate again or X to quit ");
                        quit = Console.ReadLine();
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("You cannot divide by 0.");
                        Console.Write("Press enter to calculate again or X to quit ");
                        quit = Console.ReadLine();
                    }
                } else
                {
                    Console.WriteLine("Only enter +, -, / or *");
                    Console.Write("Press enter to continue");
                    Console.ReadLine();
                }

                if (quit == "x") isCalculatorOn = false;
                Console.Clear();
            }
            
        }
    }
}
