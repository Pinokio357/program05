int[] massiv = new int[8];
Random rnd = new Random();
for(int i =0; i < massiv.Length; i++)
    {
    massiv[i] = rnd.Next(-99, 100);
    Console.Write($" {massiv[i]} ,");
    }
int GetSum(int[] array)
    {
    int oddsum = 0;
    for (int i = 1; i < massiv.Length; i += 2)
        oddsum += massiv[i];
        return oddsum;
    }
Console.WriteLine(" ");
Console.WriteLine($"odd sum = {GetSum(massiv)}");