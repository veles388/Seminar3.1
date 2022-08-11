//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeNum = Convert.ToInt32(Console.ReadLine());
string strNum = Convert.ToString(threeNum);
Console.WriteLine("вторая цифра = " + strNum[1]);


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Задача 13 ");
Console.Write("Введи число: ");
int num13 = Convert.ToInt32(Console.ReadLine());
string strNum13 = Convert.ToString(num13);
if (strNum13.Length > 2){
  Console.WriteLine("третья цифра = " + strNum13[2]);
}
else {
  Console.WriteLine(":( третьей цифры нет");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Задача 15 ");
Console.Write("Введи порядковое число дня недели: ");
int num15 = Convert.ToInt32(Console.ReadLine());
if (num15 <= 7)
{
    if(num15 == 7|| num15 == 6)
    {
        Console.WriteLine("Выходной");
    }
    if(num15 == 1|| num15 == 2||num15 == 3|| num15 == 4||num15 == 5)
    {
        Console.WriteLine("Работа");
    }
    else
{
    Console.WriteLine("Насколько я помню в неделе 7 дней и они все положительные!");
}
}


//Доп задание: угадайка
Random rand = new Random();
int randomNum = rand.Next(1, 5);
int playerNum;

Console.Write("Попробуй угдать число от 1 до 5:");
playerNum = Convert.ToInt32(Console.ReadLine());
if(playerNum <= 5)
{
    if (randomNum == playerNum)
    {
        Console.WriteLine("Ура! Ты победил");
    }
    else
    {
        Console.WriteLine("*Смеется злобно*");
    }
}
else
{
    //int floar;
    Console.Write("Ты либо прикалываешься, либо придурок, либо... Напомни с какого этажа тебя уронили?");
    /*floar = Convert.ToInt32(Console.ReadLine());
    if(5 >= floar <= 10)
    {
        Console.WriteLine("Даже не сомневался!");
    }
    if(1 => floar =< 4)
    {
        Console.WriteLine("Не ври! Для такого нужно минимум с пятого навернуться!");
    }
    if(floar > 10)
    {
        Console.WriteLine("Не ври! Или ты хочешь сказать что я с трупом разговариваю?");
    }
    */
}