while (1 == 1){
    
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Ingrese su edad: ");
        string edad = Console.ReadLine();
        
        Console.ForegroundColor = ConsoleColor.Red; //Sean maricon, este es para cambiar el color
        Console.WriteLine($"Hola {nombre} ♥ , Tienes: {edad}  años"); //Con interpolación
        Console.WriteLine(string.Format("Hola {0} ♥ , Tienes: {1}  años", nombre, edad)); //Con formateo :3

        Console.ResetColor();//Este es para volver al color original jeje
        Console.WriteLine("¿Desea continuar Si = 1, No = 2? ");
        string pregunta = Console.ReadLine();
        //Esto ya es coquetería
        
        if(pregunta == "1"){
            continue;
        }
        
        if(pregunta == "2"){
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("Gracias x usar, se cuida ese anastacio");
            Console.ResetColor();
            break;
        }
        
        else{
        Console.WriteLine("Ingrese un número valido ");
        }
      }