string NumberRec(int a, int b)
{
    if (a <=  b) return $"{a} " + NumberRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumberRec(1,10));
