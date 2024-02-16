using System.Reflection;
class BasicMenu
{
    public static string Initialize(List<List<string>> list)
    {
        Dictionary<string, List<string>> options = ToDict(list);
        string menu = "0";
        string results = "";
        int menus = options.Count();
        do
            {
            Console.WriteLine("Please enter a number.");
            foreach(string key in options.Keys)
            {
                List<string> values = options[key];
                Console.WriteLine($"{key}. {values[0]}");
            }
            menu = Console.ReadLine();
            if (options.ContainsKey(menu))
            {
                string className = options[menu][1];
                string methodName = options[menu][2];
                results = methodName;
                string runOnce = options[menu][3];
                Type classType = Type.GetType(className);
                MethodInfo methodInfo = classType.GetMethod(methodName);
                if (methodInfo != null)
                {
                    object instance = Activator.CreateInstance(classType);
                    methodInfo.Invoke(instance, null);
                    if (runOnce == "true"){
                        menu = $"{menus}";
                    }
                }
                else
                {
                    Console.WriteLine($"Method '{methodName}' not found in class '{className}'.");
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }while (int.Parse(menu) != menus);       
        return results;
    }
    public static Dictionary<string, List<string>> ToDict(List<List<string>> options)
    {
        Dictionary<string, List<string>> menu = new Dictionary<string, List<string>>();
        int i = 0;
        foreach(List<string> option in options)
        {
            i++;
            string key = i.ToString();
            menu[key] = new List<string>();
            menu[key].AddRange(option);
        }
        return menu;
    }
    public static void End()
    {
        Console.WriteLine($"Returning to previous menu.");
    }
}