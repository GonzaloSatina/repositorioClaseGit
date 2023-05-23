// 1.
// Escribe un programa que solicite un número al usuario e imprima por pantalla la suma consecutiva de los números del 1 al número ingresado.

// RESOLUCIÓN:

Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());
int suma = 0;

for (int i = 1; i <= numero; i++) {
  suma += i;
}

Console.WriteLine("La suma consecutiva de los números del 1 al {0} es: {1}", numero, suma);

//###############################################################################################################################################################################

// 2.
// Escribe una función que solicite un número al usuario y devuelva verdadero si es primo o falso si no lo es.

// RESOLUCIÓN:

public static bool EsPrimo(int numero) {
  if (numero == 1) {
    return false;
  }

  for (int i = 2; i < numero; i++) {
    if (numero % i == 0) {
      return false;
    }
  }

  return true;
}

// En el método Main podemos utilizar la función de la siguiente manera:

Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());

if (EsPrimo(numero)) {
  Console.WriteLine("El número {0} es primo.", numero);
} else {
  Console.WriteLine("El número {0} no es primo.", numero);
}

//###############################################################################################################################################################################

// 3.
// Crea una clase llamada "Persona" que tenga dos propiedades: "nombre" y "edad". Agrega un método llamado "Presentarse" que imprima por pantalla una cadena que incluya el nombre y la edad de la persona.

// RESOLUCIÓN:

public class Persona {
  public string nombre;
  public int edad;

  public void Presentarse() {
    Console.WriteLine("Hola, mi nombre es {0} y tengo {1} años.", nombre, edad);
  }
}

// En el método Main podemos utilizar la clase de la siguiente manera:

Persona juan = new Persona();
juan.nombre = "Juan";
juan.edad = 25;

juan.Presentarse();

//###############################################################################################################################################################################

// 4.
// Crea una clase "Animal" que tenga una propiedad "especie" y un método "EmitirSonido". Crea dos clases hijas de "Animal": "Perro" y "Gato". Agrega un método en cada clase que imprima por pantalla el sonido que hacen los animales.

// RESOLUCIÓN:

public class Animal {
  public string especie;

  public virtual void EmitirSonido() {
    Console.WriteLine("El animal está en silencio.");
  }
}

public class Perro : Animal {
  public override void EmitirSonido() {
    Console.WriteLine("Guau guau!");
  }
}

public class Gato : Animal {
  public override void EmitirSonido() {
    Console.WriteLine("Miau miau!");
  }
}

// En el método Main podemos utilizar las clases de la siguiente manera:

Animal animal = new Animal();
animal.EmitirSonido(); // Imprime "El animal está en silencio."

Perro perro = new Perro();
perro.EmitirSonido(); // Imprime "Guau guau!"

Gato gato = new Gato();
gato.EmitirSonido(); // Imprime "Miau miau!"

//###############################################################################################################################################################################

// 5.
// Crea una lista de números enteros y agrega 5 números aleatorios. Luego, imprime por pantalla la suma de todos los números de la lista.

// RESOLUCIÓN:

List<int> numeros = new List<int>();
Random random = new Random();

for (int i = 0; i < 5; i++) {
  numeros.Add(random.Next(1, 100));
}

int suma = 0;

foreach (int numero in numeros) {
  suma += numero;
}

Console.WriteLine("La suma de los números de la lista es: {0}", suma);

//###############################################################################################################################################################################

// 6.
// Crea una matriz de 3x3 y agrega números aleatorios del 1 al 9. Luego, imprime por pantalla la matriz completa y la suma de todos sus elementos.

// RESOLUCIÓN:

int[,] matriz = new int[3, 3];
Random random = new Random();

for (int i = 0; i < 3; i++) {
  for (int j = 0; j < 3; j++) {
    matriz[i, j] = random.Next(1, 10);
  }
}

Console.WriteLine("Matriz completa:");

for (int i = 0; i < 3; i++) {
  for (int j = 0; j < 3; j++) {
    Console.Write("{0} ", matriz[i, j]);
  }
  Console.WriteLine();
}

int suma = 0;

for (int i = 0; i < 3; i++) {
  for (int j = 0; j < 3; j++) {
    suma += matriz[i, j];
  }
}

Console.WriteLine("La suma de los elementos de la matriz es: {0}", suma);

//###############################################################################################################################################################################

// 7.
// Escribe una función que reciba una matriz cuadrada y devuelva verdadero si la diagonal principal (los números desde la esquina superior izquierda a la inferior derecha) tiene todos los elementos iguales a 1, y falso si no.

// RESOLUCIÓN:

public static bool DiagonalPrincipalIgualUno(int[,] matriz) {
  int dimension = matriz.GetLength(0);

  for (int i = 0; i < dimension; i++) {
    if (matriz[i, i] != 1) {
      return false;
    }
  }

  return true;
}

// En el método Main podemos utilizar la función de la siguiente manera:

int[,] matriz = new int[,] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

if (DiagonalPrincipalIgualUno(matriz)) {
  Console.WriteLine("La diagonal principal de la matriz tiene todos los elementos iguales a 1.");
} else {
  Console.WriteLine("La diagonal principal de la matriz NO tiene todos los elementos iguales a 1.");
}
