//Hi, en esta seccion se piden los nombres

Console.WriteLine("Ingrese el nombre del primer individuo: ");
string n1 = Console.ReadLine();
Console.WriteLine("Ingrese el nombre del segundo individuo: ");
string n2 = Console.ReadLine();
Console.WriteLine("Ingrese el nombre del tercero individuo: ");
string n3 = Console.ReadLine();
Console.WriteLine("Ingrese el nombre del cuarto individuo: ");
string n4 = Console.ReadLine();
Console.WriteLine("Ingrese el nombre del quinto individuo: ");
string n5 = Console.ReadLine();


//en esta seccion se pide las 5 notas de n1 osea del primer individuo

Console.WriteLine($"Ingrese la primer nota de {n1}:");
decimal m11 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la segunda nota de {n1}:");
decimal m12 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la tercer nota de {n1}:");
decimal m13 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la cuarta nota de {n1}:");
decimal m14 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la quinta nota de {n1}:");
decimal m15 = Convert.ToDecimal(Console.ReadLine());


//en esta seccion se pide las 5 notas de n2 osea del segundo individuo

Console.WriteLine($"Ingrese la primer nota de {n2}:");
decimal m21 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la segunda nota de {n2}:");
decimal m22 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la tercer nota de {n2}:");
decimal m23 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la cuarta nota de {n2}:");
decimal m24 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la quinta nota de {n2}:");
decimal m25 = Convert.ToDecimal(Console.ReadLine());


//lo de arriba pero con n3

Console.WriteLine($"Ingrese la primer nota de {n3}:");
decimal m31 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la segunda nota de {n3}:");
decimal m32 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la tercer nota de {n3}:");
decimal m33 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la cuarta nota de {n3}:");
decimal m34 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la quinta nota de {n3}:");
decimal m35 = Convert.ToDecimal(Console.ReadLine());


//lo de arriba pero con n4

Console.WriteLine($"Ingrese la primer nota de {n4}:");
decimal m41 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la segunda nota de {n4}:");
decimal m42 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la tercer nota de {n4}:");
decimal m43 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la cuarta nota de {n4}:");
decimal m44 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la quinta nota de {n4}:");
decimal m45 = Convert.ToDecimal(Console.ReadLine());



//lo de arriba pero con n5

Console.WriteLine($"Ingrese la primer nota de {n5}:");
decimal m51 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la segunda nota de {n5}:");
decimal m52 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la tercer nota de {n5}:");
decimal m53 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la cuarta nota de {n5}:");
decimal m54 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Ingrese la quinta nota de {n5}:");
decimal m55 = Convert.ToDecimal(Console.ReadLine());


//aca se suman las notas para cada uno y se suman los promedios ( pueden hacer lo mismo en el console.writeline si no quieren ocupar tanto espacio)

decimal mn1 = (m11 + m12 + m13 + m14 + m15) / 5;
decimal mn2 = (m21 + m22 + m23 + m24 + m25) / 5;
decimal mn3 = (m31 + m32 + m33 + m34 + m35) / 5;
decimal mn4 = (m41 + m42 + m43 + m44 + m45) / 5;
decimal mn5 = (m51 + m52 + m53 + m54 + m55) / 5;



//aca se muestran los promedios

Console.WriteLine($"{n1} tiene un promedio de {mn1}");
Console.WriteLine($"{n2} tiene un promedio de {mn2}");
Console.WriteLine($"{n3} tiene un promedio de {mn3}");
Console.WriteLine($"{n4} tiene un promedio de {mn4}");
Console.WriteLine($"{n5} tiene un promedio de {mn5}");



//aca se hacen el if en orden promedio == 5, promedio > 4, promedio >= 3, promedio < 3 y el ultimo por si acaso. se hace de esta forma escalonada debido
//a que si no se hace en ese orden puede cumplir una condicion diferente, asi se va descartando

if (mn1 == 5)
    {
        Console.WriteLine($"{n1} tiene notas Excelentes *Clap Clap*");
    }
else
        {
            if (mn1 > 4)
            {
                Console.WriteLine($"{n1} esta Super Aprobado");
            }
            else 
            { 
                if (mn1 >= 3)
                {
                    Console.WriteLine($"{n1} esta aprobado");
                }
                else
                {
                    if (mn1 < 3)
                    {
                        Console.WriteLine($"{n1} tiene notas decepcionantes");
                    }
                    else
                    {
                        Console.WriteLine($"Las notas de {n1} no estan en el rango de 0 a 5");
                    }
                }
            }
        }

if (mn2 == 5)
{
    Console.WriteLine($"{n2} tiene notas Excelentes *Clap Clap*");
}
else
{
    if (mn2 > 4)
    {
        Console.WriteLine($"{n2} esta Super Aprobado");
    }
    else
    {
        if (mn2 >= 3)
        {
            Console.WriteLine($"{n2} esta aprobado");
        }
        else
        {
            if (mn2 < 3)
            {
                Console.WriteLine($"{n2} tiene notas decepcionantes");
            }
            else
            {
                Console.WriteLine($"Las notas de {n2} no estan en el rango de 0 a 5");
            }
        }
    }
}

if (mn3 == 5)
{
    Console.WriteLine($"{n3} tiene notas Excelentes *Clap Clap*");
}
else
{
    if (mn3 > 4)
    {
        Console.WriteLine($"{n3} esta Super Aprobado");
    }
    else
    {
        if (mn3 >= 3)
        {
            Console.WriteLine($"{n3} esta aprovado");
        }
        else
        {
            if (mn3 < 3)
            {
                Console.WriteLine($"{n3} tiene notas decepcionantes");
            }
            else
            {
                Console.WriteLine($"Las notas de {n3} no estan en el rango de 0 a 5");
            }
        }
    }
}

if (mn4 == 5)
{
    Console.WriteLine($"{n4} tiene notas Excelentes *Clap Clap*");
}
else
{
    if (mn4 > 4)
    {
        Console.WriteLine($"{n4} esta Super Aprobado");
    }
    else
    {
        if (mn4 >= 3)
        {
            Console.WriteLine($"{n4} esta aprobado");
        }
        else
        {
            if (mn4 < 3)
            {
                Console.WriteLine($"{n4} tiene notas decepcionantes");
            }
            else
            {
                Console.WriteLine($"Las notas de {n4} no estan en el rango de 0 a 5");
            }
        }
    }
}

if (mn5 == 5)
{
    Console.WriteLine($"{n5} tiene notas Excelentes *Clap Clap*");
}
else
{
    if (mn5 > 4)
    {
        Console.WriteLine($"{n5} esta Super Aprobado");
    }
    else
    {
        if (mn5 >= 3)
        {
            Console.WriteLine($"{n5} esta aprovado");
        }
        else
        {
            if (mn5 < 3)
            {
                Console.WriteLine($"{n5} tiene notas decepcionantes");
            }
            else
            {
                Console.WriteLine($"Las notas de {n5} no estan en el rango de 0 a 5");
            }
        }
    }
}
