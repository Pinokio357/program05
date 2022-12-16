int[] massiv = new int[8];
Random rnd = new Random();
for(int i =0; i < massiv.Length; i++)
    {
    massiv[i] = rnd.Next(100, 1000);
    Console.Write($" {massiv[i]} ,");
    }

int count = 0;



int GetEvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < massiv.Length; i++)
        if ((massiv[i]) % 2 == 0)
            count += 1;
    return count;
}
Console.WriteLine(" ");
Console.WriteLine($"even count= {GetEvenCount(massiv)}");