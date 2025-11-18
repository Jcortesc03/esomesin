double op1 = Math.Pow((2+4), 2);
double op2 = Math.Pow((4*8), 3);
double resultado = op1 / op2;

Console.WriteLine("El resultado es: " + Convert.ToString(resultado));

double numMax = Math.Max(10 , 5);
Console.WriteLine("El n máximo es: "+ Convert.ToString(numMax));

double numMin = Math.Min(10 , 5);
Console.WriteLine("El n mínimo es: "+ Convert.ToString(numMin));

double raiz = Math.Sqrt(64);
Console.WriteLine("La raíz cuadrada es: " + Convert.ToString(raiz));


double absoluto = Math.Abs(-4.7);
Console.WriteLine("EL valor absoluto es: " + Convert.ToString(absoluto));

int redondear = Convert.ToInt16(Math.Round(9.99));
Console.WriteLine("EL valor redondeado es: " + Convert.ToString(redondear));

int redondear2 = Convert.ToInt16(Math.Round(resultado));
Console.WriteLine("EL valor redondeado del primer ejercicio es: " + Convert.ToString(redondear2));

string texto = "Sean gay";
Console.WriteLine($"La longitud del texto: ({texto}) es: {texto.Length}");

Console.WriteLine("Ingrese el número de su calle: ");
int numCalle = Convert.ToInt16(Console.ReadLine()); 

Console.WriteLine("Ingrese su la letra de su calle: ");
string? letraCalle = Console.ReadLine();

Console.WriteLine("Ingrese el número de su carrera: ");
int numCarrera = Convert.ToInt16(Console.ReadLine()); 

Console.WriteLine("Ingrese la letra de su carrera: ");
string? letraCarrera = Console.ReadLine();

Console.WriteLine("Ingrese el complemento de su dirección: ");
string? Complemento = Console.ReadLine();

string direccion = $"{numCalle}{letraCalle} #{numCarrera}{letraCarrera} - {Complemento}";
Console.WriteLine($"La longitud de su dirección es: ({direccion}) es: {direccion.Length}");

Console.WriteLine("Ingrese su nombre: ");
string nombre  = Console.ReadLine();
Console.WriteLine($"Su nombre en mayusculas es: {nombre.ToUpper()}");

Console.WriteLine("Ingrese su email: ");
string email  = Console.ReadLine();
Console.WriteLine($"Su email en minúsculas es: {email.ToLower()}");

