void multi1()
{
    Console.WriteLine("ingrese el numero que desea hallar el factorial");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int sol = 1;
    for (int n3 = n1; n3 > 1; n3--)
    {
        sol = n3 * sol;
    }

    Console.WriteLine($"el factorial de {n1} es {sol}");
}

multi1();
