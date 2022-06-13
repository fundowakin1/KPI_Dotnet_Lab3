﻿using Lab3.Creators;

namespace Lab3.MenuDisplay
{
    public class Menu
    {
        public CypherCreator GetCypher()
        {
            while (true)
            {
                Console.WriteLine("\nChoose a cypher for creating the password: ");
                Console.WriteLine("\t1. Ceasar");
                Console.WriteLine("\t2. Atbash");
                var key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        Console.WriteLine("Please, input cypher key:");
                        if (int.TryParse(Console.ReadLine(), out var cypherKey))
                            return new CeasarCreator(cypherKey);
                        else
                            throw new InvalidDataException("Key was invalid!");
                    case '2':
                        return new AtbashCreator();
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
        }
    }
}