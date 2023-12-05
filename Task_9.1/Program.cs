int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}
int PrintSequenceOfNumbers (int N)
{

    if (N == 1) 
    {
        System.Console.Write($"{N} ");
        return 1;
    }
    

    else 
    {
        System.Console.Write($"{N} ");
        return PrintSequenceOfNumbers(N - 1);
    }
        
}
int N = Prompt("Введите число N: ");
PrintSequenceOfNumbers(N);