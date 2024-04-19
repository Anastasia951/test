try
{
    Console.WriteLine("Input two numbers:");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Select an option");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Raise to a power");

    int operation = Convert.ToInt16(Console.ReadLine());

    if (operation < 1 || operation > 4)
    {
        throw new Exception("Operation must be between 1 and 4");
    }

    double result;

   if (operation == 1)
    {
        result = a + b;
    } else if (operation == 2)
    {
        result = a - b;
    } else if (operation == 3)
    {
        result = a * b;
    } else if (operation == 4) {
        result = a / b;
    } else {
        result = Math.Pow(a, b);
    }


    Console.WriteLine("Result is " + result);
    
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



