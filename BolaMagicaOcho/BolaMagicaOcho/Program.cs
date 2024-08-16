// See https://aka.ms/new-console-template for more information

string [] respuestas = { "No", "Si", "Tal vez", "Preguntá más tarde", "En 100 años tal vez", "No estoy seguro", 
    "Lo dudo", "...", "No, lo siento, no es el momento adecuado.", "404 respuesta not found", "No puedo responder eso ahora mismo.",
    "Es mejor que no te hagas ilusiones.", "Confía en ti mismo y verás resultados positivos.", "En este momento, no hay claridad.",
    "Sigue tu intuición y encontrarás la respuesta.", "Las estrellas están alineadas a tu favor.", "No es el momento adecuado para eso.",
    "Es una posibilidad, pero requiere esfuerzo.","La respuesta está en tus manos."
};

Console.WriteLine("Bienvenido a la bola mágica de la fortuna, para recibir una respuesta presiona 8");
string respuesta = Console.ReadLine();
Random random = new Random();
int indice = random.Next(respuestas.Length);
if(respuesta == "8")
    Console.WriteLine(respuestas[indice]);