void primo()
{
    Console.WriteLine("ingrese el numero a evaluar");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int ct = 0;
    int sol = 0;

    for (int i = n1 - 1; i > 0; i--)
    {

        sol = n1 % i;
        if (sol == 0)
        {
            ct++;
        }
    }
    if (ct>2)
    {
        Console.WriteLine($"{n1} no es un numero primo");
    }
    else
    {
        Console.WriteLine($"{n1} es un numero primo");
    }

}
primo();
