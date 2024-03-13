string[] a = ["NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" ];
string[] b = [ "NORTH", "WEST", "SOUTH", "EAST" ];

string[] result1 = dirReduc(a);
string[] result2 = dirReduc(b);

foreach (string dir in result1)
{
    Console.WriteLine(dir);
}

Console.WriteLine();

foreach (string dir in result2)
{
    Console.WriteLine(dir);
}

static string[] dirReduc(String[] directions)
{
    List<string> directionsList = directions.ToList();

    for (int i = 0; i < directionsList.Count - 1; i++)
    {
        if (directionsList[i] == "NORTH" && directionsList[i + 1] == "SOUTH")
        {
            directionsList.RemoveAt(i);
            directionsList.RemoveAt(i);
            i = -1;
        }
        else if (directionsList[i] == "SOUTH" && directionsList[i + 1] == "NORTH")
        {
            directionsList.RemoveAt(i);
            directionsList.RemoveAt(i);
            i = -1;
        }
        else if (directionsList[i] == "EAST" && directionsList[i + 1] == "WEST")
        {
            directionsList.RemoveAt(i);
            directionsList.RemoveAt(i);
            i = -1;
        }
        else if (directionsList[i] == "WEST" && directionsList[i + 1] == "EAST")
        {
            directionsList.RemoveAt(i);
            directionsList.RemoveAt(i);
            i = -1;
        }
    }

    return directionsList.ToArray();


}

// ---- A better way ----

//static string[] dirReduc(String[] directions)
//{
//    Stack<string> stack = new Stack<string>();

//    foreach (string direction in directions)
//    {
//        if (stack.Count > 0 && Opposite(stack.Peek(), direction))
//        {
//            stack.Pop();
//        }
//        else
//        {
//            stack.Push(direction);
//        }
//    }

//    string[] result = stack.Reverse().ToArray();
//    return result;
//}

//static bool Opposite(string dir1, string dir2)
//{
//    return (dir1 == "NORTH" && dir2 == "SOUTH") ||
//           (dir1 == "SOUTH" && dir2 == "NORTH") ||
//           (dir1 == "EAST" && dir2 == "WEST") ||
//           (dir1 == "WEST" && dir2 == "EAST");
//}

Console.ReadKey();
