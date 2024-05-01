using System;

int EU = 0;
int ronda = 0;
int PuntosBot = 0;
int PuntosUser = 0;
Random rnd = new Random();
int bot = 0;

Console.WriteLine("Ingresa tu nombre para jugar piedra, papel, tijera, lagarto o spock");
string name = Console.ReadLine();
Console.WriteLine("\nLas opciones a elegir es \n- Piedra es #1\n- Papel es #2\n- Lagarto es #4\n- Spock es #5");
while (ronda < 5)
{
    rnd.Next(1, 4);
    bot = rnd.Next(1, 6);
    Console.WriteLine($"El marcador actual es de {PuntosBot} puntos para el bot y {PuntosUser} puntos para {name}");
    Console.WriteLine("Ingresa tu Opcion.");
    EU = Convert.ToInt32(Console.ReadLine());
    if (EU == 1)
    {
        Console.WriteLine("\nElegiste Piedra");
        if (bot == 1)
        {
            Console.WriteLine("\nEl bot eligio piedra");
            Console.WriteLine("Oh, ambos sacaron Piedra, se reinicia.");
        }
        else
        {
            if (bot == 2)
            {
                Console.WriteLine("\nEl bot eligio papel");
                Console.WriteLine($"Oh no, papel cubre piedra, el bot gana un punto");
                PuntosBot++;
                ronda++;
            }
            else
            {
                if (bot == 3)
                {
                    Console.WriteLine("\nEl bot eligio tijeras");
                    Console.WriteLine($"Oh genial, piedra rompe tijeras, {name} gana un punto");
                    PuntosUser++;
                    ronda++;
                }
                else
                {
                    if (bot == 4)
                    {
                        Console.WriteLine("\nEl bot eligio lagarto");
                        Console.WriteLine($"Oh genial, piedra aplasta Lagarto, {name} gana un punto");
                        PuntosUser++;
                        ronda++;
                    }
                    else 
                    {
                        if (bot == 5)
                        {
                            Console.WriteLine("\nEl bot eligio Spock");
                            Console.WriteLine($"Oh no, Spock evaporiza piedra, el bot gana un punto");
                            PuntosBot++;
                            ronda++;
                        }
                    }
                }
            }

        }

    }

    if (EU == 2)
    {
        Console.WriteLine("Elegiste Papel");
        if (bot == 2)
        {
            Console.WriteLine("\nEl bot eligio papel");
            Console.WriteLine("Oh, ambos sacaron papel, se reinicia.");
        }
        else
        {
            if (bot == 3)
            {
                Console.WriteLine("\nEl bot eligio tijeras");
                Console.WriteLine($"Oh no, tijeras rompe papel, el bot gana un punto");
                PuntosBot++;
                ronda++;
            }
            else
            {
                if (bot == 1)
                {
                    Console.WriteLine("\nEl bot eligio piedra");
                    Console.WriteLine($"Oh genial, papel cubre piedra, {name} gana un punto");
                    PuntosUser++;
                    ronda++;
                }
                else 
                {
                    if (bot == 4)
                    {
                        Console.WriteLine("\nEl bot eligio lagarto");
                        Console.WriteLine($"Oh no, Lagarto devora papel, el bot gana un punto");
                        PuntosBot++;
                        ronda++;
                    }
                    else
                    {
                        if (bot == 5)
                        {
                            Console.WriteLine("\nEl bot eligio Spock");
                            Console.WriteLine($"Oh genial, papel desautoriza Spock, {name} gana un punto");
                            PuntosUser++;
                            ronda++;
                        }
                    }
                }
            }

        }

    }

    if (EU == 3)
    {
        Console.WriteLine("Elegiste tijeras");
        if (bot == 3)
        {
            Console.WriteLine("El bot eligio tijeras");
            Console.WriteLine("\nOh, ambos sacaron tijeras, se reinicia.");
        }
        else
        {
            if (bot == 1)
            {
                Console.WriteLine("\nEl bot eligio piedra");
                Console.WriteLine($"\nOh no, piedra rompe tijeras, el bot gana un punto");
                PuntosBot++;
                ronda++;
            }
            else
            {
                if (bot == 2)
                {
                    Console.WriteLine("\nEl bot eligio papel");
                    Console.WriteLine($"\nOh genial, tijeras corta papel, {name} gana un punto");
                    PuntosUser++;
                    ronda++;
                }
                else 
                {
                    if (bot == 4)
                    {
                        Console.WriteLine("\nEl bot eligio lagarto");
                        Console.WriteLine($"Oh genial, Tijera decapita lagarto, {name} gana un punto");
                        PuntosUser++;
                        ronda++;
                    }
                    else
                    {
                        if (bot == 5)
                        {
                            Console.WriteLine("\nEl bot eligio Spock");
                            Console.WriteLine($"\nOh no, Spock rompe tijeras, el bot gana un punto");
                            PuntosBot++;
                            ronda++;
                        }
                    }
                }
            }
        }

    }

    if (EU == 4)
    {
        Console.WriteLine("Elegiste lagarto");
        if (bot == 4)
        {
            Console.WriteLine("El bot eligio lagarto");
            Console.WriteLine("\nOh, ambos sacaron lagarto, se reinicia.");
        }
        else
        {
            if (bot == 1)
            {
                Console.WriteLine("\nEl bot eligio piedra");
                Console.WriteLine($"\nOh no, piedra aplasta lagarto, el bot gana un punto");
                PuntosBot++;
                ronda++;
            }
            else
            {
                if (bot == 2)
                {
                    Console.WriteLine("\nEl bot eligio papel");
                    Console.WriteLine($"\nOh genial, lagarto devora papel, {name} gana un punto");
                    PuntosUser++;
                    ronda++;
                }
                else
                {
                    if (bot == 3)
                    {
                        Console.WriteLine("\nEl bot eligio Tijera");
                        Console.WriteLine($"\nOh no, Tijera decapita Lagarto, el bot gana un punto");
                        PuntosBot++;
                        ronda++;
                    }
                    else
                    {
                        if (bot == 5)
                        {
                            Console.WriteLine("\nEl bot eligio Spock");
                            Console.WriteLine($"\nOh genial, lagarto envenena a Spock, {name} gana un punto");
                            PuntosUser++;
                            ronda++;
                        }
                    }
                }
            }
        }

    }

    if (EU == 5)
    {
        Console.WriteLine("Elegiste Spock");
        if (bot == 5)
        {
            Console.WriteLine("El bot eligio Spock");
            Console.WriteLine("\nOh, ambos sacaron Spock, se reinicia.");
        }
        else
        {
            if (bot == 1)
            {
                Console.WriteLine("\nEl bot eligio piedra");
                Console.WriteLine($"\nOh genial, spock evaporiza piedra, {name} gana un punto");
                PuntosUser++;
                ronda++;
            }
            else
            {
                if (bot == 2)
                {
                    Console.WriteLine("\nEl bot eligio papel");
                    Console.WriteLine($"\nOh no, Papel desautoriza a Spock, el bot gana un punto");
                    PuntosBot++;
                    ronda++;
                }
                else
                {
                    if (bot == 3)
                    {
                        Console.WriteLine("\nEl bot eligio Tijera");
                        Console.WriteLine($"\nOh genial, spock aplasta tijera, {name} gana un punto");
                        PuntosUser++;
                        ronda++;
                    }
                    else
                    {
                        if (bot == 4)
                        {
                            Console.WriteLine("\nEl bot eligio Spock");
                            Console.WriteLine($"\nOh no, Lagarto envenena a Spock, el bot gana un punto");
                            PuntosBot++;
                            ronda++;
                        }
                    }
                }
            }
        }

    }

    if (EU >= 6)
    {
        Console.WriteLine($"{name} toma un numero valido");
    }

}


Console.WriteLine($"El marcador final es de {PuntosBot} puntos para el bot y {PuntosUser} puntos para el usuario.");

if (PuntosBot < PuntosUser)
{
    Console.WriteLine($"{name} Le ganaste al bot, felicidades.");
}
else
{
    Console.WriteLine($"{name} Perdiste contra el Bot, sigue intentando.");
}



