int x = 1;
int y = 0;

try
{
    int result = x / y;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed.");
}

int negativeNumber = -5;
try
{
    if (negativeNumber < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(negativeNumber), "Value cannot be negative.");
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Argument out of range: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed for negative number check.");
}