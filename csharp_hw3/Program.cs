bool IsPalindrom(int number)
{   int buf  = 0;
    int buf2 = number;

    while (number > 0) { 
        buf = buf * 10 + number % 10; 
        number /= 10; 
    }
    return buf2 == buf;
}

void Task19 () {
    Console.WriteLine("Выбрано задание 19");
    Console.Write("Введите пятизначное число: ");
    
    int number = Convert.ToInt32(Console.ReadLine());

    if (number.ToString().Length == 5) {
        if (IsPalindrom(number)) {
            Console.WriteLine("Число является полиндромом");
        } else {
            Console.WriteLine("Число не является полиндромом");
        }
    } else {
        Console.WriteLine("Введено не пятизначное число!");
    }
}

double LengthBetweenPoint(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

void Task21 () {
    Console.WriteLine("Выбрано задание 21");

    Console.Write("Введите координату x1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату x2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    double lengthPoint = LengthBetweenPoint(x1, y1, z1, x2, y2, z2);

    Console.WriteLine("Расстояние между двумя точками = " + lengthPoint.ToString());
}

void Task23 () {
    Console.WriteLine("Выбрано задание 23");
    Console.Write("Введите число: ");
    
    int number = Convert.ToInt32(Console.ReadLine());
    int i = 1;

    while (i <= number) {
        Console.Write(Math.Pow(i, 3).ToString());
        i = i + 1;
        if (i <= number) {
            Console.Write(", ");
        }
    }
}

Console.Write("Выбирете задание (19, 21, 23): ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task) {
    case 19:
        Task19();
        break;
    case 21:
        Task21();
        break;
    case 23:
        Task23();
        break;
    default:
        Console.WriteLine("Выбрано неверный номер задания");
        break;
}

