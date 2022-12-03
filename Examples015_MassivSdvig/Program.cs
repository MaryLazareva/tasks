void Massiv(int n, int k)
{
    int[] array = new int[n];
    int[] arrayNew = new int[n];
    for (int i = 0; i < n;i++)
    {
        array[i] = new Random().Next(10);
        Console.Write($"{array[i]} ");   
    }

    Console.WriteLine();
    int j = 0;

    if (k > 0)
    {   
        for (int i = 0; i<n; i++)
        {
            if (i+k <= n-1)
            
                arrayNew[i+k] = array[i];
                
            else
            {
                arrayNew[j] = array[i];
                j++;
            }
        }   
    }       
    else
        for (int i = 0; i<n; i++)
        {
            if ( i - k <= n-1)
            
                arrayNew[i] = array[i-k];
            
            else
            {
                arrayNew[i] = array[j];
                j++;
            }
        } 

    for (int i = 0; i < n; i++)
        Console.Write($"{arrayNew[i]} ");          
}

Console.WriteLine("Введите число элементов массива:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число, на которое делать сдвиг:");
int K = int.Parse(Console.ReadLine());
Massiv(N, K);