#region Ejercicio1
/*
class Program {
    private static void Main(string[] args) {
        List<int> listaEnteros = new List<int>();
        for(int i = 0; i < 11; i++) {
            listaEnteros.Add(i);
        }
        System.Console.WriteLine("Introduzca un numero entero: ");
        int numero = int.Parse(Console.ReadLine());
        List<int> multiplos = listaEnteros.FindAll(x => (x % numero == 0) ? true : false);
        System.Console.WriteLine($"Los multiplos de {numero}, son:");
        multiplos.ForEach(x => Console.WriteLine(x)); 
    }
}
*/
#endregion


#region Ejercicio2
/*
class Program {
    delegate List<T> BuscarCoincidenciasDelegate<T>(List<T> lista, string cadena);
    private static void Main(string[] args) {
        List<string> listaCadenas = new List<string> {"Hola", "Mundo", "Hola Mundo"};
        System.Console.WriteLine("Introduzca una cadena para buscar coincidencias: ");
        string cadenaBuscar = Console.ReadLine();
        BuscarCoincidenciasDelegate<string> buscarCoincidencias = (lista, cadena) => {
            return lista.FindAll(x => x.Contains(cadena));
        };
        List<string> coincidencias = buscarCoincidencias(listaCadenas, cadenaBuscar);
        System.Console.WriteLine($"Las coincidencias encontradas son:");
        coincidencias.ForEach(x => Console.WriteLine(x)); 
    }
}
*/
#endregion


#region Ejercicio3
/*
class Libro {
    public String Titulo { get; set; }
    public String Autor { get; set; }
    public String Editorial { get; set; }
    public short NumPaginas { get; set; }
    public String ISBN { get; set; }
    public String Reseña { get; set; }
    public override string ToString() {
        return new {
            Titulo = Titulo,
            Autor = Autor,
            ISBN = ISBN
        }.ToString();
    }
}
class BibliotecaException : Exception {
    public BibliotecaException(string message) : base(message) { ; }
}
class Biblioteca {
    const string FICHERO_PRESTAMOS = "prestamos.txt";
    public List<Libro> Libros { get; set; }
    public String Nombre { get; set; }
    public Biblioteca(string nombre, List<Libro> libros) {
        Nombre = nombre;
        Libros = libros;
    }
    public void Presta(string dni, String isbn) {
        Libro l = BuscaPorISBN(isbn);
        if (l == null)
            throw new BibliotecaException($"El libro con ISBN {isbn} no existe en la biblioteca.");
        var prestamo = new {
            DNI = dni,
            Titulo = l.Titulo,
            ISBN = l.ISBN
        };
        using (FileStream fs = new FileStream(FICHERO_PRESTAMOS, FileMode.Append, FileAccess.Write)) {
            using (StreamWriter sw = new StreamWriter(fs)) {
                Console.WriteLine($"Prestando ... {prestamo}");
                sw.WriteLine(prestamo);
            }
        }
    }
    public IEnumerable<string> LibrosPrestados() {
        using (FileStream fs = new FileStream(FICHERO_PRESTAMOS, FileMode.Open, FileAccess.Read)) {
            using (StreamReader sr = new StreamReader(fs)) {
                while (!sr.EndOfStream)
                    yield return sr.ReadLine();
            }
        }
    }
    public bool EstaPrestado(String isbn) {
        Predicate<String> ContieneCandena = c => c.Contains(isbn);
        return (LibrosPrestados().ToList().Find(ContieneCandena) != null);
    }
    public Libro BuscaPorISBN(String isbn) {
        Predicate<Libro> TieneISBN = l => l.ISBN == isbn;
        return Libros.Find(TieneISBN);
    }
    public int CuentaLibrosConNumeroDePaginasMenorA(int num) {
        Predicate<Libro> TienepaPaginasMenorANum = l => l.NumPaginas < num;
        return Libros.FindAll(TienepaPaginasMenorANum).Count;
    }
    public void EliminaPorAutor(String autor) {
        Predicate<Libro> EsDeAutor = l => l.Autor == autor;
        Libros.RemoveAll(EsDeAutor);
    }
}
class Program {
    static void Main(string[] args) {
        List<Libro> libros = new List<Libro> {
            new Libro {
                Titulo = "Don Quijote de la Mancha",
                Autor = "Miguel de Cervantes",
                Editorial = "Editorial EDAF, S.A",
                NumPaginas = 765,
                ISBN = "9788441405298",
                Reseña = "El libro, sinopsis… Nos presentan a este personaje como un loco trastornado a causa de las novelas de caballerías, pero, ¿Quién dice que el señor Quijana era sólo eso? ¿Por algún motivo será la cumbre de la literatura española verdad? Y aquí se plantea la duda héroe o simplemente viejo loco."
            },
            new Libro {
                Titulo = "El camino",
                Autor = "Miguel Delibes",
                Editorial = "Espasa",
                NumPaginas = 187,
                ISBN = "9788467023664",
                Reseña = "Una de las más importantes obras de Miguel Delibes cuenta la historia de un niño , Daniel el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato. Una noche antes de partir Daniel recordará todo lo que le ha ocurrido en este lugar, sus amigos, sus peripecias, y descubrirá que su camino está en esa aldea, unido a lo que ha sido hasta ese momento su vida. Nostálgica novela realista a través de la cual podemos aprender que nunca sabemos lo que tenemos hasta que se nos ha escapado."
            },
            new Libro {
                Titulo = "Cien años de soledad",
                Autor = "Gabriel García Márquez",
                Editorial = "Alfaguara",
                NumPaginas = 562,
                ISBN = "9788420471839",
                Reseña = "Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el hielo.» Con estas palabras empieza una novela ya legendaria en los anales de la literatura universal, una de las aventuras literarias más fascinantes de nuestro s iglo.Millones de ejemplares de Cien años de soledad leídos en todas las lenguas y el premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca» -como gusta decir el escritor-son la más palpable demostración de que la aventura fabulosa de la familia Buendía - Iguarán, con sus milagros, fantasías, obsesiones, tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero."
            },
            new Libro {
                Titulo = "La Regenta",
                Autor = "Leopoldo Alas Clarín",
                Editorial = "Crítica",
                NumPaginas = 182,
                ISBN = "9788484326977",
                Reseña = "En La Regenta, sin lugar a dudas una de las cumbres de la novela realista, Leopoldo Alas alcanzó a cifrar de forma inolvidable uno de los motivos que obsesionaron a la narrativa europea de la segunda mitad del siglo XIX: el retrato de un carácter femenino que se debate entre el deseo y su represión , y que sufre, en este caso, las asechanzas de un galán y de un cura.La peripecia tiene como trasfondo la magistraly despiadada descripción del entorno de Ana Ozores, esa Vetusta murmuradora y provinciana en la que toda vanidad e hipocresía tiene su asiento. José Luis Gómez, tras un minucioso análisis de las primeras ediciones de la obra, sigue el texto de la tercera(1901), revisada por Clarín y publicada poco antes de su muerte. El prólogo de S. Beser al autor y su novela en el contexto de la creación europea y española de la época, mientras que la anotación facilita la comprensión de cada uno de los pormenores del rico universo clariniano."
            },
            new Libro {
                Titulo = "Los mejores cuentos de Clarín",
                Autor = "Leopoldo Alas Clarín",
                Editorial = "De Vecchi",
                NumPaginas = 145,
                ISBN = "9788431533441",
                Reseña = "Una cuidadosa selección que nos muestra la riqueza de los recursos estilísticos de este gran escritor del s. XIX.En el volumen se incluyen: Doña Berta, Benedictino, Manín de Pepa José, Zurita, Cambio de luz, y la Conversión de Chiripa."
            }
        };
        Biblioteca biblioteca = new Biblioteca("EL RINCÓN DE LEER", libros);
        biblioteca.Presta("22111333", "9788420471839");
        biblioteca.Presta("22111333", "9788431533441");
        Console.WriteLine(biblioteca.EstaPrestado("9788420471839"));
        Console.WriteLine(biblioteca.EstaPrestado("22111444"));
        Console.WriteLine(biblioteca.BuscaPorISBN("9788431533441"));
        Console.WriteLine(biblioteca.BuscaPorISBN("97884551533441"));
        Console.WriteLine(biblioteca.CuentaLibrosConNumeroDePaginasMenorA(400));
        Console.WriteLine(biblioteca.BuscaPorISBN("9788467023664"));
        biblioteca.EliminaPorAutor("Miguel Delibes");
        Console.WriteLine(biblioteca.BuscaPorISBN("9788467023664"));
    }
}
*/
#endregion


#region Ejercicio4
/*
class Program {
    private static void Main(string[] args) {
        List<double> reales = new List<double> {
            0.5, 1.6, 2.8, 3.9, 4.1, 5.2, 6.3, 7.4, 8.1, 9.2
        };
        reales.ForEach(x => System.Console.WriteLine(x));
        string texto = "";
        reales.ForEach(x => texto += $"{x.ToString()} ");
        System.Console.WriteLine("Elementos: " + texto); 
        int contador = reales.Select(x => x - Math.Floor(x))
                        .Where(d => d < 0.5)
                        .Aggregate(0, (acc, _) => acc + 1);
        Console.WriteLine("Cantidad de elementos cuya parte decimal < 0.5: " + contador); 
        double suma = reales.Select(x => new {e = (int)x, r = x})
                        .Where(o => o.e % 3 == 0)
                        .Sum(o => o.r);
        System.Console.WriteLine("Suma elementos con parte entera múltiplo de 3: " + suma);
        double max = reales.Select(x => new {d = x - Math.Floor(x), r = x})
                        .Where(o => o.d > 0.5)
                        .Max(o => o.r);
        System.Console.WriteLine("Máximo cuya parte decimal > 0,5: " + max);
        bool EsPrimo(int num) {
            return num > 1 && !Enumerable.Range(2, (int)Math.Floor(Math.Sqrt(num)) - 1).Any(divisor => num % divisor == 0);
        }
        List<double> primo = reales.Where(x => EsPrimo((int)Math.Floor(x))).ToList();
        System.Console.Write("Elementos parte entera es primo: ");
        primo.ForEach(x => System.Console.Write($"{x} "));
    }   
}
*/
#endregion


#region Ejercicio5
/*
namespace Ej5_ConsultasProductos {

    public class Producto {
        public string CodArticulo { get; init; }
        public string Descripcion { get; init; }
        public string Categoria { get; init; }
        public string[] Colores { get; init; }
        public Dimensiones Dimensiones { get; init; }
        public double Precio { get; init; }

    }
    public class Dimensiones {
        public int Largo { get; init; }
        public int Ancho { get; init; }
        public int Espesor { get; init; }

        public override string ToString() => $"L:{Largo} x A:{Ancho} x E:{Espesor}";
    }

    public static class Datos {
        public static IEnumerable<Producto> Productos {
            get {
                yield return new() {
                    CodArticulo = "A01",
                    Descripcion = "Uno",
                    Categoria = "C1",
                    Colores = new string[] { "blanco", "negro", "gris" },
                    Dimensiones = new() {
                        Largo = 4,
                        Ancho = 4,
                        Espesor = 3
                    },
                    Precio = 15.05
                };
                yield return new() {
                    CodArticulo = "A02",
                    Descripcion = "Dos",
                    Categoria = "C1",
                    Colores = new string[] { "blanco", "gris", "rojo" },
                    Dimensiones = new() {
                        Largo = 4,
                        Ancho = 10,
                        Espesor = 2
                    },
                    Precio = 25.95
                };
                yield return new() {
                    CodArticulo = "A03",
                    Descripcion = "Tres",
                    Categoria = "C1",
                    Colores = new string[] { "rojo", "gris", "verde" },
                    Dimensiones = new() {
                        Largo = 5,
                        Ancho = 5,
                        Espesor = 3
                    },
                    Precio = 30.25
                };
                yield return new() {
                    CodArticulo = "A04",
                    Descripcion = "Cuatro",
                    Categoria = "C2",
                    Colores = new string[] { "verde", "rojo" },
                    Dimensiones = new() {
                        Largo = 6,
                        Ancho = 8,
                        Espesor = 4
                    },
                    Precio = 18.45
                };
            }
        }

        class Principal {
            static void Main() {
                System.Console.WriteLine("hola");
                string SeparadorConsulta = "\n" + new string('-', 80) + "\n";

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 1: Usando las funciones Where y Select.\n" +
                    "Mostrar CodArticulo, Descripcion y Precio .\n" +
                    "de productos con Precio entre 10 y 30 euros\n");
                var consulta1 = Productos.Where(p => p.Precio >= 10 && p.Precio <= 30)
                                            .Select(p => new {
                                                CodArticulo = p.CodArticulo,
                                                Descripcion = p.Descripcion,
                                                Precio = p.Precio
                                            });
                Console.WriteLine(string.Join("\n", consulta1));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 2: Usando las funciones Select, OrderByDescending y Take.\n" +
                    "Muestra CodArticulo, Descripcion y Precio de los 3 productos.\n" +
                    "más caros (ordenando por Precio descendente)\n");
                var consulta2 = Productos.Select(p => new {
                                                CodArticulo = p.CodArticulo,
                                                Descripcion = p.Descripcion,
                                                Precio = p.Precio
                                            })
                                            .OrderByDescending(p => p.Precio)
                                            .Take(3);
                Console.WriteLine(string.Join("\n", consulta2));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 3: Usando las funciones GroupBy, OrderBy y First.\n" +
                    "Muestra el precio más barato por categoría\n");
                var consulta3 = Datos.Productos.GroupBy(p => p.Categoria)
                                                .Select(p => new {
                                                    Categoria = p.Key,
                                                    PrecioMasBarato = p.OrderBy(p => p.Precio).First().Precio
                                                })
                                                .OrderBy(res => res.Categoria);
                Console.WriteLine(string.Join("\n", consulta3));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 4: Usando las funciones GroupBy, Count.\n" +
                    "¿Cuántos productos hay de cada categoría?\n");
                var consulta4 = Productos.GroupBy(p => p.Categoria)
                                        .Select(p => new {
                                            Categoria = p.Key,
                                            Contador = p.Count()
                                        });
                Console.WriteLine(string.Join("\n", consulta4));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 5: Usando las funciones GroupBy, Count, Where y Select\n" +
                    "Mostrar las categorías que tengan más de 2 productos\n");
                var consulta5 = Productos.GroupBy(p => p.Categoria)
                                        .Where(p => p.Count() > 2)
                                        .Select(p => p.Key);
                Console.WriteLine(string.Join("\n", consulta5));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 6: Usando la función Select\n" +
                    "Mostrar CodArticulo, Descripcion, Precio y Descuento redondeado a 2 decimales,\n" +
                    "siendo Descuento el 10% del Precio\n");
                var consulta6 = Productos.Select(p => new {
                                            CodArticulo = p.CodArticulo,
                                            Descripcion = p.Descripcion,
                                            Precio = p.Precio,
                                            Descuento = Math.Round(p.Precio * 0.1, 2) 
                                        });
                Console.WriteLine(string.Join("\n", consulta6));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 7: Usando las funciones Where, Contains y Select.\n" +
                    "Mostrar CodArticulo, Descripcion y Colores\n" +
                    "de los productos de color verde o rojo\n" +
                    "(es decir, que contengan alguno de los dos)\n");
                var consulta7 = Productos.Where(p => p.Colores.Contains("verde") || p.Colores.Contains("rojo"))
                                        .Select(p => new{
                                            CodArticulo = p.CodArticulo,
                                            Descripcion = p.Descripcion,
                                            Colores = string.Join(", ", p.Colores)
                                        });
                Console.WriteLine(string.Join("\n", consulta7));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 8: Usando las funciones Where, Count y Select.\n" +
                    "Mostrar CodArticulo, Descripcion y Colores.\n" +
                    "de los productos que se fabrican en tres Colores\n");
                var consulta8 = Productos.Where(p => p.Colores.Count() == 3)
                                        .Select(p => new{
                                            CodArticulo = p.CodArticulo,
                                            Descripcion = p.Descripcion,
                                            Colores = string.Join(", ", p.Colores)
                                        });;
                Console.WriteLine(string.Join("\n", consulta8));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 9: Usando las funciones Where, Select.\n" +
                    "Mostrar CodArticulo, Descripcion y Dimensiones\n" +
                    "de los productos con espesor de 3 cm\n");
                var consulta9 = Productos.Select(p => new {
                                            CodArticulo = p.CodArticulo,
                                            Descripcion = p.Descripcion,
                                            Dimensiones = p.Dimensiones
                                        })
                                        .Where(p => p.Dimensiones.Espesor == 3);
                Console.WriteLine(string.Join("\n", consulta9));

                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 10: Usando las funciones SelectMany, Distinct y OrderBy.\n" +
                    "Mostrar los colores de productos ordenados y sin repeticiones\n");
                var consulta10 = Productos.SelectMany(p => p.Colores)
                                        .Distinct()
                                        .OrderBy(p => p);
                Console.WriteLine(string.Join("\n", consulta10));


                Console.WriteLine(SeparadorConsulta);
                Console.WriteLine(
                    "Consulta 11: Usando las funciones SelectMany, GroupBy, OrderByDescending.\n" +
                    "Mostrar TotalProductos que hay de cada Color ordenando de mayor a menor cantidad\n");
                var consulta11 = Productos.SelectMany(p => p.Colores)
                                        .GroupBy(p => p)
                                        .Select(p => new {
                                            Color = p.Key,
                                            TotalProductos = p.Count()
                                        })
                                        .OrderByDescending(p => p.TotalProductos);
                Console.WriteLine(string.Join("\n", consulta11));
            }
        }
    }
}
*/
#endregion