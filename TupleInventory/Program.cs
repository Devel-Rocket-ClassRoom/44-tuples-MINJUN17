using System;
using System.Collections.Generic;
using System.Xml.Linq;


List<(string name, int quantity, int price)> inventory = new();

void AddItem((string name, int quantity, int price) item)
{
    inventory.Add(item);
    Console.WriteLine($"{item.name} - 수량: {item.quantity}개, 단가: {item.price:n0}원");
}

(string name, int price) FindMostExpensive()
{
    int mostExpensiveIndex = -1;
    int mostExpensive = int.MinValue;
    for(int i = 0; i < inventory.Count; i++)
    {
        if (inventory[i].price > mostExpensive)
        {
            mostExpensiveIndex = i;
        }
    }
    return (inventory[mostExpensiveIndex].name, inventory[mostExpensiveIndex].price);
}

(int totalValue, int totalCount) CalculateTotal()
{
    int valueSum = 0;
    int CountSum = 0;
    for (int i = 0; i < inventory.Count; i++)
    {
        valueSum += inventory[i].price * inventory[i].quantity;
        CountSum += inventory[i].quantity;
    }
    return (valueSum, CountSum);
}
Console.WriteLine("=== 아이템 인벤토리 ===");
AddItem(("체력 포션", 3, 500));
AddItem(("마나 포션", 5, 800));
AddItem(("해독제", 2, 300));
AddItem(("엘릭서", 1, 5000));

Console.WriteLine("\n=== 가장 비싼 아이템 ===");
(string name, int price) item = FindMostExpensive();
Console.WriteLine($"이름: {item.name}, 단가: {item.price:n0}원");

Console.WriteLine("\n=== 인벤토리 합산 ===");
var total = CalculateTotal();
Console.WriteLine($"총 가치: {total.totalValue:n0}원");
Console.WriteLine($"총 아이템 수: {total.totalCount}개");