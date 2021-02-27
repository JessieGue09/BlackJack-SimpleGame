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
            int option = rnd.Next(1,12);
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
        /// Se genera la variable suma, la cual suma las cartas actuales del jugador con las que se les da y muestra cuantas tiene.   
        /// </summary>
        /// <param name="option">Opción que el jugador eligio, si solicita cartas (Y) o no (N)</param>
        /// <param name="rancartas">Cartas que la casa da al jugador (cartas random)</param>
        /// <param name="cartasJugador">Numero de cartas que tiene actualmente el jugaor</param>
        static void Tiradas(string option, int rancartas, int cartasJugador)
        {
            int suma = cartasJugador + rancartas;

            if (option == "Y")
            {
                Console.WriteLine("Carta aleatorea: " +  rancartas);
                Console.WriteLine("Su número de cartas actual es: " + suma);
            } 
            else if(option == "N")
            {
                Console.WriteLine("Su número de cartas actual es: " + cartasJugador);
            }
            else 
            {
                Console.WriteLine("Comando invalido");
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
            Tiradas(option, rancartas, cartasJugador);
        }
    }
}
