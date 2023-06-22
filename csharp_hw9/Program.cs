
void Natural(int count, int n)
{
    if (count <= n) {
        Natural(count + 1, n);
        Console.Write(count + " ");
    }
}

void Task64 () {
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Natural(1, n);

}

int NaturalPlus(int m, int n)
{
    if (m < n) {
        return m + NaturalPlus(m + 1, n);
    } else {
        return m;
    }

}

void Task66 () {
    Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = NaturalPlus(m, n);
    Console.Write($"Сумма наткральных элементов: {sum}");
}

int Akkerman(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (m != 0 && n == 0) {
        return Akkerman(m - 1, 1);
    } else if (m > 0 && n > 0) {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    } else {
        return Akkerman(m,n);
    }
}

void Task68 () {
    Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int akkerman = Akkerman(m, n);
    Console.Write($"A({m},{n}) = {akkerman}");
}

Console.Write("Выбирете задание (64, 66, 68): ");
int task = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Выбрано задание {task}");

switch (task) {
    case 64:
        Task64();
        break;
    case 66:
        Task66();
        break;
    case 68:
        Task68();
        break;
    default:
        Console.WriteLine("Выбрано неверный номер задания");
        break;
}

