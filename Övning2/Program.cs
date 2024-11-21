List<string> Alist = new(["Nerf Gun", "Ball", "Doll", "Buzz Lightyear", "Woody"]);

foreach (var item in Alist)
{
    System.Console.WriteLine(item);
}

List<string> Names = new(["Theo", "Sadik", "Theodora", "Josef", "Vincent"]);

Console.ReadLine();

foreach(var item in Names)
{
    System.Console.WriteLine(item);
}

int[] Num = [1,2,3,4,5];

List<int> Number = new List<int> (Num);

Console.ReadLine();

for (int i = 0; i < Names.Count; i++)
{
    System.Console.WriteLine($"{Names[i]} ger {Alist[i]} betyget {Number[i]}");
}



List<string> cities = new List<string>();

while(true)
{
    System.Console.Write("Cities List: ");
    foreach (var item in cities)
    {
        System.Console.Write($"[{item}]");
    }

    System.Console.WriteLine("");
    string Input = Console.ReadLine();

    

    if(Input == "exit")
    {
        break;
    }
    else
    {
        cities.Add(Input);
    }

    Console.Clear();
}


