using System;

namespace BlackJack_SimpleGame
{
    class Program
    {
        /// <summary>
        /// Creación de las cartas de la baraja (1 al 11, tomando al A como 11).
        /// </summary>
        /// <returns>La carta aleatorea generada (option)</returns>
        static int Cartas()
        {
            Random rnd = new Random();
            // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11.
            int option = rnd.Next(1, 12);
            return option;
        }

        /// <summary>
        /// Le damos la bienvenida al jugador y mostramos que comienza con 0 cartas.
        /// </summary>
        static int PrimerJuego()
        {
            // El jugador comienza con 0 cartas; 
            int cartasJugador = 0;

            // Mostrar al jugar con cuantas cartas comienza
            Console.WriteLine("¡Bienvenido!, has comenzado con: " + cartasJugador + " cartas.");


            return cartasJugador;

        }

        /// <summary>
        /// Preguntar al usuario si desea un carta.
        /// </summary>
        /// <returns>La decision tomada: Y - Desea cartas, N - no desea cartas</returns>
        static string SolicitarCartas()
        {
            // Y: Yes
            // N: No
            Console.WriteLine("¿Deseas tomar una carta?");
            Console.WriteLine("Y = Deseo una carta");
            Console.WriteLine("N = No deseo una carta");

            string option = Convert.ToString(Console.ReadLine());
            return option;
        }

        /// <summary>
        /// Creación de condicionales (if/else if) para determinar según la opción que eligió el jugar si se le la una carta o no.
        /// Creación de un ciclo para preguntar al usuario si desea otra carta, si es así; se genera un número aleatorio y se suma con el número de cartas del jugador.
        /// Se genera la variable random Acartas (17 - 26), el cúal será el número de la casa.
        /// </summary>
        /// <param name="option"> Opción que el jugador eligio, si solicita cartas (Y) o no (N)</param>
        /// <param name="rancartas">Manda a llamar la varible random para generar un número aleatorio<param>
        /// <param name="cartasJugador">Manda a llamar el número de cartas que tiene el jugador </param>
        static void Tiradas(string option, int rancartas, int cartasJugador)
        {
            //Cartas aleatorias del AI
                Random rnd2 = new Random();
                // 17, 18, 19, 20, 21, 22, 23, 24, 25, 26.
                int Acartas = rnd2.Next(16, 26);

            while (option == "Y")
            {
                Random rnd = new Random();
                // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11.
                int rancartas2 = rnd.Next(1, 12);
                int sum = cartasJugador + rancartas2;
                cartasJugador = sum;


                Console.WriteLine("Carta aleatoria: " + rancartas2);
                Console.WriteLine("Su número de cartas actual es: " + cartasJugador);

                if (cartasJugador > 21)
                {
                    Console.WriteLine("Pierdes");
                    Console.WriteLine("El número de cartas que tiene la casa es: " + Acartas);

                    break;
                }
                else
                {
                    Console.WriteLine("¿Deseas tomar una carta?");
                    Console.WriteLine("Y = Deseo una carta");
                    Console.WriteLine("N = No deseo una carta");

                    option = Convert.ToString(Console.ReadLine());

                }

            }
            if (option == "N")
            {
                Console.WriteLine("Su número de cartas actual es: " + cartasJugador);

                Console.WriteLine("El número de cartas que tiene la casa es: " + Acartas);
            }
        }

        static void Main(string[] args)
        {
            // TODO: El jugador comienza con un manojo de cartas vacio
            int cartasJugador = PrimerJuego();

            // TODO: Preguntar al jugar si desea quedarse con las cartas que tiene, o si solicita una carta.
            string option = SolicitarCartas();
            Console.WriteLine("Opción seleccionada: " + option);

            // Mostrar aleatoreamente una carta de la baraja.
            int rancartas = Cartas();

            // TODO: Si el jugador solicita una carta, generar aleatoriamente una carta de una baraja y agregarla a las cartas que tiene el jugador.
            // TODO: Calcular el valor de las cartas que tiene el jugador (numérico) y mostrarlo cada vez que el jugador obtenga una carta. Considerar el valor del as como 11.
            // Cuando el jugador se detenga, generar aleatoriamente un número entre el 17 y el 26 (incluyendo ambos números). Este será el valor de "la casa" contra el cual debe competir el número obtenido por las cartas del jugador.
            Tiradas(option, rancartas, cartasJugador);

        }
    }
}