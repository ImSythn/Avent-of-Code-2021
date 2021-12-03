using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day3BinaryDiagnostic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            
            {
                StreamReader file = new StreamReader("../../../../input.txt");
                string input = file.ReadToEnd();
                
 
                var numbersString = input.Split('\n').ToList();

                string gamma = "";
                string epsilon= "";
                for (int i = 0; i < numbersString[0].Length; i++)
                {
                    int zeroValues = 0;
                    int oneValues = 0;
                    for (int j = 0; j < numbersString.Count; j++)
                    {
                        char bit = numbersString[j][i];
                        if (bit.Equals('0'))
                            zeroValues++;
                        else
                            oneValues++;
                    }

                    gamma += zeroValues > oneValues ? '0' : '1';
                    epsilon += zeroValues > oneValues ? '1' : '0';
                }
                Console.WriteLine($"Multiplicative of gamma and epsilon are: {Convert.ToInt32(gamma, 2) *  Convert.ToInt32(epsilon, 2)} ");
            }
            
            #endregion
            
            #region Part 2
            
            {
                StreamReader file = new StreamReader("../../../../input.txt");
                string input = file.ReadToEnd();

                var numbersString = input.Split('\n').ToList();
            }
            
            #endregion
        }
    }
}