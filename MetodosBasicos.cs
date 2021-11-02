#region Ejercicio1
/*
Escribe el resultado de ejecutar este programa y comenta el motivo de la salida.
Nota: Puedes ayudarte con la traza.
    class Program {
        static void Eleva(int a) {
            a = a * a;
        }
        static void Main() {
            Console.Clear();
            for (int a = 0; a < 10; a = a + 2) {
            Eleva(a);
            Console.WriteLine(a);
            }
        }
    }

    Esta elevando por 2 cada vez que recorre el for, pero por consola te devuelve solo la suma de 2, en lugar de pasarte lo que te da
    el metodo elevado EJ:
    Primero da 0, como no tiene nada que elevar, se queda en 0.
    Segundo da 2, como si que tiene que elevar, se pasa a 4.
    Tercero da 4, pasa a dar 16.
    Cuarto da 6, pasa a 32.
    Quinto da 8, pasa a 64.
    Pero como todos tienen la misma variable para funcionar, cuando vuelve al for tras llamar a metodo elevar, este, recupera el valor
    inicial.

*/
#endregion

#region Ejercicio2
/*
Diseña una función denominada Eleva, que calcule x elevado a n, dados ambos como parámetro.
Una vez definido, integra dicha función en un programa que calcule e imprima el resultado de la
siguiente expresión, siendo x, y, m tres números enteros introducidos por teclado.

    static double Elevados(int x, int y, int m) {
        return (Math.Pow(x, 4) + Math.Pow(y, m))/2;
    }
    static void Main() {
        Console.Clear();
        System.Console.WriteLine("Inserta un número entero para 'x': ");
        int x = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Inserta un número entero para 'y': ");
        int y = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Inserta un número entero para 'm': ");
        int m = int.Parse(Console.ReadLine());

        double resultadoElevado = Elevados(x, y, m);

        System.Console.WriteLine($"El resultado es: {resultadoElevado}");
    }
*/
#endregion

#region Ejercicio3
/*
Escribe un algoritmo que, dados por teclado cinco días de la semana, escritos en forma de
número, muestre el nombre del día asociado a cada uno de ellos.
Para ello, implementa el procedimiento DiaSemana, que dado un número escriba en pantalla el
día correspondiente (utilizando switch).. .
Nota: el parámetro del procedimiento será de entrada y por referencia. Además deberá
comprobar que el número de entrada esté en el rango de 1 a 7 indicando, si es necesario, que la
entrada no ha sido valida.

    static string diaSem(int diaSem) {
        string mensaje;
        switch(diaSem) {
            case 1:
                mensaje = "Lunes";
                break;
            case 2:
                mensaje = "Martes";
                break;
            case 3:
                mensaje = "Miércoles";
                break;
            case 4:
                mensaje = "Jueves";
                break;
            case 5:
                mensaje = "Viernes";
                break;
            case 6:
                mensaje = "Sabado";
                break;
            case 7:
                mensaje = "Domingo";
                break;
            default:
                mensaje = "Entrada no válida";
                break;
        }
        return mensaje;
    }
    static void Main() {
        Console.Clear();
        System.Console.WriteLine("Inserte un dia de la semana (1-7): ");
        int diaSemX = int.Parse(Console.ReadLine());

        string mensaje = diaSem(diaSemX);
        
        System.Console.WriteLine($"Elegiste el dia de la semana {diaSemX} que es {mensaje}");
    }
*/
#endregion

#region Ejercicio4
/*
Implementa un programa en C# con una función que admita como argumentos dos números
enteros (m y n) y devuelva como valor asociado al nombre de la función, el número combinatorio.
Este método debe llamar a su vez a la función factorial (que devolverá el factorial de un número
pasado como argumento).

    static double Elevados(int m, int n) {
        string factorialM = "m! = ";
        string factorialN = "n! = ";
        int mX = 1;
        int nX = 1;
        for(int i = 1; i < m + 1; i++) {
            mX = i * mX;
            if(i == m) {
                factorialM = factorialM + i + ": "+ mX;
            } else {
                factorialM = factorialM + i + "*";
            }
        }
        for(int i = 1; i < n + 1; i++) {
            nX = i * nX;
            if(i == n) {
                factorialN = factorialN + i + ": "+ nX;
            } else {
                factorialN = factorialN + i + "*";
            } 
        }
        System.Console.WriteLine(factorialM);
        System.Console.WriteLine(factorialN);
        return mX/(nX*(mX-nX));
    }
    static void Main() {
        Console.Clear();
        System.Console.WriteLine("Inserta un número entero para 'm': ");
        int m = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Inserta un número entero para 'n': ");
        int n = int.Parse(Console.ReadLine());

        double resultadoElevado = Elevados(m, n);

        System.Console.WriteLine($"El resultado es: {resultadoElevado}");
    }
*/
#endregion

#region Ejercicio5
/*
Escribe el resultado de ejecutar este programa y comenta el motivo de la salida.
Nota: Puedes ayudarte con la traza.
    class Program {
        public const int n = 5;
        public static int b = 2, a = 3;
        static int funcion(int b) {
            int c;
            c = b + a;
            b++;
            return c;
        }
        static void Main() {
            int i;
            for (i = 0; i < n; i++)
                b = funcion(i);
            Console.WriteLine(b);
        }
    }

    1º pasa por el for i va sumando 1 cada ver que recorre el for
    2º b = funcion(i) esto hace que el valor b sea el que te va a retornar,
       tras recorrer el metodo funcion().
        -En este metodo tiene un int propio llamado 'c'.
        -Hace un c = b + a (a = 3).
        -La primera operacion por ejemplo seria (c = 0 + 3).
        -Luego hace que 'b' sume 1.
        -Y te devuelve con return el valor de 'c' que sería 3 ya que b inicia en 2.
        -De ahi en adelante va sumando 1 hasta que llega a 7 // (3,4,5,6,7).
    3º Lanza un WriteLine con el valor de 'b'
*/
#endregion

#region Ejercicio6
/*
Crea un método que cambie de formato una fecha. Dados el día, mes y año devuelva un número
entero tipo long (ver nota) .
Dada esta función, diseña un programa que solicite dos fechas de nacimiento y averigüe cual de
las dos personas es mayor.
Nota: Para una fecha que corresponda con 2/4/1997 el entero largo devuelto sería 19970402.

    static ulong FechaNumerica(uint dia, uint mes, uint año) {
        string fechaTxt = $"{año:D2}{mes:D2}{dia:D2}";
        ulong fechaNum = ulong.Parse(fechaTxt);

        return fechaNum;
    }

    static (string nombre1, string nombre2, ulong fechaNumerica1, ulong fechaNumerica2) recogidaDatosYCalculo() {
        System.Console.WriteLine("Introduce el nombre de la 1ª persona: ");
        string nombre1 = Console.ReadLine();
        System.Console.WriteLine("Introduce el año: ");
        uint año = uint.Parse(Console.ReadLine());
        System.Console.WriteLine("Introduce el mes: ");
        uint mes = uint.Parse(Console.ReadLine());
        System.Console.WriteLine("Introduce el día: ");
        uint dia = uint.Parse(Console.ReadLine());

        ulong fechaNumericaL1 = FechaNumerica(dia, mes, año);

        System.Console.WriteLine("Introduce el nombre de la 2ª persona: ");
        string nombre2 = Console.ReadLine();
        System.Console.WriteLine("Introduce el año: ");
        año = uint.Parse(Console.ReadLine());
        System.Console.WriteLine("Introduce el mes: ");
        mes = uint.Parse(Console.ReadLine());
        System.Console.WriteLine("Introduce el día: ");
        dia = uint.Parse(Console.ReadLine());

        ulong fechaNumericaL2 = FechaNumerica(dia, mes, año);

        return (nombre1, nombre2, fechaNumericaL1, fechaNumericaL2);
    }
    static void Main() {
        ulong fechaNumerica1, fechaNumerica2;
        string nombre1, nombre2;
        (nombre1, nombre2, fechaNumerica1, fechaNumerica2) = recogidaDatosYCalculo();

        string txtMayMen = (fechaNumerica1 > fechaNumerica2) ? "Mayor" : "Menor";

        System.Console.WriteLine($"La fecha nº1 = {fechaNumerica1} // La fecha nº2 = {fechaNumerica2}");
        System.Console.WriteLine($"La fecha de nacimiento de {nombre1} es {txtMayMen} que la de {nombre2}");
    }
*/
#endregion

#region Ejercicio7
/*
Construye un programa que dados tres números enteros correspondientes a la hora, minutos y
segundos actuales, calcula la hora (en el mismo formato) que será un segundo más tarde. Para
ello, se deben diseñar dos métodos:
• HoraASegundos que dados tres argumentos de entrada correspondientes a hora, minutos y
segundos, devuelva la conversión de dicha hora a segundos desde las 00:00:00.
• SegundosAHora, que dado un argumento de entrada correspondiente a una hora en segundos
desde las 00:00:00, la convierta en horas, minutos y segundos y la devuelva. Devolverás la
información mediante parámetros de salida.
Nota: El algoritmo debe leer la hora en formato HH, MM y SS, después transformarla a segundos
(con HoraASegundos), sumarle uno a dichos segundos y después volver a transformarla en HH,
MM y SS (con SegundosAHora).

    static long HoraASegundos(int horas, int minutos, int segundos) {
        return horas * 60 * 60 + minutos * 60 + segundos;
    }

    static (int horas, int minutos, int segundos) SegundosAHora(long segundosConversion) {
        int horas = (int)(segundosConversion / (60 * 60));
        int minutos = (int)(segundosConversion % (60 * 60) / 60);
        int segundos = (int)(segundosConversion % (60 * 60) % 60);

        return (horas, minutos, segundos);
    }

    static void Main() {
        Console.Clear();
        int horas = 20, minutos = 59, segundos = 59;

        System.Console.WriteLine($"Hora: {horas:D2}:{minutos:D2}:{segundos:D2}");
        long segundosConversion = HoraASegundos(horas, minutos, segundos);
        segundosConversion++;
        (horas, minutos, segundos) = SegundosAHora(segundosConversion);
        System.Console.WriteLine($"Hora: {horas:D2}:{minutos:D2}:{segundos:D2}"); 
    }
*/
#endregion

#region Ejercicio8
/*
Escribe un método llamado Lee que que obtenga los siguientes datos de un usuario: número de
departamento, coste por hora y horas trabajadas. Usarás tuplas para resolverlo
Escribe un método llamado Salario que para calcular el salario semanal multiplique el coste por
hora por el número de horas trabajadas.
Escribe un método llamado Muestra que muestre el salario semanal, el número del departamento,
el coste por hora y las horas trabajadas. Podéis fijaros en el siguiente DEM:

    static (short numDep, float costHora, short horasTrab) Lee(){
        short numDep, horasTrab;
        float costHora;

        System.Console.WriteLine("Introduce el número del departamento del trabajador: ");
        numDep = short.Parse(Console.ReadLine());
        System.Console.WriteLine("Introduce las horas de trabajo: ");
        costHora = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Introduce el coste de la hora");
        horasTrab = short.Parse(Console.ReadLine());

        return(numDep, costHora, horasTrab);
    }
    static void Mensaje(short numDep, float costHora, short horasTrab, float salario) {
        System.Console.WriteLine($"El empleado del departamento nº{numDep}, ha trabajado {horasTrab} " +
                                    $"horas a un coste por hora de {costHora} euros, por lo que su salario " +
                                    $"es de: {salario} euros");
    }

    static float salario(short horasTrab, float costHora) {
        return costHora * horasTrab;
    }
    static void Main() {
        Console.Clear();
        (short numDep, float costHora, short horasTrab) = Lee();

        Mensaje(numDep, costHora, horasTrab, salario(horasTrab, costHora));
        
    }
*/
#endregion

#region Ejercicio9
/*
Escribe un programa para jugar a adivinar números. El programa tiene que seguir los siguientes
pasos:
1. Calcular de forma aleatoria el número a adivinar por el jugador. El número debe hallarse
entre 0 y 50 (ambos inclusive).
2. Preguntar un número al jugador y dar una pista indicando si el número introducido es mayor o
menor que el número a adivinar.
3. Si el jugador acierta el número, la partida terminará indicando la cantidad de tentativas
hechas por este jugador para acertar.
4. Habrá un máximo de tentativas dependiendo del nivel elegido para jugar:
fácil =10, medio = 6, difícil = 4 .
5. El programa preguntará si se desea seguir jugando. Si se responde que sí el juego seguirá
pidiendo un nuevo nivel y generando otro número, si se responde ESC se saldrá del
programa. Cualquier otra respuesta no será válida y se pedirá que se vuelva a responder.
Nota: Será necesario realizar los métodos y el paso de parámetros que consideres adecuado para
una correcta programación.

    static int generadorNumRandom() {
        Random semilla = new Random();
        int numeroRandom = semilla.Next(0, 50);

        System.Console.WriteLine(numeroRandom);
        return numeroRandom;
    }
    static int selectorDificultad() {
        int intentos = 0;
        bool activo = true;
        do {
            System.Console.WriteLine("Seleccione la dificultad entre fácil(1), medio(2), difícil(3): ");
            int dificultad = int.Parse(Console.ReadLine());

            if(dificultad == 1) {
                intentos = 10;
                activo = false;
            } else if(dificultad == 2) {
                intentos = 6;
                activo = false;
            } else if(dificultad == 3) {
                intentos = 4;
                activo = false;
            } else {
                System.Console.WriteLine("Algo ha fallado vuelve a intentarlo...");
            }
        } while(activo == true);

        return intentos;
    }
    static void jugadasJugador() {
        int intentos = selectorDificultad();
        int numAdivinar = generadorNumRandom();
        int numJugador = 0;

        do {
            if(intentos != 0) {
                System.Console.WriteLine("Inserte un numero del 0 al 50 y adivinelo: ");
                numJugador = int.Parse(Console.ReadLine());

                    if(numJugador != numAdivinar) {
                        if(numJugador < numAdivinar) {
                            System.Console.WriteLine("Tu numero es menor que el numero a adivinar, vuelve a intentarlo.");
                        } else {
                            System.Console.WriteLine("Tu numero es mayor que el numero a adivinar, vuelve a intentarlo.");
                        }
                        intentos--;
                    } else {
                        System.Console.WriteLine($"Enhorabuena has acertado, el numero a adivinar era: {numAdivinar}"); 
                    }
                } else {
            }
        }while(intentos != 0);
    }
    static void Main() {
        Console.Clear();
        System.Console.WriteLine("¡Presiona cualquier tecla para empezar!");
        ConsoleKeyInfo continuar = Console.ReadKey();
        do {
            jugadasJugador();
            do {
                System.Console.WriteLine("¿Deseas jugar de nuevo? (S/Esc): ");
                continuar = Console.ReadKey();
                if(continuar.Key == ConsoleKey.S) 
                    jugadasJugador();

                if (continuar.Key != ConsoleKey.S && continuar.Key != ConsoleKey.Escape)
                    Console.WriteLine("\a\nOpción no reconocida\n");
            
            }while(continuar.Key != ConsoleKey.S && continuar.Key != ConsoleKey.Escape);
        } while(continuar.Key != ConsoleKey.Escape);
    }
*/
#endregion

#region Ejercicio10
/*
Programa que implementará un juego con las siguientes características:
1. El programa pedirá que introduzcas el número de participantes a jugar.
2. Cada participante tirará 3 veces un dado con valores entre 1 y 100 (electrónico se entiende),
sumándose el valor de las 3 jugadas. Ganará el participante que
obtenga mayor puntuación según las siguientes reglas:
◦ Si el nº obtenido es múltiplo de 3 o de 5 sumara 10 pts.
◦ Si el nº obtenido es múltiplo de 4 o de 6 sumara 5 pts.
◦ Si el nº obtenido es mayor de 80 sumara 2 pts.
◦ Si el nº obtenido es mayor de 50 sumar 1 pts.
◦ Si el nº obtenido es menor de 50 restará 2 pts.
◦ Si el nº obtenido es menor de 20 restará 1 pts.
3. El DEM para el juego será más o menos el siguiente.

    static void presentaJuego() {
        System.Console.WriteLine("Cada participante tirará 3 veces un dado con valores entre 1 y 100(electrónico se");
        System.Console.WriteLine("entiende), sumándose el valor de las 3 jugadas.Ganará el participante que");
        System.Console.WriteLine("obtenga mayor puntuación según las siguientes reglas:");
        System.Console.WriteLine("◦ Si el nº obtenido es múltiplo de 3 o de 5 sumara 10 pts.");
        System.Console.WriteLine("◦ Si el nº obtenido es múltiplo de 4 o de 6 sumara 5 pts.");
        System.Console.WriteLine("◦ Si el nº obtenido es mayor de 80 sumara 2 pts.");
        System.Console.WriteLine("◦ Si el nº obtenido es mayor de 50 sumar 1 pts.");
        System.Console.WriteLine("◦ Si el nº obtenido es menor de 50 restará 2 pts.");
        System.Console.WriteLine("◦ Si el nº obtenido es menor de 20 restará 1 pts.");
    }
    static int puntosCalculadora(int tirada) {
        int puntos = 0;

        if(tirada % 3 == 0 || tirada % 5 == 0) {
            puntos += 10;
        } else if(tirada % 4 == 0 || tirada % 6 == 0) {
            puntos += 5;
        } else if(tirada > 80) {
            puntos += 2;
        } else if(tirada > 50) {
            puntos += 1;
        } else if(tirada < 50) {
            puntos -= 2;
        } else if(tirada < 20) {
            puntos -= 1;
        }
        return puntos;
    } 
    static int jugadaJugador(int jugador, Random semilla) {
        int puntuacion = 0;
        System.Console.WriteLine($"El jugador: {jugador}, tiene las jugadas: ");

        for(int i = 0; i < 3; i++) {
            int tirada = tiradaDadoRandom(semilla);
            puntuacion += puntosCalculadora(tirada);
            System.Console.WriteLine($"Tirada: {tirada} // Puntos: {puntuacion}");
        }
        return puntuacion;
    }
    static int numeroParticipantes() {
        System.Console.WriteLine("Introduce el numero de participantes: ");
        int numParticipantes = int.Parse(Console.ReadLine());

        return numParticipantes;
    }
    static int tiradaDadoRandom(Random semilla) {
        return semilla.Next(1, 100);
    }
    static void MejorPuntuacionHastaHora(int puntuacionJugadorActual, int jugadorActual, ref int mejorPuntuacion, ref int mejorJugador) {
        if (puntuacionJugadorActual > mejorPuntuacion) {
            mejorPuntuacion = puntuacionJugadorActual;
            mejorJugador = jugadorActual;
        }
    }

    static void Main() {
        Console.Clear();
        int mejorPuntuacion = int.MinValue;
        int mejorJugador = 1;

        presentaJuego();
        int participantes = numeroParticipantes();
        Random semilla = new Random();  

        for(int jugador = 1; jugador <= participantes; jugador++) {
            int puntuacion = jugadaJugador(jugador, semilla);
            MejorPuntuacionHastaHora(puntuacion, jugador, ref mejorPuntuacion, ref mejorJugador);
        }
        System.Console.WriteLine($"La victoria es de Jugador: {mejorJugador} // Con una puntuacion de: {mejorPuntuacion}");
    }
*/
#endregion