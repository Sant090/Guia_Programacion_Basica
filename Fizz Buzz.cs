﻿
void juego()
{
    int EU = 0;
    int ronda = 0;
    int PuntosBot = 0;
    int PuntosUser = 0;
    Random rnd = new Random();
    int bot = 0;

    Console.WriteLine("Ingresa tu nombre para jugar piedra papel o tijera.");
    string name = Console.ReadLine();
    Console.WriteLine("\nLas opciones a elegir es \n- Piedra es #1\n- Papel es #2\n- Tijera es #3");
    while (ronda < 5)
    {
        rnd.Next(1, 4);
        bot = rnd.Next(1, 3);
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
                        Console.WriteLine($"Oh genial, roca rompe tijeras, {name} gana un punto");
                        PuntosUser++;
                        ronda++;
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
                }

            }

        }

        if (EU >= 4)
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
}

juego();