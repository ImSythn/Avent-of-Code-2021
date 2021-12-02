using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Day2Dive
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Part 1

            {
                Vector2 position = new Vector2();
                StreamReader file = new StreamReader("../../../../input.txt");
                string input = file.ReadToEnd();

                List<string> courseString = input.Split('\n').ToList();
                foreach (var course in courseString)
                {
                    string[] splitCourseString = course.Split(' ', 2);

                    switch (splitCourseString[0])
                    {
                        case "forward":
                            position.X += int.Parse(splitCourseString[1]);
                            break;
                        case "down":
                            position.Y -= int.Parse(splitCourseString[1]);
                            break;
                        case "up":
                            position.Y += int.Parse(splitCourseString[1]);
                            break;
                    }
                }

                Console.WriteLine(
                    $"The sub is at the following coordinate: horizontal position: {position.X}, depth: {-position.Y} multiplying these makes: {position.X * -position.Y}");
            }

            #endregion

            #region Part 2

            {
                Vector2 position = new Vector2();
                StreamReader file = new StreamReader("../../../../input.txt");
                string input = file.ReadToEnd();
                int aim = 0;

                List<string> courseString = input.Split('\n').ToList();
                foreach (var course in courseString)
                {
                    string[] splitCourseString = course.Split(' ', 2);

                    switch (splitCourseString[0])
                    {
                        case "forward":
                            int displacement = int.Parse(splitCourseString[1]);
                            position.X += displacement;
                            position.Y -= displacement * aim;
                            break;
                        case "down":
                            aim += int.Parse(splitCourseString[1]);
                            break;
                        case "up":
                            aim -= int.Parse(splitCourseString[1]);
                            break;
                    }
                }

                Console.WriteLine(
                    $"The sub is at the following coordinate: horizontal position: {position.X}, depth: {-position.Y} multiplying these makes: {((int)position.X * -(int)position.Y)}");
            }

            #endregion
        }
    }
}