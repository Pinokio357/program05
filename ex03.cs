double[] massiv = new double[8];
Random rnd = new Random();
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = rnd.Next(-99, 100);
    Console.Write($" {massiv[i]} ,");
}
double max = massiv[0];
double min = massiv[0];

double GetDifference(double[] array)
{
    double difference = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (max < massiv[i])
            max = massiv[i];
        if (min > massiv[i])
            min = massiv[i];
    }
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    difference = max - min;
    return difference;
}
Console.WriteLine(" ");
Console.WriteLine($"difference= {GetDifference(massiv)}");