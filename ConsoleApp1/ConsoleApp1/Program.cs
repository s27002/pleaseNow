// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Worldd!");
Console.WriteLine("Hello, Worlddd!");
Console.WriteLine("Hello, Worldddd!");
Console.WriteLine("Hello, Worlddsdsddsfdsf!");

int[] num = {1, 2, 3, 4, 5};
Console.WriteLine(CalculateAverage(num));
Console.WriteLine(FindMax(num));

double CalculateAverage(int[] t) {
    int sum = 0;
    for(int i = 0; i < t.Length; i++) 
        sum += t[i]; 
    return (double)sum/t.Length;
}

int FindMax(int[] t){ 
    int max = t[0];
    for(int i = 1; i < t.Length; i++)
        if (t[i] > max)
            max = t[i];
    return max;
}