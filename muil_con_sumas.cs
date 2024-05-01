void multi1()
{
    Console.WriteLine("ingrese el primer numero que desea usar en la multiplicacion");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ingrese el segundo numero que desea usar en la multiplicacion");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int n4 = 0;
    if (n2== 0)
    {
        Console.WriteLine($"el resultado dd multiplicar {n1} y {n2} es 0");
    }
    else
    {
        if (n1 == 0)
        {
            Console.WriteLine($"el resultado dd multiplicar {n1} y {n2} es 0");
        }
        else
        {
            for (int n3 = n2; n3 > 0; n3--)
            {
                n4 = n4 + n1;

                if (n3 == 1)
                    Console.WriteLine($"el resultado dd multiplicar {n1} y {n2} es {n4}");
            }
        }
    }
}
multi1();
