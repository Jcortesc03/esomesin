while(1==1){

    Console.WriteLine("Write the day of the week u want 2 see :)");
    int day = Convert.ToInt16(Console.ReadLine());


        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednsday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            
            default:
                Console.WriteLine($"There's no {day} day in the week.");
                break;
        }
    Console.WriteLine("Do u want 2 continue? y/n");
    string question = Console.ReadLine().ToLower();
    if(question == "n" || question == "no")
    {
        break;
    }
}
Console.WriteLine("Thank u 4 using");