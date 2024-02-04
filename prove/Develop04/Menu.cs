class Menu
{
    public static void Initialize()
    {
    string menu;
    do
    {
        Console.WriteLine("Please enter a number.");
        Console.WriteLine("1.Breathing Activity");
        Console.WriteLine("2.Reflecting Activity");
        Console.WriteLine("3.Listing Activity");
        Console.WriteLine("4.Custom Activity");
        Console.WriteLine("5.Exit");
        menu = Console.ReadLine();
        if (menu == "1"){
            string description = "This activity will help you breathe.";
            Console.WriteLine("How many seconds do you want to breathe?");
            int duration = int.Parse(Console.ReadLine());
            BreathingActivity breathingactivity = new BreathingActivity("Breathing", description, duration);
            breathingactivity.DisplayStartingMessage();
            breathingactivity.Run();
            breathingactivity.DisplayEndingMessage();
        }
        else if (menu == "2"){
            string description = "This activity will help you reflect on life.";
            Console.WriteLine("How many prompts do you want?");
            int duration = int.Parse(Console.ReadLine());
            ReflectingActivity reflectingactivity = new ReflectingActivity("Reflecting", description, duration);
            reflectingactivity.DisplayStartingMessage();
            reflectingactivity.Run();
            reflectingactivity.DisplayEndingMessage();
        }
        else if (menu == "3"){
            string description = "This activity will help you list.";
            Console.WriteLine("How many prompts do you want?");
            int duration = int.Parse(Console.ReadLine());
            ListingActivity listingactivity = new ListingActivity("Listing", description, duration);
            listingactivity.DisplayStartingMessage();
            listingactivity.Run();
            listingactivity.DisplayEndingMessage();
        // }else if (menu == "4"){
        //     Activity.Run();
        // }
        }
    }while (menu!= "5");
    Console.WriteLine("Good day.");
    
}
}