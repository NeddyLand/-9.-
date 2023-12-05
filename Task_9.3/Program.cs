uint Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    uint result = Convert.ToUInt32(value);

    return result;
}
uint A(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
     if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}
uint m = Prompt("Введите число m: ");
uint n = Prompt("Введите число n: ");
System.Console.WriteLine($"Функция А({m},{n}) = {A(m, n)}");
