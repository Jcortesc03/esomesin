/*
static void IngresarDato(string parametro){
    Console.WriteLine("Ingrese su " + parametro);
    string variable = Convert.ToString(Console.ReadLine());
    
    return variable;
}


static void IngresarDatoNum(string parametro){
    Console.WriteLine("Ingrese su " + parametro);
    return ConvertToInt16(Console.ReadLine());
}
*/

while (1 == 1){
    
        Console.Write("Ingrese su nombre: ");
        string? nombre = Console.ReadLine();
        
        Console.Write("Ingrese su edad: ");
        int edad = Convert.ToInt16(Console.ReadLine());
        string? edadStr = Convert.ToString(edad);

        Console.Write("Ingrese su calle: ");
        int calle = Convert.ToInt16(Console.ReadLine());
        string? calleStr = Convert.ToString(calle);

        Console.Write("Ingrese su letra: ");
        string? letra = Console.ReadLine();


        string? direccion = Console.ReadLine();
        //Convert.ToString(edad);

        Console.ForegroundColor = ConsoleColor.Red; //Sean maricon, este es para cambiar el color
        Console.WriteLine($"Hola {nombre} ♥ , Tienes: {edadStr}  años"); //Con interpolación
        Console.WriteLine(string.Format("Hola {0} ♥ , Tienes: {1}  años", nombre, edadStr)); //Con formateo :3

        Console.ResetColor();//Este es para volver al color original jeje
        Console.WriteLine("¿Desea continuar Si = 1, No = 2? ");
        string? pregunta = Console.ReadLine();
        //Esto ya es coquetería
        
        if(pregunta == "1"){
            continue;
        }
        
        if(pregunta == "2"){
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("Gracias x usar");
            Console.ResetColor();
            break;
        }
        
        else{
        Console.WriteLine("Ingrese un número valido ");
        }
      }