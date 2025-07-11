using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , int> voting = new Dictionary<string , int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int voto = int.Parse(line[1]);
                        if (voting.ContainsKey(name))
                        {
                            voting[name] += voto;
                        }
                        else
                        {
                            voting.Add(name, voto);
                        }
                    }
                    foreach (KeyValuePair<string, int> item in voting)
                    {
                        Console.WriteLine($"{item.Key}, {item.Value}");
                    }
                    Console.WriteLine("!!!End voting!!!");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}