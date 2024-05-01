int multi2(int n1, int n2)
{
    int n4 = 0;
    if (n2== 0)
    {
        n4 = 0;
    }
    else
    {
        if (n1 == 0)
        {
            n4 = 0;
        }
        else
        {
            for (int n3 = n2; n3 > 0; n3--)
            {
                n4 = n4 + n1;
            }
        }
    }
    return n4;
}

void potencia()
{
    Console.WriteLine("ingrese la base");
    int nb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ingrese el exponente");
    int ne = Convert.ToInt32(Console.ReadLine());
    int sol = 1;
    for (int n5 = 0; n5 < ne; n5++)
    {
        sol = multi2(sol, nb);
    }
    Console.WriteLine($"el resultado de potenciar {nb} a la {ne} es {sol}");
}
potencia();
