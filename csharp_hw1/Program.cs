// Task2
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b) {
    Console.WriteLine("min = " + a.ToString() + ", max = " + b.ToString());
} else {
    Console.WriteLine("min = " + b.ToString() + ", max = " + a.ToString());
}

// ------------------------------------------------------------------------
// Task4
Console.WriteLine("Введите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (max < b) {
    max = b;
}
if (max < c) {
    max = c;
}

Console.WriteLine("max = " + max.ToString());

// ------------------------------------------------------------------------
// Task6
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());

if (a % 2==1) {
    Console.WriteLine("число нечетное");
} else {
    Console.WriteLine("Число четное");
}

// ------------------------------------------------------------------------
// Task6
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;

while (b <= a) {
    if (b % 2!=1) {
        Console.Write(b.ToString() + " ");
    }
    b = b + 1;
}