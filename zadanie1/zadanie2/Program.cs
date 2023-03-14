//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int Prompt(string messege)
{
    Console.Write(messege);
    String value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int