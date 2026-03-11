using System;
using System.Collections.Generic;

////1
//var t1 = (1, 2);
//var t2 = (1, 2);
//var t3 = (2, 2);

//Console.WriteLine(t1.Equals(t2));
//Console.WriteLine(t1.Equals(t3));

////2
//var t1 = (1, 2);
//var t2 = (1, 2);

//Console.WriteLine(t1 == t2);
//Console.WriteLine(t1 != t2);

////3
//(string a, int b) t = ("Alice", 25);
//(string x, int y) t2 = t;
//Console.WriteLine(t2);


////4
//(string name, int age, char sex) t1 = ("Bob", 23, 'M');
//(string age, int sex, char name) t2 = t1;
//Console.WriteLine($"{t2.age}\n{t2.sex}\n{t2.name}");

////5

//List<(string name, int age)> people = new()
//{
//    ("Alice", 25),
//    ("Bob", 30),
//    ("Charlie", 35)
//};
//foreach(var person in people)
//{
//    Console.WriteLine($"{person.name}: {person.age}세");
//}

////6

//Dictionary<(int x, int y), string> d = new()
//{
//    { (0, 0), "원점" },
//    { (1, 0), "오른쪽" },
//    { (0, 1), "위" }
//};
//Console.WriteLine(d[(0, 0)]);
//Console.WriteLine(d[(1, 0)]);

////7

//var tuple1 = new Tuple<string, int>("Bob", 23);

//var tuple2 = Tuple.Create("Alice", 25);

//Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");
//Console.WriteLine($"{tuple2.Item1}, {tuple2.Item2}");