//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int Prompt(string massage)
{
    Console.Write(massage);
    string value = Convert.ToInt32(value);
    return result;
}

bool IsWeeked(int weekDay)
{
    if (weekDay>5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("это не день недели");
    return false;
}

int weekDay = Prompt("введите день недели >");
if (ValidateWeekday(weekDay))
{
    if (IsWeeken(weekDay))
    {
        Console.WriteLine("наконец то выходной");
    }
    else
    {
        Console.WriteLine("придется поработать");
    }
}
