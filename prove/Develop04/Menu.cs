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
            BreathingActivity breathingactivity = new BreathingActivity("Jason", "Briterature", 3);
            breathingactivity.DisplayStartingMessage();
            breathingactivity.Run();
        }
        // else if (menu == "2"){
        //     ReflectingActivity.Run();
        // }else if (menu == "3"){
        //     ListingActivity.Run();
        // }else if (menu == "4"){
        //     Activity.Run();
        // }
    }while (menu!= "5");
    Console.WriteLine("Good day.");
    }
}