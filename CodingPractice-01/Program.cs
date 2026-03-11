using System;

////1
//var p = ("Bob", 23);
//Console.WriteLine(p.Item1);
//Console.WriteLine(p.Item2);

////2-1

//var t = (12, 34, 56);
//Console.WriteLine($"{t.Item1}, {t.Item2}, {t.Item3}");


////2-2

//var t = ("Hello", 100, true, 3.14);
//Console.WriteLine($"{t.Item1}, {t.Item2}, {t.Item3}, {t.Item4}");

////3-1

//(string, int) t = ("Alice", 25);
//Console.WriteLine($"{t.Item1}, {t.Item2}");

////3-2
//(ushort Width, ushort Height) resolution = (1920, 1080);
//Console.WriteLine($"해상도: {resolution.Width} x {resolution.Height}");

////4
//var t = ("Bob", 23);
//var c = t;
//c.Item1 = "Joe";

//Console.WriteLine($"원본: ({t.Item1}, {t.Item2})");
//Console.WriteLine($"복사본: ({c.Item1}, {c.Item2})");

////5
//(string name, int age) person = ("Bob", 23);
//Console.WriteLine(person.name);
//Console.WriteLine(person.age);
//Console.WriteLine(person.Item1);
//Console.WriteLine(person.Item2);

////6
//(string Name, bool IsStudent, int OrderPrice) t = ("철수", true, 1000);
//Console.WriteLine($"{t.Name}(학: {t.IsStudent}) - 주문: {t.OrderPrice:n0}원");

////7
//(string name, int age, char gender) person = ("Bob", 23, 'M');
//Console.WriteLine($"이름: {person.name}");
//Console.WriteLine($"나이: {person.age}");
//Console.WriteLine($"성별: {person.gender}");

//8
var now = DateTime.Now;
Console.WriteLine($"일: {now.Day}");
Console.WriteLine($"월: {now.Month}");
Console.WriteLine($"년: {now.Year}");
