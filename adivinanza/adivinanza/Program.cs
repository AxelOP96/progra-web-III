﻿
/*
 * En Clase Juego de adivinanza + Unit tests
Crear un nuevo juego que contemple que el usuario pueda ingresar un numero maximo, y luego debe adivinar cual es el numero elegido por la computadora, donde en cada intento de adivinar, la computadora le dice, "helado", "frio", "tibio", "caliente", "ardiente". Ejemplo:

Ingrese nro maximo:
100
Ya elegi un nro, Adivine:
50
Tibio
60
Frio
40
Caliente
42
Ardiente
43
Muy bien ha adivinado! el nro que habia elegido era 43! lo ha adivinado en 5 intentos!
 */
Console.WriteLine("Bienvenido al juego de adivinanza, ingrese un numero limite:");
int limite = int.Parse(Console.ReadLine());
Random random = new Random();
int aleatorio = random.Next(1, limite);
//Console.WriteLine(aleatorio);
int contador = 0;
int eleccion = 0;
Console.WriteLine("Ya elegi un nro, Adivine:");
while (eleccion != aleatorio)
{
    
    eleccion = int.Parse(Console.ReadLine());
    contador++;
    if(eleccion == aleatorio)
    {
        Console.WriteLine($"Muy bien ha adivinado! el nro que habia elegido era {aleatorio}! lo ha adivinado en {contador} intentos!");
    }
    else if ((eleccion - aleatorio) == -1 || (aleatorio - eleccion) == 1 || (eleccion - aleatorio) == 1)
    {
        Console.WriteLine("Ardiente...");
    }
    else if (((eleccion - aleatorio) <= 10 && (eleccion - aleatorio) > 1) 
        //|| (aleatorio - eleccion < -1 && aleatorio-eleccion >= -10)
        || (eleccion - aleatorio >= -10 && eleccion - aleatorio < -1))
    {
        Console.WriteLine("Caliente...");
    }
    else if (((eleccion - aleatorio) <= 20 && (eleccion - aleatorio) > 11)
        || (eleccion - aleatorio >= -20 && eleccion - aleatorio <= -11))
    {
        Console.WriteLine("Tibio...");
    }
    else if (((eleccion - aleatorio) <= 35 && (eleccion - aleatorio) > 21)
        || (eleccion - aleatorio >= -35 && eleccion - aleatorio <= -21))
    {
        Console.WriteLine("Frio");
    }
    else
    {
        Console.WriteLine("Helado... seguro sos de riber");
    }
}
