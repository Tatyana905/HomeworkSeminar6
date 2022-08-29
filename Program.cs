// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
Console.Write("Введите количество цифр - ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array =  new int[size];

int count = 0; 

for (int i = 0; i < size; i++)
{
    Console.Write("Ввведите число - ");
    array[i] = Convert.ToInt32(Console.ReadLine());
          if (array[i] > 0) count++;
}
Console.WriteLine($"[ {String.Join(",",array)}]");
Console.WriteLine($" Количество положительных элементов - {count}");
*/




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
y = k1 * x + b1, y = k2 * x + b2
k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/

/*
Console.WriteLine("Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");

Console.Write("Введите коэффициент k1 - ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент b1 - ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k2 - ");
double k2= Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент b2 - ");
double b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");
else if (k1==k2) Console.WriteLine ("Прямые параллельны");

else
{
    double x = 0;
    double y = 0;
    x = (b2-b1)/(k1-k2);
    y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых - ( {x} , {y} )");
}
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число
// в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

int binaryNumber = 0;

while (number > 0)
{
    binaryNumber = number % 2;
    Console.Write(binaryNumber);
    number /=2;
}
//теперь нужно перевернуть, а дальше не получается. 
//Должно быть приблизительно так, при обычном вводе оно работает:
/*
 string s = Convert.ToString(Console.ReadLine());
            s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);
            Console.ReadLine();
*/
            