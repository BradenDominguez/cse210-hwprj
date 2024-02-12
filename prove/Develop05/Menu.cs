using System.Reflection;
class Menu
{
    public static void Initialize(List<List<string>> list, GoalMenu menuObject)
    {
        Dictionary<string, List<string>> options = ToDict(list);
        string menu = "0";
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
                Type classType = Type.GetType(className);
                MethodInfo methodInfo = classType.GetMethod(methodName);
                if (methodInfo != null)
                {
                    methodInfo.Invoke(menuObject, null);
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
    }
}