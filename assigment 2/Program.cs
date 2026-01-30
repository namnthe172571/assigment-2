// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

private Double calculate(SIGN sign, Double arg1, Double arg2)
{
    Double result = 0;
    switch (sign)
    {
        case MULTIPLY:
            result = arg1 * arg2;
            break;
    }
    return result;
}