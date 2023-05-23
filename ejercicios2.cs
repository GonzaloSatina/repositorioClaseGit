// 1.
// Escribe un programa que solicite al usuario las notas de 5 estudiantes y determine cuál es el promedio general de la clase. Si el promedio general es mayor a 6, imprime "La clase aprobó". Si no, imprime "La clase no aprobó".

// RESOLUCIÓN:

float suma = 0;

for (int i = 1; i <= 5; i++) {
  Console.WriteLine("Ingrese la nota del estudiante {0}:", i);
  float nota = float.Parse(Console.ReadLine());
  suma += nota;
}

float promedio = suma / 5;

if (promedio > 6) {
  Console.WriteLine("La clase aprobó.");
} else {
  Console.WriteLine("La clase no aprobó.");
}


// 2. 
// Escribe una función que calcule el factorial de un número ingresado por el usuario.

// RESOLUCIÓN:

public static int Factorial(int numero) {
  int factorial = 1;

  for (int i = numero; i > 0; i--) {
    factorial *= i;
  }

  return factorial;
}

// En el método Main podemos utilizar la función de la siguiente manera:

Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());

int resultado = Factorial(numero);
Console.WriteLine("El factorial de {0} es igual a {1}.", numero, resultado);


// 3. 
// Crea una clase "Empresa" que tenga una propiedad "nombre" y una lista de objetos "Empleado". Cada objeto "Empleado" debe tener dos propiedades: "nombre" y "salario". Agrega un método a la clase "Empresa" que calcule y devuelva el salario promedio de todos los empleados.

// RESOLUCIÓN:

public class Empleado {
  public string nombre;
  public float salario;
}

public class Empresa {
  public string nombre;
  public List<Empleado> empleados = new List<Empleado>();

  public float CalcularSalarioPromedio() {
    float suma = 0;

    foreach (Empleado empleado in empleados) {
      suma += empleado.salario;
    }

    float promedio = suma / empleados.Count;
    return promedio;
  }
}

// En el método Main podemos utilizar las clases de la siguiente manera:

Empresa miEmpresa = new Empresa();
miEmpresa.nombre = "Mi Empresa";

Empleado empleado1 = new Empleado();
empleado1.nombre = "Juan";
empleado1.salario = 2000;

Empleado empleado2 = new Empleado();
empleado2.nombre = "María";
empleado2.salario = 2200;

miEmpresa.empleados.Add(empleado1);
miEmpresa.empleados.Add(empleado2);

float salarioPromedio = miEmpresa.CalcularSalarioPromedio();
Console.WriteLine("El salario promedio de los empleados de {0} es de {1}.", miEmpresa.nombre, salarioPromedio);


// 4. 
// Crea una clase "Figura" que tenga dos métodos virtuales: "CalcularArea" y "CalcularPerimetro". Crea dos clases hijas de "Figura": "Rectángulo" y "Círculo". Crea una interfaz llamada "IDibujable" con un método "Dibujar". Agrega los métodos "DarInformacion" en cada clase hija, que imprima por pantalla el área y el perímetro de la figura, y un método "DibujarFigura" que imprima por pantalla la figura dibujada.

// RESOLUCIÓN:

public abstract class Figura {
  public abstract float CalcularArea();
  public abstract float CalcularPerimetro();
}

public class Rectangulo : Figura {
  public float ancho;
  public float altura;

  public override float CalcularArea() {
    return ancho * altura;
  }

  public override float CalcularPerimetro() {
    return (ancho + altura) * 2;
  }

  public void DarInformacion() {
    Console.WriteLine("Rectángulo:");
    Console.WriteLine("  - Área: {0}", CalcularArea());
    Console.WriteLine("  - Perímetro: {0}", CalcularPerimetro());
  }

  public void DibujarFigura() {
    Console.WriteLine("      ____");
    Console.WriteLine("     |    |");
    Console.WriteLine("  {0:0.00}|    |{1:0.00}", altura, altura);
    Console.WriteLine("     |____|");
    Console.WriteLine("     {0:0.00}", ancho);
  }
}

public class Circulo : Figura {
  public float radio;

  public override float CalcularArea() {
    return (float)Math.PI * radio * radio;
  }

  public override float CalcularPerimetro() {
    return (float)Math.PI * radio * 2;
  }

  public void DarInformacion() {
    Console.WriteLine("Círculo:");
    Console.WriteLine("  - Área: {0}", CalcularArea());
    Console.WriteLine("  - Perímetro: {0}", CalcularPerimetro());
  }

  public void DibujarFigura() {
    Console.WriteLine("      __");
    Console.WriteLine("    /    \\");
    Console.WriteLine("   |      |");
    Console.WriteLine("    \\ __ /");
    Console.WriteLine("  {0:0.00}", radio * 2);
  }
}

public interface IDibujable {
  void Dibujar();
}

// En el método Main podemos utilizar las clases e interfaz de la siguiente manera:

Rectangulo miRectangulo = new Rectangulo();
miRectangulo.ancho = 5;
miRectangulo.altura = 3;

Circulo miCirculo = new Circulo();
miCirculo.radio = 4;

miRectangulo.DarInformacion();
miRectangulo.DibujarFigura();

Console.WriteLine();

miCirculo.DarInformacion();
miCirculo.DibujarFigura();


// 5.  
// Crea una lista de objetos "Estudiante" con las propiedades "nombre", "edad" y "notaFinal". Luego, utiliza LINQ para seleccionar los estudiantes que tengan una nota final mayor a 7 y ordenarlos de manera descendente por edad.

// RESOLUCIÓN:

public class Estudiante {
  public string nombre;
  public int edad;
  public float notaFinal;
}

// Creación de la lista de estudiantes
List<Estudiante> estudiantes = new List<Estudiante>();
estudiantes.Add(new Estudiante { nombre = "Juan", edad = 22, notaFinal = 8 });
estudiantes.Add(new Estudiante { nombre = "María", edad = 23, notaFinal = 6 });
estudiantes.Add(new Estudiante { nombre = "Pedro", edad = 21, notaFinal = 9 });
estudiantes.Add(new Estudiante { nombre = "Laura", edad = 24, notaFinal = 7.5f });

// Selección de los estudiantes que tienen una nota final mayor a 7 y ordenamiento descendente por edad
var estudiantesAprobados = estudiantes.Where(e => e.notaFinal > 7).OrderByDescending(e => e.edad);

// Impresión de los estudiantes seleccionados
foreach (Estudiante estudiante in estudiantesAprobados) {
  Console.WriteLine("Nombre: {0} - Edad: {1} - Nota Final: {2}", estudiante.nombre, estudiante.edad, estudiante.notaFinal);
}


// 6. 
// Crea una matriz de 4x4 y agrega números aleatorios del 1 al 5. Luego, utiliza LINQ para contar cuántas veces aparece el número 3 en la matriz.

// RESOLUCIÓN:

int[,] matriz = new int[4, 4];
Random random = new Random();

for (int i = 0; i < 4; i++) {
  for (int j = 0; j < 4; j++) {
    matriz[i, j] = random.Next(1, 6);
  }
}

// Conteo de cuántas veces aparece el número 3 en la matriz
var cantidadDeTres = (from int numero in matriz
                      where numero == 3
                      select numero).Count();

Console.WriteLine("El número 3 aparece {0} veces en la matriz.", cantidadDeTres);


// 7.
// Escribe una función que reciba una matriz cuadrada y devuelva verdadero si la suma de cada fila y cada columna es igual a la suma de la diagonal principal (los números desde la esquina superior izquierda a la inferior derecha), y falso si no.

// RESOLUCIÓN:

public static bool SumaFilasColumnasDiagonalIguales(int[,] matriz) {
  int dimension = matriz.GetLength(0);
  int sumaDiagonal = 0;

  for (int i = 0; i < dimension; i++) {
    sumaDiagonal += matriz[i, i];
  }

  for (int i = 0; i < dimension; i++) {
    int sumaFila = 0;

    for (int j = 0; j < dimension; j++) {
      sumaFila += matriz[i, j];
    }

    if (sumaFila != sumaDiagonal) {
      return false;
    }
  }

  for (int j = 0; j < dimension; j++) {
    int sumaColumna = 0;

    for (int i = 0; i < dimension; i++) {
      sumaColumna += matriz[i, j];
    }

    if (sumaColumna != sumaDiagonal) {
      return false;
    }
  }

  return true;
}

// En el método Main podemos utilizar la función de la siguiente manera:

int[,] matriz = new int[,] { {2, 9, 4}, {7, 5, 3}, {6, 1, 8} };

if (SumaFilasColumnasDiagonalIguales(matriz)) {
  Console.WriteLine("La suma de las filas, columnas y diagonal principal de la matriz es igual.");
} else {
  Console.WriteLine("La suma de las filas, columnas y diagonal principal de la matriz NO es igual.");
}
