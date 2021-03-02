# Black Jack

_Código simple para el juego Black Jack (21), desde la consola._

## Puntos a desarrollar

_Puntos (del 1 al 10) de la forma en la que esta desarrollado:_

* **1.** El jugador comienza con un conjunto de cartas vacío.
* **2.** Preguntar al jugador si desea quedarse con las cartas que tiene, o si solicita una carta.
* **3.** Si el jugador solicita una carta, generar aleatoriamente una carta de una baraja y agregarla a las cartas que tiene el jugador.
* **4.** Calcular el valor de las cartas que tiene el jugador (numérico) y mostrarlo cada vez que el jugador obtenga una carta. Considerar el valor del as como 11.
* **5.** Volver a preguntar al jugador lo mismo que en el paso (2), hasta que el jugador decida detenerse o hasta que se pase de 21.
* **6.** Cuando el jugador se detenga, generar aleatoriamente un número entre el 17 y el 26 (incluyendo ambos números). Este será el valor de "la casa" contra el cual debe competir el número obtenido por las cartas del jugador.
* **7.** Mostrar los números obtenidos por el jugador y por la casa.
* **8.** Comparar ambos números mostrados para determinar el ganador, y mostrar el resultado.
* **9.** Modificar el valor del as; tomarlo con valor de 11 cuando sea posible hacerlo sin que el número total del jugador sobrepase el límite de 21, o en caso contrario tomarlo con valor de 1.
* **10.** Modificar la lógica de inicio de juego para entregar la primer tarjeta al jugador automáticamente sin que lo solicite.


### Forma de definir al ganador 

_El jugador gana cuando:_
* El jugador obtiene un 21 y la casa obtiene un número menor.
* La casa obtiene un número mayor a 21 y el jugador obtiene un número menor o igual que 21.
* El jugador y la casa obtienen un número menor o igual a 21, pero el jugador obtiene un número más alto.
* El jugador y la casa obtienen el mismo número, siendo este un número menor o igual a 21, pero el jugador lo hace con menos cartas.

_Hay un empate cuando:_
* Ambos obtienen un número mayor a 21.
* Ambos obtienen un número menor o igual a 21, con el mismo número de cartas

En caso contrario a los anteriores, el jugador pierde.


## Estructura (Rama: dev)

_Explicación de la forma en la que el código esta estructurado._

### Creación de las cartas.

_Creación de las cartas de la baraja (Del 1 al 11, tomando al AS como 11), con el metodo:_

```
 static int Cartas()
```

### Primer juego.

_Se le da la bienvenida al jugador de manera en la que se muestren las cartas que tienen._
_(fix) Se modifico el punto 1 por el punto 10. Las cartas del jugador no es siempre 0, ahora se generaron dos cartas de forma aleatoria del 1 al 11._

```
 static int Cartas()
```

### Dar cartas al jugador
_Se pregunta al usuario si desea un carta._
_Si es así se le dan dos opciones Y = Si, N = No.

```
 static string SolicitarCartas()
```

### Comienzo de la partida.

_Se crea una condicional con if/else para determinar si el jugador decidió tomar o no una carta._
_Cuando el jugador desea otra carta comienza un cilo, el cual repetirá la pregunta de tomar una carta o no-
```
 while (option == 'Y')
 {

 }
``` 
_El ciclo se detiene cuando el jugador decide presionar la tecla "N" o cuando el total de las cartas es mayor a 21._
_Se implementa una variable 'suma', la cual; Suma el total de cartas que tiene el jugador con el número de cartas que tiene la casa._
_Para que la casa pueda jugar, se implemento de manera aleatoria un rango de números del 16 al 26. Esta se agrega en la variable "ACartas"._
_(fix) Creación de condicional if, para en caso de que en la parrida de un 11 y se pasa de 21 al momento de hacer la suma, se remplaza el 11 por un 1._
_Por último se manda a llamar el metodo:_

```
 static void Ganar(int Acartas, int cartasJugador)
```
_Para mostrar un ganador cuando termine la partida._


### Determinar un ganador.

_Con base a las reglas anteriores, implementa condicionales, de manera que se pueda definir un ganador entre la casa y el jugador._
_(Revisar el punto anterior: "Forma de definir un ganador")

```
 static void Ganar(int Acartas, int cartasJugador)
```
_El metodo implementado contiene las variables: ACartas(Número de cartas que tiene la casa. Del 16 al 26), y cartasJugador(Número de cartas que tiene el jugador. Del 1 al 11).

### Metodo Main.

_Este metodo es utilizado para mandar a llamar todos los metodos que se mostrarán en la terminal._
_Metodos mandados llamar:_

```
 int cartasJugador = PrimerJuego();
 string option = SolicitarCartas();
 int rancartas = Cartas();
 Tiradas(option, rancartas, cartasJugador);
```

## Notas adicionales 

_Ejemplificación de la partida en ejecución._

*La manera en la que se muestra una partida es la siguiente:

```
 ¡Bienvenido! has comenzado con 2 cartas: (Carta aleatoria1) y (Carta aleatoria2).
 Su número de cartas actual es: (Suma de las cartas aleatorias 1 y 2).
 ¿Desea tomar 1 carta?
 Y = Deseo una carta.
 N = No deseo una carta.
 Y (En caso de desear una carta)
 Opción seleccionada: Y
 Carta aleatoria: (random)
 Su número de cartas actual es: (Suma de cartas aleatorias 1, 2 y random)
```
El ciclo se repite hasta comprobar un ganador.

*La forma en la que se remplaza el AS 11, por un 1 es la siguiente:
_Ejemplificación de la consola._

```
 ¡Bienvenido! has comenzado con 2 cartas: (Carta aleatoria1) y (Carta aleatoria2).
 Su número de cartas actual es: (Suma de las cartas aleatorias 1 y 2).
 ¿Desea tomar 1 carta?
 Y = Deseo una carta.
 N = No deseo una carta.
 Y (En caso de desear una carta)
 Opción seleccionada: Y
 Carta aleatoria: (random)
 Adquiriste un AS, el número 11 pasa a ser 1.
 Su número de cartas actual es: (Suma de cartas aleatorias 1, 2 y random)
```


## Autor

* **Jessica Hernández** - *Trabajo Inicial* - [JessieGue09](https://github.com/JessieGue09)



