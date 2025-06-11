Console.Clear();

Console.WriteLine("");
Console.Write("Número de jogadas: ");
int jogadas = Convert.ToInt32(Console.ReadLine());


int[,] surpresinha = new int[jogadas, 6];

Random gerador = new Random(); //gerador de nm aleatórios

for (int i0 = 0; i0 < jogadas; i0++)
{
    
    for (int i1 = surpresinha.GetLowerBound(1); i1 <= surpresinha.GetUpperBound(1); i1++)
    {
        surpresinha[i0, i1] = gerador.Next(01, 60);
        
        Console.Write($"[{surpresinha[i0, i1]:00}] "); // :00 para exibir dois dígitos
    }
    Console.WriteLine();
}
// Array.Sort(surpresinha); - Organizar
