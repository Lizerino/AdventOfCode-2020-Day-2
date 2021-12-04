using System;
using System.Collections.Generic;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleInput = new List<string>();

            var getInput = true;
            while (getInput)
            {
                var input = Console.ReadLine();
                if (input=="")
                {
                    getInput = false;
                }
                else
                {
                    puzzleInput.Add(input);
                }
            }

            var min = 0;
            var max = 0;
            char letter;
            var password = "";
            var validPasswords=0;

            var splitRows = new List<string[]>();

            foreach (var row in puzzleInput)
            {
                splitRows.Add(row.Split(" "));
            }

            for (int i = 0; i < splitRows.Count; i++)
            {
                var numbers = splitRows[i][0].Split("-");
                min = int.Parse(numbers[0]);
                max = int.Parse(numbers[1]);
                letter = splitRows[i][1][0];
                password = splitRows[i][2];

                var count=0;
                foreach (var character in password)
                {
                    if (password[min-1]==letter)
                    {
                        count++;
                    }
                    if (password[max-1] == letter)
                    {
                        count++;
                    }
                    if (count==1)
                    {
                        validPasswords++;
                    }
                }
            }

            
            Console.WriteLine(validPasswords);
        }
    }
}
