//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}
int SumOfRangeNumbers (int N, int M)
{

    if (N == M) 
    {
        return N;
    }
    

    else 
    {
        return N + SumOfRangeNumbers(N + 1, M);
    }
        
}
int N = Prompt("Введите число N: ");
int M = Prompt("Введите число M: ");
System.Console.WriteLine($"Сумма чисел от {N} до {M} = {SumOfRangeNumbers(N, M)}");
