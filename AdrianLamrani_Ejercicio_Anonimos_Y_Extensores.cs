#region Ejercicio1
/*
--=-=[La respuesta a la duda se encuentra al final de este ejercicio...]=-=--

namespace ConList {
    class Libro {
        public string Titulo { get; init; }
        public string Autor { get; init; }
        public string Editorial { get; init; }
        public short NumPaginas { get; init; }
        public string ISBN { get; init; }
        public string Reseña { get; init; }
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
                    Reseña = @"El libro, sinopsis… Nos presentan a este personaje como un loco
                            trastornado a causa de las novelas de caballerías, pero,
                            ¿Quién dice que el señor Quijana era sólo eso?
                            ¿Por algún motivo será la cumbre de la literatura española verdad?
                            Y aquí se plantea la duda héroe o simplemente viejo loco."
                },
                new Libro {
                    Titulo = "El camino",
                    Autor = "Miguel Delibes",
                    Editorial = "Espasa",
                    NumPaginas = 187,
                    ISBN = "9788467023664",
                    Reseña = @"Una de las más importantes obras de Miguel Delibes cuenta la historia de un
                            niño , Daniel el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato.
                            Una noche antes de partir Daniel recordará todo lo que le ha ocurrido en este lugar, sus
                            amigos, sus peripecias, y descubrirá que su camino está en esa aldea, unido a lo que ha
                            sido hasta ese momento su vida. Nostálgica novela realista a través de la cual podemos
                            aprender que nunca sabemos lo que tenemos hasta que se nos ha escapado."
                },
                new Libro {
                    Titulo = "Cien años de soledad",
                    Autor = "Gabriel García Márquez",
                    Editorial = "Alfaguara",
                    NumPaginas = 562,
                    ISBN = "9788420471839",
                    Reseña = @"Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano
                            Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el
                            hielo.» Con estas palabras empieza una novela ya legendaria en los anales de la
                            literatura universal, una de las aventuras literarias más fascinantes de nuestro s
                            iglo.Millones de ejemplares de Cien años de soledad leídos en todas las lenguas y el
                            premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca»
                            -como gusta decir el escritor-son la más palpable demostración de que la aventura
                            fabulosa de la familia Buendía - Iguarán, con sus milagros, fantasías, obsesiones,
                            tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al
                            mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero."
                },
                new Libro {
                    Titulo = "La Regenta",
                    Autor = "Leopoldo Alas Clarín",
                    Editorial = "Crítica",
                    NumPaginas = 182,
                    ISBN = "9788484326977",
                    Reseña = @"En La Regenta, sin lugar a dudas una de las cumbres de la novela realista,
                            Leopoldo Alas alcanzó a cifrar de forma inolvidable uno de los motivos que obsesionaron
                            a la narrativa europea de la segunda mitad del siglo XIX: el retrato de un carácter
                            femenino que se debate entre el deseo y su represión , y que sufre, en este caso, las
                            asechanzas de un galán y de un cura.La peripecia tiene como trasfondo la magistraly
                            despiadada descripción del entorno de Ana Ozores, esa Vetusta murmuradora y
                            provinciana en la que toda vanidad e hipocresía tiene su asiento. José Luis Gómez, tras
                            un minucioso análisis de las primeras ediciones de la obra, sigue el texto de la
                            tercera(1901), revisada por Clarín y publicada poco antes de su muerte. El prólogo de S.
                            Beser al autor y su novela en el contexto de la creación europea y española de la época,
                            mientras que la anotación facilita la comprensión de cada uno de los pormenores del rico
                            universo clariniano."
                },
                new Libro {
                    Titulo = "Los mejores cuentos de Clarín",
                    Autor = "Leopoldo Alas Clarín",
                    Editorial = "De Vecchi",
                    NumPaginas = 145,
                    ISBN = "9788431533441",
                    Reseña = @"Una cuidadosa selección que nos muestra la riqueza de los recursos estilísticos
                            de este gran escritor del s. XIX.En el volumen se incluyen: Doña Berta, Benedictino,
                            Manín de Pepa José, Zurita, Cambio de luz, y la Conversión de Chiripa."
                }
            };
        }
    }
}
namespace ConArrayInmutable {
    class Libro {
        public string Titulo { get; }
        public string Autor { get; }
        public string Editorial { get; }
        public short NumPaginas { get; }
        public string ISBN { get; }
        public string Reseña { get; }

        public Libro(string titulo, string autor, string editorial, short numPaginas, string ISBN, string reseña) {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            NumPaginas = numPaginas;
            this.ISBN= ISBN;
            Reseña = reseña;
        }
    }
    class Program {
        static void Main(string[] args) {
            ImmutableArray<Libro> libros = new ImmutableArray<Libro> {
                new Libro (
                    "Don Quijote de la Mancha",
                    "Miguel de Cervantes",
                    "Editorial EDAF, S.A",
                    765,
                    "9788441405298",
                    @"El libro, sinopsis… Nos presentan a este personaje como un loco
                    trastornado a causa de las novelas de caballerías, pero,
                    ¿Quién dice que el señor Quijana era sólo eso?
                    ¿Por algún motivo será la cumbre de la literatura española verdad?
                    Y aquí se plantea la duda héroe o simplemente viejo loco."
                ),
                new Libro (
                    "El camino",
                    "Miguel Delibes",
                    "Espasa",
                    187,
                    "9788467023664",
                    @"Una de las más importantes obras de Miguel Delibes cuenta la historia de un
                    niño , Daniel el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato.
                    Una noche antes de partir Daniel recordará todo lo que le ha ocurrido en este lugar, sus
                    amigos, sus peripecias, y descubrirá que su camino está en esa aldea, unido a lo que ha
                    sido hasta ese momento su vida. Nostálgica novela realista a través de la cual podemos
                    aprender que nunca sabemos lo que tenemos hasta que se nos ha escapado."
                ),
                new Libro (
                    "Cien años de soledad",
                    "Gabriel García Márquez",
                    "Alfaguara",
                    562,
                    "9788420471839",
                    @"Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano
                    Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el
                    hielo.» Con estas palabras empieza una novela ya legendaria en los anales de la
                    literatura universal, una de las aventuras literarias más fascinantes de nuestro s
                    iglo.Millones de ejemplares de Cien años de soledad leídos en todas las lenguas y el
                    premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca»
                    -como gusta decir el escritor-son la más palpable demostración de que la aventura
                    fabulosa de la familia Buendía - Iguarán, con sus milagros, fantasías, obsesiones,
                    tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al
                    mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero."
                ),
                new Libro (
                    "La Regenta",
                    "Leopoldo Alas Clarín",
                    "Crítica",
                    182,
                    "9788484326977",
                    @"En La Regenta, sin lugar a dudas una de las cumbres de la novela realista,
                    Leopoldo Alas alcanzó a cifrar de forma inolvidable uno de los motivos que obsesionaron
                    a la narrativa europea de la segunda mitad del siglo XIX: el retrato de un carácter
                    femenino que se debate entre el deseo y su represión , y que sufre, en este caso, las
                    asechanzas de un galán y de un cura.La peripecia tiene como trasfondo la magistraly
                    despiadada descripción del entorno de Ana Ozores, esa Vetusta murmuradora y
                    provinciana en la que toda vanidad e hipocresía tiene su asiento. José Luis Gómez, tras
                    un minucioso análisis de las primeras ediciones de la obra, sigue el texto de la
                    tercera(1901), revisada por Clarín y publicada poco antes de su muerte. El prólogo de S.
                    Beser al autor y su novela en el contexto de la creación europea y española de la época,
                    mientras que la anotación facilita la comprensión de cada uno de los pormenores del rico
                    universo clariniano."
                ),
                new Libro (
                    "Los mejores cuentos de Clarín",
                    "Leopoldo Alas Clarín",
                    "De Vecchi",
                    145,
                    "9788431533441",
                    @"Una cuidadosa selección que nos muestra la riqueza de los recursos estilísticos
                    de este gran escritor del s. XIX.En el volumen se incluyen: Doña Berta, Benedictino,
                    Manín de Pepa José, Zurita, Cambio de luz, y la Conversión de Chiripa."
                )
            };
        }
    }
}

R: La principal diferencia que puedo observar es que con List, hay que escribir menos codigo, para empezar 
no requerimos de constructor en la clase Libro, mientras que con el metodo Array si que lo requerimos para 
declarar el valor de las variables, en cuanto a funcionamiento es exactamente el mismo, pero definitivamente 
solo cambia que uno requiere de mas lineas de codigo.
*/
#endregion


#region Ejercicio2
/*
class Libro {
    public string Titulo { get; init; }
    public string Autor { get; init; }
    public string Editorial { get; init; }
    public short NumPaginas { get; init; }
    public string ISBN { get; init; }
    public string Reseña { get; init; }
}

class Biblioteca {
    string nombre { get; }
    List<Libro> libros { get; }
    public Biblioteca(string nombre, List<Libro> libros) {
        this.nombre = nombre;
        this.libros = libros;
    }
    public Libro BuscaPorISBN(string ISBN) {
        return libros.FirstOrDefault(libro => libro.ISBN == ISBN);
    }
    public void Presta(string dni, string ISBN) {
        var libro  = BuscaPorISBN(ISBN);
        if(libro != null) {
            var prestamo = new {DNI = dni, libro.Titulo, ISBN = libro.ISBN};
            string prestamoString = prestamo.ToString() + Environment.NewLine;
        
            using(StreamWriter writer = new StreamWriter("prestamos.txt", true)) {
                writer.Write(prestamoString);
            }
        } else {
            throw new BibliotecaException($"El libro con ISBN {ISBN} no existe en la biblioteca.");
        }
    }
    public bool EstaPrestado(string ISBN) {
        using (StreamReader reader = new StreamReader("prestamos.txt")) {
            string linea;
            while((linea = reader.ReadLine()) != null) {
                if(linea.Contains(ISBN)) {
                    return true;
                }
            }
        }
        return false;
    }
    public int CuentaLibrosConNumeroDePaginasMenorA(int numPaginas) {
        return libros.Count(libros => libros.NumPaginas < numPaginas);
    }
    public void EliminaPorAutor(string autor) {
        libros.RemoveAll(libro => libro.Autor == autor);
    }        
}
class BibliotecaException : Exception {
    public BibliotecaException(string message) : base(message) {}
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
                Reseña = @"El libro, sinopsis… Nos presentan a este personaje como un loco
                        trastornado a causa de las novelas de caballerías, pero,
                        ¿Quién dice que el señor Quijana era sólo eso?
                        ¿Por algún motivo será la cumbre de la literatura española verdad?
                        Y aquí se plantea la duda héroe o simplemente viejo loco."
            },
            new Libro {
                Titulo = "El camino",
                Autor = "Miguel Delibes",
                Editorial = "Espasa",
                NumPaginas = 187,
                ISBN = "9788467023664",
                Reseña = @"Una de las más importantes obras de Miguel Delibes cuenta la historia de un
                        niño , Daniel el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato.
                        Una noche antes de partir Daniel recordará todo lo que le ha ocurrido en este lugar, sus
                        amigos, sus peripecias, y descubrirá que su camino está en esa aldea, unido a lo que ha
                        sido hasta ese momento su vida. Nostálgica novela realista a través de la cual podemos
                        aprender que nunca sabemos lo que tenemos hasta que se nos ha escapado."
            },
            new Libro {
                Titulo = "Cien años de soledad",
                Autor = "Gabriel García Márquez",
                Editorial = "Alfaguara",
                NumPaginas = 562,
                ISBN = "9788420471839",
                Reseña = @"Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano
                        Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el
                        hielo.» Con estas palabras empieza una novela ya legendaria en los anales de la
                        literatura universal, una de las aventuras literarias más fascinantes de nuestro s
                        iglo.Millones de ejemplares de Cien años de soledad leídos en todas las lenguas y el
                        premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca»
                        -como gusta decir el escritor-son la más palpable demostración de que la aventura
                        fabulosa de la familia Buendía - Iguarán, con sus milagros, fantasías, obsesiones,
                        tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al
                        mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero."
            },
            new Libro {
                Titulo = "La Regenta",
                Autor = "Leopoldo Alas Clarín",
                Editorial = "Crítica",
                NumPaginas = 182,
                ISBN = "9788484326977",
                Reseña = @"En La Regenta, sin lugar a dudas una de las cumbres de la novela realista,
                        Leopoldo Alas alcanzó a cifrar de forma inolvidable uno de los motivos que obsesionaron
                        a la narrativa europea de la segunda mitad del siglo XIX: el retrato de un carácter
                        femenino que se debate entre el deseo y su represión , y que sufre, en este caso, las
                        asechanzas de un galán y de un cura.La peripecia tiene como trasfondo la magistraly
                        despiadada descripción del entorno de Ana Ozores, esa Vetusta murmuradora y
                        provinciana en la que toda vanidad e hipocresía tiene su asiento. José Luis Gómez, tras
                        un minucioso análisis de las primeras ediciones de la obra, sigue el texto de la
                        tercera(1901), revisada por Clarín y publicada poco antes de su muerte. El prólogo de S.
                        Beser al autor y su novela en el contexto de la creación europea y española de la época,
                        mientras que la anotación facilita la comprensión de cada uno de los pormenores del rico
                        universo clariniano."
            },
            new Libro {
                Titulo = "Los mejores cuentos de Clarín",
                Autor = "Leopoldo Alas Clarín",
                Editorial = "De Vecchi",
                NumPaginas = 145,
                ISBN = "9788431533441",
                Reseña = @"Una cuidadosa selección que nos muestra la riqueza de los recursos estilísticos
                        de este gran escritor del s. XIX.En el volumen se incluyen: Doña Berta, Benedictino,
                        Manín de Pepa José, Zurita, Cambio de luz, y la Conversión de Chiripa."
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


#region Ejercicio3
/*
namespace BibliotecaExtensions
{
    public static class BibliotecaExtensions {
        public static string[] ISBNS(this Biblioteca.Biblioteca biblioteca) {
            return biblioteca.libros.OrderBy(libro => libro.Titulo)
                                   .Select(libro => libro.ISBN)
                                   .ToArray();
        }
    }
}

namespace Biblioteca {
    public class Libro {
        public string Titulo { get; init; }
        public string Autor { get; init; }
        public string Editorial { get; init; }
        public short NumPaginas { get; init; }
        public string ISBN { get; init; }
        public string Reseña { get; init; }
    }

    public class Biblioteca {
        public string nombre { get; }
        public List<Libro> libros { get; }
        public Biblioteca(string nombre, List<Libro> libros) {
            this.nombre = nombre;
            this.libros = libros;
        }
        public Libro BuscaPorISBN(string ISBN) {
            return libros.FirstOrDefault(libro => libro.ISBN == ISBN);
        }
        public void Presta(string dni, string ISBN) {
            var libro  = BuscaPorISBN(ISBN);
            if(libro != null) {
                var prestamo = new {DNI = dni, libro.Titulo, ISBN = libro.ISBN};
                string prestamoString = prestamo.ToString() + Environment.NewLine;
            
                using(StreamWriter writer = new StreamWriter("prestamos.txt", true)) {
                    writer.Write(prestamoString);
                }
            } else {
                throw new BibliotecaException($"El libro con ISBN {ISBN} no existe en la biblioteca.");
            }
        }
        public bool EstaPrestado(string ISBN) {
            using (StreamReader reader = new StreamReader("prestamos.txt")) {
                string linea;
                while((linea = reader.ReadLine()) != null) {
                    if(linea.Contains(ISBN)) {
                        return true;
                    }
                }
            }
            return false;
        }
        public int CuentaLibrosConNumeroDePaginasMenorA(int numPaginas) {
            return libros.Count(libros => libros.NumPaginas < numPaginas);
        }
        public void EliminaPorAutor(string autor) {
            libros.RemoveAll(libro => libro.Autor == autor);
        }        
    }
    class BibliotecaException : Exception {
        public BibliotecaException(string message) : base(message) {}
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
                    Reseña = @"El libro, sinopsis… Nos presentan a este personaje como un loco
                            trastornado a causa de las novelas de caballerías, pero,
                            ¿Quién dice que el señor Quijana era sólo eso?
                            ¿Por algún motivo será la cumbre de la literatura española verdad?
                            Y aquí se plantea la duda héroe o simplemente viejo loco."
                },
                new Libro {
                    Titulo = "El camino",
                    Autor = "Miguel Delibes",
                    Editorial = "Espasa",
                    NumPaginas = 187,
                    ISBN = "9788467023664",
                    Reseña = @"Una de las más importantes obras de Miguel Delibes cuenta la historia de un
                            niño , Daniel el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato.
                            Una noche antes de partir Daniel recordará todo lo que le ha ocurrido en este lugar, sus
                            amigos, sus peripecias, y descubrirá que su camino está en esa aldea, unido a lo que ha
                            sido hasta ese momento su vida. Nostálgica novela realista a través de la cual podemos
                            aprender que nunca sabemos lo que tenemos hasta que se nos ha escapado."
                },
                new Libro {
                    Titulo = "Cien años de soledad",
                    Autor = "Gabriel García Márquez",
                    Editorial = "Alfaguara",
                    NumPaginas = 562,
                    ISBN = "9788420471839",
                    Reseña = @"Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano
                            Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el
                            hielo.» Con estas palabras empieza una novela ya legendaria en los anales de la
                            literatura universal, una de las aventuras literarias más fascinantes de nuestro s
                            iglo.Millones de ejemplares de Cien años de soledad leídos en todas las lenguas y el
                            premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca»
                            -como gusta decir el escritor-son la más palpable demostración de que la aventura
                            fabulosa de la familia Buendía - Iguarán, con sus milagros, fantasías, obsesiones,
                            tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al
                            mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero."
                },
                new Libro {
                    Titulo = "La Regenta",
                    Autor = "Leopoldo Alas Clarín",
                    Editorial = "Crítica",
                    NumPaginas = 182,
                    ISBN = "9788484326977",
                    Reseña = @"En La Regenta, sin lugar a dudas una de las cumbres de la novela realista,
                            Leopoldo Alas alcanzó a cifrar de forma inolvidable uno de los motivos que obsesionaron
                            a la narrativa europea de la segunda mitad del siglo XIX: el retrato de un carácter
                            femenino que se debate entre el deseo y su represión , y que sufre, en este caso, las
                            asechanzas de un galán y de un cura.La peripecia tiene como trasfondo la magistraly
                            despiadada descripción del entorno de Ana Ozores, esa Vetusta murmuradora y
                            provinciana en la que toda vanidad e hipocresía tiene su asiento. José Luis Gómez, tras
                            un minucioso análisis de las primeras ediciones de la obra, sigue el texto de la
                            tercera(1901), revisada por Clarín y publicada poco antes de su muerte. El prólogo de S.
                            Beser al autor y su novela en el contexto de la creación europea y española de la época,
                            mientras que la anotación facilita la comprensión de cada uno de los pormenores del rico
                            universo clariniano."
                },
                new Libro {
                    Titulo = "Los mejores cuentos de Clarín",
                    Autor = "Leopoldo Alas Clarín",
                    Editorial = "De Vecchi",
                    NumPaginas = 145,
                    ISBN = "9788431533441",
                    Reseña = @"Una cuidadosa selección que nos muestra la riqueza de los recursos estilísticos
                            de este gran escritor del s. XIX.En el volumen se incluyen: Doña Berta, Benedictino,
                            Manín de Pepa José, Zurita, Cambio de luz, y la Conversión de Chiripa."
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
}
*/
#endregion


#region Ejercicio4
/*
namespace System.Collections.Generic.ListExtensions {
    public static class ListExtensions {
        private static Random random = new Random();
        public static List<T> SecuenciaAleatoria<T>(this List<T> list, int n) {
            if (list.Count < n) {
                throw new ListExtensionException("La lista original no tiene suficientes elementos para generar una secuencia aleatoria sin repeticiones.");
            }
            List<T> result = new List<T>();
            HashSet<int> usedIndices = new HashSet<int>();
            int count = 0;
            while (count < n) {
                int index = random.Next(list.Count);
                if (!usedIndices.Contains(index)) {
                    result.Add(list[index]);
                    usedIndices.Add(index);
                    count++;
                }
            }
            return result;
        }
        public static List<T> SecuenciaAleatoriaConRepeticiones<T>(this List<T> list, int n) {
            List<T> result = new List<T>();
            for (int i = 0; i < n; i++) {
                int index = random.Next(list.Count);
                result.Add(list[index]);
            }
            return result;
        }
    }
}
class ListExtensionException : Exception {
    public ListExtensionException(string message) : base(message) {}
}
class Program {
    static void Main(string[] args) {
        try {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(string.Join(", ", numeros.SecuenciaAleatoria(5)));
            Console.WriteLine(string.Join(", ", numeros.SecuenciaAleatoriaConRepeticiones(5)));
            Console.WriteLine(string.Join(", ", numeros.SecuenciaAleatoriaConRepeticiones(15)));
            Console.WriteLine(string.Join(", ", numeros.SecuenciaAleatoria(15)));
        } catch (ListExtensionException e) {
            Console.WriteLine(e.Message);
        }
    }
}
*/
#endregion


