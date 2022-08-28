// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int CounterPositivNumbersInput()
{
    int inputNumber = 1;
    int counterPositiv = 0;
    System.Console.WriteLine("Введите числа. Для окончания ввода введите 0 : ");
    while (inputNumber != 0)
    {
        inputNumber = Prompt("---> ");
        if (inputNumber > 0)
        {
            counterPositiv++;
        }

    }
    return counterPositiv;
}
int counter = CounterPositivNumbersInput();
System.Console.WriteLine($"Конец ввода. Введено {counter} чисел больше 0");
