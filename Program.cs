// Импорт пространства имен для математических задач из библиотеки CRE.MathTasks
using CRE.MathTasks;

// Импорт пространства имен для калькуляторов из библиотеки CRE.MathTasks.Calculators
using CRE.MathTasks.Calculators;

// Инициализация переменной cont, управляющей циклом, значением true
var cont = true;

// Цикл while, выполняющийся, пока cont равно truex
while (cont)
{
    // Выводит на консоль текст с просьбой ввести номер задачи, для выхода введите 9
    Console.WriteLine("Введите номер задачи, если хотите выйти, введите 9:");

    // Считывает введенный пользователем номер задачи
    var numberOfTask = Console.ReadLine();

    // Инициализация переменной calculator интерфейсом ICalculator
    ICalculator calculator = null;

    // Конструкция switch для выбора калькулятора в зависимости от введенного номера задачи
    switch (numberOfTask)
    {
        case "1":
            calculator = new Function1();
            break;
        case "2":
            calculator = new Function2();
            break;
        case "3":
            calculator = new Function3();
            break;
        case "9":
            // Если введен номер 9, устанавливает cont в false, чтобы выйти из цикла
            cont = false;
            break;
        default:
            // В случае некорректного ввода номера задачи ничего не делает
            break;
    }

    // Проверка, был ли выбран калькулятор (не осталась ли переменная calculator равной null)
    if (calculator == null)
    {
        // Выводит сообщение об ошибке и переходит к следующей итерации цикла
        Console.WriteLine("Неправильный номер");
        continue;
    }

    // Выводит на консоль текст с просьбой ввести значение a
    Console.WriteLine("Введите a:");

    // Считывает введенное пользователем значение a и преобразует его в тип int
    var a = int.Parse(Console.ReadLine());

    // Выводит на консоль текст с просьбой ввести значение b
    Console.WriteLine("Введите b:");

    // Считывает введенное пользователем значение b и преобразует его в тип int
    var b = int.Parse(Console.ReadLine());

    // Выводит на консоль текст с просьбой ввести значение h
    Console.WriteLine("Введите h:");

    // Считывает введенное пользователем значение h и преобразует его в тип int
    var h = int.Parse(Console.ReadLine());

    // Вызывает метод BuildTable из класса MathHelper, передавая значения a, b, h и выбранный калькулятор
    MathHelper.BuildTable(a, b, h, calculator);
}
