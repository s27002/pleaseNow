// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Worldd!");
Console.WriteLine("Hello, Worlddd!");
Console.WriteLine("Hello, Worldddd!");
Console.WriteLine("Hello, Worlddsdsddd!");

int[] num = {1, 2, 3, 4, 5};
Console.WriteLine(CalculateAverage(num));

double CalculateAverage(int[] t) {
    int sum = 0;
    foreach(int num in t) 
        sum += num; 
    return (double)sum/t.Length;
}