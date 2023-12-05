using CRE.MathTasks;

var cont = true;

while (cont)
{
    Console.WriteLine("Номер варианта - 3");
    Console.WriteLine("Выберите задание:");
    Console.WriteLine("(1)78 V");
    Console.WriteLine("(2)78 VI");
    Console.WriteLine("(3)37 I");
    Console.WriteLine("(4)38 II");
    Console.WriteLine("(5)38 III");
    Console.WriteLine("(6)164 II");
    Console.WriteLine("(7)164 III");
    Console.WriteLine("(8)94 I");
    Console.WriteLine("(9)95 II");
    Console.WriteLine("(10)96 III");
    Console.WriteLine("Выход - q");
    var choise = Console.ReadLine();
    switch (choise)
    {
        case "1":
            MathTasks.Task_78_V();
            break;
        case "2":
            MathTasks.Task_78_VI();
            break;
        case "3":
            MathTasks.Task_37_I();
            break;
        case "4":
            MathTasks.Task_38_II();
            break;
        case "5":
            MathTasks.Task_38_III();
            break;
        case "6":
            MathTasks.Task_164_II();
            break;
        case "7":
            MathTasks.Task_164_III();
            break;
        case "8":
            MathTasks.Task_94_I();
            break;
        case "9":
            MathTasks.Task_95_II();
            break;
        case "10":
            MathTasks.Task_96_III();
            break;
        case "q":
            cont = false;
            break; 
        default:
            Console.WriteLine("Неправильный ввод");
            break;
    }
}

