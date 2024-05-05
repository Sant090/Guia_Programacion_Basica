void bin()
{
    int n1 = 0;
    int[] Binarios = { 1, 0, 1, 1, 0 };

    Array.Reverse(Binarios);

    for (int i = 0; i < Binarios.Length; i++)
    {
        if (Binarios[i] == 1)
        {
            n1 += (int)Math.Pow(2, i);
        }
    }
    Console.WriteLine(n1);
}
bin();

