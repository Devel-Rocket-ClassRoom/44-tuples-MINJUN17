using System;
using System.Linq;

////1
//var t = Tally();
//Console.WriteLine($"합계: {t.Item1}, 개수: {t.Item2}");

//(int, int) Tally()
//{ 
//    return (12, 3);
//} 

////2
//var t = Calculate();
//Console.WriteLine($"합계: {t.Item1}, 개수: {t.Item2}");

//(int sum, int count) Calculate()
//{
//    return (45, 6);
//}

////3
//var t = GetPair();
//Console.WriteLine($"{t.Item1}, {t.Item2}");

//(int first, int second) GetPair() => (100, 200);

////4
//int[] numbers = { 5, 2, 8, 1, 9, 3 };
//var result = FindMinMax(numbers);
//Console.WriteLine($"최솟값: {result.min}, 최댓값: {result.max}");

//(int min, int max) FindMinMax(int[] numbers)
//{
//    int min = int.MaxValue;
//    int max = int.MinValue;
//    foreach (int num in numbers)
//    {
//        if (num < min)
//        {
//            min = num;
//        }
//        if (num > max)
//        {
//            max = num;
//        }
//    }

//    return (min, max);
//}

////5
//var zero = ZeroZero();
//Console.WriteLine(zero);
//(int, int) ZeroZero() => default;


////6

//var t = ("Bob", 23);
//(string name, int age) = t;
//Console.WriteLine($"이름: {name}");
//Console.WriteLine($"나이: {age}");

////7
//var (sum, count) = Tally();
//Console.WriteLine($"Sum: {sum}, Count: {count}");

//(int, int) Tally() => (12, 3);

////8
//string name;
//int age;
//var p = ("Alice", 30);
//(name, age) = p;
//Console.WriteLine($"{name}, {age}");

//9
//var p = ("Alice", 30, true);
//(_,int age, _) = p;
//Console.WriteLine($"나이: {age}");