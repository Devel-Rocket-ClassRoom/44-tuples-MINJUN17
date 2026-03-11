using System;



(string name, int age, int grade)CreateStudent(string name, int age, int grade)
{
    return (name, age, grade);
}
void PrintStudent((string, int, int ) x)
{
    Console.WriteLine($"{x.Item1} - 나이: {x.Item2}세, 학년: {x.Item3}학년");
}
Console.WriteLine("=== 학생 정보 출력 ===");
PrintStudent(CreateStudent("철수", 16, 1));
PrintStudent(CreateStudent("영희", 17, 2));
PrintStudent(CreateStudent("민수", 18, 3));

(string name, int age, int grade) = CreateStudent("철수", 16, 1);

Console.WriteLine("=== 첫 번째 학생 분해 ===");
Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");
Console.WriteLine($"학년: {grade}");