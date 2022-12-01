Console.Write("Введите число = ");
int n = Convert.ToInt32(Console.ReadLine());

if((n/10000) == (n % 10) &&
   ((n / 1000) % 10) == ((n / 10) % 10)) Console.WriteLine("Да");
else Console.WriteLine("Нет");