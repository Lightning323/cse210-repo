using System;

namespace TodoList;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, bool> list = [];
        Console.WriteLine("\nTo List Application." +
                          "\nPlease enter items in the todo list using the \"add\" and \"remove\" keywords." +
                          "\nUse the \"view\" keyword to see your list items." +
                          "\nUse \"check\" or \"uncheck\" to mark items on the todo list as complete." +
                          "\nUse \"exit\" to exit");
        while (true)
        {
            string input = Console.ReadLine().Trim();
            if (input.ToLower().Equals("exit"))
            {
                break;
            }
            else if (input.ToLower().Equals("list"))
            {
                foreach (KeyValuePair<string, bool> element in list)
                {
                    string status = element.Value ? "DONE" : "INCOMPLETE";
                    Console.WriteLine($"{element.Key}: \t {status}");
                }
            }
            else
            {
                string[] command = input.Split(" ");
                string keyword = command[0].ToLower();
                string data = string.Join(" ", command[1..]);
                Console.WriteLine($"\n{keyword} === {data}");
                if (keyword.Equals("add"))
                {
                    if (!list.ContainsKey(data))
                    {
                        list.Add(data, false);
                    }
                    else
                    {
                        Console.WriteLine("Already added that");
                    }
                }
                else if (keyword.Equals("remove"))
                {
                    list.Remove(data);
                }
                else if (keyword.Equals("check"))
                {
                    if (list.ContainsKey(data))
                    {
                        list[data] = true;
                    }
                    else
                    {
                        Console.WriteLine("Item not found");
                    }
                }
                else if (keyword.Equals("cncheck"))
                {
                    if (list.ContainsKey(data))
                    {
                        list[data] = false;
                    }
                    else
                    {
                        Console.WriteLine("Item not found");
                    }
                }
            }
        }
    }
}