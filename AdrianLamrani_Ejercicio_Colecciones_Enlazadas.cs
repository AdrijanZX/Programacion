#region Ejercicio1
/*
using System;
public class NodoListaDoblementeEnlazada<T> : IDisposable where T : IComparable<T> {
    public NodoListaDoblementeEnlazada<T> anterior {get; set;}
    public NodoListaDoblementeEnlazada<T> siguiente {get; set;}
    public T dato {get; set;}

    public NodoListaDoblementeEnlazada(T dato) {
        if(dato == null)
            throw new ArgumentException("Null Exception point");
        siguiente = null;
        anterior = null;
        this.dato = dato;
    }

    public void Dispose() {
        siguiente = null;
        anterior = null;
        if(dato is IDisposable d)
            d.Dispose();
    }
}
class ListaDoblementeEnlazada<T> : IDisposable, IEnumerable<T> where T : IComparable<T> {
    public NodoListaDoblementeEnlazada<T> primero {get; private set;}
    public NodoListaDoblementeEnlazada<T> ultimo {get; private set;}
    public int longitud {get; private set;}
    public bool vacia => longitud == 0;

    public ListaDoblementeEnlazada() {
        primero = ultimo = null;
        longitud = 0;
    }
    //public ListaDoblementeEnlazada(IEnumerable<T> secuencia) {}
    public void AñadeAlPrincipio(NodoListaDoblementeEnlazada<T> nuevo) {
        if(vacia) {
            primero = nuevo;
            ultimo = nuevo;
        } else {
            primero.anterior = nuevo;
            nuevo.siguiente = primero;
        }
        longitud++;
    }

    public void AñadeAlPrincipio(T dato) {
        AñadeAlPrincipio(new NodoListaDoblementeEnlazada<T>(dato));
    }
    public void AñadeAlFinal(NodoListaDoblementeEnlazada<T> nuevo) {
        if(vacia) {
            primero = nuevo;
            ultimo = nuevo;
        } else if(nuevo == primero) {
            primero.siguiente = nuevo;
            nuevo.anterior = primero;
        } else {
            ultimo.siguiente = nuevo;
            nuevo.anterior = ultimo;
        }
        longitud++;
    }
    public void AñadeAlFinal(T dato) {
        AñadeAlFinal(new NodoListaDoblementeEnlazada<T>(dato));
    }
    public void AñadeAntesDe(NodoListaDoblementeEnlazada<T> nodo, NodoListaDoblementeEnlazada<T> nuevo) {
        if(primero != null) {
            nuevo.anterior = nodo.anterior;
            nuevo.siguiente = nodo;
            nodo.anterior.siguiente = nuevo;
            nodo.anterior = nuevo;
            longitud++;
        } else {
            System.Console.WriteLine("Error lista vacía");
        }
    }
    public void AñadeAntesDe(T dato) {
        AñadeAntesDe(Buscar(dato), new NodoListaDoblementeEnlazada<T>(dato));
    }
    public void AñadeDespuesDe(NodoListaDoblementeEnlazada<T> nodo, NodoListaDoblementeEnlazada<T> nuevo) {
        if(primero != null) {
            nuevo.anterior = nodo;
            nuevo.siguiente = nodo.siguiente;
            nodo.siguiente = nuevo;
            nodo.siguiente.anterior = nuevo;
            longitud++;
        } else {
            System.Console.WriteLine("Error lista vacía");
        }
    }
    public void AñadeDespuesDe(T dato) {
        AñadeDespuesDe(Buscar(dato),new NodoListaDoblementeEnlazada<T>(dato));
    }
    public void Borra(NodoListaDoblementeEnlazada<T> nodo) {
        NodoListaDoblementeEnlazada<T> iterador = Buscar(nodo.dato);
        if(iterador == null) {
            System.Console.WriteLine("Nodo no encontrado");
        } else {
            nodo.anterior.siguiente = nodo.siguiente;
            nodo.siguiente.anterior = nodo.anterior;
            nodo = null;
        }
    }
    public NodoListaDoblementeEnlazada<T> Buscar(T dato) {
        NodoListaDoblementeEnlazada<T> nodo = new NodoListaDoblementeEnlazada<T>(dato);
        NodoListaDoblementeEnlazada<T> iterador = new NodoListaDoblementeEnlazada<T>(default);
        iterador = primero;
        do {
            iterador = iterador.siguiente;
        } while(iterador.siguiente != null || iterador.dato.CompareTo(nodo.dato) == 0);
        if(iterador.dato.CompareTo(nodo.dato) != 0) {
            iterador = null;
        }
        return iterador;
    }
    public void Clear() {
        primero = ultimo = null;
        longitud = 0;
    }
    public override string ToString() {
        string cadena = "";
        NodoListaDoblementeEnlazada<T> iterador = primero;

        do {
            cadena += "[" + iterador.dato + "]";
            iterador = iterador.siguiente;
        } while(iterador.siguiente != null);
        cadena += " - ";
        iterador = ultimo;
        do {
            cadena += "[" + iterador.dato + "]";
            iterador = iterador.anterior;
        } while(iterador.anterior != null);
        return cadena;
    }
    public void Dispose() {
        primero.Dispose();
        ultimo.Dispose();
    }
}
class Program {
    private static void Main(string[] args) {
        ListaDoblementeEnlazada<int> ld = new ListaDoblementeEnlazada<int>();
        ld.AñadeAlPrincipio(4);
        ld.AñadeAlPrincipio(3);
        Console.WriteLine(ld);
        ld.Clear();
        ld.AñadeAlFinal(6);
        ld.AñadeAlFinal(9);
        ld.AñadeAlPrincipio(3);
        Console.WriteLine(ld);
        NodoListaDoblementeEnlazada<int> nodo = ld.Buscar(6);
        ld.AñadeAntesDe(nodo, 5);
        ld.AñadeAntesDe(ld.primero, 1);
        ld.AñadeDespuesDe(nodo, 7);
        ld.AñadeDespuesDe(ld.ultimo, 12);
        Console.WriteLine(ld);
        ld.Borra(nodo);
        ld.Borra(ld.primero);
        ld.Borra(ld.ultimo);
        Console.WriteLine(ld);
    }
}
*/
#endregion


#region Ejercicio2 
/*
using System;
using System.Collections.Generic;

public class CaracterException : Exception {
    public CaracterException(string message) : base(message) { }
}

public class CaracterAsCII : IComparable<CaracterAsCII> {
    private char _caracter;

    public char Caracter {
        get => _caracter;
        set {
            if (value < 0 || value > 255) {
                throw new CaracterException("El valor debe estar entre 0 y 255");
            }
            _caracter = value;
        }
    }

    public string CaracterDecimal => ((int) _caracter).ToString();

    public string CaracterOctal => Convert.ToString(_caracter, 8);

    public string CaracterHexadecimal => Convert.ToString(_caracter, 16);

    public CaracterAsCII(char caracter) {
        Caracter = caracter;
    }

    public CaracterAsCII(short caracter) {
        Caracter = (char) caracter;
    }

    public override string ToString() {
        return $"{CaracterDecimal} {CaracterOctal} {CaracterHexadecimal} {Caracter}";
    }

    public override bool Equals(object obj) {
        if (obj == null || GetType() != obj.GetType()) {
            return false;
        }
        CaracterAsCII other = (CaracterAsCII) obj;
        return Caracter == other.Caracter;
    }

    public override int GetHashCode() {
        return Caracter.GetHashCode();
    }

    public int CompareTo(CaracterAsCII other) {
        return Caracter.CompareTo(other.Caracter);
    }
}

class Program {
    static void Main() {
        LinkedList<CaracterAsCII> listaAscii = new LinkedList<CaracterAsCII>();
        GeneraElementos(listaAscii, 240);
        MuestraLista(listaAscii);
        Console.ReadLine();
    }

    private static void modificarDimensionesPantalla() {
        int ancho = Console.LargestWindowWidth;
        int alto = Console.LargestWindowHeight;

        if (Console.WindowWidth < ancho || Console.WindowHeight < alto) {
            Console.WindowWidth = ancho > Console.WindowWidth ? ancho : Console.WindowWidth;
            Console.WindowHeight = alto > Console.WindowHeight ? alto : Console.WindowHeight;
        }

        if (Console.BufferWidth < ancho || Console.BufferHeight < alto) {
            Console.BufferWidth = ancho > Console.BufferWidth ? ancho : Console.BufferWidth;
            Console.BufferHeight = alto > Console.BufferHeight ? alto : Console.BufferHeight;
        }
    }


    static string Cabecera() => "DEC OCT HEX CAR ";

    static void MuestraLista(LinkedList<CaracterAsCII> lista) {
        modificarDimensionesPantalla();
        const short NUMERO_COLUMNAS = 8;
        for (int i = 0; i < NUMERO_COLUMNAS; i++) Console.Write(Cabecera());
        Console.WriteLine("\n");
        int columnas = 1;
        foreach (var caracter in lista) {
            Console.Write($"{caracter} ");
            if (columnas % NUMERO_COLUMNAS == 0) {
                columnas = 0;
                Console.WriteLine();
            }
            columnas++;
        }
    }

    private static void GeneraElementos(LinkedList<CaracterAsCII> lista, int numeroElementos) {
        Random random = new Random();
        int contador = 0;
        while (contador < numeroElementos) {
            char caracterAleatorio = (char)random.Next(16, 256);
            CaracterAsCII nuevoCaracter = new CaracterAsCII(caracterAleatorio);

            if (!lista.Contains(nuevoCaracter)) {
                LinkedListNode<CaracterAsCII> nodoActual = lista.First;
                while (nodoActual != null && nodoActual.Value.CompareTo(nuevoCaracter) < 0) {
                    nodoActual = nodoActual.Next;
                }

                if (nodoActual == null) {
                    lista.AddLast(nuevoCaracter);
                }
                else {
                    lista.AddBefore(nodoActual, nuevoCaracter);
                }

                contador++;
            }
        }
    }
}
*/
#endregion