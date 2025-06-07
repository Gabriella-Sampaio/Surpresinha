Console.Clear();

Console.WriteLine("");
Console.Write("Número de jogadas: ");
int jogadas = Convert.ToInt32(Console.ReadLine());


int[,] surpresinha = new int[jogadas, 6];

Random gerador = new Random();

for (int i0 = 0; i0 < jogadas; i0++)
{
    for (int i1 = surpresinha.GetLowerBound(1); i1 <= surpresinha.GetUpperBound(1); i1++)
    {
        // Console.WriteLine($"[{i0,i1}] "); ???
    }
    // surpresinha[i, ] = gerador.Next(1, 60);

}

Array.Sort(surpresinha);

foreach (int surpresa in surpresinha)
{
    Console.Write($"[{surpresa}] ");
}