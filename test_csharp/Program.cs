using System;
using System.Collections.Generic;

namespace test_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "String Interpolation";
            // int a = 5;
            // int b = 4;
            // int c = 2;
            // int d = (a + b) - 6 * c + (12 * 4) / 5 + 12;
            // Console.WriteLine(d);
            //
            // double aa = 5;
            // double bb = 4;
            // double cc = 2;
            // double dd = (aa + bb) / cc;
            // Console.WriteLine(dd);
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
            var names = new List<string>{"john", "tomas", "peter"};
            names.Add("hosi");
            names.Remove("john");
            foreach (var name in names)
            {
                Console.WriteLine($"this is {name.ToUpper()}");
            }
            Console.WriteLine($"this is the 2nd element in the names list {names[1].ToUpper()}");
            Console.WriteLine($"this is the number of people in the list {names.Count}");
            
            var index = names.IndexOf("hosi");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");
            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            
            Console.WriteLine($"This is what we call {text.ToUpper()}");
            
            // if statement
            int x = 5;
            int y = 6;
            if (x + y > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is smaller than 10 we can use && as AND and || as OR Operator");
            int sum = 0;
            for(int counter = 1; counter < 20; counter++)
            {
                if (counter%3 == 0)
                {
                    sum += counter;
                }
            }
            Console.WriteLine($"the sum of number between 1 and 20 which is divisible by 3 is {sum}");
            
            var fibonacciList = new List<int>{1, 1};
            for (int i = 0; i < 20; i++)
            {
                var newNum = fibonacciList[i]+fibonacciList[i+1];
                fibonacciList.Add(newNum);
            }
            Console.WriteLine($"this is fibonacci number between 1 and 20 {fibonacciList[fibonacciList.Count-1]}");

            // Console.WriteLine("Would you like a cake? (Y/N)?");
            // var yesOrNo = Console.ReadLine();
            // if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "YES")
            // {
            //     Console.WriteLine("here you have the cake");
            // }
            Console.Clear();
            // Console.WriteLine("it is cleared now!");

            
            Console.WriteLine("calculate any number, first choose operator(+, -, *, /), 1st number and 2nd number here");
            var data = Console.ReadLine();
            var info = data.Split(' '); 
            if (info[0] == "+") {
                Console.WriteLine($"{int.Parse(info[1]) + int.Parse(info[2])}");   
            } else if (info[0] == "-") {
                Console.WriteLine($"{int.Parse(info[1]) - int.Parse(info[2])}");
            } else if (info[0] == "*") {
                Console.WriteLine($"{int.Parse(info[1]) * int.Parse(info[2])}");
            } else if (info[0] == "/") {
                Console.WriteLine($"{int.Parse(info[1]) / int.Parse(info[2])}");
            }
        }
    }
}