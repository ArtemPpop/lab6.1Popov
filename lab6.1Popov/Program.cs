try
{
    Console.Write("Введите число:");
    int n = int.Parse(Console.ReadLine());
    int largDigit = FindLargDigit(n);
    Console.Write("самое большое число: " + largDigit);
    int FindLargDigit(int num)
    {
        if (num < 10);

        else
        {
            int LastDigit = num % 10;
            int RemDigit = num / 10;
            int MaxRem = FindLargDigit(RemDigit);
            return Math.Max(LastDigit, MaxRem);
        }

        {
            return num;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
