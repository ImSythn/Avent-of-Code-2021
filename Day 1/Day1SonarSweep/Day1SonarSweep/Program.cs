// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

StreamReader file = new StreamReader("../../../../input.txt");
string input = file.ReadToEnd();

var numbersString = input.Split('\n').ToList();

var numbers = numbersString.Select(int.Parse).ToList();

int increaseCount = 0;
int scanDelta = 3;

for(int i = 0; i+scanDelta < numbers.Count; i++)
{
    int num = 0;
    int nextNum = 0;
    
    for (int j = 0; j < scanDelta; j++)
    {
        num += numbers[i + j];
        nextNum += numbers[i + j + 1];
    }
    
    if (num < nextNum)
        increaseCount++;
}
Console.WriteLine(increaseCount);



