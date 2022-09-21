/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Input three digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("The second digit is -> "+stringNumber[1]);

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Input number: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(Num);
if (NumText.Length > 2)
{
  Console.WriteLine("Third digit -> " + NumText[2]);
}
else 
{
  Console.WriteLine("-> No third digit");
}

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Input number corresponding to the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
{
Console.WriteLine("(that is weekend) -> yes");
}
else if (dayNumber < 1 || dayNumber > 7) 
{
Console.WriteLine("not a week day");
}
else Console.WriteLine("(not a weekend) -> no");
}

CheckingTheDayOfTheWeek(dayNumber);