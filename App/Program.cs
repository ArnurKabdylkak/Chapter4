using Library;

Console.Write("Please, enter a number between 1 and 1000: ");

if (int.TryParse(Console.ReadLine(), out int inputNumber))
{
    Console.WriteLine($"Prime factors of {inputNumber} are: {PrimeUtils.GetPrimeFactors(inputNumber)}");
}
