int? n = null; // ? aplicação do Nullable

if (n == null)
{
    Console.WriteLine("Valor nulo");
}

if (!n.HasValue)
{
    Console.WriteLine("Valor nulo");
}

int x = n ?? 0; // ?? aplicação do coalesce

Console.WriteLine(x);
