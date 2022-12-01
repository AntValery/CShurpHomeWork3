Console.Write("Введите число = ");
int n = Convert.ToInt32(Console.ReadLine());
Double[] array = new Double[n];

for(int i = 0; i < n; i++){
    array[i] = Math.Pow(i+1,3);
    Console.Write(array[i] + " ");
}